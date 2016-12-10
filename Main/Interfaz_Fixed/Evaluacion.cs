using CapaLógica;
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
       
        public Evaluacion(string EvaluacionNombre,PlanDeEstudio PDE)
        {
            InitializeComponent();
            Asignar_Labels(EvaluacionNombre);
            Asignar_Loop(PDE);
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
        
        
        private void EventoClick_Asset(object sender, EventArgs e, Asset asset)
        {
            Form material_Apoyo = new Material_Apoyo(asset);
            material_Apoyo.Show();
        }

        private void SinMaterial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La pregunta se realiza sin ningun material","Material", MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void Entregar_Boton_Click(object sender, EventArgs e)
        {
           EvaluadorPruebasEspecificas evaluador = new EvaluadorPruebasEspecificas();
            evaluador.recorrerPreguntas(this.Layout_Alternativas1);
            evaluador.recorrerPreguntas(this.layout_Alternativas2);
            evaluador.recorrerPreguntas(this.layout_Alternativas3);
            evaluador.Evaluar();
            evaluador.MostrarResultados();
        }
    }

}
