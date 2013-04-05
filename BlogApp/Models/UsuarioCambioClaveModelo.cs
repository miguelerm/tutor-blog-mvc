using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class UsuarioCambioClaveModelo
    {
        [Required]
        public string Clave { get; set; }
        [Required]
        public string Confirmacion { get; set; }

    }
}