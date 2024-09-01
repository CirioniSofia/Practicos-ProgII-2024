using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Domain
{
    public class Factura
    {
        public int Nro {  get; set; }
        public DateTime Fecha { get; set; }
        public int FormaPago { get; set; }
        public string Cliente { get; set; }


        private List<DetalleFactura> detalles;
        public List<DetalleFactura> GetDetalles()
        { return detalles; }

        public Factura(DetalleFactura d)
        {
            detalles = new List<DetalleFactura>();
        }
        public void AgregarDetalle(DetalleFactura detalle)
        {
            if(detalle != null)
                detalles.Add(detalle);
        }

        public void QuitarDetalle(int index)
        {
            detalles.RemoveAt(index); 
        }

        public float subTotal()
        {
            float total = 0;
            foreach (var detalle in detalles)
                total += detalle.SubTotal();
            return total;
        }



    }
}
