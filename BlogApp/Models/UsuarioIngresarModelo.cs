using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class UsuarioIngresarModelo
    {

        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

    }
}