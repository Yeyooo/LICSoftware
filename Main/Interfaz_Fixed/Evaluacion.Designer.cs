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

        #region Windows Form Designer generated code SOLO PARA ENTRENAMIENTO GENERAL 

        // private void InitializeComponent(string tipoEvaluacion, Dictionary<int, Asset> diccionarioWriting, Dictionary<int, Asset> diccionarioListening, Dictionary<int, Asset> diccionarioReading,int i)
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayout_Evaluacion = new System.Windows.Forms.TableLayoutPanel();
            this.EvaluacionDe_Label = new System.Windows.Forms.Label();
            this.Cancelar_boton = new System.Windows.Forms.Button();
            this.Entregar_Boton = new System.Windows.Forms.Button();
            this.tableLayout_Pregunta1 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta1 = new System.Windows.Forms.Label();
            this.Boton_Pregunta1 = new System.Windows.Forms.Button();
            this.tableLayout_Pregunta2 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta2 = new System.Windows.Forms.Label();
            this.Boton_Pregunta2 = new System.Windows.Forms.Button();
            this.tableLayout_Pregunta3 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta3 = new System.Windows.Forms.Label();
            this.tableLayout_Pregunta4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayout_Pregunta5 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta5 = new System.Windows.Forms.Label();
            this.tableLayout_Pregunta6 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta6 = new System.Windows.Forms.Label();
            this.tableLayout_Pregunta7 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta7 = new System.Windows.Forms.Label();
            this.tableLayout_Pregunta8 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta12 = new System.Windows.Forms.Label();
            this.tableLayout_Pregunta9 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta9 = new System.Windows.Forms.Label();
            this.tableLayout_Pregunta10 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta10 = new System.Windows.Forms.Label();
            this.tableLayout_Pregunta11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta19 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta18 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta17 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta20 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta21 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta22 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta23 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta24 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta25 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta26 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta27 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta28 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta29 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta30 = new System.Windows.Forms.TableLayoutPanel();
            this.Tiempo_RestanteLabel = new System.Windows.Forms.Label();
            this.Tiempo_RestanteTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayout_Evaluacion.SuspendLayout();
            this.tableLayout_Pregunta1.SuspendLayout();
            this.tableLayout_Pregunta2.SuspendLayout();
            this.tableLayout_Pregunta3.SuspendLayout();
            this.tableLayout_Pregunta4.SuspendLayout();
            this.tableLayout_Pregunta5.SuspendLayout();
            this.tableLayout_Pregunta6.SuspendLayout();
            this.tableLayout_Pregunta7.SuspendLayout();
            this.tableLayout_Pregunta8.SuspendLayout();
            this.tableLayout_Pregunta9.SuspendLayout();
            this.tableLayout_Pregunta10.SuspendLayout();
            this.tableLayout_Pregunta11.SuspendLayout();
            this.tableLayout_Pregunta12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_Evaluacion
            // 
            this.tableLayout_Evaluacion.AccessibleName = "tablaEvaluacion";
            this.tableLayout_Evaluacion.AutoScroll = true;
            this.tableLayout_Evaluacion.ColumnCount = 2;
            this.tableLayout_Evaluacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayout_Evaluacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tableLayout_Evaluacion.Controls.Add(this.EvaluacionDe_Label, 0, 0);
            this.tableLayout_Evaluacion.Controls.Add(this.Cancelar_boton, 0, 16);
            this.tableLayout_Evaluacion.Controls.Add(this.Entregar_Boton, 1, 16);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta1, 0, 1);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta2, 1, 1);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta3, 0, 2);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta4, 1, 2);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta5, 0, 3);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta6, 1, 3);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta7, 0, 4);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta8, 1, 4);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta9, 0, 5);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta10, 1, 5);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta11, 0, 6);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta12, 1, 6);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta13, 0, 7);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta14, 1, 7);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta19, 0, 9);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta18, 1, 9);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta17, 0, 10);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta20, 1, 10);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta21, 0, 11);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta22, 1, 11);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta23, 0, 12);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta15, 0, 8);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta16, 1, 8);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta24, 1, 12);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta25, 0, 13);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta26, 1, 13);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta27, 0, 14);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta28, 1, 14);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta29, 0, 15);
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_Pregunta30, 1, 15);
            this.tableLayout_Evaluacion.Controls.Add(this.Tiempo_RestanteLabel, 1, 0);
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
            this.tableLayout_Evaluacion.Size = new System.Drawing.Size(759, 658);
            this.tableLayout_Evaluacion.TabIndex = 0;
            // 
            // EvaluacionDe_Label
            // 
            this.EvaluacionDe_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluacionDe_Label.Font = new System.Drawing.Font("Starcraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluacionDe_Label.Location = new System.Drawing.Point(3, 0);
            this.EvaluacionDe_Label.Name = "EvaluacionDe_Label";
            this.EvaluacionDe_Label.Size = new System.Drawing.Size(344, 45);
            this.EvaluacionDe_Label.TabIndex = 0;
            this.EvaluacionDe_Label.Text = "Evaluacion de ";
            this.EvaluacionDe_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancelar_boton
            // 
            this.Cancelar_boton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancelar_boton.Font = new System.Drawing.Font("Starcraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_boton.Location = new System.Drawing.Point(3, 5298);
            this.Cancelar_boton.Name = "Cancelar_boton";
            this.Cancelar_boton.Size = new System.Drawing.Size(344, 74);
            this.Cancelar_boton.TabIndex = 2;
            this.Cancelar_boton.Text = "Cancelar Evaluacion";
            this.Cancelar_boton.UseVisualStyleBackColor = true;
            this.Cancelar_boton.Click += new System.EventHandler(this.Cancelar_boton_Click);
            // 
            // Entregar_Boton
            // 
            this.Entregar_Boton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Entregar_Boton.Font = new System.Drawing.Font("Starcraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entregar_Boton.Location = new System.Drawing.Point(353, 5298);
            this.Entregar_Boton.Name = "Entregar_Boton";
            this.Entregar_Boton.Size = new System.Drawing.Size(403, 74);
            this.Entregar_Boton.TabIndex = 3;
            this.Entregar_Boton.Text = "Entregar";
            this.Entregar_Boton.UseVisualStyleBackColor = true;
            // 
            // tableLayout_Pregunta1
            // 
            this.tableLayout_Pregunta1.AutoScroll = true;
            this.tableLayout_Pregunta1.ColumnCount = 1;
            this.tableLayout_Pregunta1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta1.Controls.Add(this.Enunciado_Pregunta1, 0, 0);
            this.tableLayout_Pregunta1.Controls.Add(this.Boton_Pregunta1, 0, 2);
            this.tableLayout_Pregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta1.Location = new System.Drawing.Point(3, 48);
            this.tableLayout_Pregunta1.Name = "tableLayout_Pregunta1";
            this.tableLayout_Pregunta1.RowCount = 3;
            this.tableLayout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayout_Pregunta1.Size = new System.Drawing.Size(344, 344);
            this.tableLayout_Pregunta1.TabIndex = 4;
            // 
            // Enunciado_Pregunta1
            // 
            this.Enunciado_Pregunta1.AutoSize = true;
            this.Enunciado_Pregunta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta1.Location = new System.Drawing.Point(3, 0);
            this.Enunciado_Pregunta1.Name = "Enunciado_Pregunta1";
            this.Enunciado_Pregunta1.Size = new System.Drawing.Size(338, 58);
            this.Enunciado_Pregunta1.TabIndex = 0;
            this.Enunciado_Pregunta1.Text = "Enunciado";
            this.Enunciado_Pregunta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton_Pregunta1
            // 
            this.Boton_Pregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Boton_Pregunta1.Location = new System.Drawing.Point(3, 288);
            this.Boton_Pregunta1.Name = "Boton_Pregunta1";
            this.Boton_Pregunta1.Size = new System.Drawing.Size(338, 53);
            this.Boton_Pregunta1.TabIndex = 1;
            this.Boton_Pregunta1.Text = "Material";
            this.Boton_Pregunta1.UseVisualStyleBackColor = true;
            // 
            // tableLayout_Pregunta2
            // 
            this.tableLayout_Pregunta2.AutoScroll = true;
            this.tableLayout_Pregunta2.ColumnCount = 1;
            this.tableLayout_Pregunta2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta2.Controls.Add(this.Enunciado_Pregunta2, 0, 0);
            this.tableLayout_Pregunta2.Controls.Add(this.Boton_Pregunta2, 0, 2);
            this.tableLayout_Pregunta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta2.Location = new System.Drawing.Point(352, 47);
            this.tableLayout_Pregunta2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta2.Name = "tableLayout_Pregunta2";
            this.tableLayout_Pregunta2.RowCount = 3;
            this.tableLayout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayout_Pregunta2.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta2.TabIndex = 5;
            // 
            // Enunciado_Pregunta2
            // 
            this.Enunciado_Pregunta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta2.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta2.Name = "Enunciado_Pregunta2";
            this.Enunciado_Pregunta2.Size = new System.Drawing.Size(401, 59);
            this.Enunciado_Pregunta2.TabIndex = 0;
            this.Enunciado_Pregunta2.Text = "Enunciado";
            this.Enunciado_Pregunta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton_Pregunta2
            // 
            this.Boton_Pregunta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Boton_Pregunta2.Location = new System.Drawing.Point(3, 290);
            this.Boton_Pregunta2.Name = "Boton_Pregunta2";
            this.Boton_Pregunta2.Size = new System.Drawing.Size(399, 53);
            this.Boton_Pregunta2.TabIndex = 1;
            this.Boton_Pregunta2.Text = "Material";
            this.Boton_Pregunta2.UseVisualStyleBackColor = true;
            // 
            // tableLayout_Pregunta3
            // 
            this.tableLayout_Pregunta3.AutoScroll = true;
            this.tableLayout_Pregunta3.ColumnCount = 1;
            this.tableLayout_Pregunta3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayout_Pregunta3.Controls.Add(this.Enunciado_Pregunta3, 0, 0);
            this.tableLayout_Pregunta3.Controls.Add(this.button1, 0, 2);
            this.tableLayout_Pregunta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta3.Location = new System.Drawing.Point(2, 397);
            this.tableLayout_Pregunta3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta3.Name = "tableLayout_Pregunta3";
            this.tableLayout_Pregunta3.RowCount = 3;
            this.tableLayout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18497F));
            this.tableLayout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.18497F));
            this.tableLayout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.91908F));
            this.tableLayout_Pregunta3.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta3.TabIndex = 6;
            // 
            // Enunciado_Pregunta3
            // 
            this.Enunciado_Pregunta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta3.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta3.Name = "Enunciado_Pregunta3";
            this.Enunciado_Pregunta3.Size = new System.Drawing.Size(342, 55);
            this.Enunciado_Pregunta3.TabIndex = 0;
            this.Enunciado_Pregunta3.Text = "Enunciado";
            this.Enunciado_Pregunta3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Pregunta4
            // 
            this.tableLayout_Pregunta4.ColumnCount = 1;
            this.tableLayout_Pregunta4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta4.Controls.Add(this.label4, 0, 0);
            this.tableLayout_Pregunta4.Controls.Add(this.button2, 0, 2);
            this.tableLayout_Pregunta4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta4.Location = new System.Drawing.Point(352, 397);
            this.tableLayout_Pregunta4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta4.Name = "tableLayout_Pregunta4";
            this.tableLayout_Pregunta4.RowCount = 3;
            this.tableLayout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.60694F));
            this.tableLayout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.76301F));
            this.tableLayout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63006F));
            this.tableLayout_Pregunta4.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta4.TabIndex = 7;
            this.tableLayout_Pregunta4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enunciado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Pregunta5
            // 
            this.tableLayout_Pregunta5.ColumnCount = 1;
            this.tableLayout_Pregunta5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta5.Controls.Add(this.Enunciado_Pregunta5, 0, 0);
            this.tableLayout_Pregunta5.Controls.Add(this.button3, 0, 2);
            this.tableLayout_Pregunta5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta5.Location = new System.Drawing.Point(2, 747);
            this.tableLayout_Pregunta5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta5.Name = "tableLayout_Pregunta5";
            this.tableLayout_Pregunta5.RowCount = 3;
            this.tableLayout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayout_Pregunta5.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta5.TabIndex = 8;
            // 
            // Enunciado_Pregunta5
            // 
            this.Enunciado_Pregunta5.AutoSize = true;
            this.Enunciado_Pregunta5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta5.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta5.Name = "Enunciado_Pregunta5";
            this.Enunciado_Pregunta5.Size = new System.Drawing.Size(342, 66);
            this.Enunciado_Pregunta5.TabIndex = 0;
            this.Enunciado_Pregunta5.Text = "Enunciado";
            this.Enunciado_Pregunta5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Pregunta6
            // 
            this.tableLayout_Pregunta6.ColumnCount = 1;
            this.tableLayout_Pregunta6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta6.Controls.Add(this.Enunciado_Pregunta6, 0, 0);
            this.tableLayout_Pregunta6.Controls.Add(this.button4, 0, 2);
            this.tableLayout_Pregunta6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta6.Location = new System.Drawing.Point(352, 747);
            this.tableLayout_Pregunta6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta6.Name = "tableLayout_Pregunta6";
            this.tableLayout_Pregunta6.RowCount = 3;
            this.tableLayout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.89562F));
            this.tableLayout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.10438F));
            this.tableLayout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayout_Pregunta6.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta6.TabIndex = 9;
            // 
            // Enunciado_Pregunta6
            // 
            this.Enunciado_Pregunta6.AutoSize = true;
            this.Enunciado_Pregunta6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta6.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta6.Name = "Enunciado_Pregunta6";
            this.Enunciado_Pregunta6.Size = new System.Drawing.Size(401, 68);
            this.Enunciado_Pregunta6.TabIndex = 0;
            this.Enunciado_Pregunta6.Text = "Enunciado";
            this.Enunciado_Pregunta6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Pregunta7
            // 
            this.tableLayout_Pregunta7.ColumnCount = 1;
            this.tableLayout_Pregunta7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta7.Controls.Add(this.Enunciado_Pregunta7, 0, 0);
            this.tableLayout_Pregunta7.Controls.Add(this.button5, 0, 2);
            this.tableLayout_Pregunta7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta7.Location = new System.Drawing.Point(2, 1097);
            this.tableLayout_Pregunta7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta7.Name = "tableLayout_Pregunta7";
            this.tableLayout_Pregunta7.RowCount = 3;
            this.tableLayout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.79191F));
            this.tableLayout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.20809F));
            this.tableLayout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayout_Pregunta7.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta7.TabIndex = 10;
            // 
            // Enunciado_Pregunta7
            // 
            this.Enunciado_Pregunta7.AutoSize = true;
            this.Enunciado_Pregunta7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta7.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta7.Name = "Enunciado_Pregunta7";
            this.Enunciado_Pregunta7.Size = new System.Drawing.Size(342, 89);
            this.Enunciado_Pregunta7.TabIndex = 0;
            this.Enunciado_Pregunta7.Text = "Enunciado";
            this.Enunciado_Pregunta7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Pregunta8
            // 
            this.tableLayout_Pregunta8.AutoScroll = true;
            this.tableLayout_Pregunta8.ColumnCount = 1;
            this.tableLayout_Pregunta8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta8.Controls.Add(this.Enunciado_Pregunta12, 0, 0);
            this.tableLayout_Pregunta8.Controls.Add(this.button6, 0, 2);
            this.tableLayout_Pregunta8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta8.Location = new System.Drawing.Point(352, 1097);
            this.tableLayout_Pregunta8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta8.Name = "tableLayout_Pregunta8";
            this.tableLayout_Pregunta8.RowCount = 3;
            this.tableLayout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.79191F));
            this.tableLayout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.20809F));
            this.tableLayout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayout_Pregunta8.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta8.TabIndex = 11;
            // 
            // Enunciado_Pregunta12
            // 
            this.Enunciado_Pregunta12.AutoSize = true;
            this.Enunciado_Pregunta12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta12.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta12.Name = "Enunciado_Pregunta12";
            this.Enunciado_Pregunta12.Size = new System.Drawing.Size(401, 89);
            this.Enunciado_Pregunta12.TabIndex = 0;
            this.Enunciado_Pregunta12.Text = "Enunciado";
            this.Enunciado_Pregunta12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Pregunta9
            // 
            this.tableLayout_Pregunta9.AutoScroll = true;
            this.tableLayout_Pregunta9.ColumnCount = 1;
            this.tableLayout_Pregunta9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta9.Controls.Add(this.Enunciado_Pregunta9, 0, 0);
            this.tableLayout_Pregunta9.Controls.Add(this.button7, 0, 2);
            this.tableLayout_Pregunta9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta9.Location = new System.Drawing.Point(2, 1447);
            this.tableLayout_Pregunta9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta9.Name = "tableLayout_Pregunta9";
            this.tableLayout_Pregunta9.RowCount = 3;
            this.tableLayout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.78218F));
            this.tableLayout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.21782F));
            this.tableLayout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayout_Pregunta9.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta9.TabIndex = 12;
            // 
            // Enunciado_Pregunta9
            // 
            this.Enunciado_Pregunta9.AutoSize = true;
            this.Enunciado_Pregunta9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta9.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta9.Name = "Enunciado_Pregunta9";
            this.Enunciado_Pregunta9.Size = new System.Drawing.Size(342, 64);
            this.Enunciado_Pregunta9.TabIndex = 0;
            this.Enunciado_Pregunta9.Text = "Enunciado";
            this.Enunciado_Pregunta9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Pregunta10
            // 
            this.tableLayout_Pregunta10.AutoScroll = true;
            this.tableLayout_Pregunta10.ColumnCount = 1;
            this.tableLayout_Pregunta10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta10.Controls.Add(this.Enunciado_Pregunta10, 0, 0);
            this.tableLayout_Pregunta10.Controls.Add(this.button8, 0, 2);
            this.tableLayout_Pregunta10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta10.Location = new System.Drawing.Point(352, 1447);
            this.tableLayout_Pregunta10.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta10.Name = "tableLayout_Pregunta10";
            this.tableLayout_Pregunta10.RowCount = 3;
            this.tableLayout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.27536F));
            this.tableLayout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.72464F));
            this.tableLayout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayout_Pregunta10.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta10.TabIndex = 13;
            // 
            // Enunciado_Pregunta10
            // 
            this.Enunciado_Pregunta10.AutoSize = true;
            this.Enunciado_Pregunta10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta10.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta10.Name = "Enunciado_Pregunta10";
            this.Enunciado_Pregunta10.Size = new System.Drawing.Size(401, 71);
            this.Enunciado_Pregunta10.TabIndex = 0;
            this.Enunciado_Pregunta10.Text = "Enunciado";
            this.Enunciado_Pregunta10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_Pregunta11
            // 
            this.tableLayout_Pregunta11.ColumnCount = 1;
            this.tableLayout_Pregunta11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta11.Controls.Add(this.button9, 0, 2);
            this.tableLayout_Pregunta11.Controls.Add(this.label1, 0, 0);
            this.tableLayout_Pregunta11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta11.Location = new System.Drawing.Point(2, 1797);
            this.tableLayout_Pregunta11.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta11.Name = "tableLayout_Pregunta11";
            this.tableLayout_Pregunta11.RowCount = 3;
            this.tableLayout_Pregunta11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.34104F));
            this.tableLayout_Pregunta11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.71676F));
            this.tableLayout_Pregunta11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.23121F));
            this.tableLayout_Pregunta11.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta11.TabIndex = 14;
            // 
            // tableLayout_Pregunta12
            // 
            this.tableLayout_Pregunta12.ColumnCount = 1;
            this.tableLayout_Pregunta12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta12.Controls.Add(this.button10, 0, 2);
            this.tableLayout_Pregunta12.Controls.Add(this.label2, 0, 0);
            this.tableLayout_Pregunta12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta12.Location = new System.Drawing.Point(352, 1797);
            this.tableLayout_Pregunta12.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta12.Name = "tableLayout_Pregunta12";
            this.tableLayout_Pregunta12.RowCount = 3;
            this.tableLayout_Pregunta12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayout_Pregunta12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.26087F));
            this.tableLayout_Pregunta12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayout_Pregunta12.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta12.TabIndex = 15;
            // 
            // tableLayout_Pregunta13
            // 
            this.tableLayout_Pregunta13.ColumnCount = 1;
            this.tableLayout_Pregunta13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta13.Location = new System.Drawing.Point(2, 2147);
            this.tableLayout_Pregunta13.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta13.Name = "tableLayout_Pregunta13";
            this.tableLayout_Pregunta13.RowCount = 3;
            this.tableLayout_Pregunta13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.9604F));
            this.tableLayout_Pregunta13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.0396F));
            this.tableLayout_Pregunta13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayout_Pregunta13.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta13.TabIndex = 16;
            // 
            // tableLayout_Pregunta14
            // 
            this.tableLayout_Pregunta14.ColumnCount = 1;
            this.tableLayout_Pregunta14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta14.Location = new System.Drawing.Point(352, 2147);
            this.tableLayout_Pregunta14.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta14.Name = "tableLayout_Pregunta14";
            this.tableLayout_Pregunta14.RowCount = 3;
            this.tableLayout_Pregunta14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.45545F));
            this.tableLayout_Pregunta14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.54456F));
            this.tableLayout_Pregunta14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayout_Pregunta14.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta14.TabIndex = 17;
            // 
            // tableLayout_Pregunta19
            // 
            this.tableLayout_Pregunta19.AutoScroll = true;
            this.tableLayout_Pregunta19.ColumnCount = 1;
            this.tableLayout_Pregunta19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta19.Location = new System.Drawing.Point(2, 2847);
            this.tableLayout_Pregunta19.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta19.Name = "tableLayout_Pregunta19";
            this.tableLayout_Pregunta19.RowCount = 3;
            this.tableLayout_Pregunta19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta19.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta19.TabIndex = 18;
            // 
            // tableLayout_Pregunta18
            // 
            this.tableLayout_Pregunta18.ColumnCount = 1;
            this.tableLayout_Pregunta18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta18.Location = new System.Drawing.Point(352, 2847);
            this.tableLayout_Pregunta18.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta18.Name = "tableLayout_Pregunta18";
            this.tableLayout_Pregunta18.RowCount = 3;
            this.tableLayout_Pregunta18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta18.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta18.TabIndex = 19;
            // 
            // tableLayout_Pregunta17
            // 
            this.tableLayout_Pregunta17.ColumnCount = 1;
            this.tableLayout_Pregunta17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta17.Location = new System.Drawing.Point(2, 3197);
            this.tableLayout_Pregunta17.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta17.Name = "tableLayout_Pregunta17";
            this.tableLayout_Pregunta17.RowCount = 3;
            this.tableLayout_Pregunta17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta17.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta17.TabIndex = 20;
            // 
            // tableLayout_Pregunta20
            // 
            this.tableLayout_Pregunta20.ColumnCount = 1;
            this.tableLayout_Pregunta20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta20.Location = new System.Drawing.Point(352, 3197);
            this.tableLayout_Pregunta20.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta20.Name = "tableLayout_Pregunta20";
            this.tableLayout_Pregunta20.RowCount = 3;
            this.tableLayout_Pregunta20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta20.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta20.TabIndex = 21;
            // 
            // tableLayout_Pregunta21
            // 
            this.tableLayout_Pregunta21.ColumnCount = 1;
            this.tableLayout_Pregunta21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta21.Location = new System.Drawing.Point(2, 3547);
            this.tableLayout_Pregunta21.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta21.Name = "tableLayout_Pregunta21";
            this.tableLayout_Pregunta21.RowCount = 3;
            this.tableLayout_Pregunta21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta21.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta21.TabIndex = 22;
            // 
            // tableLayout_Pregunta22
            // 
            this.tableLayout_Pregunta22.ColumnCount = 1;
            this.tableLayout_Pregunta22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta22.Location = new System.Drawing.Point(352, 3547);
            this.tableLayout_Pregunta22.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta22.Name = "tableLayout_Pregunta22";
            this.tableLayout_Pregunta22.RowCount = 3;
            this.tableLayout_Pregunta22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta22.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta22.TabIndex = 23;
            // 
            // tableLayout_Pregunta23
            // 
            this.tableLayout_Pregunta23.ColumnCount = 1;
            this.tableLayout_Pregunta23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta23.Location = new System.Drawing.Point(2, 3897);
            this.tableLayout_Pregunta23.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta23.Name = "tableLayout_Pregunta23";
            this.tableLayout_Pregunta23.RowCount = 3;
            this.tableLayout_Pregunta23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta23.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta23.TabIndex = 24;
            // 
            // tableLayout_Pregunta15
            // 
            this.tableLayout_Pregunta15.ColumnCount = 1;
            this.tableLayout_Pregunta15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta15.Location = new System.Drawing.Point(2, 2497);
            this.tableLayout_Pregunta15.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta15.Name = "tableLayout_Pregunta15";
            this.tableLayout_Pregunta15.RowCount = 3;
            this.tableLayout_Pregunta15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta15.Size = new System.Drawing.Size(346, 346);
            this.tableLayout_Pregunta15.TabIndex = 25;
            // 
            // tableLayout_Pregunta16
            // 
            this.tableLayout_Pregunta16.ColumnCount = 1;
            this.tableLayout_Pregunta16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta16.Location = new System.Drawing.Point(352, 2497);
            this.tableLayout_Pregunta16.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta16.Name = "tableLayout_Pregunta16";
            this.tableLayout_Pregunta16.RowCount = 3;
            this.tableLayout_Pregunta16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayout_Pregunta16.Size = new System.Drawing.Size(405, 346);
            this.tableLayout_Pregunta16.TabIndex = 26;
            // 
            // tableLayout_Pregunta24
            // 
            this.tableLayout_Pregunta24.AutoScroll = true;
            this.tableLayout_Pregunta24.ColumnCount = 1;
            this.tableLayout_Pregunta24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta24.Location = new System.Drawing.Point(353, 3898);
            this.tableLayout_Pregunta24.Name = "tableLayout_Pregunta24";
            this.tableLayout_Pregunta24.RowCount = 3;
            this.tableLayout_Pregunta24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta24.Size = new System.Drawing.Size(403, 344);
            this.tableLayout_Pregunta24.TabIndex = 27;
            // 
            // tableLayout_Pregunta25
            // 
            this.tableLayout_Pregunta25.AutoScroll = true;
            this.tableLayout_Pregunta25.ColumnCount = 1;
            this.tableLayout_Pregunta25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta25.Location = new System.Drawing.Point(3, 4248);
            this.tableLayout_Pregunta25.Name = "tableLayout_Pregunta25";
            this.tableLayout_Pregunta25.RowCount = 3;
            this.tableLayout_Pregunta25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta25.Size = new System.Drawing.Size(344, 344);
            this.tableLayout_Pregunta25.TabIndex = 28;
            // 
            // tableLayout_Pregunta26
            // 
            this.tableLayout_Pregunta26.AutoScroll = true;
            this.tableLayout_Pregunta26.ColumnCount = 1;
            this.tableLayout_Pregunta26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta26.Location = new System.Drawing.Point(353, 4248);
            this.tableLayout_Pregunta26.Name = "tableLayout_Pregunta26";
            this.tableLayout_Pregunta26.RowCount = 3;
            this.tableLayout_Pregunta26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta26.Size = new System.Drawing.Size(403, 344);
            this.tableLayout_Pregunta26.TabIndex = 29;
            // 
            // tableLayout_Pregunta27
            // 
            this.tableLayout_Pregunta27.ColumnCount = 1;
            this.tableLayout_Pregunta27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta27.Location = new System.Drawing.Point(3, 4598);
            this.tableLayout_Pregunta27.Name = "tableLayout_Pregunta27";
            this.tableLayout_Pregunta27.RowCount = 3;
            this.tableLayout_Pregunta27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta27.Size = new System.Drawing.Size(344, 344);
            this.tableLayout_Pregunta27.TabIndex = 30;
            // 
            // tableLayout_Pregunta28
            // 
            this.tableLayout_Pregunta28.AutoScroll = true;
            this.tableLayout_Pregunta28.ColumnCount = 1;
            this.tableLayout_Pregunta28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta28.Location = new System.Drawing.Point(353, 4598);
            this.tableLayout_Pregunta28.Name = "tableLayout_Pregunta28";
            this.tableLayout_Pregunta28.RowCount = 3;
            this.tableLayout_Pregunta28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta28.Size = new System.Drawing.Size(403, 344);
            this.tableLayout_Pregunta28.TabIndex = 31;
            // 
            // tableLayout_Pregunta29
            // 
            this.tableLayout_Pregunta29.AutoScroll = true;
            this.tableLayout_Pregunta29.ColumnCount = 1;
            this.tableLayout_Pregunta29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta29.Location = new System.Drawing.Point(3, 4948);
            this.tableLayout_Pregunta29.Name = "tableLayout_Pregunta29";
            this.tableLayout_Pregunta29.RowCount = 3;
            this.tableLayout_Pregunta29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta29.Size = new System.Drawing.Size(344, 344);
            this.tableLayout_Pregunta29.TabIndex = 32;
            // 
            // tableLayout_Pregunta30
            // 
            this.tableLayout_Pregunta30.AutoScroll = true;
            this.tableLayout_Pregunta30.ColumnCount = 1;
            this.tableLayout_Pregunta30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta30.Location = new System.Drawing.Point(353, 4948);
            this.tableLayout_Pregunta30.Name = "tableLayout_Pregunta30";
            this.tableLayout_Pregunta30.RowCount = 3;
            this.tableLayout_Pregunta30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta30.Size = new System.Drawing.Size(403, 344);
            this.tableLayout_Pregunta30.TabIndex = 33;
            // 
            // Tiempo_RestanteLabel
            // 
            this.Tiempo_RestanteLabel.AutoSize = true;
            this.Tiempo_RestanteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tiempo_RestanteLabel.Font = new System.Drawing.Font("Starcraft", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo_RestanteLabel.Location = new System.Drawing.Point(353, 0);
            this.Tiempo_RestanteLabel.Name = "Tiempo_RestanteLabel";
            this.Tiempo_RestanteLabel.Size = new System.Drawing.Size(403, 45);
            this.Tiempo_RestanteLabel.TabIndex = 34;
            this.Tiempo_RestanteLabel.Text = "-";
            this.Tiempo_RestanteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tiempo_RestanteTimer
            // 
            this.Tiempo_RestanteTimer.Enabled = true;
            this.Tiempo_RestanteTimer.Interval = 1800;
            this.Tiempo_RestanteTimer.Tick += new System.EventHandler(this.tiempoRestante_tick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(399, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(399, 43);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(340, 58);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(3, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(399, 58);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(340, 47);
            this.button7.TabIndex = 1;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(3, 295);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(399, 48);
            this.button8.TabIndex = 1;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(3, 278);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(340, 65);
            this.button9.TabIndex = 0;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(3, 279);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(399, 64);
            this.button10.TabIndex = 0;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(759, 658);
            this.Controls.Add(this.tableLayout_Evaluacion);
            this.Name = "Evaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluacion";
            this.tableLayout_Evaluacion.ResumeLayout(false);
            this.tableLayout_Evaluacion.PerformLayout();
            this.tableLayout_Pregunta1.ResumeLayout(false);
            this.tableLayout_Pregunta1.PerformLayout();
            this.tableLayout_Pregunta2.ResumeLayout(false);
            this.tableLayout_Pregunta3.ResumeLayout(false);
            this.tableLayout_Pregunta4.ResumeLayout(false);
            this.tableLayout_Pregunta4.PerformLayout();
            this.tableLayout_Pregunta5.ResumeLayout(false);
            this.tableLayout_Pregunta5.PerformLayout();
            this.tableLayout_Pregunta6.ResumeLayout(false);
            this.tableLayout_Pregunta6.PerformLayout();
            this.tableLayout_Pregunta7.ResumeLayout(false);
            this.tableLayout_Pregunta7.PerformLayout();
            this.tableLayout_Pregunta8.ResumeLayout(false);
            this.tableLayout_Pregunta8.PerformLayout();
            this.tableLayout_Pregunta9.ResumeLayout(false);
            this.tableLayout_Pregunta9.PerformLayout();
            this.tableLayout_Pregunta10.ResumeLayout(false);
            this.tableLayout_Pregunta10.PerformLayout();
            this.tableLayout_Pregunta11.ResumeLayout(false);
            this.tableLayout_Pregunta11.PerformLayout();
            this.tableLayout_Pregunta12.ResumeLayout(false);
            this.tableLayout_Pregunta12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Aqui se seleccionan los assets de forma aleatoria 1 LISTA ENLAZADA PARA TODOS LOS ASSETS

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

        #region Aqui se seleccionan solo los assets para Writing, 1 Lista enlazada unica para los assets
        public LinkedList<Asset> SeleccionarAsset_Writing(Dictionary<int, Asset> diccionarioWriting)
        {
            LinkedList<Asset> listaAssetSeleccionados = new LinkedList<Asset>();
            #region Lectura de los Assets en Writting
            for (int i = 0; i < 30; i++)
            {
                Random rnd = new Random();
                if (diccionarioWriting.Count == 0)
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
            return listaAssetSeleccionados;
            #endregion
        }

        #endregion

        #region Aqui se seleccionan solo los Assets para Listening, 1 lista enlazada unica para los Assets
        public LinkedList<Asset> SeleccionarAsset_Listening(Dictionary<int,Asset> diccionarioListening)
        {
            LinkedList<Asset> Asset_Listening= new LinkedList<Asset>();
            for (int j = 0; j< 30; j++)
            {
                Random rnd = new Random();
                int numeroClave = rnd.Next(1, diccionarioListening.Count);
                if (diccionarioListening.ContainsKey(numeroClave))
                {
                    Asset_Listening.AddLast(diccionarioListening[numeroClave]);
                }
                else
                {
                    Console.WriteLine("No contiene la clave, esto no deberia pasar D:");
                }
            }
            return Asset_Listening;
        }
        #endregion

        #region Aqui se seleccionan solo los Assets para Reading, 1 lista enlazada unica para los Assets
        public LinkedList<Asset> SeleccionarAsset_Reading(Dictionary<int,Asset> diccionarioReading)
        {
            LinkedList<Asset> Assets_Reading = new LinkedList<Asset>();
            for (int j = 0; j < 30; j++)
            {
                Random rnd = new Random();
                int numeroClave = rnd.Next(1, diccionarioReading.Count);
                if (diccionarioReading.ContainsKey(numeroClave))
                {
                    Assets_Reading.AddLast(diccionarioReading[numeroClave]);
                }
                else
                {
                    Console.WriteLine("No contiene la clave, esto no deberia pasar D:");
                }
            }
            return Assets_Reading;
        }
        #endregion


        #region Aqui se lee las rows de la Pregunta en concreto
        void RecorrerRows_Pregunta(TableLayoutPanel layoutPanel, Asset Assets)
        {
            for (int i = 0;i<3;i++)
            {
                if (i == 0)
                {
                    Control control = layoutPanel.GetControlFromPosition(0, i);
                    control.Text = "Ya se modifico";
                }
                else if (i == 1)
                {
                    //Aqui las alternativas
                    layoutPanel.Controls.Add(new Alternativas_Slots(Assets),0,i);
                }
                else if(i == 2)
                {
                    Control control = layoutPanel.GetControlFromPosition(0, i);
                    control.Text = "Boton Modificado";
                }
            }
        }
        #endregion

        #region Funcion De Prueba

        void AsignarTexto(TableLayoutPanel layoutPanel)
        {
            for (int i = 0; i<layoutPanel.RowCount;i++)
            {
                if (i == 0)
                {
                    Control control = layoutPanel.GetControlFromPosition(0,i) ;
                    control.Text = "Ya se modifico";
                }
                if (i == 1)
                {
                }
                if (i == 2)
                {
                    Control control = layoutPanel.GetControlFromPosition(0,i) ;
                    control.Text = "Boton Modificado";
                }
            }
        }

        #endregion

        private TableLayoutPanel tableLayout_Evaluacion;
        private Label EvaluacionDe_Label;
        private Button Cancelar_boton;
        private Button Entregar_Boton;
        private TableLayoutPanel tableLayout_Pregunta1;
        private Label Enunciado_Pregunta1;
        private TableLayoutPanel tableLayout_Pregunta2;
        private Label Enunciado_Pregunta2;
        private TableLayoutPanel tableLayout_Pregunta3;
        private Label Enunciado_Pregunta3;
        private TableLayoutPanel tableLayout_Pregunta4;
        private Label label4;
        private TableLayoutPanel tableLayout_Pregunta5;
        private Label Enunciado_Pregunta5;
        private TableLayoutPanel tableLayout_Pregunta6;
        private Label Enunciado_Pregunta6;
        private TableLayoutPanel tableLayout_Pregunta7;
        private TableLayoutPanel tableLayout_Pregunta8;
        private Label Enunciado_Pregunta7;
        private Label Enunciado_Pregunta12;
        private TableLayoutPanel tableLayout_Pregunta9;
        private Label Enunciado_Pregunta9;
        private TableLayoutPanel tableLayout_Pregunta10;
        private Label Enunciado_Pregunta10;
        private TableLayoutPanel tableLayout_Pregunta11;
        private TableLayoutPanel tableLayout_Pregunta12;
        private TableLayoutPanel tableLayout_Pregunta13;
        private TableLayoutPanel tableLayout_Pregunta14;
        private TableLayoutPanel tableLayout_Pregunta19;
        private TableLayoutPanel tableLayout_Pregunta18;
        private TableLayoutPanel tableLayout_Pregunta17;
        private TableLayoutPanel tableLayout_Pregunta20;
        private TableLayoutPanel tableLayout_Pregunta21;
        private TableLayoutPanel tableLayout_Pregunta22;
        private TableLayoutPanel tableLayout_Pregunta23;
        private TableLayoutPanel tableLayout_Pregunta15;
        private TableLayoutPanel tableLayout_Pregunta16;
        private TableLayoutPanel tableLayout_Pregunta24;
        private TableLayoutPanel tableLayout_Pregunta25;
        private TableLayoutPanel tableLayout_Pregunta26;
        private TableLayoutPanel tableLayout_Pregunta27;
        private TableLayoutPanel tableLayout_Pregunta28;
        private TableLayoutPanel tableLayout_Pregunta29;
        private TableLayoutPanel tableLayout_Pregunta30;
        private Button Boton_Pregunta1;
        private Timer Tiempo_RestanteTimer;
        private Label Tiempo_RestanteLabel;
        private Button Boton_Pregunta2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Button button10;
        private Label label2;
    }
}