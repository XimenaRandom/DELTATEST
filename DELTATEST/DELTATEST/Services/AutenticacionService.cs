using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.JSInterop;
using DELTATEST.Models;

namespace DELTATEST.Services
{
    // Servicio simple para autenticación: llama a api/auth/login y guarda token en localStorage
    public class AutenticacionService
    {
        private readonly HttpClient _http;
        private readonly IJSRuntime _js;

        public AutenticacionService(HttpClient http, IJSRuntime js)
        {
            _http = http;
            _js = js;
        }

        public async Task<bool> LoginAsync(LoginModel model)
        {
            // Ajusta la URL según tu API
            var resp = await _http.PostAsJsonAsync("api/auth/login", model);
            if (!resp.IsSuccessStatusCode)
                return false;

            // Asumimos que la API devuelve { token: "..." }
            var payload = await resp.Content.ReadFromJsonAsync<LoginResult?>();
            if (payload?.Token is null)
                return false;

            await _js.InvokeVoidAsync("localStorage.setItem", "authToken", payload.Token);

            // Opcional: configurar _http.DefaultRequestHeaders.Authorization aquí no es permanente
            // Para usar el token en todas las peticiones, crea un DelegatingHandler o un HttpClientFactory
            return true;
        }

        public async Task LogoutAsync()
        {
            await _js.InvokeVoidAsync("localStorage.removeItem", "authToken");
        }

        public async Task<string?> GetTokenAsync()
        {
            return await _js.InvokeAsync<string?>("localStorage.getItem", "authToken");
        }

        private class LoginResult
        {
            public string? Token { get; set; }
        }
    }
}