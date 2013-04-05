using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataAnnotationsExtensions;
using System.Web.Mvc;

namespace BlogApp.Models
{
    public class UsuarioRegistrarseModelo
    {
        [Required]
        [StringLength(10)]
        [Remote("Existe", "Usuarios", ErrorMessage="El usuario ya existe")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4)]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        [EqualTo("Clave")]
        [DataType(DataType.Password)]
        [Display(Name="Confirmación")]
        public string Confirmacion { get; set; }
        
    }
}