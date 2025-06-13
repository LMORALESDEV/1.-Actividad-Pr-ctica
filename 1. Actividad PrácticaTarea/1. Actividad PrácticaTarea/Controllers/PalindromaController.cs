using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Actividad_PrácticaTarea.Controllers
{
    public class PalindromaController : Controller
    {
        // GET: PalindromaController
        public ActionResult Palabra(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                ViewBag.Mensaje = "Por favor, ingresa una palabra.";
            }

            else
            {
                string palabraOriginal = texto.ToLower().Replace(" ", "");
                char[] caracteres = palabraOriginal.ToCharArray();
                System.Array.Reverse(caracteres);
                string palabraInvertida = new string(caracteres);

                bool esPalindromo = palabraOriginal == palabraInvertida;

                ViewBag.Mensaje = esPalindromo
                    ? $"La palabra \"{texto}\" es un palíndromo."
                    : $"La palabra \"{texto}\" no es un palíndromo.";
            }

            return View();
        }

        // GET: PalindromaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PalindromaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PalindromaController/Create
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

        // GET: PalindromaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PalindromaController/Edit/5
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

        // GET: PalindromaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PalindromaController/Delete/5
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
