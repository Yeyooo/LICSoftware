using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Datos
{

    //Clase exclusiva para trabajar con base de datos.
    public class Conexión
    {
        public static SqlConnection obtenerConexion(string bdAcceso)
        {
            try
            {
                SqlConnection conectar = new SqlConnection("Data source=DESKTOP-TVNPEVE\\SQLEXPRESS_NOTE; Initial Catalog=" + bdAcceso+"; User Id=sa; Password = felipe2-;");
                //SqlConnection conectar = new SqlConnection("Data source=YEYO-PC; Initial Catalog=" + bdAcceso + "; User Id=sa; Password = abcd123456;");

                conectar.Open();

                return conectar;
            }
            catch (SqlException )
            {
                //Console.WriteLine(e.StackTrace);
                MessageBox.Show("Problema con la conexión de la Base de Datos", "Inicio de sesión fallado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            
        }

    }
}
