using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Domain
{
    public class DetalleFactura
    {
        public Articulo Articulo { get; set; }
        public int cantidad {  get; set; }
        public float precio { get; set; }

        public float SubTotal() 
        {
            return precio * cantidad;
        }

    }
}
