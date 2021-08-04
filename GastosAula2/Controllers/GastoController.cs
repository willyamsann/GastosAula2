using GastosAula2.Context;
using GastosAula2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GastosAula2.Controllers
{
    public class GastoController : Controller
    {
        public ActionResult Index()
        {
            //INSTACIOU O BANCO
            GastoContext db = new GastoContext();

            //VARIAVEL COM OS OBJETOS DO BANCO;
            var gastos = db.Gastos.ToList();

            //RETORNA PARA O HTML OS DADOS VINDO DO BANCO
            return View(gastos);
        }


        public ActionResult Details(int id)
        {
            GastoContext db = new GastoContext();
            var gasto = db.Gastos.Find(id);

            return View(gasto);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Gasto obj)
        {
            GastoContext db = new GastoContext();
            if (ModelState.IsValid)
            {
                db.Gastos.Add(obj);
                db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

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

        public ActionResult Delete(int id)
        {
            return View();
        }

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
