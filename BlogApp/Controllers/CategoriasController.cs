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
    public class CategoriasController : Controller
    {
        private BlogDb db = new BlogDb();

        //
        // GET: /Categorias/

        public ActionResult Index()
        {
            var categorias = db.Categorias.Include(c => c.CategoriaPadre);
            return View(categorias.ToList());
        }

        //
        // GET: /Categorias/Details/5

        public ActionResult Details(int id = 0)
        {
            Categoria categoria = db.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        //
        // GET: /Categorias/Create

        public ActionResult Create()
        {
            ViewBag.CategoriaPadreId = new SelectList(db.Categorias, "Id", "Nombre");
            return View();
        }

        //
        // POST: /Categorias/Create

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaPadreId = new SelectList(db.Categorias, "Id", "Nombre", categoria.CategoriaPadreId);
            return View(categoria);
        }

        //
        // GET: /Categorias/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Categoria categoria = db.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaPadreId = new SelectList(db.Categorias, "Id", "Nombre", categoria.CategoriaPadreId);
            return View(categoria);
        }

        //
        // POST: /Categorias/Edit/5

        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaPadreId = new SelectList(db.Categorias, "Id", "Nombre", categoria.CategoriaPadreId);
            return View(categoria);
        }

        //
        // GET: /Categorias/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Categoria categoria = db.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        //
        // POST: /Categorias/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Categoria categoria = db.Categorias.Find(id);
            db.Categorias.Remove(categoria);
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