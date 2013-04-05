using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogApp.Entidades
{
    public class Comentario
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
                
    }
}
