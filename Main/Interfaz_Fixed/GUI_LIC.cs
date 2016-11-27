using EvaluacionGUI;
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
    public partial class LICGUI : Form
    {
        public EvaluacionGUI.EvaluacionGUI form;
        public EvaluacionGUI.Contador_Tiempo_GUI formTiempo;

        public LICGUI()
        {
            InitializeComponent();
        }

        private void Entrenar_Click(object sender, EventArgs e)
        {
            formTiempo = new EvaluacionGUI.Contador_Tiempo_GUI();
            form = new EvaluacionGUI.EvaluacionGUI();
            formTiempo.Show();
            form.Show();

        }
    }
}
