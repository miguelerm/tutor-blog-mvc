using BlogApp.Entidades;
using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class ArticulosController : Controller
    {
        private BlogDb db = new BlogDb();

        public ActionResult Index()
        {
            var modelo = db.Articulos.ToList();
            return View(modelo);
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(ArticuloModel modelo)
        {
            if (ModelState.IsValid)
            {
                var articulo = new Articulo();
                articulo.Titulo = modelo.Titulo;
                articulo.Nombre = modelo.Nombre;
                articulo.Resumen = modelo.Resumen;
                articulo.Fecha = modelo.Fecha;
                articulo.Contenido = modelo.Contenido;

                var nombreDeUsuario = User.Identity.Name;

                articulo.UsuarioId = db.Usuarios.First(x => x.Nombre == nombreDeUsuario).Id;

                if (modelo.Imagen != null && modelo.Imagen.ContentLength > 0)
                {
                    using (BinaryReader reader = new BinaryReader(modelo.Imagen.InputStream))
                    {
                        var length = modelo.Imagen.ContentLength;
                        articulo.Imagen = reader.ReadBytes(length);
                    }
                }

                db.Articulos.Add(articulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
