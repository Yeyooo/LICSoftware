using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{

    //Clase exclusiva para trabajar con base de datos.
    public class Conexión
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=tiendaPOO; Uid=root; pwd=abcd123456;");

            conectar.Open();
            return conectar;
        }
    }
}
