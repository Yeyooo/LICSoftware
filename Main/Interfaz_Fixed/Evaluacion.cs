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

        private int correctasListening = 0;
        private int incorrectasListening = 0;

        private int correctasWriting = 0;
        private int incorrectasWriting = 0;

        private int correctasReading = 0;
        private int incorrectasReading = 0;

        public Evaluacion(string EvaluacionNombre,EvaluacionNOGUI Assets)
        {
            InitializeComponent();
            Asignar_Labels(EvaluacionNombre);
            Asignar_Loop(Assets.getPreguntasReading(),Assets.getPreguntasWriting(),Assets.getPreguntasListening());
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
            EvaluadorPruebasEspecificas evaluadorReading = new EvaluadorPruebasEspecificas();
            evaluadorReading.recorrerPreguntas(this.Layout_Alternativas1);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas2);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas3);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas4);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas5);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas6);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas7);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas8);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas9);
            evaluadorReading.recorrerPreguntas(this.layout_Alternativas10);
            evaluadorReading.Evaluar();
            correctasReading = evaluadorReading.getRespuestasCorrectas();
            incorrectasReading = evaluadorReading.getRespuestasIncorrectas();

            EvaluadorPruebasEspecificas evaluadorWriting = new EvaluadorPruebasEspecificas();
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas11);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas12);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas13);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas14);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas15);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas16);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas17);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas18);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas19);
            evaluadorWriting.recorrerPreguntas(this.layout_Alternativas20);
            evaluadorWriting.Evaluar();
            correctasWriting = evaluadorWriting.getRespuestasCorrectas();
            incorrectasWriting = evaluadorWriting.getRespuestasIncorrectas();

            EvaluadorPruebasEspecificas evaluadorListening = new EvaluadorPruebasEspecificas();
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas21);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas22);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas23);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas24);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas25);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas26);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas27);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas28);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas29);
            evaluadorListening.recorrerPreguntas(this.layout_Alternativas30);
            evaluadorListening.Evaluar();
            correctasListening = evaluadorListening.getRespuestasCorrectas();
            incorrectasListening = evaluadorListening.getRespuestasIncorrectas();

            //ENVIAR POR 3 PARAMETROS, CORRECTAS E INCORRECTA DE TAL (INT CORRECTAS, INT INCORRECTAS, STRING HABILIDAD) EL NIVEL NO LO PUSE YA QUE EL TUTOR DEBERIA SABER DE ANTEMANO

        }

        private void Evento_MaterialAudio(object sender, EventArgs e, Asset asset)
        {
            string path = Environment.CurrentDirectory + "/Recursos/Audios/" + asset.getUrlArchivo();
            new Material_ApoyoAudio(path).Show();
        }

        private void Evento_MaterialImagen(object sender, EventArgs e, Asset asset)
        {
            string path = Environment.CurrentDirectory + "/Recursos/Imagen/" + asset.getUrlArchivo();
            new Material_ApoyoImagen(path).Show();
        }

        private void Evento_SinMaterial(object sender, EventArgs e)
        {
            MessageBox.Show("La pregunta no tiene material asociado", "Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }

}
