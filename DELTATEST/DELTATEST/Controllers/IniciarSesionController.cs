using Microsoft.AspNetCore.Mvc;

namespace DELTATEST.Controllers
{
    public class IniciarSesionController : Controller
    {
        public IActionResult Index()
        {
            // Devuelve la vista existente en Views/Login/IniciarSesion.cshtml
            return View("~/Views/Login/IniciarSesion.cshtml");
        }
    }
}
