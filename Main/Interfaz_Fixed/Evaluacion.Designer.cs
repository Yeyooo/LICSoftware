using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    partial class Evaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Evaluacion));
            this.tableLayout_Evaluacion = new TableLayoutPanel();
            this.label1 = new Label();
            this.label2 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.tableLayout_pregunta1 = new TableLayoutPanel();
            this.label3 = new Label();
            this.tableLayout_Evaluacion.SuspendLayout();
            this.tableLayout_pregunta1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_Evaluacion
            // 
            this.tableLayout_Evaluacion.AccessibleName = "tablaEvaluacion";
            this.tableLayout_Evaluacion.AutoScroll = true;
            this.tableLayout_Evaluacion.ColumnCount = 2;
            this.tableLayout_Evaluacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tableLayout_Evaluacion.Controls.Add(this.label1, 0, 0);
            this.tableLayout_Evaluacion.Controls.Add(this.label2, 1, 0);
            this.tableLayout_Evaluacion.Controls.Add(this.button1, 0, 16);
            this.tableLayout_Evaluacion.Controls.Add(this.button2, 1, 16);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_pregunta1, 0, 1);
            this.tableLayout_Evaluacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Evaluacion.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_Evaluacion.Name = "tableLayout_Evaluacion";
            this.tableLayout_Evaluacion.RowCount = 17;
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayout_Evaluacion.Size = new System.Drawing.Size(726, 664);
            this.tableLayout_Evaluacion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Starcraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evaluacion de";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Starcraft", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo Restante";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Starcraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 5298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar Evaluacion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Starcraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(353, 5298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(353, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "Entregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayout_pregunta1
            // 
            this.tableLayout_pregunta1.AutoScroll = true;
            this.tableLayout_pregunta1.ColumnCount = 1;
            this.tableLayout_pregunta1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_pregunta1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_pregunta1.Controls.Add(this.label3, 0, 0);
            this.tableLayout_pregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_pregunta1.Location = new System.Drawing.Point(3, 48);
            this.tableLayout_pregunta1.Name = "tableLayout_pregunta1";
            this.tableLayout_pregunta1.RowCount = 3;
            this.tableLayout_pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayout_pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayout_pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayout_pregunta1.Size = new System.Drawing.Size(344, 344);
            this.tableLayout_pregunta1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enunciado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(726, 664);
            this.Controls.Add(this.tableLayout_Evaluacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Evaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluacion";
            this.tableLayout_Evaluacion.ResumeLayout(false);
            this.tableLayout_Evaluacion.PerformLayout();
            this.tableLayout_pregunta1.ResumeLayout(false);
            this.tableLayout_pregunta1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Setear Assets en la Evaluacion
        public void LlenarEvaluacion()
        {
            LinkedList<Asset> listaFinal = SeleccionarAssets(AssetDAL.getDiccionarioWriting(), AssetDAL.getDiccionarioReading(), AssetDAL.getDiccionarioListening());
            LinkedList<Control> Assets = LlenarAssets(listaFinal);
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                   
                }
            }
        }
        #endregion

        #region Aqui se crea el control, nueva layout, labels y radiobuttons

        LinkedList<Control> LlenarAssets(LinkedList<Asset> listAssets)
        {
            LinkedList<Control> control = new LinkedList<Control>();
            for (int i = 0; i < 30; i++)
            {
                TableLayoutPanel panel = new TableLayoutPanel();
                Label Enunciado = new Label();

                //Aqui crear un metodo para llenar otro layout de las alternativas

                panel.AutoScroll = true;
                panel.ColumnCount = 1;
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
                panel.Controls.Add(this.label3, 0, 0);
                panel.Dock = DockStyle.Fill;
                panel.Location = new Point(3, 48);
                panel.Name = "tableLayout_pregunta"+i;
                panel.RowCount = 3;
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 219F));
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
                panel.Size = new Size(344, 344);
            }
            return null;
        }

        #endregion del Control

        #region Aqui se seleccionan los assets de forma aleatoria

        public LinkedList<Asset> SeleccionarAssets(Dictionary<int, Asset> diccionarioWriting, Dictionary<int, Asset> diccionarioListening, Dictionary<int, Asset> diccionarioReading)
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
                int numeroClave = rnd.Next(1, diccionarioWriting.Count);
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
            for (int j = 0; j < 10; j++)
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
        
        #endregion
    

        private TableLayoutPanel tableLayout_Evaluacion;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayout_pregunta1;
        private System.Windows.Forms.Label label3;
    }
}