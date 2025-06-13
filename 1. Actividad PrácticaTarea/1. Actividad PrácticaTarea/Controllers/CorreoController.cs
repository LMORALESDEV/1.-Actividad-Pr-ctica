using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Actividad_PrácticaTarea.Controllers
{
    public class CorreoController : Controller
    {
        // GET: CorreoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Correo/Dominio
        [HttpGet]
        public ActionResult Dominio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dominio(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                ViewBag.Mensaje = "Correo electrónico no válido.";
                return View();
            }

            // Extraer el dominio del correo
            string dominio = email.Split('@')[1];
            ViewBag.Mensaje = $"El dominio del correo es: {dominio}";

            return View();
        }

        // GET: CorreoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CorreoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CorreoController/Create
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

        // GET: CorreoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CorreoController/Edit/5
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

        // GET: CorreoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CorreoController/Delete/5
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
