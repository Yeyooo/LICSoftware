using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    public partial class Material_Apoyo : Form
    {
        public Material_Apoyo(Asset asset)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hablador("Soy la voz de la muñeca system, ahora ven y toca mi teclado retroiluminado pequeño hijo de la perra");
        }
    }
}
