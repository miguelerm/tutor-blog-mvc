using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Entidades
{
    public class Articulo
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Nombre { get; set; }
        public string Resumen { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Imagen { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
        public ICollection<Etiqueta> Etiquetas { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
        
    }
}