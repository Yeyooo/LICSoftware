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
    public partial class EvaluacionEnfocada : Form
    {
        private int TiempoRestante = 720;
        private int MinutosRestante = 0;
        private int SegundosRestantes = 60;

        private List<Asset> AssetsEscogidos;

        private string nombreUsuario;
        private string tipoEvaluacion;
        private int NivelUsuario;
        private Usuario userInternal;

        public EvaluacionEnfocada(string Nombre,List<Asset> Assets,string nombreUser, int nivelUsuario,Usuario user)
        {
            InitializeComponent();
            this.NivelUsuario = nivelUsuario;
            nombreUsuario = nombreUser;
            userInternal = user;
            AssetsEscogidos = Assets;
            Asignar_Loop(AssetsEscogidos);
            tipoEvaluacion = Nombre.ToLower();
            tipoEvaluacion_Label.Text = tipoEvaluacion_Label.Text +" "+ Nombre;
        }

        private void Evento_MaterialAudio(object sender, EventArgs e, Asset asset)
        {
            string path = Environment.CurrentDirectory +"\\Recursos\\Audio\\"+asset.getUrlArchivo();
            new Material_ApoyoAudio(path).Show();
        }

        private void Evento_MaterialImagen(object sender, EventArgs e, Asset asset)
        {
            string path = Environment.CurrentDirectory + "\\Recursos\\Imagen\\" + asset.getUrlArchivo();
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
            EvaluadorPruebasEspecificas evaluador = new EvaluadorPruebasEspecificas(tipoEvaluacion,NivelUsuario);
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
            //ANTES DE ENVIAR AL TUTOR PREGUNTAR SI DESEA GUARDAR LA EVALUACION
            evaluador.MostrarResultados();
            DialogResult resultado = MessageBox.Show("¿Desea guardar esta evaluacion corregida para su posterior revisión?", "Guardar Evaluación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //Escribir en Memoria secundaria

                EscribirEnDisco(nombreUsuario, AssetsEscogidos, tipoEvaluacion_Label.Text);
                //Enviar al Tutor
                DialogResult dialog =MessageBox.Show("Guardado Correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    
                    LICGUI.EstadoWriting = Agente.agente(evaluador.getHechos());
                    LICGUI.EstadoListening = Agente.agente(evaluador.getHechos());
                    LICGUI.EstadoReading = Agente.agente(evaluador.getHechos());
                    int nivelwriting = userInternal.getNivelWriting();
                    int nivelreading = userInternal.getNivelReading();
                    int nivellistening = userInternal.getNivelListening();
                    string correo = userInternal.getCorreo();

                    if (LICGUI.EstadoWriting == "bajar")
                    {
                        UsuarioDAL.setNivelesUsuarioEnBD(nivelwriting-1, nivelreading, nivellistening, correo);
                        LICGUI.EstadoWriting = "mantener";
                    }
                    if (LICGUI.EstadoReading == "bajar")
                    {
                        UsuarioDAL.setNivelesUsuarioEnBD(nivelwriting, nivelreading-1, nivellistening, correo);
                        LICGUI.EstadoReading = "mantener";
                    }
                    if (LICGUI.EstadoListening == "bajar")
                    {
                        UsuarioDAL.setNivelesUsuarioEnBD(nivelwriting, nivelreading, nivellistening-1, correo);
                        LICGUI.EstadoListening = "mantener";
                    }
                    if (LICGUI.EstadoWriting == "subir")
                    {
                        UsuarioDAL.setNivelesUsuarioEnBD(nivelwriting + 1, nivelreading, nivellistening, correo);
                        LICGUI.EstadoWriting = "mantener";
                    }
                    if (LICGUI.EstadoReading == "subir")
                    {
                        UsuarioDAL.setNivelesUsuarioEnBD(nivelwriting, nivelreading + 1, nivellistening, correo);
                        LICGUI.EstadoReading = "mantener";
                     
                    }
                    if (LICGUI.EstadoListening == "subir")
                    {
                        UsuarioDAL.setNivelesUsuarioEnBD(nivelwriting, nivelreading, nivellistening + 1, correo);
                        LICGUI.EstadoListening = "mantener";

                    }
                    MessageBox.Show("Directorio del usuario no existe"+LICGUI.EstadoWriting, "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    new LICGUI(userInternal).Show();
                    this.Close();
                }
            }
            else if (resultado == DialogResult.No)
            {

                this.Close();
                //Enviar al Tutor
            }
        }

        private void EscribirEnDisco(string usuarioName, List<Asset> listaAuxiliar, string TipoEvaluacion)
        {
            string currentPath = Environment.CurrentDirectory + "\\Recursos\\Usuarios\\" + usuarioName;
            if (Directory.Exists(currentPath))
            {
                SaveFileDialog saver = new SaveFileDialog();
                saver.InitialDirectory = currentPath;
                if (saver.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter escritor = new StreamWriter(File.Create(saver.FileName + ".sav"));
                    escritor.WriteLine(TipoEvaluacion);
                    foreach (Asset asset in listaAuxiliar)
                    {
                        escritor.Write(asset.getId() + ", ");
                    }
                    escritor.Close();
                }
            }
            else
            {
                MessageBox.Show("Directorio del usuario no existe", "ERROR FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
