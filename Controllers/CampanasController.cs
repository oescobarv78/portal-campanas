using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Services;
using PortalCampanas.Models;
using System.Linq;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index(string categoria, string estado)
        {
            var lista = CampanaService.ObtenerCampanas();

            if (!string.IsNullOrEmpty(categoria))
            {
                lista = lista.Where(c => c.Categoria == categoria).ToList();
            }

            if (!string.IsNullOrEmpty(estado))
            {
                lista = lista.Where(c => c.Estado == estado).ToList();
            }

            return View(lista);
        }

        public IActionResult Resumen()
        {
            var lista = CampanaService.ObtenerCampanas();

            var total = lista.Count;
            var vigentes = lista.Count(c => c.Estado == "Vigente");
            var proximas = lista.Count(c => c.Estado == "Próxima");
            var promedio = lista.Average(c => c.DescuentoPct);

            ViewBag.Total = total;
            ViewBag.Vigentes = vigentes;
            ViewBag.Proximas = proximas;
            ViewBag.Promedio = promedio;

            return View();
        }
    }
}