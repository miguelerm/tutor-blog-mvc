using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BlogApp.Entidades
{
    public class Usuario
    {

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Clave { get; set; }

        public ICollection<Articulo> Articulos { get; set; }

    }
}
