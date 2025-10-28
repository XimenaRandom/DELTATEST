using DELTATEST.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Añadir soporte MVC (vistas y controladores)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();

// Habilitar routing antes de mapear endpoints
app.UseRouting();

// Si usas antiforgery (como tenías), mantenlo si tu proyecto lo requiere
app.UseAntiforgery();

// Mapear rutas de controladores (MVC)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Mantener mapeo de componentes Razor/Blazor
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
