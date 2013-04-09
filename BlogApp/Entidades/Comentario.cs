using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BlogApp.Entidades
{
    public class Comentario
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(80)]
        public string Asunto { get; set; }

        [Required]
        [StringLength(3000)]
        public string Contenido { get; set; }

    }
}
