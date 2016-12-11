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
    public partial class EvaluacionEnfocada : Form
    {
        private int TiempoRestante = 720;
        private int MinutosRestante = 0;
        private int SegundosRestantes = 60;

        public EvaluacionEnfocada(string Nombre,List<Asset> Assets)
        {
            InitializeComponent();
            Asignar_Loop(Assets);
            tipoEvaluacion_Label.Text = tipoEvaluacion_Label+Nombre;
        }

        private void Evento_MaterialAudio(object sender, EventArgs e, Asset asset)
        {
            string path = Environment.CurrentDirectory +"/Recursos/Audios/"+asset.getUrlArchivo();
        }

        private void Evento_MaterialImagen(object sender, EventArgs e, Asset asset)
        {
            string path = Environment.CurrentDirectory + "/Recursos/Imagen/" + asset.getUrlArchivo();
            new Material_ApoyoImagen(path).Show();
        }
        
        private void Evento_SinMaterial(object sender, EventArgs e)
        {
            MessageBox.Show("La pregunta no tiene material asociado","Material",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TiempoRestante--; //Segundos para los minutos
            SegundosRestantes--;
            MinutosRestante = Int32.Parse(TiempoRestante.ToString()) / 60;
            if (SegundosRestantes < 0)
            {
                SegundosRestantes = 59;
                tiempoRestante_Label.Text = "Tiempo Restante = " + MinutosRestante.ToString() + ":" + SegundosRestantes.ToString();
            }
            else
            {
                if (SegundosRestantes < 10)
                {
                    tiempoRestante_Label.Text = "Tiempo Restante = " + MinutosRestante.ToString() + ":0" + SegundosRestantes.ToString();
                }
                else
                {
                    tiempoRestante_Label.Text = "Tiempo Restante = " + MinutosRestante.ToString() + ":" + SegundosRestantes.ToString();
                }
            }
        }

        private void Entregar_EvaluacionCustom(object sender, EventArgs e)
        {
            EvaluadorPruebasEspecificas evaluador = new EvaluadorPruebasEspecificas();
            evaluador.recorrerPreguntas(this.layout_Alternativas1);
            evaluador.recorrerPreguntas(this.layout_Alternativas2);
            evaluador.recorrerPreguntas(this.layout_Alternativas3);
            evaluador.recorrerPreguntas(this.layout_Alternativas4);
            evaluador.recorrerPreguntas(this.layout_Alternativas5);
            evaluador.recorrerPreguntas(this.layout_Alternativas6);
            evaluador.recorrerPreguntas(this.layout_Alternativas7);
            evaluador.recorrerPreguntas(this.layout_Alternativas8);
            evaluador.recorrerPreguntas(this.layout_Alternativas9);
            evaluador.recorrerPreguntas(this.layout_Alternativas10);
            evaluador.Evaluar();
        }

    }
}
