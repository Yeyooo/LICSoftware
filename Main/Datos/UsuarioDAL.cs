﻿using System;
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
