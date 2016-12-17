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
    public partial class LICGUI : Form
    {
        private Usuario userInternal;
        private EvaluacionNOGUI listaInternal;

        private string nombreEvaluacion;
        private string arregloID;
        private string[] IDS;


        public LICGUI(Usuario user)
        {
            userInternal = user;
            //listaInternal = new EvaluacionNOGUI(user.getPlanDeEstudio());
            InitializeComponent();
            this.Usuario_Label.Text = this.Usuario_Label.Text + " "+user.getNombre().ToUpper();
            Cargar_Ligas(userInternal);
        }

        private void Cargar_Ligas(Usuario userLiga)
        {
            setLigaListening(userLiga.getNivelListening());
            setLigaReading(userLiga.getNivelReading());
            setLigaWriting(userLiga.getNivelWriting());     
        }

        private void setLigaListening(int Numero)
        {
            switch (Numero)
            {
                case 1: picture_ListeningLiga.Image = Properties.Resources.Bronze_Leage;
                        break;
                case 2: picture_ListeningLiga.Image = Properties.Resources.Silver_leage_NB;
                        break;
                case 3: picture_ListeningLiga.Image = Properties.Resources.Gold_Leage;
                        break;
            }
        }

        private void setLigaReading(int Numero)
        {
            switch (Numero)
            {
                case 1:
                    picture_ReadingLiga.Image = Properties.Resources.Bronze_Leage;
                    break;
                case 2:
                    picture_ReadingLiga.Image = Properties.Resources.Silver_leage_NB;
                    break;
                case 3:
                    picture_ReadingLiga.Image = Properties.Resources.Gold_Leage;
                    break;
            }
        }

        private void setLigaWriting(int Numero)
        {
            switch (Numero)
            {
                case 1:
                    picture_WritingLiga.Image = Properties.Resources.Bronze_Leage;
                    break;
                case 2:
                    picture_WritingLiga.Image = Properties.Resources.Silver_leage_NB;
                    break;
                case 3:
                    picture_WritingLiga.Image = Properties.Resources.Gold_Leage;
                    break;
            }

        }

        private void EntrenarListening_Click(object sender, EventArgs e)
        {
            try
            {


                //EvaluacionEnfocada evaluacionListening = new EvaluacionEnfocada("Listening",listaInternal.getPreguntasListening());

                PlanDeEstudio x = userInternal.getPlanDeEstudio();

                Dictionary<int, Asset> dicc = x.getDicListening();
                Console.WriteLine("count: " + dicc.Count);
                foreach (KeyValuePair<int, Asset> asd in dicc)
                {
                    Console.WriteLine("valor id : "+asd.Value.getId());
                }
                List<Asset> tmp = EvaluacionNOGUI.EvaluacionPorHabilidadTEST(dicc);
                
                Console.WriteLine("count: "+tmp.Count);
                EvaluacionEnfocada evaluacionListening = new EvaluacionEnfocada("Listening", tmp);

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
                PlanDeEstudio x = userInternal.getPlanDeEstudio();

                Dictionary<int, Asset> dicc = x.getDicReading();
                Console.WriteLine("count: " + dicc.Count);
                foreach (KeyValuePair<int, Asset> asd in dicc)
                {
                    Console.WriteLine("valor id : " + asd.Value.getId());
                }
                List<Asset> tmp = EvaluacionNOGUI.EvaluacionPorHabilidadTEST(dicc);

                Console.WriteLine("count: " + tmp.Count);
                EvaluacionEnfocada evaluacionReading = new EvaluacionEnfocada("Reading", tmp);

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
                PlanDeEstudio x = userInternal.getPlanDeEstudio();

                Dictionary<int, Asset> dicc = x.getDicWriting();
                Console.WriteLine("count: " + dicc.Count);
                foreach (KeyValuePair<int, Asset> asd in dicc)
                {
                    Console.WriteLine("valor id : " + asd.Value.getId());
                }
                List<Asset> tmp = EvaluacionNOGUI.EvaluacionPorHabilidadTEST(dicc);

                Console.WriteLine("count: " + tmp.Count);
                EvaluacionEnfocada evaluacionWriting = new EvaluacionEnfocada("Writing", tmp);

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
            string currentPath = Environment.CurrentDirectory + "\\Recursos\\Usuarios\\" + userInternal.getNombre();
            if (!Directory.Exists(currentPath))
            {
                try
                {
                    DirectoryInfo di = Directory.CreateDirectory(currentPath);
                    MessageBox.Show("Carpeta Creada Exitosamente","Mensaje Importante",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al crear la carpeta para el Usuario, por favor ponganse en contacto con los Desarrolladores","FATAL ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Error_Report().Show();
        }

        private void CargarEvaluaciones_Label_Click(object sender, EventArgs e)
        {
            //Aqui se abirar el open dialog
            OpenFileDialog fileChooser = new OpenFileDialog();
            //fileChooser.Filter = "Archivos SAVLIC(*.savlic)|(*.SAVLIC)";
            fileChooser.Title = "Archivos de Pruebas Corregidas";
            string currentPath = Environment.CurrentDirectory + "\\Recursos\\Usuarios\\"+userInternal.getNombre();
            if (Directory.Exists(currentPath))
            {
                fileChooser.InitialDirectory = currentPath;
                if (fileChooser.ShowDialog() == DialogResult.OK)
                {
                    //abrir la prueba
                    StreamReader lector = new StreamReader(File.OpenRead(fileChooser.FileName));

                    string auxiliar = lector.ReadLine();
                    if (auxiliar == "Contenidos Generales")
                    {
                        lector.Close();
                        new EvaluacionGeneral_Loaded(fileChooser.FileName).Show();
                        //new EvaluacionGeneral_Loaded(currentPath + FileNameInternal).Show();
                    }
                    else if (auxiliar == "Reading" || auxiliar == "Listening" || auxiliar == "Writing")
                    {
                        lector.Close();
                        new EvaluacionCustom_Loaded(fileChooser.FileName).Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("El usuario Actual no ha guardado ninguna evaluación","Error al cargar Carpeta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

    }
}
