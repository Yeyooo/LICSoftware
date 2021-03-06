﻿using Datos;
using Microsoft.CSharp.RuntimeBinder;
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

        #region Form de EVALUACION

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
            this.Layout_Alternativas1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta2 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta2 = new System.Windows.Forms.Label();
            this.Boton_Pregunta2 = new System.Windows.Forms.Button();
            this.layout_Alternativas2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta3 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.layout_Alternativas3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.layout_Alternativas4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta5 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.layout_Alternativas5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta6 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.layout_Alternativas6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta7 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.layout_Alternativas7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta8 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.layout_Alternativas8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta9 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.layout_Alternativas9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta10 = new System.Windows.Forms.TableLayoutPanel();
            this.Enunciado_Pregunta10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.layout_Alternativas10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta11 = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.layout_Alternativas11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta12 = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.layout_Alternativas12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta13 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.layout_Alternativas13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta14 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.layout_Alternativas14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta19 = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.layout_Alternativas17 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta18 = new System.Windows.Forms.TableLayoutPanel();
            this.button16 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.layout_Alternativas18 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta17 = new System.Windows.Forms.TableLayoutPanel();
            this.button17 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.layout_Alternativas19 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta20 = new System.Windows.Forms.TableLayoutPanel();
            this.button18 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.layout_Alternativas20 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta21 = new System.Windows.Forms.TableLayoutPanel();
            this.button19 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.layout_Alternativas21 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta22 = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.layout_Alternativas22 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta23 = new System.Windows.Forms.TableLayoutPanel();
            this.button21 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.layout_Alternativas23 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta15 = new System.Windows.Forms.TableLayoutPanel();
            this.button13 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.layout_Alternativas15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta16 = new System.Windows.Forms.TableLayoutPanel();
            this.button14 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.layout_Alternativas16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta24 = new System.Windows.Forms.TableLayoutPanel();
            this.button22 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.layout_Alternativas24 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta25 = new System.Windows.Forms.TableLayoutPanel();
            this.button23 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.layout_Alternativas25 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta26 = new System.Windows.Forms.TableLayoutPanel();
            this.button24 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.layout_Alternativas26 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta27 = new System.Windows.Forms.TableLayoutPanel();
            this.button25 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.layout_Alternativas27 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta28 = new System.Windows.Forms.TableLayoutPanel();
            this.button26 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.layout_Alternativas28 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta29 = new System.Windows.Forms.TableLayoutPanel();
            this.button27 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.layout_Alternativas29 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayout_Pregunta30 = new System.Windows.Forms.TableLayoutPanel();
            this.button28 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.layout_Alternativas30 = new System.Windows.Forms.TableLayoutPanel();
            this.Tiempo_RestanteLabel = new System.Windows.Forms.Label();
            this.Tiempo_RestanteTimer = new System.Windows.Forms.Timer(this.components);
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
            this.tableLayout_Pregunta13.SuspendLayout();
            this.tableLayout_Pregunta14.SuspendLayout();
            this.tableLayout_Pregunta19.SuspendLayout();
            this.tableLayout_Pregunta18.SuspendLayout();
            this.tableLayout_Pregunta17.SuspendLayout();
            this.tableLayout_Pregunta20.SuspendLayout();
            this.tableLayout_Pregunta21.SuspendLayout();
            this.tableLayout_Pregunta22.SuspendLayout();
            this.tableLayout_Pregunta23.SuspendLayout();
            this.tableLayout_Pregunta15.SuspendLayout();
            this.tableLayout_Pregunta16.SuspendLayout();
            this.tableLayout_Pregunta24.SuspendLayout();
            this.tableLayout_Pregunta25.SuspendLayout();
            this.tableLayout_Pregunta26.SuspendLayout();
            this.tableLayout_Pregunta27.SuspendLayout();
            this.tableLayout_Pregunta28.SuspendLayout();
            this.tableLayout_Pregunta29.SuspendLayout();
            this.tableLayout_Pregunta30.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_Evaluacion
            // 
            this.tableLayout_Evaluacion.AccessibleName = "tablaEvaluacion";
            this.tableLayout_Evaluacion.AutoScroll = true;
            this.tableLayout_Evaluacion.ColumnCount = 2;
            this.tableLayout_Evaluacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Evaluacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayout_Evaluacion.Size = new System.Drawing.Size(937, 691);
            this.tableLayout_Evaluacion.TabIndex = 0;
            // 
            // EvaluacionDe_Label
            // 
            this.EvaluacionDe_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluacionDe_Label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluacionDe_Label.Location = new System.Drawing.Point(3, 0);
            this.EvaluacionDe_Label.Name = "EvaluacionDe_Label";
            this.EvaluacionDe_Label.Size = new System.Drawing.Size(462, 45);
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
            this.Cancelar_boton.Size = new System.Drawing.Size(462, 74);
            this.Cancelar_boton.TabIndex = 2;
            this.Cancelar_boton.Text = "Cancelar Evaluacion";
            this.Cancelar_boton.UseVisualStyleBackColor = true;
            this.Cancelar_boton.Click += new System.EventHandler(this.Cancelar_boton_Click);
            // 
            // Entregar_Boton
            // 
            this.Entregar_Boton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Entregar_Boton.Font = new System.Drawing.Font("Starcraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entregar_Boton.Location = new System.Drawing.Point(471, 5298);
            this.Entregar_Boton.Name = "Entregar_Boton";
            this.Entregar_Boton.Size = new System.Drawing.Size(463, 74);
            this.Entregar_Boton.TabIndex = 3;
            this.Entregar_Boton.Text = "Entregar";
            this.Entregar_Boton.UseVisualStyleBackColor = true;
            this.Entregar_Boton.Click += new System.EventHandler(this.Entregar_Boton_Click);
            // 
            // tableLayout_Pregunta1
            // 
            this.tableLayout_Pregunta1.AutoScroll = true;
            this.tableLayout_Pregunta1.ColumnCount = 1;
            this.tableLayout_Pregunta1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta1.Controls.Add(this.Enunciado_Pregunta1, 0, 0);
            this.tableLayout_Pregunta1.Controls.Add(this.Boton_Pregunta1, 0, 2);
            this.tableLayout_Pregunta1.Controls.Add(this.Layout_Alternativas1, 0, 1);
            this.tableLayout_Pregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta1.Location = new System.Drawing.Point(3, 48);
            this.tableLayout_Pregunta1.Name = "tableLayout_Pregunta1";
            this.tableLayout_Pregunta1.RowCount = 3;
            this.tableLayout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayout_Pregunta1.Size = new System.Drawing.Size(462, 344);
            this.tableLayout_Pregunta1.TabIndex = 4;
            // 
            // Enunciado_Pregunta1
            // 
            this.Enunciado_Pregunta1.AutoSize = true;
            this.Enunciado_Pregunta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta1.Location = new System.Drawing.Point(3, 0);
            this.Enunciado_Pregunta1.Name = "Enunciado_Pregunta1";
            this.Enunciado_Pregunta1.Size = new System.Drawing.Size(456, 58);
            this.Enunciado_Pregunta1.TabIndex = 0;
            this.Enunciado_Pregunta1.Text = "Enunciado";
            this.Enunciado_Pregunta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton_Pregunta1
            // 
            this.Boton_Pregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Boton_Pregunta1.Location = new System.Drawing.Point(3, 288);
            this.Boton_Pregunta1.Name = "Boton_Pregunta1";
            this.Boton_Pregunta1.Size = new System.Drawing.Size(456, 53);
            this.Boton_Pregunta1.TabIndex = 1;
            this.Boton_Pregunta1.Text = "Material";
            this.Boton_Pregunta1.UseVisualStyleBackColor = true;
            // 
            // Layout_Alternativas1
            // 
            this.Layout_Alternativas1.ColumnCount = 1;
            this.Layout_Alternativas1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Alternativas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Alternativas1.Location = new System.Drawing.Point(3, 61);
            this.Layout_Alternativas1.Name = "Layout_Alternativas1";
            this.Layout_Alternativas1.RowCount = 4;
            this.Layout_Alternativas1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Alternativas1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Alternativas1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Alternativas1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_Alternativas1.Size = new System.Drawing.Size(456, 221);
            this.Layout_Alternativas1.TabIndex = 2;
            // 
            // tableLayout_Pregunta2
            // 
            this.tableLayout_Pregunta2.AutoScroll = true;
            this.tableLayout_Pregunta2.ColumnCount = 1;
            this.tableLayout_Pregunta2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta2.Controls.Add(this.Enunciado_Pregunta2, 0, 0);
            this.tableLayout_Pregunta2.Controls.Add(this.Boton_Pregunta2, 0, 2);
            this.tableLayout_Pregunta2.Controls.Add(this.layout_Alternativas2, 0, 1);
            this.tableLayout_Pregunta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta2.Location = new System.Drawing.Point(470, 47);
            this.tableLayout_Pregunta2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta2.Name = "tableLayout_Pregunta2";
            this.tableLayout_Pregunta2.RowCount = 3;
            this.tableLayout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayout_Pregunta2.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta2.TabIndex = 5;
            // 
            // Enunciado_Pregunta2
            // 
            this.Enunciado_Pregunta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta2.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta2.Name = "Enunciado_Pregunta2";
            this.Enunciado_Pregunta2.Size = new System.Drawing.Size(461, 59);
            this.Enunciado_Pregunta2.TabIndex = 0;
            this.Enunciado_Pregunta2.Text = "Enunciado";
            this.Enunciado_Pregunta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton_Pregunta2
            // 
            this.Boton_Pregunta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Boton_Pregunta2.Location = new System.Drawing.Point(3, 290);
            this.Boton_Pregunta2.Name = "Boton_Pregunta2";
            this.Boton_Pregunta2.Size = new System.Drawing.Size(459, 53);
            this.Boton_Pregunta2.TabIndex = 1;
            this.Boton_Pregunta2.Text = "Material";
            this.Boton_Pregunta2.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas2
            // 
            this.layout_Alternativas2.ColumnCount = 1;
            this.layout_Alternativas2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout_Alternativas2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas2.Location = new System.Drawing.Point(2, 61);
            this.layout_Alternativas2.Margin = new System.Windows.Forms.Padding(2);
            this.layout_Alternativas2.Name = "layout_Alternativas2";
            this.layout_Alternativas2.RowCount = 4;
            this.layout_Alternativas2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas2.Size = new System.Drawing.Size(461, 224);
            this.layout_Alternativas2.TabIndex = 2;
            // 
            // tableLayout_Pregunta3
            // 
            this.tableLayout_Pregunta3.AutoScroll = true;
            this.tableLayout_Pregunta3.ColumnCount = 1;
            this.tableLayout_Pregunta3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayout_Pregunta3.Controls.Add(this.Enunciado_Pregunta3, 0, 0);
            this.tableLayout_Pregunta3.Controls.Add(this.button1, 0, 2);
            this.tableLayout_Pregunta3.Controls.Add(this.layout_Alternativas3, 0, 1);
            this.tableLayout_Pregunta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta3.Location = new System.Drawing.Point(2, 397);
            this.tableLayout_Pregunta3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta3.Name = "tableLayout_Pregunta3";
            this.tableLayout_Pregunta3.RowCount = 3;
            this.tableLayout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18497F));
            this.tableLayout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.18497F));
            this.tableLayout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.91908F));
            this.tableLayout_Pregunta3.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta3.TabIndex = 6;
            // 
            // Enunciado_Pregunta3
            // 
            this.Enunciado_Pregunta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta3.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta3.Name = "Enunciado_Pregunta3";
            this.Enunciado_Pregunta3.Size = new System.Drawing.Size(460, 55);
            this.Enunciado_Pregunta3.TabIndex = 0;
            this.Enunciado_Pregunta3.Text = "Enunciado";
            this.Enunciado_Pregunta3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(458, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas3
            // 
            this.layout_Alternativas3.ColumnCount = 1;
            this.layout_Alternativas3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas3.Location = new System.Drawing.Point(2, 57);
            this.layout_Alternativas3.Margin = new System.Windows.Forms.Padding(2);
            this.layout_Alternativas3.Name = "layout_Alternativas3";
            this.layout_Alternativas3.RowCount = 4;
            this.layout_Alternativas3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas3.Size = new System.Drawing.Size(460, 224);
            this.layout_Alternativas3.TabIndex = 2;
            // 
            // tableLayout_Pregunta4
            // 
            this.tableLayout_Pregunta4.ColumnCount = 1;
            this.tableLayout_Pregunta4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta4.Controls.Add(this.label4, 0, 0);
            this.tableLayout_Pregunta4.Controls.Add(this.button2, 0, 2);
            this.tableLayout_Pregunta4.Controls.Add(this.layout_Alternativas4, 0, 1);
            this.tableLayout_Pregunta4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta4.Location = new System.Drawing.Point(470, 397);
            this.tableLayout_Pregunta4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta4.Name = "tableLayout_Pregunta4";
            this.tableLayout_Pregunta4.RowCount = 3;
            this.tableLayout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.60694F));
            this.tableLayout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.76301F));
            this.tableLayout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63006F));
            this.tableLayout_Pregunta4.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enunciado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(459, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas4
            // 
            this.layout_Alternativas4.ColumnCount = 1;
            this.layout_Alternativas4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas4.Location = new System.Drawing.Point(2, 56);
            this.layout_Alternativas4.Margin = new System.Windows.Forms.Padding(2);
            this.layout_Alternativas4.Name = "layout_Alternativas4";
            this.layout_Alternativas4.RowCount = 4;
            this.layout_Alternativas4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas4.Size = new System.Drawing.Size(461, 226);
            this.layout_Alternativas4.TabIndex = 2;
            // 
            // tableLayout_Pregunta5
            // 
            this.tableLayout_Pregunta5.ColumnCount = 1;
            this.tableLayout_Pregunta5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta5.Controls.Add(this.Enunciado_Pregunta5, 0, 0);
            this.tableLayout_Pregunta5.Controls.Add(this.button3, 0, 2);
            this.tableLayout_Pregunta5.Controls.Add(this.layout_Alternativas5, 0, 1);
            this.tableLayout_Pregunta5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta5.Location = new System.Drawing.Point(2, 747);
            this.tableLayout_Pregunta5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta5.Name = "tableLayout_Pregunta5";
            this.tableLayout_Pregunta5.RowCount = 3;
            this.tableLayout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayout_Pregunta5.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta5.TabIndex = 8;
            // 
            // Enunciado_Pregunta5
            // 
            this.Enunciado_Pregunta5.AutoSize = true;
            this.Enunciado_Pregunta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta5.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta5.Name = "Enunciado_Pregunta5";
            this.Enunciado_Pregunta5.Size = new System.Drawing.Size(460, 66);
            this.Enunciado_Pregunta5.TabIndex = 0;
            this.Enunciado_Pregunta5.Text = "Enunciado";
            this.Enunciado_Pregunta5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(458, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas5
            // 
            this.layout_Alternativas5.ColumnCount = 1;
            this.layout_Alternativas5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas5.Location = new System.Drawing.Point(2, 68);
            this.layout_Alternativas5.Margin = new System.Windows.Forms.Padding(2);
            this.layout_Alternativas5.Name = "layout_Alternativas5";
            this.layout_Alternativas5.RowCount = 4;
            this.layout_Alternativas5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas5.Size = new System.Drawing.Size(460, 227);
            this.layout_Alternativas5.TabIndex = 2;
            // 
            // tableLayout_Pregunta6
            // 
            this.tableLayout_Pregunta6.ColumnCount = 1;
            this.tableLayout_Pregunta6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta6.Controls.Add(this.Enunciado_Pregunta6, 0, 0);
            this.tableLayout_Pregunta6.Controls.Add(this.button4, 0, 2);
            this.tableLayout_Pregunta6.Controls.Add(this.layout_Alternativas6, 0, 1);
            this.tableLayout_Pregunta6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta6.Location = new System.Drawing.Point(470, 747);
            this.tableLayout_Pregunta6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta6.Name = "tableLayout_Pregunta6";
            this.tableLayout_Pregunta6.RowCount = 3;
            this.tableLayout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.89562F));
            this.tableLayout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.10438F));
            this.tableLayout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayout_Pregunta6.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta6.TabIndex = 9;
            // 
            // Enunciado_Pregunta6
            // 
            this.Enunciado_Pregunta6.AutoSize = true;
            this.Enunciado_Pregunta6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta6.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta6.Name = "Enunciado_Pregunta6";
            this.Enunciado_Pregunta6.Size = new System.Drawing.Size(461, 68);
            this.Enunciado_Pregunta6.TabIndex = 0;
            this.Enunciado_Pregunta6.Text = "Enunciado";
            this.Enunciado_Pregunta6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(459, 43);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas6
            // 
            this.layout_Alternativas6.ColumnCount = 1;
            this.layout_Alternativas6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas6.Location = new System.Drawing.Point(2, 70);
            this.layout_Alternativas6.Margin = new System.Windows.Forms.Padding(2);
            this.layout_Alternativas6.Name = "layout_Alternativas6";
            this.layout_Alternativas6.RowCount = 4;
            this.layout_Alternativas6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas6.Size = new System.Drawing.Size(461, 225);
            this.layout_Alternativas6.TabIndex = 2;
            // 
            // tableLayout_Pregunta7
            // 
            this.tableLayout_Pregunta7.ColumnCount = 1;
            this.tableLayout_Pregunta7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta7.Controls.Add(this.Enunciado_Pregunta7, 0, 0);
            this.tableLayout_Pregunta7.Controls.Add(this.button5, 0, 2);
            this.tableLayout_Pregunta7.Controls.Add(this.layout_Alternativas7, 0, 1);
            this.tableLayout_Pregunta7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta7.Location = new System.Drawing.Point(2, 1097);
            this.tableLayout_Pregunta7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta7.Name = "tableLayout_Pregunta7";
            this.tableLayout_Pregunta7.RowCount = 3;
            this.tableLayout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.79191F));
            this.tableLayout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.20809F));
            this.tableLayout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayout_Pregunta7.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta7.TabIndex = 10;
            // 
            // Enunciado_Pregunta7
            // 
            this.Enunciado_Pregunta7.AutoSize = true;
            this.Enunciado_Pregunta7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta7.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta7.Name = "Enunciado_Pregunta7";
            this.Enunciado_Pregunta7.Size = new System.Drawing.Size(460, 89);
            this.Enunciado_Pregunta7.TabIndex = 0;
            this.Enunciado_Pregunta7.Text = "Enunciado";
            this.Enunciado_Pregunta7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(458, 58);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas7
            // 
            this.layout_Alternativas7.ColumnCount = 1;
            this.layout_Alternativas7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas7.Location = new System.Drawing.Point(2, 91);
            this.layout_Alternativas7.Margin = new System.Windows.Forms.Padding(2);
            this.layout_Alternativas7.Name = "layout_Alternativas7";
            this.layout_Alternativas7.RowCount = 4;
            this.layout_Alternativas7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas7.Size = new System.Drawing.Size(460, 189);
            this.layout_Alternativas7.TabIndex = 2;
            // 
            // tableLayout_Pregunta8
            // 
            this.tableLayout_Pregunta8.AutoScroll = true;
            this.tableLayout_Pregunta8.ColumnCount = 1;
            this.tableLayout_Pregunta8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta8.Controls.Add(this.Enunciado_Pregunta12, 0, 0);
            this.tableLayout_Pregunta8.Controls.Add(this.button6, 0, 2);
            this.tableLayout_Pregunta8.Controls.Add(this.layout_Alternativas8, 0, 1);
            this.tableLayout_Pregunta8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta8.Location = new System.Drawing.Point(470, 1097);
            this.tableLayout_Pregunta8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta8.Name = "tableLayout_Pregunta8";
            this.tableLayout_Pregunta8.RowCount = 3;
            this.tableLayout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.79191F));
            this.tableLayout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.20809F));
            this.tableLayout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayout_Pregunta8.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta8.TabIndex = 11;
            // 
            // Enunciado_Pregunta12
            // 
            this.Enunciado_Pregunta12.AutoSize = true;
            this.Enunciado_Pregunta12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta12.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta12.Name = "Enunciado_Pregunta12";
            this.Enunciado_Pregunta12.Size = new System.Drawing.Size(461, 89);
            this.Enunciado_Pregunta12.TabIndex = 0;
            this.Enunciado_Pregunta12.Text = "Enunciado";
            this.Enunciado_Pregunta12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(3, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(459, 58);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas8
            // 
            this.layout_Alternativas8.ColumnCount = 1;
            this.layout_Alternativas8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas8.Location = new System.Drawing.Point(2, 91);
            this.layout_Alternativas8.Margin = new System.Windows.Forms.Padding(2);
            this.layout_Alternativas8.Name = "layout_Alternativas8";
            this.layout_Alternativas8.RowCount = 4;
            this.layout_Alternativas8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas8.Size = new System.Drawing.Size(461, 189);
            this.layout_Alternativas8.TabIndex = 2;
            // 
            // tableLayout_Pregunta9
            // 
            this.tableLayout_Pregunta9.AutoScroll = true;
            this.tableLayout_Pregunta9.ColumnCount = 1;
            this.tableLayout_Pregunta9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta9.Controls.Add(this.Enunciado_Pregunta9, 0, 0);
            this.tableLayout_Pregunta9.Controls.Add(this.button7, 0, 2);
            this.tableLayout_Pregunta9.Controls.Add(this.layout_Alternativas9, 0, 1);
            this.tableLayout_Pregunta9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta9.Location = new System.Drawing.Point(2, 1447);
            this.tableLayout_Pregunta9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta9.Name = "tableLayout_Pregunta9";
            this.tableLayout_Pregunta9.RowCount = 3;
            this.tableLayout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.78218F));
            this.tableLayout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.21782F));
            this.tableLayout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayout_Pregunta9.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta9.TabIndex = 12;
            // 
            // Enunciado_Pregunta9
            // 
            this.Enunciado_Pregunta9.AutoSize = true;
            this.Enunciado_Pregunta9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta9.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta9.Name = "Enunciado_Pregunta9";
            this.Enunciado_Pregunta9.Size = new System.Drawing.Size(460, 64);
            this.Enunciado_Pregunta9.TabIndex = 0;
            this.Enunciado_Pregunta9.Text = "Enunciado";
            this.Enunciado_Pregunta9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(458, 47);
            this.button7.TabIndex = 1;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas9
            // 
            this.layout_Alternativas9.ColumnCount = 1;
            this.layout_Alternativas9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas9.Location = new System.Drawing.Point(3, 67);
            this.layout_Alternativas9.Name = "layout_Alternativas9";
            this.layout_Alternativas9.RowCount = 4;
            this.layout_Alternativas9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas9.Size = new System.Drawing.Size(458, 223);
            this.layout_Alternativas9.TabIndex = 2;
            // 
            // tableLayout_Pregunta10
            // 
            this.tableLayout_Pregunta10.AutoScroll = true;
            this.tableLayout_Pregunta10.ColumnCount = 1;
            this.tableLayout_Pregunta10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta10.Controls.Add(this.Enunciado_Pregunta10, 0, 0);
            this.tableLayout_Pregunta10.Controls.Add(this.button8, 0, 2);
            this.tableLayout_Pregunta10.Controls.Add(this.layout_Alternativas10, 0, 1);
            this.tableLayout_Pregunta10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta10.Location = new System.Drawing.Point(470, 1447);
            this.tableLayout_Pregunta10.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta10.Name = "tableLayout_Pregunta10";
            this.tableLayout_Pregunta10.RowCount = 3;
            this.tableLayout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.32964F));
            this.tableLayout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.67036F));
            this.tableLayout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_Pregunta10.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta10.TabIndex = 13;
            // 
            // Enunciado_Pregunta10
            // 
            this.Enunciado_Pregunta10.AutoSize = true;
            this.Enunciado_Pregunta10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enunciado_Pregunta10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enunciado_Pregunta10.Location = new System.Drawing.Point(2, 0);
            this.Enunciado_Pregunta10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Enunciado_Pregunta10.Name = "Enunciado_Pregunta10";
            this.Enunciado_Pregunta10.Size = new System.Drawing.Size(461, 62);
            this.Enunciado_Pregunta10.TabIndex = 0;
            this.Enunciado_Pregunta10.Text = "Enunciado";
            this.Enunciado_Pregunta10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(3, 295);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(459, 48);
            this.button8.TabIndex = 1;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas10
            // 
            this.layout_Alternativas10.ColumnCount = 1;
            this.layout_Alternativas10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas10.Location = new System.Drawing.Point(3, 65);
            this.layout_Alternativas10.Name = "layout_Alternativas10";
            this.layout_Alternativas10.RowCount = 4;
            this.layout_Alternativas10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas10.Size = new System.Drawing.Size(459, 224);
            this.layout_Alternativas10.TabIndex = 2;
            // 
            // tableLayout_Pregunta11
            // 
            this.tableLayout_Pregunta11.ColumnCount = 1;
            this.tableLayout_Pregunta11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Pregunta11.Controls.Add(this.button9, 0, 2);
            this.tableLayout_Pregunta11.Controls.Add(this.label1, 0, 0);
            this.tableLayout_Pregunta11.Controls.Add(this.layout_Alternativas11, 0, 1);
            this.tableLayout_Pregunta11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta11.Location = new System.Drawing.Point(2, 1797);
            this.tableLayout_Pregunta11.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta11.Name = "tableLayout_Pregunta11";
            this.tableLayout_Pregunta11.RowCount = 3;
            this.tableLayout_Pregunta11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.34104F));
            this.tableLayout_Pregunta11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.71676F));
            this.tableLayout_Pregunta11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.23121F));
            this.tableLayout_Pregunta11.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta11.TabIndex = 14;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(3, 278);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(458, 65);
            this.button9.TabIndex = 0;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas11
            // 
            this.layout_Alternativas11.ColumnCount = 1;
            this.layout_Alternativas11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas11.Location = new System.Drawing.Point(3, 62);
            this.layout_Alternativas11.Name = "layout_Alternativas11";
            this.layout_Alternativas11.RowCount = 4;
            this.layout_Alternativas11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas11.Size = new System.Drawing.Size(458, 210);
            this.layout_Alternativas11.TabIndex = 2;
            // 
            // tableLayout_Pregunta12
            // 
            this.tableLayout_Pregunta12.ColumnCount = 1;
            this.tableLayout_Pregunta12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta12.Controls.Add(this.button10, 0, 2);
            this.tableLayout_Pregunta12.Controls.Add(this.label2, 0, 0);
            this.tableLayout_Pregunta12.Controls.Add(this.layout_Alternativas12, 0, 1);
            this.tableLayout_Pregunta12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta12.Location = new System.Drawing.Point(470, 1797);
            this.tableLayout_Pregunta12.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta12.Name = "tableLayout_Pregunta12";
            this.tableLayout_Pregunta12.RowCount = 3;
            this.tableLayout_Pregunta12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayout_Pregunta12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.26087F));
            this.tableLayout_Pregunta12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayout_Pregunta12.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta12.TabIndex = 15;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(3, 279);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(459, 64);
            this.button10.TabIndex = 0;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas12
            // 
            this.layout_Alternativas12.ColumnCount = 1;
            this.layout_Alternativas12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas12.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas12.Name = "layout_Alternativas12";
            this.layout_Alternativas12.RowCount = 4;
            this.layout_Alternativas12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas12.Size = new System.Drawing.Size(459, 210);
            this.layout_Alternativas12.TabIndex = 2;
            // 
            // tableLayout_Pregunta13
            // 
            this.tableLayout_Pregunta13.ColumnCount = 1;
            this.tableLayout_Pregunta13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta13.Controls.Add(this.label3, 0, 0);
            this.tableLayout_Pregunta13.Controls.Add(this.button11, 0, 2);
            this.tableLayout_Pregunta13.Controls.Add(this.layout_Alternativas13, 0, 1);
            this.tableLayout_Pregunta13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta13.Location = new System.Drawing.Point(2, 2147);
            this.tableLayout_Pregunta13.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta13.Name = "tableLayout_Pregunta13";
            this.tableLayout_Pregunta13.RowCount = 3;
            this.tableLayout_Pregunta13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.15789F));
            this.tableLayout_Pregunta13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.8421F));
            this.tableLayout_Pregunta13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayout_Pregunta13.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta13.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 66);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(2, 287);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(460, 57);
            this.button11.TabIndex = 1;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas13
            // 
            this.layout_Alternativas13.ColumnCount = 1;
            this.layout_Alternativas13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas13.Location = new System.Drawing.Point(3, 69);
            this.layout_Alternativas13.Name = "layout_Alternativas13";
            this.layout_Alternativas13.RowCount = 4;
            this.layout_Alternativas13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas13.Size = new System.Drawing.Size(458, 213);
            this.layout_Alternativas13.TabIndex = 2;
            // 
            // tableLayout_Pregunta14
            // 
            this.tableLayout_Pregunta14.ColumnCount = 1;
            this.tableLayout_Pregunta14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta14.Controls.Add(this.label5, 0, 0);
            this.tableLayout_Pregunta14.Controls.Add(this.button12, 0, 2);
            this.tableLayout_Pregunta14.Controls.Add(this.layout_Alternativas14, 0, 1);
            this.tableLayout_Pregunta14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta14.Location = new System.Drawing.Point(470, 2147);
            this.tableLayout_Pregunta14.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta14.Name = "tableLayout_Pregunta14";
            this.tableLayout_Pregunta14.RowCount = 3;
            this.tableLayout_Pregunta14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.15789F));
            this.tableLayout_Pregunta14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.8421F));
            this.tableLayout_Pregunta14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayout_Pregunta14.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta14.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(461, 66);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(2, 287);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(461, 57);
            this.button12.TabIndex = 1;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas14
            // 
            this.layout_Alternativas14.ColumnCount = 1;
            this.layout_Alternativas14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas14.Location = new System.Drawing.Point(3, 69);
            this.layout_Alternativas14.Name = "layout_Alternativas14";
            this.layout_Alternativas14.RowCount = 4;
            this.layout_Alternativas14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas14.Size = new System.Drawing.Size(459, 213);
            this.layout_Alternativas14.TabIndex = 2;
            // 
            // tableLayout_Pregunta19
            // 
            this.tableLayout_Pregunta19.AutoScroll = true;
            this.tableLayout_Pregunta19.ColumnCount = 1;
            this.tableLayout_Pregunta19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta19.Controls.Add(this.button15, 0, 2);
            this.tableLayout_Pregunta19.Controls.Add(this.label8, 0, 0);
            this.tableLayout_Pregunta19.Controls.Add(this.layout_Alternativas17, 0, 1);
            this.tableLayout_Pregunta19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta19.Location = new System.Drawing.Point(2, 2847);
            this.tableLayout_Pregunta19.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta19.Name = "tableLayout_Pregunta19";
            this.tableLayout_Pregunta19.RowCount = 3;
            this.tableLayout_Pregunta19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.38424F));
            this.tableLayout_Pregunta19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.61576F));
            this.tableLayout_Pregunta19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayout_Pregunta19.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta19.TabIndex = 18;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(2, 277);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(460, 67);
            this.button15.TabIndex = 0;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(2, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(460, 67);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas17
            // 
            this.layout_Alternativas17.ColumnCount = 1;
            this.layout_Alternativas17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas17.Location = new System.Drawing.Point(3, 70);
            this.layout_Alternativas17.Name = "layout_Alternativas17";
            this.layout_Alternativas17.RowCount = 4;
            this.layout_Alternativas17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas17.Size = new System.Drawing.Size(458, 202);
            this.layout_Alternativas17.TabIndex = 2;
            // 
            // tableLayout_Pregunta18
            // 
            this.tableLayout_Pregunta18.ColumnCount = 1;
            this.tableLayout_Pregunta18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta18.Controls.Add(this.button16, 0, 2);
            this.tableLayout_Pregunta18.Controls.Add(this.label9, 0, 0);
            this.tableLayout_Pregunta18.Controls.Add(this.layout_Alternativas18, 0, 1);
            this.tableLayout_Pregunta18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta18.Location = new System.Drawing.Point(470, 2847);
            this.tableLayout_Pregunta18.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta18.Name = "tableLayout_Pregunta18";
            this.tableLayout_Pregunta18.RowCount = 3;
            this.tableLayout_Pregunta18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.63054F));
            this.tableLayout_Pregunta18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.36946F));
            this.tableLayout_Pregunta18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayout_Pregunta18.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta18.TabIndex = 19;
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(2, 277);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(461, 67);
            this.button16.TabIndex = 0;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(2, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(461, 67);
            this.label9.TabIndex = 1;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas18
            // 
            this.layout_Alternativas18.ColumnCount = 1;
            this.layout_Alternativas18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas18.Location = new System.Drawing.Point(3, 70);
            this.layout_Alternativas18.Name = "layout_Alternativas18";
            this.layout_Alternativas18.RowCount = 4;
            this.layout_Alternativas18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas18.Size = new System.Drawing.Size(459, 202);
            this.layout_Alternativas18.TabIndex = 2;
            // 
            // tableLayout_Pregunta17
            // 
            this.tableLayout_Pregunta17.ColumnCount = 1;
            this.tableLayout_Pregunta17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta17.Controls.Add(this.button17, 0, 2);
            this.tableLayout_Pregunta17.Controls.Add(this.label10, 0, 0);
            this.tableLayout_Pregunta17.Controls.Add(this.layout_Alternativas19, 0, 1);
            this.tableLayout_Pregunta17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta17.Location = new System.Drawing.Point(2, 3197);
            this.tableLayout_Pregunta17.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta17.Name = "tableLayout_Pregunta17";
            this.tableLayout_Pregunta17.RowCount = 3;
            this.tableLayout_Pregunta17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.92118F));
            this.tableLayout_Pregunta17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.07882F));
            this.tableLayout_Pregunta17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayout_Pregunta17.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta17.TabIndex = 20;
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Location = new System.Drawing.Point(2, 274);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(460, 70);
            this.button17.TabIndex = 0;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(2, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(460, 59);
            this.label10.TabIndex = 1;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas19
            // 
            this.layout_Alternativas19.ColumnCount = 1;
            this.layout_Alternativas19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas19.Location = new System.Drawing.Point(3, 62);
            this.layout_Alternativas19.Name = "layout_Alternativas19";
            this.layout_Alternativas19.RowCount = 4;
            this.layout_Alternativas19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas19.Size = new System.Drawing.Size(458, 207);
            this.layout_Alternativas19.TabIndex = 2;
            // 
            // tableLayout_Pregunta20
            // 
            this.tableLayout_Pregunta20.ColumnCount = 1;
            this.tableLayout_Pregunta20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta20.Controls.Add(this.button18, 0, 2);
            this.tableLayout_Pregunta20.Controls.Add(this.label11, 0, 0);
            this.tableLayout_Pregunta20.Controls.Add(this.layout_Alternativas20, 0, 1);
            this.tableLayout_Pregunta20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta20.Location = new System.Drawing.Point(470, 3197);
            this.tableLayout_Pregunta20.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta20.Name = "tableLayout_Pregunta20";
            this.tableLayout_Pregunta20.RowCount = 3;
            this.tableLayout_Pregunta20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.92118F));
            this.tableLayout_Pregunta20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.07882F));
            this.tableLayout_Pregunta20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayout_Pregunta20.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta20.TabIndex = 21;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Location = new System.Drawing.Point(2, 275);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(461, 69);
            this.button18.TabIndex = 0;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(2, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(461, 60);
            this.label11.TabIndex = 1;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas20
            // 
            this.layout_Alternativas20.ColumnCount = 1;
            this.layout_Alternativas20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas20.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas20.Name = "layout_Alternativas20";
            this.layout_Alternativas20.RowCount = 4;
            this.layout_Alternativas20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas20.Size = new System.Drawing.Size(459, 207);
            this.layout_Alternativas20.TabIndex = 2;
            // 
            // tableLayout_Pregunta21
            // 
            this.tableLayout_Pregunta21.ColumnCount = 1;
            this.tableLayout_Pregunta21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta21.Controls.Add(this.button19, 0, 2);
            this.tableLayout_Pregunta21.Controls.Add(this.label12, 0, 0);
            this.tableLayout_Pregunta21.Controls.Add(this.layout_Alternativas21, 0, 1);
            this.tableLayout_Pregunta21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta21.Location = new System.Drawing.Point(2, 3547);
            this.tableLayout_Pregunta21.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta21.Name = "tableLayout_Pregunta21";
            this.tableLayout_Pregunta21.RowCount = 3;
            this.tableLayout_Pregunta21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.10837F));
            this.tableLayout_Pregunta21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.89162F));
            this.tableLayout_Pregunta21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayout_Pregunta21.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta21.TabIndex = 22;
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Location = new System.Drawing.Point(2, 281);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(460, 63);
            this.button19.TabIndex = 0;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(2, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(460, 73);
            this.label12.TabIndex = 1;
            this.label12.Text = "label12";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas21
            // 
            this.layout_Alternativas21.ColumnCount = 1;
            this.layout_Alternativas21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas21.Location = new System.Drawing.Point(3, 76);
            this.layout_Alternativas21.Name = "layout_Alternativas21";
            this.layout_Alternativas21.RowCount = 4;
            this.layout_Alternativas21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas21.Size = new System.Drawing.Size(458, 200);
            this.layout_Alternativas21.TabIndex = 2;
            // 
            // tableLayout_Pregunta22
            // 
            this.tableLayout_Pregunta22.ColumnCount = 1;
            this.tableLayout_Pregunta22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta22.Controls.Add(this.button20, 0, 2);
            this.tableLayout_Pregunta22.Controls.Add(this.label13, 0, 0);
            this.tableLayout_Pregunta22.Controls.Add(this.layout_Alternativas22, 0, 1);
            this.tableLayout_Pregunta22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta22.Location = new System.Drawing.Point(470, 3547);
            this.tableLayout_Pregunta22.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta22.Name = "tableLayout_Pregunta22";
            this.tableLayout_Pregunta22.RowCount = 3;
            this.tableLayout_Pregunta22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.35468F));
            this.tableLayout_Pregunta22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.64532F));
            this.tableLayout_Pregunta22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayout_Pregunta22.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta22.TabIndex = 23;
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.Location = new System.Drawing.Point(2, 284);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(461, 60);
            this.button20.TabIndex = 0;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(2, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(461, 74);
            this.label13.TabIndex = 1;
            this.label13.Text = "label13";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas22
            // 
            this.layout_Alternativas22.ColumnCount = 1;
            this.layout_Alternativas22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas22.Location = new System.Drawing.Point(3, 77);
            this.layout_Alternativas22.Name = "layout_Alternativas22";
            this.layout_Alternativas22.RowCount = 4;
            this.layout_Alternativas22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas22.Size = new System.Drawing.Size(459, 202);
            this.layout_Alternativas22.TabIndex = 2;
            // 
            // tableLayout_Pregunta23
            // 
            this.tableLayout_Pregunta23.ColumnCount = 1;
            this.tableLayout_Pregunta23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta23.Controls.Add(this.button21, 0, 2);
            this.tableLayout_Pregunta23.Controls.Add(this.label14, 0, 0);
            this.tableLayout_Pregunta23.Controls.Add(this.layout_Alternativas23, 0, 1);
            this.tableLayout_Pregunta23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta23.Location = new System.Drawing.Point(2, 3897);
            this.tableLayout_Pregunta23.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta23.Name = "tableLayout_Pregunta23";
            this.tableLayout_Pregunta23.RowCount = 3;
            this.tableLayout_Pregunta23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.64532F));
            this.tableLayout_Pregunta23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.35468F));
            this.tableLayout_Pregunta23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayout_Pregunta23.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta23.TabIndex = 24;
            // 
            // button21
            // 
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.Location = new System.Drawing.Point(2, 273);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(460, 71);
            this.button21.TabIndex = 0;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(2, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(460, 64);
            this.label14.TabIndex = 1;
            this.label14.Text = "label14";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas23
            // 
            this.layout_Alternativas23.ColumnCount = 1;
            this.layout_Alternativas23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas23.Location = new System.Drawing.Point(3, 67);
            this.layout_Alternativas23.Name = "layout_Alternativas23";
            this.layout_Alternativas23.RowCount = 4;
            this.layout_Alternativas23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas23.Size = new System.Drawing.Size(458, 201);
            this.layout_Alternativas23.TabIndex = 2;
            // 
            // tableLayout_Pregunta15
            // 
            this.tableLayout_Pregunta15.ColumnCount = 1;
            this.tableLayout_Pregunta15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta15.Controls.Add(this.button13, 0, 2);
            this.tableLayout_Pregunta15.Controls.Add(this.label6, 0, 0);
            this.tableLayout_Pregunta15.Controls.Add(this.layout_Alternativas15, 0, 1);
            this.tableLayout_Pregunta15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta15.Location = new System.Drawing.Point(2, 2497);
            this.tableLayout_Pregunta15.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta15.Name = "tableLayout_Pregunta15";
            this.tableLayout_Pregunta15.RowCount = 3;
            this.tableLayout_Pregunta15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.92118F));
            this.tableLayout_Pregunta15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.07882F));
            this.tableLayout_Pregunta15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayout_Pregunta15.Size = new System.Drawing.Size(464, 346);
            this.tableLayout_Pregunta15.TabIndex = 25;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(2, 278);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(460, 66);
            this.button13.TabIndex = 0;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 60);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas15
            // 
            this.layout_Alternativas15.ColumnCount = 1;
            this.layout_Alternativas15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas15.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas15.Name = "layout_Alternativas15";
            this.layout_Alternativas15.RowCount = 4;
            this.layout_Alternativas15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas15.Size = new System.Drawing.Size(458, 210);
            this.layout_Alternativas15.TabIndex = 2;
            // 
            // tableLayout_Pregunta16
            // 
            this.tableLayout_Pregunta16.ColumnCount = 1;
            this.tableLayout_Pregunta16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta16.Controls.Add(this.button14, 0, 2);
            this.tableLayout_Pregunta16.Controls.Add(this.label7, 0, 0);
            this.tableLayout_Pregunta16.Controls.Add(this.layout_Alternativas16, 0, 1);
            this.tableLayout_Pregunta16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta16.Location = new System.Drawing.Point(470, 2497);
            this.tableLayout_Pregunta16.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout_Pregunta16.Name = "tableLayout_Pregunta16";
            this.tableLayout_Pregunta16.RowCount = 3;
            this.tableLayout_Pregunta16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.92118F));
            this.tableLayout_Pregunta16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.07882F));
            this.tableLayout_Pregunta16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayout_Pregunta16.Size = new System.Drawing.Size(465, 346);
            this.tableLayout_Pregunta16.TabIndex = 26;
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Location = new System.Drawing.Point(2, 279);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(461, 65);
            this.button14.TabIndex = 0;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(2, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(461, 60);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas16
            // 
            this.layout_Alternativas16.ColumnCount = 1;
            this.layout_Alternativas16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas16.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas16.Name = "layout_Alternativas16";
            this.layout_Alternativas16.RowCount = 4;
            this.layout_Alternativas16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas16.Size = new System.Drawing.Size(459, 211);
            this.layout_Alternativas16.TabIndex = 2;
            // 
            // tableLayout_Pregunta24
            // 
            this.tableLayout_Pregunta24.AutoScroll = true;
            this.tableLayout_Pregunta24.ColumnCount = 1;
            this.tableLayout_Pregunta24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta24.Controls.Add(this.button22, 0, 2);
            this.tableLayout_Pregunta24.Controls.Add(this.label15, 0, 0);
            this.tableLayout_Pregunta24.Controls.Add(this.layout_Alternativas24, 0, 1);
            this.tableLayout_Pregunta24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta24.Location = new System.Drawing.Point(471, 3898);
            this.tableLayout_Pregunta24.Name = "tableLayout_Pregunta24";
            this.tableLayout_Pregunta24.RowCount = 3;
            this.tableLayout_Pregunta24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.18136F));
            this.tableLayout_Pregunta24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.81864F));
            this.tableLayout_Pregunta24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayout_Pregunta24.Size = new System.Drawing.Size(463, 344);
            this.tableLayout_Pregunta24.TabIndex = 27;
            // 
            // button22
            // 
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.Location = new System.Drawing.Point(2, 273);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(459, 69);
            this.button22.TabIndex = 0;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(2, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(459, 65);
            this.label15.TabIndex = 1;
            this.label15.Text = "label15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas24
            // 
            this.layout_Alternativas24.ColumnCount = 1;
            this.layout_Alternativas24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas24.Location = new System.Drawing.Point(3, 68);
            this.layout_Alternativas24.Name = "layout_Alternativas24";
            this.layout_Alternativas24.RowCount = 4;
            this.layout_Alternativas24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas24.Size = new System.Drawing.Size(457, 200);
            this.layout_Alternativas24.TabIndex = 2;
            // 
            // tableLayout_Pregunta25
            // 
            this.tableLayout_Pregunta25.AutoScroll = true;
            this.tableLayout_Pregunta25.ColumnCount = 1;
            this.tableLayout_Pregunta25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta25.Controls.Add(this.button23, 0, 2);
            this.tableLayout_Pregunta25.Controls.Add(this.label16, 0, 0);
            this.tableLayout_Pregunta25.Controls.Add(this.layout_Alternativas25, 0, 1);
            this.tableLayout_Pregunta25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta25.Location = new System.Drawing.Point(3, 4248);
            this.tableLayout_Pregunta25.Name = "tableLayout_Pregunta25";
            this.tableLayout_Pregunta25.RowCount = 3;
            this.tableLayout_Pregunta25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.19647F));
            this.tableLayout_Pregunta25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.80353F));
            this.tableLayout_Pregunta25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayout_Pregunta25.Size = new System.Drawing.Size(462, 344);
            this.tableLayout_Pregunta25.TabIndex = 28;
            // 
            // button23
            // 
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.Location = new System.Drawing.Point(2, 278);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(458, 64);
            this.button23.TabIndex = 0;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(2, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(458, 72);
            this.label16.TabIndex = 1;
            this.label16.Text = "label16";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas25
            // 
            this.layout_Alternativas25.ColumnCount = 2;
            this.layout_Alternativas25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas25.Location = new System.Drawing.Point(3, 75);
            this.layout_Alternativas25.Name = "layout_Alternativas25";
            this.layout_Alternativas25.RowCount = 2;
            this.layout_Alternativas25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas25.Size = new System.Drawing.Size(200, 100);
            this.layout_Alternativas25.TabIndex = 2;
            // 
            // tableLayout_Pregunta26
            // 
            this.tableLayout_Pregunta26.AutoScroll = true;
            this.tableLayout_Pregunta26.ColumnCount = 1;
            this.tableLayout_Pregunta26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta26.Controls.Add(this.button24, 0, 2);
            this.tableLayout_Pregunta26.Controls.Add(this.label17, 0, 0);
            this.tableLayout_Pregunta26.Controls.Add(this.layout_Alternativas26, 0, 1);
            this.tableLayout_Pregunta26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta26.Location = new System.Drawing.Point(471, 4248);
            this.tableLayout_Pregunta26.Name = "tableLayout_Pregunta26";
            this.tableLayout_Pregunta26.RowCount = 3;
            this.tableLayout_Pregunta26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.19647F));
            this.tableLayout_Pregunta26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.80353F));
            this.tableLayout_Pregunta26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayout_Pregunta26.Size = new System.Drawing.Size(463, 344);
            this.tableLayout_Pregunta26.TabIndex = 29;
            // 
            // button24
            // 
            this.button24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button24.Location = new System.Drawing.Point(2, 279);
            this.button24.Margin = new System.Windows.Forms.Padding(2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(459, 63);
            this.button24.TabIndex = 0;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(2, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(459, 72);
            this.label17.TabIndex = 1;
            this.label17.Text = "label17";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas26
            // 
            this.layout_Alternativas26.ColumnCount = 2;
            this.layout_Alternativas26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas26.Location = new System.Drawing.Point(3, 75);
            this.layout_Alternativas26.Name = "layout_Alternativas26";
            this.layout_Alternativas26.RowCount = 2;
            this.layout_Alternativas26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas26.Size = new System.Drawing.Size(200, 100);
            this.layout_Alternativas26.TabIndex = 2;
            // 
            // tableLayout_Pregunta27
            // 
            this.tableLayout_Pregunta27.ColumnCount = 1;
            this.tableLayout_Pregunta27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta27.Controls.Add(this.button25, 0, 2);
            this.tableLayout_Pregunta27.Controls.Add(this.label18, 0, 0);
            this.tableLayout_Pregunta27.Controls.Add(this.layout_Alternativas27, 0, 1);
            this.tableLayout_Pregunta27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta27.Location = new System.Drawing.Point(3, 4598);
            this.tableLayout_Pregunta27.Name = "tableLayout_Pregunta27";
            this.tableLayout_Pregunta27.RowCount = 3;
            this.tableLayout_Pregunta27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.16625F));
            this.tableLayout_Pregunta27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.83376F));
            this.tableLayout_Pregunta27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayout_Pregunta27.Size = new System.Drawing.Size(462, 344);
            this.tableLayout_Pregunta27.TabIndex = 30;
            // 
            // button25
            // 
            this.button25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button25.Location = new System.Drawing.Point(2, 268);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(458, 74);
            this.button25.TabIndex = 0;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(2, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(458, 59);
            this.label18.TabIndex = 1;
            this.label18.Text = "label18";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas27
            // 
            this.layout_Alternativas27.ColumnCount = 2;
            this.layout_Alternativas27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas27.Location = new System.Drawing.Point(3, 62);
            this.layout_Alternativas27.Name = "layout_Alternativas27";
            this.layout_Alternativas27.RowCount = 2;
            this.layout_Alternativas27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas27.Size = new System.Drawing.Size(200, 100);
            this.layout_Alternativas27.TabIndex = 2;
            // 
            // tableLayout_Pregunta28
            // 
            this.tableLayout_Pregunta28.AutoScroll = true;
            this.tableLayout_Pregunta28.ColumnCount = 1;
            this.tableLayout_Pregunta28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta28.Controls.Add(this.button26, 0, 2);
            this.tableLayout_Pregunta28.Controls.Add(this.label19, 0, 0);
            this.tableLayout_Pregunta28.Controls.Add(this.layout_Alternativas28, 0, 1);
            this.tableLayout_Pregunta28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta28.Location = new System.Drawing.Point(471, 4598);
            this.tableLayout_Pregunta28.Name = "tableLayout_Pregunta28";
            this.tableLayout_Pregunta28.RowCount = 3;
            this.tableLayout_Pregunta28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.9068F));
            this.tableLayout_Pregunta28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.0932F));
            this.tableLayout_Pregunta28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayout_Pregunta28.Size = new System.Drawing.Size(463, 344);
            this.tableLayout_Pregunta28.TabIndex = 31;
            // 
            // button26
            // 
            this.button26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button26.Location = new System.Drawing.Point(2, 273);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(459, 69);
            this.button26.TabIndex = 0;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(2, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(459, 56);
            this.label19.TabIndex = 1;
            this.label19.Text = "label19";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas28
            // 
            this.layout_Alternativas28.ColumnCount = 2;
            this.layout_Alternativas28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas28.Location = new System.Drawing.Point(3, 59);
            this.layout_Alternativas28.Name = "layout_Alternativas28";
            this.layout_Alternativas28.RowCount = 2;
            this.layout_Alternativas28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas28.Size = new System.Drawing.Size(200, 100);
            this.layout_Alternativas28.TabIndex = 2;
            // 
            // tableLayout_Pregunta29
            // 
            this.tableLayout_Pregunta29.AutoScroll = true;
            this.tableLayout_Pregunta29.ColumnCount = 1;
            this.tableLayout_Pregunta29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta29.Controls.Add(this.button27, 0, 2);
            this.tableLayout_Pregunta29.Controls.Add(this.label20, 0, 0);
            this.tableLayout_Pregunta29.Controls.Add(this.layout_Alternativas29, 0, 1);
            this.tableLayout_Pregunta29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta29.Location = new System.Drawing.Point(3, 4948);
            this.tableLayout_Pregunta29.Name = "tableLayout_Pregunta29";
            this.tableLayout_Pregunta29.RowCount = 3;
            this.tableLayout_Pregunta29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.41058F));
            this.tableLayout_Pregunta29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.58942F));
            this.tableLayout_Pregunta29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayout_Pregunta29.Size = new System.Drawing.Size(462, 344);
            this.tableLayout_Pregunta29.TabIndex = 32;
            // 
            // button27
            // 
            this.button27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button27.Location = new System.Drawing.Point(2, 276);
            this.button27.Margin = new System.Windows.Forms.Padding(2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(458, 66);
            this.button27.TabIndex = 0;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(2, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(458, 58);
            this.label20.TabIndex = 1;
            this.label20.Text = "label20";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas29
            // 
            this.layout_Alternativas29.ColumnCount = 2;
            this.layout_Alternativas29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas29.Location = new System.Drawing.Point(3, 61);
            this.layout_Alternativas29.Name = "layout_Alternativas29";
            this.layout_Alternativas29.RowCount = 2;
            this.layout_Alternativas29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas29.Size = new System.Drawing.Size(200, 100);
            this.layout_Alternativas29.TabIndex = 2;
            // 
            // tableLayout_Pregunta30
            // 
            this.tableLayout_Pregunta30.AutoScroll = true;
            this.tableLayout_Pregunta30.ColumnCount = 1;
            this.tableLayout_Pregunta30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Pregunta30.Controls.Add(this.button28, 0, 2);
            this.tableLayout_Pregunta30.Controls.Add(this.label21, 0, 0);
            this.tableLayout_Pregunta30.Controls.Add(this.layout_Alternativas30, 0, 1);
            this.tableLayout_Pregunta30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_Pregunta30.Location = new System.Drawing.Point(471, 4948);
            this.tableLayout_Pregunta30.Name = "tableLayout_Pregunta30";
            this.tableLayout_Pregunta30.RowCount = 3;
            this.tableLayout_Pregunta30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.65491F));
            this.tableLayout_Pregunta30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.34509F));
            this.tableLayout_Pregunta30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayout_Pregunta30.Size = new System.Drawing.Size(463, 344);
            this.tableLayout_Pregunta30.TabIndex = 33;
            // 
            // button28
            // 
            this.button28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button28.Location = new System.Drawing.Point(2, 278);
            this.button28.Margin = new System.Windows.Forms.Padding(2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(459, 64);
            this.button28.TabIndex = 0;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(2, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(459, 57);
            this.label21.TabIndex = 1;
            this.label21.Text = "label21";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layout_Alternativas30
            // 
            this.layout_Alternativas30.ColumnCount = 2;
            this.layout_Alternativas30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas30.Location = new System.Drawing.Point(3, 60);
            this.layout_Alternativas30.Name = "layout_Alternativas30";
            this.layout_Alternativas30.RowCount = 2;
            this.layout_Alternativas30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Alternativas30.Size = new System.Drawing.Size(200, 100);
            this.layout_Alternativas30.TabIndex = 2;
            // 
            // Tiempo_RestanteLabel
            // 
            this.Tiempo_RestanteLabel.AutoSize = true;
            this.Tiempo_RestanteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tiempo_RestanteLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo_RestanteLabel.Location = new System.Drawing.Point(471, 0);
            this.Tiempo_RestanteLabel.Name = "Tiempo_RestanteLabel";
            this.Tiempo_RestanteLabel.Size = new System.Drawing.Size(463, 45);
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
            // Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(937, 691);
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
            this.tableLayout_Pregunta13.ResumeLayout(false);
            this.tableLayout_Pregunta13.PerformLayout();
            this.tableLayout_Pregunta14.ResumeLayout(false);
            this.tableLayout_Pregunta14.PerformLayout();
            this.tableLayout_Pregunta19.ResumeLayout(false);
            this.tableLayout_Pregunta19.PerformLayout();
            this.tableLayout_Pregunta18.ResumeLayout(false);
            this.tableLayout_Pregunta18.PerformLayout();
            this.tableLayout_Pregunta17.ResumeLayout(false);
            this.tableLayout_Pregunta17.PerformLayout();
            this.tableLayout_Pregunta20.ResumeLayout(false);
            this.tableLayout_Pregunta20.PerformLayout();
            this.tableLayout_Pregunta21.ResumeLayout(false);
            this.tableLayout_Pregunta21.PerformLayout();
            this.tableLayout_Pregunta22.ResumeLayout(false);
            this.tableLayout_Pregunta22.PerformLayout();
            this.tableLayout_Pregunta23.ResumeLayout(false);
            this.tableLayout_Pregunta23.PerformLayout();
            this.tableLayout_Pregunta15.ResumeLayout(false);
            this.tableLayout_Pregunta15.PerformLayout();
            this.tableLayout_Pregunta16.ResumeLayout(false);
            this.tableLayout_Pregunta16.PerformLayout();
            this.tableLayout_Pregunta24.ResumeLayout(false);
            this.tableLayout_Pregunta24.PerformLayout();
            this.tableLayout_Pregunta25.ResumeLayout(false);
            this.tableLayout_Pregunta25.PerformLayout();
            this.tableLayout_Pregunta26.ResumeLayout(false);
            this.tableLayout_Pregunta26.PerformLayout();
            this.tableLayout_Pregunta27.ResumeLayout(false);
            this.tableLayout_Pregunta27.PerformLayout();
            this.tableLayout_Pregunta28.ResumeLayout(false);
            this.tableLayout_Pregunta28.PerformLayout();
            this.tableLayout_Pregunta29.ResumeLayout(false);
            this.tableLayout_Pregunta29.PerformLayout();
            this.tableLayout_Pregunta30.ResumeLayout(false);
            this.tableLayout_Pregunta30.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Asignar loop

        public void Asignar_Loop(List<Asset> ListaReading,List<Asset> ListaWriting, List<Asset> ListaListening)
        {
            try
            {
                AsignarTexto(tableLayout_Pregunta1, ListaReading[0], Layout_Alternativas1);
                AsignarTexto(tableLayout_Pregunta2, ListaReading[1], layout_Alternativas2);
                AsignarTexto(tableLayout_Pregunta3, ListaReading[2], layout_Alternativas3);
                AsignarTexto(tableLayout_Pregunta4, ListaReading[3], layout_Alternativas4);
                AsignarTexto(tableLayout_Pregunta5, ListaReading[4], layout_Alternativas5);
                AsignarTexto(tableLayout_Pregunta6, ListaReading[5], layout_Alternativas6);
                AsignarTexto(tableLayout_Pregunta7, ListaReading[6], layout_Alternativas7);
                AsignarTexto(tableLayout_Pregunta8, ListaReading[7], layout_Alternativas8);
                AsignarTexto(tableLayout_Pregunta9, ListaReading[8], layout_Alternativas9);
                AsignarTexto(tableLayout_Pregunta10, ListaReading[9], layout_Alternativas10);
                AsignarTexto(tableLayout_Pregunta11, ListaWriting[0], layout_Alternativas11);
                AsignarTexto(tableLayout_Pregunta12, ListaWriting[1], layout_Alternativas12);
                AsignarTexto(tableLayout_Pregunta13, ListaWriting[2], layout_Alternativas13);
                AsignarTexto(tableLayout_Pregunta14, ListaWriting[3], layout_Alternativas14);
                AsignarTexto(tableLayout_Pregunta15, ListaWriting[4], layout_Alternativas15);
                AsignarTexto(tableLayout_Pregunta16, ListaWriting[5], layout_Alternativas16);
                AsignarTexto(tableLayout_Pregunta17, ListaWriting[6], layout_Alternativas17);
                AsignarTexto(tableLayout_Pregunta18, ListaWriting[7], layout_Alternativas18);
                AsignarTexto(tableLayout_Pregunta19, ListaWriting[8], layout_Alternativas19);
                AsignarTexto(tableLayout_Pregunta20, ListaWriting[9], layout_Alternativas20);
                AsignarTexto(tableLayout_Pregunta21, ListaListening[0], layout_Alternativas21);
                AsignarTexto(tableLayout_Pregunta22, ListaListening[1], layout_Alternativas22);
                AsignarTexto(tableLayout_Pregunta23, ListaListening[2], layout_Alternativas23);
                AsignarTexto(tableLayout_Pregunta24, ListaListening[3], layout_Alternativas24);
                AsignarTexto(tableLayout_Pregunta25, ListaListening[4], layout_Alternativas25);
                AsignarTexto(tableLayout_Pregunta26, ListaListening[5], layout_Alternativas26);
                AsignarTexto(tableLayout_Pregunta27, ListaListening[6], layout_Alternativas27);
                AsignarTexto(tableLayout_Pregunta28, ListaListening[7], layout_Alternativas28);
                AsignarTexto(tableLayout_Pregunta29, ListaListening[8],layout_Alternativas29);
                AsignarTexto(tableLayout_Pregunta30, ListaListening[9], layout_Alternativas30);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la generacion de la Evaluacion", "ERROR FALTA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Asignar Nombre
        private void Asignar_Labels(string nombre)
        {
            EvaluacionDe_Label.Text = "Evaluacion de "+nombre;
        }
        
        #endregion

        #region Funcion De Asignar Assets a la Evaluacion
        void AsignarTexto(TableLayoutPanel layoutPanel, Asset asset,TableLayoutPanel panelAlternativas)
        {
            for (int i = 0; i < layoutPanel.RowCount; i++)
            {
                if (i == 0)
                {
                    Label control = layoutPanel.GetControlFromPosition(0, i) as Label;
                    control.Text = asset.getEnunciadoPregunta();
                }
                if (i == 2)
                {
                    //preguntar si tiene material
                    if (asset.getUrlArchivo() != null) {
                        //SI EL ARCHIVO ES UNA IMAGEN
                        if (asset.getUrlArchivo().EndsWith(".jpg") || asset.getUrlArchivo().EndsWith(".JPG")) {
                            Button control = layoutPanel.GetControlFromPosition(0, i) as Button;
                            control.Text = "Material de Apoyo";
                            control.Click += (s, e) => Evento_MaterialImagen(s, e, asset);
                        }
                        //SI EL ARCHIVO ES UN AUDIO
                        if(asset.getUrlArchivo().EndsWith(".mp3") || asset.getUrlArchivo().EndsWith(".MP3"))
                        {
                            Button control = layoutPanel.GetControlFromPosition(0, i) as Button;
                            control.Text = "Material de Apoyo";
                            control.Click += (s, e) => Evento_MaterialAudio(s, e, asset);
                        }
                        else if (asset.getUrlArchivo().EndsWith("NULL") || asset.getUrlArchivo().EndsWith("null"))
                        {
                            Button control = layoutPanel.GetControlFromPosition(0, i) as Button;
                            control.Text = "Material de Apoyo";
                            control.Click += (s, e) => Evento_SinMaterial(s, e);
                        }
                    }
                    else
                    {
                        Button control = layoutPanel.GetControlFromPosition(0, i) as Button;
                        control.Text = "Material de Apoyo";
                        control.Click += (s, e) => Evento_SinMaterial(s,e);
                    }
                    if (AssetDAL.AssetTieneConjunto(asset.getId()))
                    {
                        Button control = layoutPanel.GetControlFromPosition(0, i) as Button;
                        control.MouseHover += (s, e) => mouseOver_ButtonConjunto(s,e);
                    }
                }
                if (i == 1)
                {
                    //Alternativas
                    //Obtener la lista de Alternativas
                    List<Alternativa> alternativasAux;
                    alternativasAux = asset.getAlternativas();
                    foreach (Alternativa alternativa in alternativasAux)
                    {
                        panelAlternativas.Controls.Add(new Slots_Alternativas(alternativa.getTxtAlternativa(), asset,alternativasAux));
                    }
                    //new Alternativas_Slots(asset,panelAlternativas);
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
        private Label label3;
        private Button button11;
        private Label label5;
        private Button button12;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button13;
        private Button button14;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label6;
        private Label label7;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TableLayoutPanel layout_Alternativas2;
        private TableLayoutPanel layout_Alternativas3;
        private TableLayoutPanel layout_Alternativas4;
        private TableLayoutPanel layout_Alternativas5;
        private TableLayoutPanel layout_Alternativas6;
        private TableLayoutPanel layout_Alternativas7;
        private TableLayoutPanel layout_Alternativas8;
        private TableLayoutPanel Layout_Alternativas1;
        private TableLayoutPanel layout_Alternativas9;
        private TableLayoutPanel layout_Alternativas10;
        private TableLayoutPanel layout_Alternativas11;
        private TableLayoutPanel layout_Alternativas12;
        private TableLayoutPanel layout_Alternativas13;
        private TableLayoutPanel layout_Alternativas14;
        private TableLayoutPanel layout_Alternativas17;
        private TableLayoutPanel layout_Alternativas18;
        private TableLayoutPanel layout_Alternativas19;
        private TableLayoutPanel layout_Alternativas20;
        private TableLayoutPanel layout_Alternativas21;
        private TableLayoutPanel layout_Alternativas22;
        private TableLayoutPanel layout_Alternativas23;
        private TableLayoutPanel layout_Alternativas15;
        private TableLayoutPanel layout_Alternativas16;
        private TableLayoutPanel layout_Alternativas24;
        private TableLayoutPanel layout_Alternativas25;
        private TableLayoutPanel layout_Alternativas26;
        private TableLayoutPanel layout_Alternativas27;
        private TableLayoutPanel layout_Alternativas28;
        private TableLayoutPanel layout_Alternativas29;
        private TableLayoutPanel layout_Alternativas30;
    }
}