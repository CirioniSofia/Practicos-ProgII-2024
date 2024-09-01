using Practica01.Data.Utils;
using Practica01.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Data
{
    public class FacturaRepository : IFacturaRepository
    {
        public List<Factura> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Factura> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Factura oFactura)
        {
            bool result = true;
            SqlTransaction? t = null;
            SqlConnection? cnn = null;

            try 
            {
                cnn = DataHelper.GetInstance().GetConnection();
                cnn.Open();
                t = cnn.BeginTransaction(0);

                var cmd = new SqlCommand("SP_INSERTAR_FACTURA", cnn, t);
                //parametros de entrada
                cmd.Parameters.AddWithValue("@id_forma_pago", oFactura.FormaPago);
                cmd.Parameters.AddWithValue("@cliente", oFactura.Cliente);

                //parametros de salida si tiene

            }
        }
    }
}
