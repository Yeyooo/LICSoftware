using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{

    //Clase exclusiva para trabajar con base de datos.
    public class Conexión
    {
        public static SqlConnection obtenerConexion()
        {
            SqlConnection conectar = new SqlConnection("Data source=YEYO-PC; Initial Catalog=registro; User Id=sa; Password=abcd123456;");

            conectar.Open();
            return conectar;
        }
    }
}
