using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using System.Linq;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index()
        {
            var campanias = CampaniaData.ObtenerCampanias();
            return View(campanias);
        }

        // NUEVO: /Campanas/Detalle/{id}
        public IActionResult Detalle(int id)
        {
            var campania = CampaniaData
                .ObtenerCampanias()
                .FirstOrDefault(c => c.Id == id);

            if (campania == null)
            {
                return NotFound();
            }

            return View(campania);
        }
    }
}
