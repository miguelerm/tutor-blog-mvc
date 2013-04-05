using BlogApp.Entidades;
using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class UsuariosController : Controller
    {

        /// <summary>
        /// Despliega la vista que solicita la información de registro al usuario.
        /// </summary>
        /// <returns>Retorna una vista</returns>
        public ActionResult Registrarse()
        {
            return View();
        }

        /// <summary>
        /// Procesa la información ingresada por el usuario en el formulario de registro.
        /// </summary>
        /// <param name="modelo">informacion que ingresó el usuario.</param>
        /// <returns>
        ///    Si los datos ingresados no son válidos, se muestra nuevamente al usuario la vista.
        ///    si los datos ingresados son válidos, se redirecciona al usuario a la pagina correcta.
        /// </returns>
        [HttpPost]
        [ActionName("Registrarse")]
        public ActionResult RegistrarsePost(UsuarioModelo modelo)
        {
            if (ModelState.IsValid)
            {
                
                var db = new BlogDb();

                if (db.Usuarios.Any(x => x.Nombre == modelo.Nombre))
                {
                    ModelState.AddModelError("", "Error de base de datos");
                    ModelState.AddModelError("Nombre", "Ya existe otro usuario con este mismo nombre");
                    return View();
                }
                else
                {

                    var usuario = new Usuario();

                    usuario.Nombre = modelo.Nombre;
                    usuario.Clave = modelo.Clave;

                    db.Usuarios.Add(usuario);
                    db.SaveChanges();

                    return RedirectToAction("RegistroCorrecto");

                }

            }
            else
            {
                return View();
            }
                        
        }

        public ActionResult Existe(string nombre)
        {
            var db = new BlogDb();

            var existe =db.Usuarios.Any(x => x.Nombre == nombre);

            return Json(!existe, JsonRequestBehavior.AllowGet);

        }

        public ActionResult RegistroCorrecto()
        {
            return View();
        }

        public ActionResult Ingresar()
        {
            return View();
        }



    }
}
