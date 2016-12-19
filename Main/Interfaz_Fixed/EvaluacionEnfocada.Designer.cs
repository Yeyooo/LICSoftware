using Datos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    partial class EvaluacionEnfocada
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayout_EvaluacionCustom = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta10 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.layout_Alternativas10 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta9 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.layout_Alternativas9 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta8 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.layout_Alternativas8 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta7 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.layout_Alternativas7 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.layout_Alternativas6 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.layout_Alternativas5 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.layout_Alternativas4 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.layout_Alternativas3 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_Pregunta2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.layout_Alternativas2 = new System.Windows.Forms.TableLayoutPanel();
            this.tiempoRestante_Label = new System.Windows.Forms.Label();
            this.tipoEvaluacion_Label = new System.Windows.Forms.Label();
            this.Cancelar_Evaluacion = new System.Windows.Forms.Button();
            this.EntregarEvaluacion_Button = new System.Windows.Forms.Button();
            this.layout_Pregunta1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Enunciado1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.layout_Alternativas1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer_TestEnfocada = new System.Windows.Forms.Timer(this.components);
            this.tableLayout_EvaluacionCustom.SuspendLayout();
            this.layout_Pregunta10.SuspendLayout();
            this.layout_Pregunta9.SuspendLayout();
            this.layout_Pregunta8.SuspendLayout();
            this.layout_Pregunta7.SuspendLayout();
            this.layout_Pregunta6.SuspendLayout();
            this.layout_Pregunta5.SuspendLayout();
            this.layout_Pregunta4.SuspendLayout();
            this.layout_Pregunta3.SuspendLayout();
            this.layout_Pregunta2.SuspendLayout();
            this.layout_Pregunta1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_EvaluacionCustom
            // 
            this.tableLayout_EvaluacionCustom.AutoScroll = true;
            this.tableLayout_EvaluacionCustom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayout_EvaluacionCustom.ColumnCount = 2;
            this.tableLayout_EvaluacionCustom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_EvaluacionCustom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta10, 1, 5);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta9, 0, 5);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta8, 1, 4);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta7, 0, 4);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta6, 1, 3);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta5, 0, 3);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta4, 1, 2);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta3, 0, 2);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta2, 1, 1);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.tiempoRestante_Label, 1, 0);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.tipoEvaluacion_Label, 0, 0);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.Cancelar_Evaluacion, 0, 6);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.EntregarEvaluacion_Button, 1, 6);
            this.tableLayout_EvaluacionCustom.Controls.Add(this.layout_Pregunta1, 0, 1);
            this.tableLayout_EvaluacionCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_EvaluacionCustom.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_EvaluacionCustom.Name = "tableLayout_EvaluacionCustom";
            this.tableLayout_EvaluacionCustom.RowCount = 7;
            this.tableLayout_EvaluacionCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayout_EvaluacionCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout_EvaluacionCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout_EvaluacionCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout_EvaluacionCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout_EvaluacionCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout_EvaluacionCustom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayout_EvaluacionCustom.Size = new System.Drawing.Size(883, 606);
            this.tableLayout_EvaluacionCustom.TabIndex = 0;
            // 
            // layout_Pregunta10
            // 
            this.layout_Pregunta10.ColumnCount = 1;
            this.layout_Pregunta10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Pregunta10.Controls.Add(this.label11, 0, 0);
            this.layout_Pregunta10.Controls.Add(this.button12, 0, 2);
            this.layout_Pregunta10.Controls.Add(this.layout_Alternativas10, 0, 1);
            this.layout_Pregunta10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta10.Location = new System.Drawing.Point(439, 1278);
            this.layout_Pregunta10.Name = "layout_Pregunta10";
            this.layout_Pregunta10.RowCount = 3;
            this.layout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.43103F));
            this.layout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.56896F));
            this.layout_Pregunta10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.layout_Pregunta10.Size = new System.Drawing.Size(427, 294);
            this.layout_Pregunta10.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(421, 59);
            this.label11.TabIndex = 0;
            this.label11.Text = "Enunciado";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(3, 235);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(421, 56);
            this.button12.TabIndex = 1;
            this.button12.Text = "Material";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas10
            // 
            this.layout_Alternativas10.ColumnCount = 1;
            this.layout_Alternativas10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas10.Location = new System.Drawing.Point(3, 62);
            this.layout_Alternativas10.Name = "layout_Alternativas10";
            this.layout_Alternativas10.RowCount = 4;
            this.layout_Alternativas10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas10.Size = new System.Drawing.Size(421, 167);
            this.layout_Alternativas10.TabIndex = 2;
            // 
            // layout_Pregunta9
            // 
            this.layout_Pregunta9.ColumnCount = 1;
            this.layout_Pregunta9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta9.Controls.Add(this.label10, 0, 0);
            this.layout_Pregunta9.Controls.Add(this.button11, 0, 2);
            this.layout_Pregunta9.Controls.Add(this.layout_Alternativas9, 0, 1);
            this.layout_Pregunta9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta9.Location = new System.Drawing.Point(5, 1278);
            this.layout_Pregunta9.Name = "layout_Pregunta9";
            this.layout_Pregunta9.RowCount = 3;
            this.layout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta9.Size = new System.Drawing.Size(426, 294);
            this.layout_Pregunta9.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(420, 60);
            this.label10.TabIndex = 0;
            this.label10.Text = "Enunciado";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(3, 237);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(420, 54);
            this.button11.TabIndex = 1;
            this.button11.Text = "Material";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas9
            // 
            this.layout_Alternativas9.ColumnCount = 1;
            this.layout_Alternativas9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas9.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas9.Name = "layout_Alternativas9";
            this.layout_Alternativas9.RowCount = 4;
            this.layout_Alternativas9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas9.Size = new System.Drawing.Size(420, 168);
            this.layout_Alternativas9.TabIndex = 2;
            // 
            // layout_Pregunta8
            // 
            this.layout_Pregunta8.ColumnCount = 1;
            this.layout_Pregunta8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_Pregunta8.Controls.Add(this.label9, 0, 0);
            this.layout_Pregunta8.Controls.Add(this.button10, 0, 2);
            this.layout_Pregunta8.Controls.Add(this.layout_Alternativas8, 0, 1);
            this.layout_Pregunta8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta8.Location = new System.Drawing.Point(439, 976);
            this.layout_Pregunta8.Name = "layout_Pregunta8";
            this.layout_Pregunta8.RowCount = 3;
            this.layout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.56637F));
            this.layout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.43363F));
            this.layout_Pregunta8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.layout_Pregunta8.Size = new System.Drawing.Size(427, 294);
            this.layout_Pregunta8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 52);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enunciado";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(3, 234);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(421, 57);
            this.button10.TabIndex = 1;
            this.button10.Text = "Material";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas8
            // 
            this.layout_Alternativas8.ColumnCount = 1;
            this.layout_Alternativas8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas8.Location = new System.Drawing.Point(3, 55);
            this.layout_Alternativas8.Name = "layout_Alternativas8";
            this.layout_Alternativas8.RowCount = 4;
            this.layout_Alternativas8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas8.Size = new System.Drawing.Size(421, 173);
            this.layout_Alternativas8.TabIndex = 2;
            // 
            // layout_Pregunta7
            // 
            this.layout_Pregunta7.ColumnCount = 1;
            this.layout_Pregunta7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta7.Controls.Add(this.label8, 0, 0);
            this.layout_Pregunta7.Controls.Add(this.button9, 0, 2);
            this.layout_Pregunta7.Controls.Add(this.layout_Alternativas7, 0, 1);
            this.layout_Pregunta7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta7.Location = new System.Drawing.Point(5, 976);
            this.layout_Pregunta7.Name = "layout_Pregunta7";
            this.layout_Pregunta7.RowCount = 3;
            this.layout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta7.Size = new System.Drawing.Size(426, 294);
            this.layout_Pregunta7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(420, 60);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enunciado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(3, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(420, 54);
            this.button9.TabIndex = 1;
            this.button9.Text = "Material";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas7
            // 
            this.layout_Alternativas7.ColumnCount = 1;
            this.layout_Alternativas7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas7.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas7.Name = "layout_Alternativas7";
            this.layout_Alternativas7.RowCount = 4;
            this.layout_Alternativas7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas7.Size = new System.Drawing.Size(420, 168);
            this.layout_Alternativas7.TabIndex = 2;
            // 
            // layout_Pregunta6
            // 
            this.layout_Pregunta6.ColumnCount = 1;
            this.layout_Pregunta6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta6.Controls.Add(this.label7, 0, 0);
            this.layout_Pregunta6.Controls.Add(this.button8, 0, 2);
            this.layout_Pregunta6.Controls.Add(this.layout_Alternativas6, 0, 1);
            this.layout_Pregunta6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta6.Location = new System.Drawing.Point(439, 674);
            this.layout_Pregunta6.Name = "layout_Pregunta6";
            this.layout_Pregunta6.RowCount = 3;
            this.layout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta6.Size = new System.Drawing.Size(427, 294);
            this.layout_Pregunta6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(421, 60);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enunciado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(3, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(421, 54);
            this.button8.TabIndex = 1;
            this.button8.Text = "Material";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas6
            // 
            this.layout_Alternativas6.ColumnCount = 1;
            this.layout_Alternativas6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas6.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas6.Name = "layout_Alternativas6";
            this.layout_Alternativas6.RowCount = 4;
            this.layout_Alternativas6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas6.Size = new System.Drawing.Size(421, 168);
            this.layout_Alternativas6.TabIndex = 2;
            // 
            // layout_Pregunta5
            // 
            this.layout_Pregunta5.ColumnCount = 1;
            this.layout_Pregunta5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta5.Controls.Add(this.label6, 0, 0);
            this.layout_Pregunta5.Controls.Add(this.button7, 0, 2);
            this.layout_Pregunta5.Controls.Add(this.layout_Alternativas5, 0, 1);
            this.layout_Pregunta5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta5.Location = new System.Drawing.Point(5, 674);
            this.layout_Pregunta5.Name = "layout_Pregunta5";
            this.layout_Pregunta5.RowCount = 3;
            this.layout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta5.Size = new System.Drawing.Size(426, 294);
            this.layout_Pregunta5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(420, 60);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enunciado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(420, 54);
            this.button7.TabIndex = 1;
            this.button7.Text = "Material";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas5
            // 
            this.layout_Alternativas5.ColumnCount = 1;
            this.layout_Alternativas5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas5.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas5.Name = "layout_Alternativas5";
            this.layout_Alternativas5.RowCount = 4;
            this.layout_Alternativas5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas5.Size = new System.Drawing.Size(420, 168);
            this.layout_Alternativas5.TabIndex = 2;
            // 
            // layout_Pregunta4
            // 
            this.layout_Pregunta4.ColumnCount = 1;
            this.layout_Pregunta4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta4.Controls.Add(this.label5, 0, 0);
            this.layout_Pregunta4.Controls.Add(this.button6, 0, 2);
            this.layout_Pregunta4.Controls.Add(this.layout_Alternativas4, 0, 1);
            this.layout_Pregunta4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta4.Location = new System.Drawing.Point(439, 372);
            this.layout_Pregunta4.Name = "layout_Pregunta4";
            this.layout_Pregunta4.RowCount = 3;
            this.layout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta4.Size = new System.Drawing.Size(427, 294);
            this.layout_Pregunta4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 60);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enunciado";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(3, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(421, 54);
            this.button6.TabIndex = 1;
            this.button6.Text = "Material";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas4
            // 
            this.layout_Alternativas4.ColumnCount = 1;
            this.layout_Alternativas4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas4.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas4.Name = "layout_Alternativas4";
            this.layout_Alternativas4.RowCount = 4;
            this.layout_Alternativas4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas4.Size = new System.Drawing.Size(421, 168);
            this.layout_Alternativas4.TabIndex = 2;
            // 
            // layout_Pregunta3
            // 
            this.layout_Pregunta3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.layout_Pregunta3.ColumnCount = 1;
            this.layout_Pregunta3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta3.Controls.Add(this.label4, 0, 0);
            this.layout_Pregunta3.Controls.Add(this.button5, 0, 2);
            this.layout_Pregunta3.Controls.Add(this.layout_Alternativas3, 0, 1);
            this.layout_Pregunta3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta3.Location = new System.Drawing.Point(5, 372);
            this.layout_Pregunta3.Name = "layout_Pregunta3";
            this.layout_Pregunta3.RowCount = 3;
            this.layout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta3.Size = new System.Drawing.Size(426, 294);
            this.layout_Pregunta3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(5, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 60);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enunciado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(5, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(416, 54);
            this.button5.TabIndex = 1;
            this.button5.Text = "Material";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas3
            // 
            this.layout_Alternativas3.ColumnCount = 1;
            this.layout_Alternativas3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas3.Location = new System.Drawing.Point(5, 67);
            this.layout_Alternativas3.Name = "layout_Alternativas3";
            this.layout_Alternativas3.RowCount = 4;
            this.layout_Alternativas3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas3.Size = new System.Drawing.Size(416, 160);
            this.layout_Alternativas3.TabIndex = 2;
            // 
            // layout_Pregunta2
            // 
            this.layout_Pregunta2.ColumnCount = 1;
            this.layout_Pregunta2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta2.Controls.Add(this.label3, 0, 0);
            this.layout_Pregunta2.Controls.Add(this.button4, 0, 2);
            this.layout_Pregunta2.Controls.Add(this.layout_Alternativas2, 0, 1);
            this.layout_Pregunta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta2.Location = new System.Drawing.Point(439, 70);
            this.layout_Pregunta2.Name = "layout_Pregunta2";
            this.layout_Pregunta2.RowCount = 3;
            this.layout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta2.Size = new System.Drawing.Size(427, 294);
            this.layout_Pregunta2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enunciado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(421, 54);
            this.button4.TabIndex = 1;
            this.button4.Text = "Material";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas2
            // 
            this.layout_Alternativas2.ColumnCount = 1;
            this.layout_Alternativas2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas2.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas2.Name = "layout_Alternativas2";
            this.layout_Alternativas2.RowCount = 4;
            this.layout_Alternativas2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas2.Size = new System.Drawing.Size(421, 168);
            this.layout_Alternativas2.TabIndex = 2;
            // 
            // tiempoRestante_Label
            // 
            this.tiempoRestante_Label.AutoSize = true;
            this.tiempoRestante_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tiempoRestante_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tiempoRestante_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoRestante_Label.Location = new System.Drawing.Point(439, 2);
            this.tiempoRestante_Label.Name = "tiempoRestante_Label";
            this.tiempoRestante_Label.Size = new System.Drawing.Size(427, 63);
            this.tiempoRestante_Label.TabIndex = 1;
            this.tiempoRestante_Label.Text = "Tiempo Restante";
            this.tiempoRestante_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoEvaluacion_Label
            // 
            this.tipoEvaluacion_Label.AutoSize = true;
            this.tipoEvaluacion_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoEvaluacion_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoEvaluacion_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoEvaluacion_Label.Location = new System.Drawing.Point(5, 2);
            this.tipoEvaluacion_Label.Name = "tipoEvaluacion_Label";
            this.tipoEvaluacion_Label.Size = new System.Drawing.Size(426, 63);
            this.tipoEvaluacion_Label.TabIndex = 0;
            this.tipoEvaluacion_Label.Text = "Evaluacion de";
            this.tipoEvaluacion_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancelar_Evaluacion
            // 
            this.Cancelar_Evaluacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancelar_Evaluacion.Location = new System.Drawing.Point(5, 1580);
            this.Cancelar_Evaluacion.Name = "Cancelar_Evaluacion";
            this.Cancelar_Evaluacion.Size = new System.Drawing.Size(426, 61);
            this.Cancelar_Evaluacion.TabIndex = 3;
            this.Cancelar_Evaluacion.Text = "Cancelar Evaluacion";
            this.Cancelar_Evaluacion.UseVisualStyleBackColor = true;
            // 
            // EntregarEvaluacion_Button
            // 
            this.EntregarEvaluacion_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntregarEvaluacion_Button.Location = new System.Drawing.Point(439, 1580);
            this.EntregarEvaluacion_Button.Name = "EntregarEvaluacion_Button";
            this.EntregarEvaluacion_Button.Size = new System.Drawing.Size(427, 61);
            this.EntregarEvaluacion_Button.TabIndex = 4;
            this.EntregarEvaluacion_Button.Text = "Entregar Evaluacion";
            this.EntregarEvaluacion_Button.UseVisualStyleBackColor = true;
            this.EntregarEvaluacion_Button.Click += new System.EventHandler(this.Entregar_EvaluacionCustom);
            // 
            // layout_Pregunta1
            // 
            this.layout_Pregunta1.ColumnCount = 1;
            this.layout_Pregunta1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta1.Controls.Add(this.label_Enunciado1, 0, 0);
            this.layout_Pregunta1.Controls.Add(this.button3, 0, 2);
            this.layout_Pregunta1.Controls.Add(this.layout_Alternativas1, 0, 1);
            this.layout_Pregunta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Pregunta1.Location = new System.Drawing.Point(5, 70);
            this.layout_Pregunta1.Name = "layout_Pregunta1";
            this.layout_Pregunta1.RowCount = 3;
            this.layout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Pregunta1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout_Pregunta1.Size = new System.Drawing.Size(426, 294);
            this.layout_Pregunta1.TabIndex = 5;
            // 
            // label_Enunciado1
            // 
            this.label_Enunciado1.AutoSize = true;
            this.label_Enunciado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Enunciado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Enunciado1.Location = new System.Drawing.Point(3, 0);
            this.label_Enunciado1.Name = "label_Enunciado1";
            this.label_Enunciado1.Size = new System.Drawing.Size(420, 60);
            this.label_Enunciado1.TabIndex = 0;
            this.label_Enunciado1.Text = "Enunciado";
            this.label_Enunciado1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(420, 54);
            this.button3.TabIndex = 1;
            this.button3.Text = "Material";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // layout_Alternativas1
            // 
            this.layout_Alternativas1.ColumnCount = 1;
            this.layout_Alternativas1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_Alternativas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_Alternativas1.Location = new System.Drawing.Point(3, 63);
            this.layout_Alternativas1.Name = "layout_Alternativas1";
            this.layout_Alternativas1.RowCount = 4;
            this.layout_Alternativas1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout_Alternativas1.Size = new System.Drawing.Size(420, 168);
            this.layout_Alternativas1.TabIndex = 2;
            // 
            // timer_TestEnfocada
            // 
            this.timer_TestEnfocada.Enabled = true;
            this.timer_TestEnfocada.Interval = 1000;
            this.timer_TestEnfocada.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EvaluacionEnfocada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(883, 606);
            this.Controls.Add(this.tableLayout_EvaluacionCustom);
            this.Name = "EvaluacionEnfocada";
            this.Text = "EvaluacionEnfocada";
            this.tableLayout_EvaluacionCustom.ResumeLayout(false);
            this.tableLayout_EvaluacionCustom.PerformLayout();
            this.layout_Pregunta10.ResumeLayout(false);
            this.layout_Pregunta10.PerformLayout();
            this.layout_Pregunta9.ResumeLayout(false);
            this.layout_Pregunta9.PerformLayout();
            this.layout_Pregunta8.ResumeLayout(false);
            this.layout_Pregunta8.PerformLayout();
            this.layout_Pregunta7.ResumeLayout(false);
            this.layout_Pregunta7.PerformLayout();
            this.layout_Pregunta6.ResumeLayout(false);
            this.layout_Pregunta6.PerformLayout();
            this.layout_Pregunta5.ResumeLayout(false);
            this.layout_Pregunta5.PerformLayout();
            this.layout_Pregunta4.ResumeLayout(false);
            this.layout_Pregunta4.PerformLayout();
            this.layout_Pregunta3.ResumeLayout(false);
            this.layout_Pregunta3.PerformLayout();
            this.layout_Pregunta2.ResumeLayout(false);
            this.layout_Pregunta2.PerformLayout();
            this.layout_Pregunta1.ResumeLayout(false);
            this.layout_Pregunta1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Asignar LOOP

        private void Asignar_Loop(List<Asset> ListaAsset)
        {
            try
            {
                AsignarTexto(layout_Pregunta1, ListaAsset[0], layout_Alternativas1);
                AsignarTexto(layout_Pregunta2, ListaAsset[1], layout_Alternativas2);
                AsignarTexto(layout_Pregunta3, ListaAsset[2], layout_Alternativas3);
                AsignarTexto(layout_Pregunta4, ListaAsset[3], layout_Alternativas4);
                AsignarTexto(layout_Pregunta5, ListaAsset[4], layout_Alternativas5);
                AsignarTexto(layout_Pregunta6, ListaAsset[5], layout_Alternativas6);
                AsignarTexto(layout_Pregunta7, ListaAsset[6], layout_Alternativas7);
                AsignarTexto(layout_Pregunta8, ListaAsset[7], layout_Alternativas8);
                AsignarTexto(layout_Pregunta9, ListaAsset[8], layout_Alternativas9);
                AsignarTexto(layout_Pregunta10, ListaAsset[9], layout_Alternativas10);
                Console.WriteLine("llegue aqui");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Generar la Evaluación", "FATAL ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
       }

        #endregion

        #region Asignar Assets

        private void AsignarTexto(TableLayoutPanel panel, Asset asset, TableLayoutPanel panelAlternativas)
        {

            for (int i = 0; i < panel.RowCount; i++)
            {
                if (i == 0)
                {
                    Label control = panel.GetControlFromPosition(0, i) as Label;
                    control.Text = asset.getEnunciadoPregunta() + " Nivel: "+asset.getNivelHabilidad();
                }
                if (i == 2)
                {
                    //preguntar si tiene material
                    if (asset.getUrlArchivo() != null)
                    {
                        //SI EL ARCHIVO ES UNA IMAGEN
                        if (asset.getUrlArchivo().EndsWith(".jpg"))
                        {
                            Button control = panel.GetControlFromPosition(0, i) as Button;
                            control.Text = "Material de Apoyo";
                            control.Click += (s, e) => Evento_MaterialImagen(s, e, asset);
                        }
                        //SI EL ARCHIVO ES UN AUDIO
                        if (asset.getUrlArchivo().EndsWith(".mp3"))
                        {
                            Button control = panel.GetControlFromPosition(0, i) as Button;
                            control.Text = "Material de Apoyo";
                            control.Click += (s, e) => Evento_MaterialAudio(s, e, asset);
                        }
                        else if(asset.getUrlArchivo().EndsWith("null") || asset.getUrlArchivo().EndsWith("NULL"))
                        {
                            Button control = panel.GetControlFromPosition(0, i) as Button;
                            control.Text = "Material de Apoyo";
                            control.Click += (s, e) => Evento_SinMaterial(s, e);
                        }
                    }
                    else
                    {
                        Button control = panel.GetControlFromPosition(0, i) as Button;
                        control.Text = "Material de Apoyo";
                        control.Click += (s, e) => Evento_SinMaterial(s, e);
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
                        panelAlternativas.Controls.Add(new Slots_Alternativas(alternativa.getTxtAlternativa(), asset, alternativasAux));
                    }
                    //new Alternativas_Slots(asset,panelAlternativas);
                }
            }

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_EvaluacionCustom;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label tiempoRestante_Label;
        private System.Windows.Forms.Label tipoEvaluacion_Label;
        private System.Windows.Forms.Button Cancelar_Evaluacion;
        private System.Windows.Forms.Button EntregarEvaluacion_Button;
        private System.Windows.Forms.TableLayoutPanel layout_Pregunta1;
        private System.Windows.Forms.Label label_Enunciado1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas1;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas2;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas10;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas9;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas8;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas7;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas6;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas5;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas4;
        private System.Windows.Forms.TableLayoutPanel layout_Alternativas3;
        private Timer timer_TestEnfocada;
    }
}