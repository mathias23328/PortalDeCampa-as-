using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using System.Linq;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        // LISTADO + FILTROS
        public IActionResult Index(string categoria, string estado)
        {
            var campanias = CampaniaData.ObtenerCampanias();

            if (!string.IsNullOrEmpty(categoria))
            {
                campanias = campanias
                    .Where(c => c.Categoria == categoria)
                    .ToList();
            }

            if (!string.IsNullOrEmpty(estado))
            {
                campanias = campanias
                    .Where(c => c.Estado == estado)
                    .ToList();
            }

            ViewBag.CategoriaSeleccionada = categoria;
            ViewBag.EstadoSeleccionado = estado;

            return View(campanias);
        }

        // DETALLE
        public IActionResult Detalle(int id)
        {
            var campania = CampaniaData.ObtenerCampanias()
                .FirstOrDefault(c => c.Id == id);

            if (campania == null)
            {
                return NotFound();
            }

            return View(campania);
        }
    }
}