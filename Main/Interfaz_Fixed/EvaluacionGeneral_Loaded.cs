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
    public partial class EvaluacionGeneral_Loaded : Form
    {
        private string nombreEvaluacion;
        private string arregloID;
        private string[] IDS;

        public EvaluacionGeneral_Loaded(string path)
        {
            InitializeComponent();
            CargarAssets(recuperarAssets(recuperarIDs(path)));
        }

        private List<int> recuperarIDs(string path)
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
                            idsRecuperadas.Add(int.Parse(indice));
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

        private List<Asset> recuperarAssets(List<int> id_Assets)
        {
            List<Asset> listaRecuperada = new List<Asset>();
            foreach (int id in id_Assets)
            {
                listaRecuperada.Add(AssetDAL.BuscarAssetPorID(id));
            }
            return listaRecuperada;
        }

        private void CargarAssets(List<Asset> assetsRecuperados)
        {
            AsignarTexto(layout_Pregunta1, assetsRecuperados[0], radioButton1);
            AsignarTexto(layout_Pregunta2, assetsRecuperados[1], radioButton2);
            AsignarTexto(layout_Pregunta3, assetsRecuperados[2], radioButton3);
            AsignarTexto(layout_Pregunta4, assetsRecuperados[3], radioButton4);
            AsignarTexto(layout_Pregunta5, assetsRecuperados[4], radioButton5);
            AsignarTexto(layout_Pregunta6, assetsRecuperados[5], radioButton6);
            AsignarTexto(layout_Pregunta7, assetsRecuperados[6], radioButton7);
            AsignarTexto(layout_Pregunta8, assetsRecuperados[7], radioButton8);
            AsignarTexto(layout_Pregunta9, assetsRecuperados[8], radioButton9);
            AsignarTexto(layout_Pregunta10, assetsRecuperados[9], radioButton10);
            AsignarTexto(layout_Pregunta11, assetsRecuperados[10], radioButton11);
            AsignarTexto(layout_Pregunta12, assetsRecuperados[11], radioButton12);
            AsignarTexto(layout_Pregunta13, assetsRecuperados[12], radioButton13);
            AsignarTexto(layout_Pregunta14, assetsRecuperados[13], radioButton14);
            AsignarTexto(layout_Pregunta15, assetsRecuperados[14], radioButton15);
            AsignarTexto(layout_Pregunta16, assetsRecuperados[15], radioButton16);
            AsignarTexto(layout_Pregunta17, assetsRecuperados[16], radioButton17);
            AsignarTexto(layout_Pregunta18, assetsRecuperados[17], radioButton18);
            AsignarTexto(layout_Pregunta19, assetsRecuperados[18], radioButton19);
            AsignarTexto(layout_Pregunta20, assetsRecuperados[19], radioButton20);
            AsignarTexto(layout_Pregunta21, assetsRecuperados[20], radioButton21);
            AsignarTexto(layout_Pregunta22, assetsRecuperados[21], radioButton22);
            AsignarTexto(layout_Pregunta23, assetsRecuperados[22], radioButton23);
            AsignarTexto(layout_Pregunta24, assetsRecuperados[23], radioButton24);
            AsignarTexto(layout_Pregunta25, assetsRecuperados[24], radioButton25);
            AsignarTexto(layout_Pregunta26, assetsRecuperados[25], radioButton26);
            AsignarTexto(layout_Pregunta27, assetsRecuperados[26], radioButton27);
            AsignarTexto(layout_Pregunta28, assetsRecuperados[27], radioButton28);
            AsignarTexto(layout_Pregunta29, assetsRecuperados[28], radioButton29);
            AsignarTexto(layout_Pregunta30, assetsRecuperados[29], radioButton30);
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
