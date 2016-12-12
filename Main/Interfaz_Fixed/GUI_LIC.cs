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
        private Usuario userInternal;
        private EvaluacionNOGUI listaInternal;

        public LICGUI(Usuario user)
        {
            userInternal = user;
            InitializeComponent();
            this.Usuario_Label.Text = this.Usuario_Label.Text + ""+user.getNombre();
        }

        private void EntrenarListening_Click(object sender, EventArgs e)
        {
            try
            {
                EvaluacionEnfocada evaluacionListening = new EvaluacionEnfocada("Listening",listaInternal.getPreguntasListening());
                evaluacionListening.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Crear la Evaluacion, favor enviar un reporte","Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EntrenarReading_Click(object sender, EventArgs e)
        {
            try
            {
                EvaluacionEnfocada evaluacionReading = new EvaluacionEnfocada("Reading", listaInternal.getPreguntasReading());
                evaluacionReading.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Crear la Evaluacion, favor enviar un reporte","ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EntrenarWriting_Click(object sender, EventArgs e)
        {
            try {
                EvaluacionEnfocada evaluacionWriting = new EvaluacionEnfocada("Writing", listaInternal.getPreguntasWriting());
                evaluacionWriting.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Crear la Evaluacion, favor enviar un reporte", "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void EntrenamientoGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                /*Evaluacion evaluacionGeneral = new Evaluacion("Contenidos Generales", diccionarios, 1);
                evaluacionGeneral.Show();*/
            }
            catch (Exception){
                MessageBox.Show("No se pudo Crear la Evaluacion, favor enviar un reporte", "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cerrando_GUI(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void GUILIC_Loading(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Error_Report().Show();
        }
    }
}
