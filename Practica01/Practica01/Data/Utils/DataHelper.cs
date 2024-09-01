using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Data.Utils
{
    public class DataHelper
    {
        private static DataHelper _instancia;
        private SqlConnection _connection;

        private DataHelper() 
        {
            _connection = new SqlConnection(Properties.Resources.cnn);

        }
        public static DataHelper GetInstance()
        {
            if(_instancia == null)
                _instancia = new DataHelper();
            return _instancia;
        }
        public SqlConnection GetConnection() 
        {
            return _connection;
        }


    }

    
}
