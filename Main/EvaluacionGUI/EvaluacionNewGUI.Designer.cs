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
        private TableLayoutPanel LayoutPanel_Evaluacion;
        private GroupBox Pregunta1;
        private GroupBox Pregunta2;
        private GroupBox Pregunta7;
        private GroupBox Pregunta3;
        private GroupBox Pregunta9;
        private GroupBox Pregunta8;
        private GroupBox Pregunta13;
        private GroupBox Pregunta4;
        private GroupBox Pregunta14;
        private GroupBox Pregunta15;
        private GroupBox Pregunta20;
        private GroupBox Pregunta19;
        private GroupBox Pregunta21;
        private GroupBox Pregunta16;
        private GroupBox Pregunta10;
        private GroupBox Pregunta11;
        private GroupBox Pregunta5;
        private GroupBox Pregunta17;
        private GroupBox Pregunta23;
        private GroupBox Pregunta22;
        private GroupBox Pregunta12;
        private GroupBox Pregunta18;
        private GroupBox Pregunta6;
        private GroupBox Pregunta24;
        private GroupBox Pregunta25;
        private GroupBox Pregunta26;
        private GroupBox Pregunta27;
        private GroupBox Pregunta28;
        private GroupBox Pregunta29;
        private GroupBox Pregunta30;
        private GroupBox groupBox1;
        
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(EvaluacionNewGUI));
            this.LayoutPanel_Evaluacion = new TableLayoutPanel();
            this.Pregunta1 = new System.Windows.Forms.GroupBox();
            this.Pregunta2 = new System.Windows.Forms.GroupBox();
            this.Pregunta7 = new System.Windows.Forms.GroupBox();
            this.Pregunta3 = new System.Windows.Forms.GroupBox();
            this.Pregunta9 = new System.Windows.Forms.GroupBox();
            this.Pregunta8 = new System.Windows.Forms.GroupBox();
            this.Pregunta13 = new System.Windows.Forms.GroupBox();
            this.Pregunta4 = new System.Windows.Forms.GroupBox();
            this.Pregunta14 = new System.Windows.Forms.GroupBox();
            this.Pregunta15 = new System.Windows.Forms.GroupBox();
            this.Pregunta20 = new System.Windows.Forms.GroupBox();
            this.Pregunta19 = new System.Windows.Forms.GroupBox();
            this.Pregunta21 = new System.Windows.Forms.GroupBox();
            this.Pregunta16 = new System.Windows.Forms.GroupBox();
            this.Pregunta10 = new System.Windows.Forms.GroupBox();
            this.Pregunta11 = new System.Windows.Forms.GroupBox();
            this.Pregunta5 = new System.Windows.Forms.GroupBox();
            this.Pregunta17 = new System.Windows.Forms.GroupBox();
            this.Pregunta23 = new System.Windows.Forms.GroupBox();
            this.Pregunta22 = new System.Windows.Forms.GroupBox();
            this.Pregunta12 = new System.Windows.Forms.GroupBox();
            this.Pregunta18 = new System.Windows.Forms.GroupBox();
            this.Pregunta6 = new System.Windows.Forms.GroupBox();
            this.Pregunta24 = new System.Windows.Forms.GroupBox();
            this.Pregunta25 = new System.Windows.Forms.GroupBox();
            this.Pregunta26 = new System.Windows.Forms.GroupBox();
            this.Pregunta27 = new System.Windows.Forms.GroupBox();
            this.Pregunta28 = new System.Windows.Forms.GroupBox();
            this.Pregunta29 = new System.Windows.Forms.GroupBox();
            this.Pregunta30 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LayoutPanel_Evaluacion.SuspendLayout();
            this.Pregunta1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel_Evaluacion
            // 
            resources.ApplyResources(this.LayoutPanel_Evaluacion, "LayoutPanel_Evaluacion");
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta1, 0, 0);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta2, 1, 0);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta7, 0, 1);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta3, 2, 0);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta9, 2, 1);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta8, 1, 1);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta13, 0, 2);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta4, 3, 0);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta14, 1, 2);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta15, 2, 2);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta20, 1, 3);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta19, 0, 3);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta21, 2, 3);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta16, 3, 2);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta10, 3, 1);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta11, 4, 1);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta5, 4, 0);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta17, 4, 2);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta23, 4, 3);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta22, 3, 3);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta12, 5, 1);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta18, 5, 2);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta6, 5, 0);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta24, 5, 3);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta25, 0, 4);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta26, 1, 4);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta27, 2, 4);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta28, 3, 4);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta29, 4, 4);
            this.LayoutPanel_Evaluacion.Controls.Add(this.Pregunta30, 5, 4);
            this.LayoutPanel_Evaluacion.Name = "LayoutPanel_Evaluacion";
            // 
            // Pregunta1
            // 
            this.Pregunta1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.Pregunta1, "Pregunta1");
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.TabStop = false;
            // 
            // Pregunta2
            // 
            resources.ApplyResources(this.Pregunta2, "Pregunta2");
            this.Pregunta2.Name = "Pregunta2";
            this.Pregunta2.TabStop = false;
            // 
            // Pregunta7
            // 
            resources.ApplyResources(this.Pregunta7, "Pregunta7");
            this.Pregunta7.Name = "Pregunta7";
            this.Pregunta7.TabStop = false;
            // 
            // Pregunta3
            // 
            resources.ApplyResources(this.Pregunta3, "Pregunta3");
            this.Pregunta3.Name = "Pregunta3";
            this.Pregunta3.TabStop = false;
            // 
            // Pregunta9
            // 
            resources.ApplyResources(this.Pregunta9, "Pregunta9");
            this.Pregunta9.Name = "Pregunta9";
            this.Pregunta9.TabStop = false;
            // 
            // Pregunta8
            // 
            resources.ApplyResources(this.Pregunta8, "Pregunta8");
            this.Pregunta8.Name = "Pregunta8";
            this.Pregunta8.TabStop = false;
            // 
            // Pregunta13
            // 
            resources.ApplyResources(this.Pregunta13, "Pregunta13");
            this.Pregunta13.Name = "Pregunta13";
            this.Pregunta13.TabStop = false;
            // 
            // Pregunta4
            // 
            resources.ApplyResources(this.Pregunta4, "Pregunta4");
            this.Pregunta4.Name = "Pregunta4";
            this.Pregunta4.TabStop = false;
            // 
            // Pregunta14
            // 
            resources.ApplyResources(this.Pregunta14, "Pregunta14");
            this.Pregunta14.Name = "Pregunta14";
            this.Pregunta14.TabStop = false;
            // 
            // Pregunta15
            // 
            resources.ApplyResources(this.Pregunta15, "Pregunta15");
            this.Pregunta15.Name = "Pregunta15";
            this.Pregunta15.TabStop = false;
            // 
            // Pregunta20
            // 
            resources.ApplyResources(this.Pregunta20, "Pregunta20");
            this.Pregunta20.Name = "Pregunta20";
            this.Pregunta20.TabStop = false;
            // 
            // Pregunta19
            // 
            resources.ApplyResources(this.Pregunta19, "Pregunta19");
            this.Pregunta19.Name = "Pregunta19";
            this.Pregunta19.TabStop = false;
            // 
            // Pregunta21
            // 
            resources.ApplyResources(this.Pregunta21, "Pregunta21");
            this.Pregunta21.Name = "Pregunta21";
            this.Pregunta21.TabStop = false;
            // 
            // Pregunta16
            // 
            resources.ApplyResources(this.Pregunta16, "Pregunta16");
            this.Pregunta16.Name = "Pregunta16";
            this.Pregunta16.TabStop = false;
            // 
            // Pregunta10
            // 
            resources.ApplyResources(this.Pregunta10, "Pregunta10");
            this.Pregunta10.Name = "Pregunta10";
            this.Pregunta10.TabStop = false;
            // 
            // Pregunta11
            // 
            resources.ApplyResources(this.Pregunta11, "Pregunta11");
            this.Pregunta11.Name = "Pregunta11";
            this.Pregunta11.TabStop = false;
            // 
            // Pregunta5
            // 
            resources.ApplyResources(this.Pregunta5, "Pregunta5");
            this.Pregunta5.Name = "Pregunta5";
            this.Pregunta5.TabStop = false;
            // 
            // Pregunta17
            // 
            resources.ApplyResources(this.Pregunta17, "Pregunta17");
            this.Pregunta17.Name = "Pregunta17";
            this.Pregunta17.TabStop = false;
            // 
            // Pregunta23
            // 
            resources.ApplyResources(this.Pregunta23, "Pregunta23");
            this.Pregunta23.Name = "Pregunta23";
            this.Pregunta23.TabStop = false;
            // 
            // Pregunta22
            // 
            resources.ApplyResources(this.Pregunta22, "Pregunta22");
            this.Pregunta22.Name = "Pregunta22";
            this.Pregunta22.TabStop = false;
            // 
            // Pregunta12
            // 
            resources.ApplyResources(this.Pregunta12, "Pregunta12");
            this.Pregunta12.Name = "Pregunta12";
            this.Pregunta12.TabStop = false;
            // 
            // Pregunta18
            // 
            resources.ApplyResources(this.Pregunta18, "Pregunta18");
            this.Pregunta18.Name = "Pregunta18";
            this.Pregunta18.TabStop = false;
            // 
            // Pregunta6
            // 
            resources.ApplyResources(this.Pregunta6, "Pregunta6");
            this.Pregunta6.Name = "Pregunta6";
            this.Pregunta6.TabStop = false;
            // 
            // Pregunta24
            // 
            resources.ApplyResources(this.Pregunta24, "Pregunta24");
            this.Pregunta24.Name = "Pregunta24";
            this.Pregunta24.TabStop = false;
            // 
            // Pregunta25
            // 
            resources.ApplyResources(this.Pregunta25, "Pregunta25");
            this.Pregunta25.Name = "Pregunta25";
            this.Pregunta25.TabStop = false;
            // 
            // Pregunta26
            // 
            resources.ApplyResources(this.Pregunta26, "Pregunta26");
            this.Pregunta26.Name = "Pregunta26";
            this.Pregunta26.TabStop = false;
            // 
            // Pregunta27
            // 
            resources.ApplyResources(this.Pregunta27, "Pregunta27");
            this.Pregunta27.Name = "Pregunta27";
            this.Pregunta27.TabStop = false;
            // 
            // Pregunta28
            // 
            resources.ApplyResources(this.Pregunta28, "Pregunta28");
            this.Pregunta28.Name = "Pregunta28";
            this.Pregunta28.TabStop = false;
            // 
            // Pregunta29
            // 
            resources.ApplyResources(this.Pregunta29, "Pregunta29");
            this.Pregunta29.Name = "Pregunta29";
            this.Pregunta29.TabStop = false;
            // 
            // Pregunta30
            // 
            resources.ApplyResources(this.Pregunta30, "Pregunta30");
            this.Pregunta30.Name = "Pregunta30";
            this.Pregunta30.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
  
            // 
            // EvaluacionGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutPanel_Evaluacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EvaluacionGUI";
            this.LayoutPanel_Evaluacion.ResumeLayout(false);
            this.Pregunta1.ResumeLayout(false);
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
    }
}