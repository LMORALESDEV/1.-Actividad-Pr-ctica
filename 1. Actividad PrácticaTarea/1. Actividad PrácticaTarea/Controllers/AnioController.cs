using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Actividad_PrácticaTarea.Controllers
{
    public class AnioController : Controller
    {
        // GET: AnioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Anio/Bisiesto?anio=2024
        public ActionResult Bisiesto(int anio)
        {
            string mensaje;

            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                mensaje = $"{anio} es un año bisiesto.";
            }
            else
            {
                mensaje = $"{anio} no es un año bisiesto.";
            }

            ViewBag.Mensaje = mensaje;
            return View();
        }

        // GET: AnioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
