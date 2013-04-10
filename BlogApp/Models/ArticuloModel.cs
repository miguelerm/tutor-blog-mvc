using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class ArticuloModel
    {

        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(80)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(300)]
        public string Resumen { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Contenido { get; set; }

        public DateTime Fecha { get; set; }

        public HttpPostedFileWrapper Imagen { get; set; }

        public int[] Categorias { get; set; }
        public int[] Etiquetas { get; set; }

    }
}