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
    public partial class Material_ApoyoImagen : Form
    {
        public Material_ApoyoImagen(string path)
        {
            InitializeComponent();
            Material(path);
        }

        private void Material(string path)
        {
            this.Imagen.Image = Image.FromFile(path);
        }
    }
}
