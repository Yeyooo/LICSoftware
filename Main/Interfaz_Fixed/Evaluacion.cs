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
    public partial class Evaluacion : Form
    {
        //Tiempo Restante representado en segundos
        private int TiempoRestante = 1800;
        private int MinutosRestante = 0;
        private int SegundosRestantes = 60;

        public Evaluacion(string tipoEvaluacion)
        {
            InitializeComponent();
        }
        /*
        public Evaluacion(string tipoEvaluacion, AssetDAL asset, int i)
        {
            *Entrenamiento General : 1
            Entrenamiento Reading : 2
            Entrenamineto Listening : 3
            Entrenamiento Writing : 4
            try
            {
                if (asset.getDiccionarioWriting() != null || asset.getDiccionarioReading() != null || asset.getDiccionarioListening() != null)
                {
                    InitializeComponent(tipoEvaluacion, asset.getDiccionarioWriting(), asset.getDiccionarioReading(), asset.getDiccionarioListening(), i);
                }
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Los Diccionarios de Assets estan vacios !", "Problema en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }*/

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tiempoRestante_tick(object sender, EventArgs e)
        {
            TiempoRestante--; //Segundos para los minutos
            SegundosRestantes--;
            MinutosRestante = Int32.Parse(TiempoRestante.ToString())/60;   
            if (SegundosRestantes < 0)
            {
                SegundosRestantes = 59;
                Tiempo_RestanteLabel.Text = "Tiempo Restante = " + MinutosRestante.ToString() + ":" + SegundosRestantes.ToString();
            }
            else
            {
                if (SegundosRestantes < 10)
                {
                    Tiempo_RestanteLabel.Text = "Tiempo Restante = " + MinutosRestante.ToString() + ":0" + SegundosRestantes.ToString();
                }
                else
                {
                    Tiempo_RestanteLabel.Text = "Tiempo Restante = " + MinutosRestante.ToString() + ":" + SegundosRestantes.ToString();
                }
            }
        }

        private void Cancelar_boton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
