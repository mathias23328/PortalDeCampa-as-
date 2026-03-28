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
        public IActionResult Resumen()
{
    var campanias = CampaniaData.ObtenerCampanias();

    var total = campanias.Count();

    var vigentes = campanias.Count(c => c.Estado == "Vigente");
    var proximas = campanias.Count(c => c.Estado == "Próxima");

    var promedioDescuento = campanias.Average(c => c.DescuentoPct);

    var porCanal = campanias
        .GroupBy(c => c.Canal)
        .Select(g => new
        {
            Canal = g.Key,
            Cantidad = g.Count()
        })
        .ToList();

    ViewBag.Total = total;
    ViewBag.Vigentes = vigentes;
    ViewBag.Proximas = proximas;
    ViewBag.Promedio = promedioDescuento;
    ViewBag.PorCanal = porCanal;

    return View();
}
    }
    
}