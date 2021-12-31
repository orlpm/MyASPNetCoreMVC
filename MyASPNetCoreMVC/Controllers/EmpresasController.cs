using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyASPNetCoreMVC.Models;

namespace MyASPNetCoreMVC.Controllers
{
    public class EmpresasController : Controller
    {
        private AppDBContext AppDBContext { get; }
        public EmpresasController(AppDBContext appDBContext)
        {
            AppDBContext = appDBContext;
        }

        // GET: EmpresasController
        public ActionResult Index()
        {
            var empresas = AppDBContext.Empresas.ToList();
            
            return View(empresas);
        }

        // GET: EmpresasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpresasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpresasController/Create
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

        // GET: EmpresasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpresasController/Edit/5
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

        // GET: EmpresasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpresasController/Delete/5
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
