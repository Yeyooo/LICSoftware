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
    public partial class EvaluacionCustom_Loaded : Form
    {
        private string nombreEvaluacion;

        public EvaluacionCustom_Loaded(string path)
        {
            InitializeComponent();
            try
            {
                CargarAssets(recuperarAssets(recuperarIDs(path)));
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Problema al cargar la Evaluacion","Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<int> recuperarIDs(string path)
        {
            string arregloID;
            string[] IDS;
            try
            {
                List<int> idsRecuperadas = new List<int>();
                if (File.Exists(path) && path.EndsWith(".sav"))
                {
                    StreamReader readerArchivo = new StreamReader(path);
                    while (!readerArchivo.EndOfStream)
                    {
                        nombreEvaluacion = readerArchivo.ReadLine();
                        arregloID = readerArchivo.ReadLine();
                        IDS = arregloID.Split(',');
                        foreach (string indice in IDS)
                        {
                            if (indice != " ") {
                                int aux = int.Parse(indice);
                                idsRecuperadas.Add(aux);
                            }
                            else
                            {

                            }
                        }
                    }
                    readerArchivo.Close();
                }
                return idsRecuperadas;
            }
            catch (Exception)
            {
                MessageBox.Show("Problema al cargar Assets","Assets Invalidos",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return null;
            }
        }

        private List<Asset> recuperarAssets(List<int> id_Assets)
        {
            List<Asset> listaRecuperada = new List<Asset>();
            foreach (int id in id_Assets) {
                listaRecuperada.Add(AssetDAL.BuscarAssetPorID(id));
            }
            return listaRecuperada;
        }

        private void CargarAssets(List<Asset> assetsRecuperados)
        {
            Tipo_Evaluacion.Text = "Pauta de " + nombreEvaluacion;
            AsignarTexto(layout_Pregunta1,assetsRecuperados[0],radioButton1);
            AsignarTexto(layout_Pregunta2, assetsRecuperados[1], radioButton2);
            AsignarTexto(layout_Pregunta3, assetsRecuperados[2], radioButton3);
            AsignarTexto(layout_Pregunta4, assetsRecuperados[3], radioButton4);
            AsignarTexto(layout_Pregunta5, assetsRecuperados[4], radioButton5);
            AsignarTexto(layout_Pregunta6, assetsRecuperados[5], radioButton6);
            AsignarTexto(layout_Pregunta7, assetsRecuperados[6], radioButton7);
            AsignarTexto(layout_Pregunta8, assetsRecuperados[7], radioButton8);
            AsignarTexto(layout_Pregunta9, assetsRecuperados[8], radioButton9);
            AsignarTexto(layout_Pregunta10, assetsRecuperados[9], radioButton10);
        }

        private void AsignarTexto(TableLayoutPanel panel, Asset asset, RadioButton buttonAlternativas)
        {

            for (int i = 0; i < panel.RowCount; i++)
            {
                if (i == 0)
                {
                    Label control = panel.GetControlFromPosition(0, i) as Label;
                    control.Text = asset.getEnunciadoPregunta();
                }
                if (i == 1)
                {
                    List<Alternativa> alternativas = asset.getAlternativas();
                    buttonAlternativas.Text = alternativas[asset.getRespuestaCorrecta()].getTxtAlternativa();
                }
                if (i == 2)
                {
                    Button control = panel.GetControlFromPosition(0, i) as Button;
                    control.Text = "Teoria";
                    control.Click += (s, e) => Evento_Teoria(s, e, asset);
                }
            }
        }

        private void Evento_Teoria(object sender, EventArgs e, Asset asset)
        {
            new Teoria(asset).Show();      
        }
    }
}
