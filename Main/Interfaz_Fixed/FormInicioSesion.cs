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
using FormRegistro;
using Interfaz_Fixed;

namespace FormLogin
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBoxPw.Text != "" && textBoxCorreo.Text != "")
            {
                if (UsuarioDAL.verificarPassword(textBoxCorreo.Text) != null) {
                    if (textBoxPw.Text == UsuarioDAL.verificarPassword(textBoxCorreo.Text))
                    {
                        MessageBox.Show("Has iniciado sesión!", "Inicio Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Usuario user = new Usuario(textBoxCorreo.Text);
                        PlanDeEstudio PE = new PlanDeEstudio(user.getNivelWriting(), user.getNivelReading(), user.getNivelListening());
                        Application.Run(new LICGUI(user, PE));
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no es la correcta", "Inicio Unsuccesful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }


        }

        private void buttonParaRegistro_Click(object sender, EventArgs e)
        {
            new Registro_GUI().Show();
            
        }
    }
}
