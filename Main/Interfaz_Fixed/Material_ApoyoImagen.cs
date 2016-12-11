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
        private string path;

        public Material_ApoyoImagen()
        {
            InitializeComponent();
        }

        public Material_ApoyoImagen(string path)
        {
            this.pictureBox.Image = Image.FromFile(@path);
        }
    }
}
