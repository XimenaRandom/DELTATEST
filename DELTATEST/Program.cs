// Añade estas líneas en Program.cs (dentro de builder.Services / antes de Build)
using DELTATEST.Services;

// ...

// Registrar el servicio de autenticación
builder.Services.AddScoped<AutenticacionService>();

// Si tu HttpClient base no está configurado, asegúrate de tener:
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
