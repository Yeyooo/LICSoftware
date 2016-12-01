using Datos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;


namespace EvaluacionGUI
{
    partial class EvaluacionNewGUI
    {

        private System.ComponentModel.IContainer components = null;


        #region Todas las variables de la GUI, botones, boxes, etc
        
        #endregion
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Interfaz de la Evaluacion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EvaluacionNewGUI
            // 
            this.ClientSize = new System.Drawing.Size(855, 449);
            this.Name = "EvaluacionNewGUI";
            this.ResumeLayout(false);

        }

        #endregion

        #region Aqui se llena la evaluacion

        public void LlenarEvaluacion()
        {
            LinkedList<Asset> listaFinal = SeleccionarAssets(AssetDAL.getDiccionarioWriting(), AssetDAL.getDiccionarioReading(), AssetDAL.getDiccionarioListening()) ;

        }

        public LinkedList<Asset> SeleccionarAssets(Dictionary<int,Asset> diccionarioWriting, Dictionary<int,Asset> diccionarioListening, Dictionary<int,Asset> diccionarioReading)
        {
            LinkedList<Asset> listaAssetSeleccionados = new LinkedList<Asset>();
            #region Lectura de los Assets en Writting
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                if (diccionarioWriting.Count == 0 || diccionarioReading.Count == 0 || diccionarioListening.Count == 0)
                {
                    MessageBox.Show("Los diccionarios estan vacios, problema a la BD");
                }
                int numeroClave = rnd.Next(1,diccionarioWriting.Count);
                if (diccionarioWriting.ContainsKey(numeroClave))
                {
                    listaAssetSeleccionados.AddLast(diccionarioWriting[numeroClave]);
                }
                else
                {
                    Console.WriteLine("No contiene la clave, esto no deberia pasar D:");
                }
            }
            #endregion
            #region Lectura de los Assets en Listenning
            for (int j = 0; j<10;j++)
            {
                Random rnd = new Random();
                int numeroClave = rnd.Next(1, diccionarioListening.Count);
                if (diccionarioListening.ContainsKey(numeroClave))
                {
                    listaAssetSeleccionados.AddLast(diccionarioListening[numeroClave]);
                }
                else
                {
                    Console.WriteLine("No contiene la clave, esto no deberia pasar D:");
                }
            }
            #endregion
            #region Lectura de los Assets en Reading
            for (int j = 0; j < 10; j++)
            {
                Random rnd = new Random();
                int numeroClave = rnd.Next(1, diccionarioReading.Count);
                if (diccionarioReading.ContainsKey(numeroClave))
                {
                    listaAssetSeleccionados.AddLast(diccionarioReading[numeroClave]);
                }
                else
                {
                    Console.WriteLine("No contiene la clave, esto no deberia pasar D:");
                }
            }
            #endregion
            return listaAssetSeleccionados;
        }

        public void AsignacionDeEspacio(LinkedList<Asset> listaAssets)
        {

            foreach(Asset asset in listaAssets)
            {

            }
        }

        #endregion

        private TableLayoutPanel Layout_FormEvaluacion;
        private Label GUIEvaluacion_tipo;
        private Label TiempoRestante_Label;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox Enunciado1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}