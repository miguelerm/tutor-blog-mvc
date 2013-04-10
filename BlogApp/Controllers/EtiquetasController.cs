using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogApp.Entidades;

namespace BlogApp.Controllers
{
    public class EtiquetasController : Controller
    {
        private BlogDb db = new BlogDb();

        //
        // GET: /Etiquetas/

        public ActionResult Index()
        {
            return View(db.Etiquetas.ToList());
        }

        //
        // GET: /Etiquetas/Details/5

        public ActionResult Details(int id = 0)
        {
            Etiqueta etiqueta = db.Etiquetas.Find(id);
            if (etiqueta == null)
            {
                return HttpNotFound();
            }
            return View(etiqueta);
        }

        //
        // GET: /Etiquetas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Etiquetas/Create

        [HttpPost]
        public ActionResult Create(Etiqueta etiqueta)
        {
            if (ModelState.IsValid)
            {
                db.Etiquetas.Add(etiqueta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(etiqueta);
        }

        //
        // GET: /Etiquetas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Etiqueta etiqueta = db.Etiquetas.Find(id);
            if (etiqueta == null)
            {
                return HttpNotFound();
            }
            return View(etiqueta);
        }

        //
        // POST: /Etiquetas/Edit/5

        [HttpPost]
        public ActionResult Edit(Etiqueta etiqueta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(etiqueta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(etiqueta);
        }

        //
        // GET: /Etiquetas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Etiqueta etiqueta = db.Etiquetas.Find(id);
            if (etiqueta == null)
            {
                return HttpNotFound();
            }
            return View(etiqueta);
        }

        //
        // POST: /Etiquetas/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Etiqueta etiqueta = db.Etiquetas.Find(id);
            db.Etiquetas.Remove(etiqueta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}