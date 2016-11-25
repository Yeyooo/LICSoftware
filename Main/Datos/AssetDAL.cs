using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Datos
{
    class AssetDAL
    {
        public static int agregar (Asset asset)
        {
            int retorno = 0;
            string insert = ""; // esto se borra, es para mayor claridad

            MySqlCommand comando = new MySqlCommand(string.Format(insert), Conexión.obtenerConexion()); // en el insert va la consulta(inserción) sql.
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
    }
}
