using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Actividad_PrácticaTarea.Controllers
{
    public class FraseController : Controller
    {
        // GET: FraseController
        public ActionResult ContarPalabras(string frase)
        {
            if (string.IsNullOrWhiteSpace(frase))
            {
                ViewBag.Mensaje = "La frase está vacía o no se proporcionó.";
                ViewBag.Cantidad = 0;
            }
            else
            {
                // Separar por espacios, quitando espacios extras
                var palabras = frase.Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                ViewBag.Mensaje = $"La frase contiene {palabras.Length} palabra(s).";
                ViewBag.Cantidad = palabras.Length;
            }

            ViewBag.FraseOriginal = frase;

            return View();
        }

        // GET: FraseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FraseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FraseController/Create
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

        // GET: FraseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FraseController/Edit/5
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

        // GET: FraseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FraseController/Delete/5
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
