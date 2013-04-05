using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Entidades
{
    public class Etiqueta
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Articulo> Articulos { get; set; }

    }
}
