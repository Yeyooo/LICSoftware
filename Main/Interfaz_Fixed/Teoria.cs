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
    public partial class Teoria : Form
    {
        public Teoria(Asset asset)
        {
            InitializeComponent();
            this.textBox_Teoria.Text = asset.getTeoria();
            this.Enunciado_Pregunta.Text = asset.getEnunciadoPregunta();
        }
    }
}
