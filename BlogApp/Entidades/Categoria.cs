using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Entidades
{
    public class Categoria
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categoria CategoriaPadre { get; set; }


        public ICollection<Articulo> Articulos { get; set; }
        public ICollection<Categoria> SubCategorias { get; set; }
        

    }
}
