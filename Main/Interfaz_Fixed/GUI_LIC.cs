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
    public partial class LICGUI : Form
    {
        private PlanDeEstudio PDE;

        public LICGUI(PlanDeEstudio planEstudio)
        {
            PDE = planEstudio;
            InitializeComponent();

        }

        private void EntrenarListening_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                Evaluacion evaluacionListening = new Evaluacion("Listening", diccionarios, 3);
                evaluacionListening.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Crear la Evaluacion, favor enviar un reporte","Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            */
            Evaluacion evaluacionListening = new Evaluacion("Listening",PDE);
            evaluacionListening.Show();
        }

        private void EntrenarReading_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                Evaluacion evaluacionReading = new Evaluacion("Reading", diccionarios, 2);
                evaluacionReading.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Crear la Evaluacion, favor enviar un reporte","ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
            Evaluacion evaluacionReading = new Evaluacion("Reading",PDE);
            evaluacionReading.Show();
        }

        private void EntrenarWriting_Click(object sender, EventArgs e)
        {
            /*
            try {
                Evaluacion evaluacionWriting = new Evaluacion("Writing", diccionarios, 4);
                evaluacionWriting.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Crear la Evaluacion, favor enviar un reporte", "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
            Evaluacion evaluacionWriting = new Evaluacion("Writing",PDE);
            evaluacionWriting.Show();
        }
        private void EntrenamientoGeneral_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                Evaluacion evaluacionGeneral = new Evaluacion("Contenidos Generales", diccionarios, 1);
                evaluacionGeneral.Show();
            }
            catch (Exception){
                MessageBox.Show("No se pudo Crear la Evaluacion, favor enviar un reporte", "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            */
            Evaluacion evaluacionGeneral = new Evaluacion("Contenidos Generales",PDE);
            evaluacionGeneral.Show();
        }
    }
}
