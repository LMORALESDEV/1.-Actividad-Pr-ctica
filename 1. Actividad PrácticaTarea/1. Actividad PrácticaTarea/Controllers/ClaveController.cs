using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace _1._Actividad_PrácticaTarea.Controllers
{
    public class ClaveController : Controller
    {
        // GET: ClaveController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Clave/Segura?password=TuContraseña
        public ActionResult Segura(string password)
        {
            bool esSegura = EsContrasenaSegura(password);

            ViewBag.Password = password;
            ViewBag.EsSegura = esSegura;

            return View();
        }

        private bool EsContrasenaSegura(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            bool tieneLongitud = password.Length >= 8;
            bool tieneMayuscula = Regex.IsMatch(password, @"[A-Z]");
            bool tieneNumero = Regex.IsMatch(password, @"\d");

            return tieneLongitud && tieneMayuscula && tieneNumero;
        }

        // GET: ClaveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClaveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClaveController/Create
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

        // GET: ClaveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClaveController/Edit/5
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

        // GET: ClaveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClaveController/Delete/5
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
