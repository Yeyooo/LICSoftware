using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class UsuarioDAL
    {

        public static int agregar(Usuario usuario) // insertar a BD para registrarse
        {
            int retorno = 0;
            using (SqlConnection Conn = Conexión.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("INSERT INTO usuarios (correo, nombre, password) values ('" + usuario.Correo + "', '" + usuario.Nombre + "', '" + usuario.Password + "')"), Conexión.obtenerConexion()); // en el insert va la consulta(inserción) sql.
                retorno = comando.ExecuteNonQuery();
            }

            return retorno;
        }


    }
}
