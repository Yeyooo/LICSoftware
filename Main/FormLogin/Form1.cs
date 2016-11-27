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

namespace FormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if( textBoxPw.Text != "" && textBoxCorreo.Text != "")
            {
                if(textBoxPw.Text == UsuarioDAL.verificarPassword(textBoxCorreo.Text))
                {
                    MessageBox.Show("Has iniciado sesión!", "Inicio Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("La contraseña no es la correcta", "Inicio Unsuccesful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            


        }
    }
}
