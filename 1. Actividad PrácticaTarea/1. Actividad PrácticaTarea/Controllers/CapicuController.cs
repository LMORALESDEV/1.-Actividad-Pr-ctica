using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Actividad_PrácticaTarea.Controllers
{
    public class CapicuController : Controller
    {
        // GET: CapicuController
        public ActionResult Index()
        {
            return View();
        }

        // Acción GET que muestra un formulario (opcional)
        public ActionResult Verificar()
        {
            return View();
        }

        // Acción POST que recibe el número y verifica si es capicúa
        [HttpPost]
        public ActionResult Verificar(int numero)
        {
            bool esCapicua = EsCapicua(numero);
            ViewBag.Numero = numero;
            ViewBag.Resultado = esCapicua ? "es un número capicúa." : "NO es un número capicúa.";

            return View();
        }

        private bool EsCapicua(int numero)
        {
            string original = numero.ToString();
            char[] arr = original.ToCharArray();
            Array.Reverse(arr);
            string invertido = new string(arr);

            return original == invertido;
        }

        // GET: CapicuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CapicuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapicuController/Create
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

        // GET: CapicuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CapicuController/Edit/5
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

        // GET: CapicuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CapicuController/Delete/5
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
