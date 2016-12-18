using CapaLógica;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    public partial class Evaluacion : Form
    {
        //Tiempo Restante representado en segundos
        #region Variables
        private int TiempoRestante = 1800;
        private int MinutosRestante = 0;
        private int SegundosRestantes = 60;

        private int correctasListening = 0;
        private int incorrectasListening = 0;

        private int correctasWriting = 0;
        private int incorrectasWriting = 0;

        private int correctasReading = 0;
        private int incorrectasReading = 0;

        private Usuario userInternal;
        private string tipoEvaluacion;

        private List<Asset> listaReading, listaWriting, listaListening;

        #endregion

        public Evaluacion(string EvaluacionNombre,EvaluacionNOGUI Assets, Usuario user)
        {
            InitializeComponent();
            Asignar_Labels(EvaluacionNombre);
            tipoEvaluacion = EvaluacionNombre;
            userInternal = user;
            listaReading = Assets.getPreguntasReading();
            listaWriting = Assets.getPreguntasWriting();
            listaListening = Assets.getPreguntasListening();
            Asignar_Loop(listaReading, listaWriting, listaListening);
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
            this.Close();
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
            correctasListening = evaluadorListening.getRespuestasCorrectas();
            incorrectasListening = evaluadorListening.getRespuestasIncorrectas();

            //ANTES DE ENVIAR AL TUTOR PREGUNTAR SI DESEA GUARDAR LA EVALUACION

            DialogResult resultado = MessageBox.Show("¿Desea guardar esta evaluacion corregida para su posterior revisión?","Guardar Evaluación",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //Escribir en Memoria secundaria
                EscribirEnDisco(userInternal.getNombre(),listaReading,listaWriting,listaListening,EvaluacionDe_Label.Text);
                //Enviar al Tutor
            }
            else if (resultado == DialogResult.No)
            {
                //Enviar al Tutor
            }

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

        private List<Asset> ConcatenarAssets(List<Asset> listaReading, List<Asset> listaWriting, List<Asset> listaListening)
        {
            List<Asset> ListaFinal = new List<Asset>();
            foreach (Asset asset in listaReading)
            {
                ListaFinal.Add(asset);
            }
            foreach (Asset asset in listaWriting)
            {
                ListaFinal.Add(asset);
            }
            foreach (Asset asset in listaListening)
            {
                ListaFinal.Add(asset);
            }
            return ListaFinal;
        }

        private void EscribirEnDisco(string usuarioName,List<Asset> listaReading, List<Asset> listaWriting, List<Asset> listaListening,string TipoEvaluacion)
        {
            string currentPath = Environment.CurrentDirectory + "\\Recursos\\Usuarios\\" + usuarioName;
            if (Directory.Exists(currentPath)) {
                List<Asset> listaFinal = ConcatenarAssets(listaReading,listaWriting,listaListening);
                SaveFileDialog saver = new SaveFileDialog();
                saver.InitialDirectory = currentPath;
                if (saver.ShowDialog() == DialogResult.OK) {
                    StreamWriter escritor = new StreamWriter(File.Create(saver.FileName + ".sav"));
                    escritor.WriteLine(TipoEvaluacion);
                    foreach (Asset asset in listaFinal) {
                        escritor.Write(asset.getId()+", ");
                    }
                    escritor.Close();
                }
            }
            else
            {
                MessageBox.Show("Directorio del usuario no existe","ERROR FATAL",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


    }

}
