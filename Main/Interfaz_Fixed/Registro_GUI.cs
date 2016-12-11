using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Interfaz_Fixed;

namespace FormRegistro
{
    public partial class Registro_GUI : Form
    {
        public Registro_GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirme.Text)
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = textBoxNombre.Text;
                usuario.Correo = textBoxCorreo.Text;
                usuario.Password = textBoxPassword.Text;

                Console.WriteLine("nombre: "+usuario.Nombre);
                Console.WriteLine("nombre: " + usuario.Correo);
                Console.WriteLine("nombre: " + usuario.Password);

                int resultado = UsuarioDAL.agregar(usuario);

                if ( resultado > 0 )
                {
                    MessageBox.Show("Se guardaron los datos con exito!", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("No se pudieron guardar los datos!", "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //LICGUI FormPrincipal = new LICGUI();
                //FormPrincipal.Show();
                new AutoEvaluacion(usuario.Correo).Show();
                this.Hide();
            }
        }
    }
}
