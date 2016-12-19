using Datos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    partial class AutoEvaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoEvaluacion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.ListeningGold_label = new System.Windows.Forms.Label();
            this.ListeningGold_chk = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.WritingGold_Label = new System.Windows.Forms.Label();
            this.WritingGold_Chk = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ListeningSilver_label = new System.Windows.Forms.Label();
            this.ListeningSilver_Chk = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.WritingSilver_Chk = new System.Windows.Forms.CheckBox();
            this.reading_Label = new System.Windows.Forms.Label();
            this.Escrita_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Evaluar_AutoButton = new System.Windows.Forms.Button();
            this.Cancelar_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LecturaSilver_Label = new System.Windows.Forms.Label();
            this.ReadingSilver_chk = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LecturaGold_Label = new System.Windows.Forms.Label();
            this.ReadingGold_chk = new System.Windows.Forms.CheckBox();
            this.Help_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.reading_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Escrita_Label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Evaluar_AutoButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Cancelar_Button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Help_Button, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.715655F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.14611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.62808F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1119, 698);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.ListeningGold_label, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.ListeningGold_chk, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(750, 384);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(362, 240);
            this.tableLayoutPanel10.TabIndex = 15;
            // 
            // ListeningGold_label
            // 
            this.ListeningGold_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListeningGold_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeningGold_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ListeningGold_label.Location = new System.Drawing.Point(4, 0);
            this.ListeningGold_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListeningGold_label.Name = "ListeningGold_label";
            this.ListeningGold_label.Size = new System.Drawing.Size(353, 193);
            this.ListeningGold_label.TabIndex = 5;
            this.ListeningGold_label.Text = resources.GetString("ListeningGold_label.Text");
            this.ListeningGold_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListeningGold_chk
            // 
            this.ListeningGold_chk.AutoCheck = false;
            this.ListeningGold_chk.AutoSize = true;
            this.ListeningGold_chk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeningGold_chk.Enabled = false;
            this.ListeningGold_chk.Location = new System.Drawing.Point(4, 197);
            this.ListeningGold_chk.Margin = new System.Windows.Forms.Padding(4);
            this.ListeningGold_chk.Name = "ListeningGold_chk";
            this.ListeningGold_chk.Size = new System.Drawing.Size(354, 39);
            this.ListeningGold_chk.TabIndex = 6;
            this.ListeningGold_chk.Tag = "Listening";
            this.ListeningGold_chk.Text = "Si comprendo";
            this.ListeningGold_chk.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.WritingGold_Label, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.WritingGold_Chk, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(378, 384);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(361, 240);
            this.tableLayoutPanel9.TabIndex = 14;
            // 
            // WritingGold_Label
            // 
            this.WritingGold_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WritingGold_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WritingGold_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WritingGold_Label.Location = new System.Drawing.Point(4, 0);
            this.WritingGold_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WritingGold_Label.Name = "WritingGold_Label";
            this.WritingGold_Label.Size = new System.Drawing.Size(351, 193);
            this.WritingGold_Label.TabIndex = 5;
            this.WritingGold_Label.Text = "Soy capaz de escribir textos sencillos y bien enlazados sobre temas que me son co" +
    "nocidos o de interés personal. Puedo escribir cartas personales que describen ex" +
    "periencias e impresiones.";
            this.WritingGold_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WritingGold_Chk
            // 
            this.WritingGold_Chk.AutoCheck = false;
            this.WritingGold_Chk.AutoSize = true;
            this.WritingGold_Chk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WritingGold_Chk.Enabled = false;
            this.WritingGold_Chk.Location = new System.Drawing.Point(4, 197);
            this.WritingGold_Chk.Margin = new System.Windows.Forms.Padding(4);
            this.WritingGold_Chk.Name = "WritingGold_Chk";
            this.WritingGold_Chk.Size = new System.Drawing.Size(353, 39);
            this.WritingGold_Chk.TabIndex = 6;
            this.WritingGold_Chk.Tag = "Writing";
            this.WritingGold_Chk.Text = "Si soy Capaz";
            this.WritingGold_Chk.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.ListeningSilver_label, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.ListeningSilver_Chk, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(750, 125);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(362, 248);
            this.tableLayoutPanel8.TabIndex = 13;
            // 
            // ListeningSilver_label
            // 
            this.ListeningSilver_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListeningSilver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeningSilver_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ListeningSilver_label.Location = new System.Drawing.Point(4, 0);
            this.ListeningSilver_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListeningSilver_label.Name = "ListeningSilver_label";
            this.ListeningSilver_label.Size = new System.Drawing.Size(353, 201);
            this.ListeningSilver_label.TabIndex = 5;
            this.ListeningSilver_label.Text = resources.GetString("ListeningSilver_label.Text");
            this.ListeningSilver_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListeningSilver_Chk
            // 
            this.ListeningSilver_Chk.AutoCheck = false;
            this.ListeningSilver_Chk.AutoSize = true;
            this.ListeningSilver_Chk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeningSilver_Chk.Location = new System.Drawing.Point(4, 205);
            this.ListeningSilver_Chk.Margin = new System.Windows.Forms.Padding(4);
            this.ListeningSilver_Chk.Name = "ListeningSilver_Chk";
            this.ListeningSilver_Chk.Size = new System.Drawing.Size(354, 39);
            this.ListeningSilver_Chk.TabIndex = 6;
            this.ListeningSilver_Chk.Tag = "Listening";
            this.ListeningSilver_Chk.Text = "Si comprendo";
            this.ListeningSilver_Chk.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.WritingSilver_Chk, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(378, 125);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(361, 248);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 201);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soy capaz de escribir notas y mensajes breves y sencillos relativos a mis necesid" +
    "ades inmediatas. Puedo escribir cartas personales muy sencillas, por ejemplo agr" +
    "adeciendo algo a alguien.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WritingSilver_Chk
            // 
            this.WritingSilver_Chk.AutoCheck = false;
            this.WritingSilver_Chk.AutoSize = true;
            this.WritingSilver_Chk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WritingSilver_Chk.Location = new System.Drawing.Point(4, 205);
            this.WritingSilver_Chk.Margin = new System.Windows.Forms.Padding(4);
            this.WritingSilver_Chk.Name = "WritingSilver_Chk";
            this.WritingSilver_Chk.Size = new System.Drawing.Size(353, 39);
            this.WritingSilver_Chk.TabIndex = 6;
            this.WritingSilver_Chk.Tag = "Writing";
            this.WritingSilver_Chk.Text = "Si soy capaz";
            this.WritingSilver_Chk.UseVisualStyleBackColor = true;
            // 
            // reading_Label
            // 
            this.reading_Label.AutoSize = true;
            this.reading_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reading_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reading_Label.Location = new System.Drawing.Point(7, 3);
            this.reading_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reading_Label.Name = "reading_Label";
            this.reading_Label.Size = new System.Drawing.Size(360, 98);
            this.reading_Label.TabIndex = 0;
            this.reading_Label.Text = "Lectura";
            this.reading_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Escrita_Label
            // 
            this.Escrita_Label.AutoSize = true;
            this.Escrita_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Escrita_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Escrita_Label.Location = new System.Drawing.Point(378, 3);
            this.Escrita_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Escrita_Label.Name = "Escrita_Label";
            this.Escrita_Label.Size = new System.Drawing.Size(361, 98);
            this.Escrita_Label.TabIndex = 1;
            this.Escrita_Label.Text = "Writing";
            this.Escrita_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(750, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 98);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comprensión Auditiva";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Evaluar_AutoButton
            // 
            this.Evaluar_AutoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Evaluar_AutoButton.Location = new System.Drawing.Point(750, 635);
            this.Evaluar_AutoButton.Margin = new System.Windows.Forms.Padding(4);
            this.Evaluar_AutoButton.Name = "Evaluar_AutoButton";
            this.Evaluar_AutoButton.Size = new System.Drawing.Size(362, 56);
            this.Evaluar_AutoButton.TabIndex = 3;
            this.Evaluar_AutoButton.Tag = "Boton";
            this.Evaluar_AutoButton.Text = "Evaluar";
            this.Evaluar_AutoButton.UseVisualStyleBackColor = true;
            // 
            // Cancelar_Button
            // 
            this.Cancelar_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancelar_Button.Location = new System.Drawing.Point(7, 635);
            this.Cancelar_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar_Button.Name = "Cancelar_Button";
            this.Cancelar_Button.Size = new System.Drawing.Size(360, 56);
            this.Cancelar_Button.TabIndex = 4;
            this.Cancelar_Button.Tag = "Boton";
            this.Cancelar_Button.Text = "Cancelar";
            this.Cancelar_Button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LecturaSilver_Label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ReadingSilver_chk, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 125);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.76768F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(360, 248);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // LecturaSilver_Label
            // 
            this.LecturaSilver_Label.AutoSize = true;
            this.LecturaSilver_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LecturaSilver_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturaSilver_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturaSilver_Label.Location = new System.Drawing.Point(4, 0);
            this.LecturaSilver_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LecturaSilver_Label.Name = "LecturaSilver_Label";
            this.LecturaSilver_Label.Size = new System.Drawing.Size(352, 190);
            this.LecturaSilver_Label.TabIndex = 0;
            this.LecturaSilver_Label.Text = resources.GetString("LecturaSilver_Label.Text");
            this.LecturaSilver_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadingSilver_chk
            // 
            this.ReadingSilver_chk.AutoSize = true;
            this.ReadingSilver_chk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadingSilver_chk.Location = new System.Drawing.Point(4, 194);
            this.ReadingSilver_chk.Margin = new System.Windows.Forms.Padding(4);
            this.ReadingSilver_chk.Name = "ReadingSilver_chk";
            this.ReadingSilver_chk.Size = new System.Drawing.Size(352, 50);
            this.ReadingSilver_chk.TabIndex = 1;
            this.ReadingSilver_chk.Tag = "Reading";
            this.ReadingSilver_chk.Text = "Si soy Capaz";
            this.ReadingSilver_chk.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.LecturaGold_Label, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ReadingGold_chk, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 384);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(360, 240);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // LecturaGold_Label
            // 
            this.LecturaGold_Label.AutoSize = true;
            this.LecturaGold_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturaGold_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturaGold_Label.Location = new System.Drawing.Point(4, 0);
            this.LecturaGold_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LecturaGold_Label.Name = "LecturaGold_Label";
            this.LecturaGold_Label.Size = new System.Drawing.Size(352, 194);
            this.LecturaGold_Label.TabIndex = 0;
            this.LecturaGold_Label.Text = "Comprendo textos redactados en una lengua de uso habitual y cotidiano o relaciona" +
    "da con el trabajo. Comprendo la descripción de acontecimientos, sentimientos y d" +
    "eseos en cartas personales.";
            this.LecturaGold_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadingGold_chk
            // 
            this.ReadingGold_chk.AutoSize = true;
            this.ReadingGold_chk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadingGold_chk.Enabled = false;
            this.ReadingGold_chk.Location = new System.Drawing.Point(4, 198);
            this.ReadingGold_chk.Margin = new System.Windows.Forms.Padding(4);
            this.ReadingGold_chk.Name = "ReadingGold_chk";
            this.ReadingGold_chk.Size = new System.Drawing.Size(352, 38);
            this.ReadingGold_chk.TabIndex = 1;
            this.ReadingGold_chk.Tag = "Reading";
            this.ReadingGold_chk.Text = "Si comprendo";
            this.ReadingGold_chk.UseVisualStyleBackColor = true;
            // 
            // Help_Button
            // 
            this.Help_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Help_Button.Location = new System.Drawing.Point(378, 635);
            this.Help_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(361, 56);
            this.Help_Button.TabIndex = 16;
            this.Help_Button.Text = "Ayuda";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // AutoEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1119, 698);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutoEvaluacion";
            this.Text = "AutoEvaluacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cerrando);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Asignamiento de Eventos Dinamicos

        void Eventos(string Correo)
        {
            //
            //Asignamiento de Eventos Dinamico
            //
            this.ReadingSilver_chk.Click += (s, e) => valorCambiado_checkbox(s, e, ReadingGold_chk);
            this.ReadingGold_chk.Click += (s, e) => checkBox_Gold(s,e, ReadingSilver_chk);
            this.ListeningSilver_Chk.Click += (s, e) => valorCambiado_checkbox(s, e, ListeningGold_chk);
            this.ListeningGold_chk.Click += (s, e) => checkBox_Gold(s,e,ListeningSilver_Chk);
            this.WritingSilver_Chk.Click += (s, e) => valorCambiado_checkbox(s,e,WritingGold_Chk);
            this.WritingGold_Chk.Click += (s, e) => checkBox_Gold(s,e, WritingSilver_Chk);
            this.ReadingSilver_chk.Click += (s, e) => valorCambiado_checkbox(s, e, ReadingGold_chk);
            this.ReadingGold_chk.Click += (s, e) => checkBox_Gold(s, e, ReadingSilver_chk);

            this.Evaluar_AutoButton.Click += (s, e) => Evaluar_AutoButton_Click(s,e, Correo);
        }

        #endregion


        #endregion

        private int determinarNivel(CheckBox checkPlata, CheckBox checkGold)
        {
            List<CheckBox> Lista = new List<CheckBox>();
            Lista.Add(checkPlata);
            Lista.Add(checkGold);
            int contador = 1;
            foreach (CheckBox caja in Lista)
            {
                if (caja.Checked)
                {
                    contador++;
                }
            }
            return contador;
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label reading_Label;
        private System.Windows.Forms.Label Escrita_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Evaluar_AutoButton;
        private System.Windows.Forms.Button Cancelar_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LecturaSilver_Label;
        private System.Windows.Forms.CheckBox ReadingSilver_chk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LecturaGold_Label;
        private System.Windows.Forms.CheckBox ReadingGold_chk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label ListeningGold_label;
        private System.Windows.Forms.CheckBox ListeningGold_chk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label WritingGold_Label;
        private System.Windows.Forms.CheckBox WritingGold_Chk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label ListeningSilver_label;
        private System.Windows.Forms.CheckBox ListeningSilver_Chk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox WritingSilver_Chk;
        private System.Windows.Forms.Button Help_Button;
    }
}