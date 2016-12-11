using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Datos
{
    public class UsuarioDAL
    {

        public static void setNivelesUsuarioEnBD(int NivelWriting, int NivelReading, int NivelListening, string Correo)
        {
            using (SqlConnection Conn = Conexión.obtenerConexion("registro"))
            {
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE usuarios SET nivelwriting = "+NivelWriting+", nivelreading = "+NivelReading+", nivellistening = "+NivelListening+" WHERE correo = '"+Correo+"';"), Conn);
                try
                {
                    int retorno = cmd.ExecuteNonQuery();
                    Conn.Close();
     
                }
                catch (System.InvalidOperationException e)
                {
                    MessageBox.Show("Problema con la contraseña de usuario", "Inicio de sesión fallado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        public static List<string> datosUsuario(string correoIngresado) // sin niveles
        {

            List<string> TmpDatos = new List<string>();

            using (SqlConnection Conn = Conexión.obtenerConexion("registro"))
            {
                //cmd = new SqlCommand(string.Format("select password from usuarios where correo = '" + correoIngresado + "'"));
                SqlCommand cmd = new SqlCommand(string.Format("select nombre, correo, password from usuarios where correo = '" + correoIngresado + "'"), Conn);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TmpDatos.Add(reader.GetString(0)); // agrega el nombre
                        TmpDatos.Add(reader.GetString(1)); // agrega el correo
                        TmpDatos.Add(reader.GetString(2)); // agrega el password

                    }
                    Conn.Close();
                    return TmpDatos;
                }
                catch (System.InvalidOperationException e)
                {
                    MessageBox.Show("Problema con la contraseña de usuario", "Inicio de sesión fallado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }

            }



        }

        public static List<int> nivelesUsuario(string correoIngresado) // solo los niveles del usuario
        {
            List<int> TmpNiveles = new List<int>();

            using (SqlConnection Conn = Conexión.obtenerConexion("registro"))
            {
                //cmd = new SqlCommand(string.Format("select password from usuarios where correo = '" + correoIngresado + "'"));
                SqlCommand cmd = new SqlCommand(string.Format("select nivelwriting, nivelreading, nivellistening from usuarios where correo = '" + correoIngresado + "'"), Conn);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TmpNiveles.Add(reader.GetInt32(0)); // agrega el writing
                        TmpNiveles.Add(reader.GetInt32(1)); // agrega el reading
                        TmpNiveles.Add(reader.GetInt32(2)); // agrega el listening

                    }
                    Conn.Close();
                    return TmpNiveles;
                }
                catch (System.InvalidOperationException e)
                {
                    MessageBox.Show("Problema con la contraseña de usuario", "Inicio de sesión fallado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }

            }


        }
        public static int agregar(Usuario usuario) // insertar a BD para registrarse
        {
            int retorno = 0;
            using (SqlConnection Conn = Conexión.obtenerConexion("registro"))
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("INSERT INTO usuarios (correo, nombre, password) values ('" + usuario.Correo + "', '" + usuario.Nombre + "', '" + usuario.Password + "')"), Conexión.obtenerConexion("registro")); // en el insert va la consulta(inserción) sql.
                    retorno = comando.ExecuteNonQuery();
                    Conn.Close();
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show("Problema con el registro del usuario", "El registro ha fallado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            return retorno;
        }

        public static string verificarPassword(string correoIngresado)
        {
            using (SqlConnection Conn = Conexión.obtenerConexion("registro"))
            {
                //cmd = new SqlCommand(string.Format("select password from usuarios where correo = '" + correoIngresado + "'"));
                SqlCommand cmd = new SqlCommand(string.Format("select password from usuarios where correo = '" + correoIngresado + "'"), Conn);
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    string pw = "";

                    while (reader.Read())
                    {
                        pw = reader.GetString(0);

                    }
                    Conn.Close();
                    return pw;
                }
                catch (System.InvalidOperationException e)
                {
                    MessageBox.Show("Problema con la contraseña de usuario", "Inicio de sesión fallado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }   
            }
        }

    }


}
