using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp.Entidades
{
    public class Articulo
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
        public string Contenido { get; set; }

        public DateTime Fecha { get; set; }

        public byte[] Imagen { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<Categoria> Categorias { get; set; }
        public ICollection<Etiqueta> Etiquetas { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
                
    }
}