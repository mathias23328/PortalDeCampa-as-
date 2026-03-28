using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index()
        {
            var campanias = CampaniaData.ObtenerCampanias();
            return View(campanias);
        }
    }
}