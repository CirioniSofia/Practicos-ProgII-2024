using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Domain
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public float Precio { get; set; }

        public override string ToString()
        {
            return "[" + Id + "] " + Nombre;
        }
    }
}
