using Practica01.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Data
{
    public interface IFacturaRepository
    {
        bool Save(Factura oFactura);
        List<Factura> GetAll();

        List<Factura> GetById(int id);

    }
}
