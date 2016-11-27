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
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TableLayoutPanel LayoutPanel_Evaluacion { get; private set; }

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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(EvaluacionGUI));
            this.LayoutPanel_Evaluacion = new TableLayoutPanel();
            // 
            // EvaluacionNewGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(745, 671);
            this.AutoScroll = true;
            this.Name = "EvaluacionNewGUI";
            this.Text = "Evaluacion";
            this.ResumeLayout(false);
            this.LayoutPanel_Evaluacion = new System.Windows.Forms.TableLayoutPanel();
            resources.ApplyResources(this.LayoutPanel_Evaluacion, "LayoutPanel_Evaluacion");

            LlenarEvaluacion();

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
    }
}