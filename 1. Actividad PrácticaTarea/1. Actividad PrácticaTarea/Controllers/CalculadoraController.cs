using Microsoft.AspNetCore.Mvc;

namespace _1._Actividad_PrácticaTarea.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sumar(int NUM1, int NUM2)
        {
            return View(NUM1 + NUM2);
        }
    }
}
