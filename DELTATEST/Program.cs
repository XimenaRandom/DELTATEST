// A�ade estas l�neas en Program.cs (dentro de builder.Services / antes de Build)
using DELTATEST.Services;

// ...

// Registrar el servicio de autenticaci�n
builder.Services.AddScoped<AutenticacionService>();

// Si tu HttpClient base no est� configurado, aseg�rate de tener:
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
