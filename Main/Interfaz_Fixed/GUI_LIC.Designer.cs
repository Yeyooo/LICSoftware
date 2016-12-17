namespace Interfaz_Fixed
{
    partial class LICGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LICGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Entrenamiento_Pane = new System.Windows.Forms.TabControl();
            this.Panel_habilidades = new System.Windows.Forms.TabPage();
            this.picture_WritingLiga = new System.Windows.Forms.PictureBox();
            this.picture_ReadingLiga = new System.Windows.Forms.PictureBox();
            this.Boton_Entrenar_Writing = new System.Windows.Forms.Button();
            this.Boton_Entrenar_Reading = new System.Windows.Forms.Button();
            this.Boton_Entrenar_Listenning = new System.Windows.Forms.Button();
            this.picture_ListeningLiga = new System.Windows.Forms.PictureBox();
            this.General_Panel = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GeneralTrainningLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UsurioInfo_Panel = new System.Windows.Forms.Panel();
            this.Usuario_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CargarEvaluaciones_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Entrenamiento_Pane.SuspendLayout();
            this.Panel_habilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_WritingLiga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ReadingLiga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ListeningLiga)).BeginInit();
            this.General_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UsurioInfo_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Entrenamiento_Pane);
            this.panel1.Location = new System.Drawing.Point(13, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 468);
            this.panel1.TabIndex = 0;
            // 
            // Entrenamiento_Pane
            // 
            this.Entrenamiento_Pane.Controls.Add(this.Panel_habilidades);
            this.Entrenamiento_Pane.Controls.Add(this.General_Panel);
            this.Entrenamiento_Pane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.Entrenamiento_Pane.Location = new System.Drawing.Point(3, 0);
            this.Entrenamiento_Pane.Name = "Entrenamiento_Pane";
            this.Entrenamiento_Pane.SelectedIndex = 0;
            this.Entrenamiento_Pane.Size = new System.Drawing.Size(827, 465);
            this.Entrenamiento_Pane.TabIndex = 0;
            // 
            // Panel_habilidades
            // 
            this.Panel_habilidades.BackColor = System.Drawing.Color.LightSlateGray;
            this.Panel_habilidades.BackgroundImage = global::Interfaz_Fixed.Properties.Resources.Panel_Habilidades;
            this.Panel_habilidades.Controls.Add(this.picture_WritingLiga);
            this.Panel_habilidades.Controls.Add(this.picture_ReadingLiga);
            this.Panel_habilidades.Controls.Add(this.Boton_Entrenar_Writing);
            this.Panel_habilidades.Controls.Add(this.Boton_Entrenar_Reading);
            this.Panel_habilidades.Controls.Add(this.Boton_Entrenar_Listenning);
            this.Panel_habilidades.Controls.Add(this.picture_ListeningLiga);
            this.Panel_habilidades.Location = new System.Drawing.Point(4, 26);
            this.Panel_habilidades.Name = "Panel_habilidades";
            this.Panel_habilidades.Padding = new System.Windows.Forms.Padding(3);
            this.Panel_habilidades.Size = new System.Drawing.Size(819, 435);
            this.Panel_habilidades.TabIndex = 0;
            this.Panel_habilidades.Text = "Habilidades";
            // 
            // picture_WritingLiga
            // 
            this.picture_WritingLiga.BackColor = System.Drawing.Color.Transparent;
            this.picture_WritingLiga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_WritingLiga.Image = global::Interfaz_Fixed.Properties.Resources.Bronze_Leage;
            this.picture_WritingLiga.Location = new System.Drawing.Point(613, 300);
            this.picture_WritingLiga.Name = "picture_WritingLiga";
            this.picture_WritingLiga.Size = new System.Drawing.Size(138, 129);
            this.picture_WritingLiga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_WritingLiga.TabIndex = 7;
            this.picture_WritingLiga.TabStop = false;
            // 
            // picture_ReadingLiga
            // 
            this.picture_ReadingLiga.BackColor = System.Drawing.Color.Transparent;
            this.picture_ReadingLiga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_ReadingLiga.Image = global::Interfaz_Fixed.Properties.Resources.Gold_Leage;
            this.picture_ReadingLiga.Location = new System.Drawing.Point(613, 155);
            this.picture_ReadingLiga.Name = "picture_ReadingLiga";
            this.picture_ReadingLiga.Size = new System.Drawing.Size(138, 129);
            this.picture_ReadingLiga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_ReadingLiga.TabIndex = 6;
            this.picture_ReadingLiga.TabStop = false;
            // 
            // Boton_Entrenar_Writing
            // 
            this.Boton_Entrenar_Writing.BackColor = System.Drawing.Color.Transparent;
            this.Boton_Entrenar_Writing.Location = new System.Drawing.Point(366, 320);
            this.Boton_Entrenar_Writing.Name = "Boton_Entrenar_Writing";
            this.Boton_Entrenar_Writing.Size = new System.Drawing.Size(166, 54);
            this.Boton_Entrenar_Writing.TabIndex = 5;
            this.Boton_Entrenar_Writing.Text = "Entrenar !";
            this.Boton_Entrenar_Writing.UseVisualStyleBackColor = false;
            this.Boton_Entrenar_Writing.Click += new System.EventHandler(this.EntrenarWriting_Click);
            // 
            // Boton_Entrenar_Reading
            // 
            this.Boton_Entrenar_Reading.BackColor = System.Drawing.Color.Transparent;
            this.Boton_Entrenar_Reading.Location = new System.Drawing.Point(366, 199);
            this.Boton_Entrenar_Reading.Name = "Boton_Entrenar_Reading";
            this.Boton_Entrenar_Reading.Size = new System.Drawing.Size(166, 54);
            this.Boton_Entrenar_Reading.TabIndex = 4;
            this.Boton_Entrenar_Reading.Text = "Entrenar !";
            this.Boton_Entrenar_Reading.UseVisualStyleBackColor = false;
            this.Boton_Entrenar_Reading.Click += new System.EventHandler(this.EntrenarReading_Click);
            // 
            // Boton_Entrenar_Listenning
            // 
            this.Boton_Entrenar_Listenning.BackColor = System.Drawing.Color.Transparent;
            this.Boton_Entrenar_Listenning.Location = new System.Drawing.Point(366, 66);
            this.Boton_Entrenar_Listenning.Name = "Boton_Entrenar_Listenning";
            this.Boton_Entrenar_Listenning.Size = new System.Drawing.Size(166, 54);
            this.Boton_Entrenar_Listenning.TabIndex = 3;
            this.Boton_Entrenar_Listenning.Text = "Entrenar !";
            this.Boton_Entrenar_Listenning.UseVisualStyleBackColor = false;
            this.Boton_Entrenar_Listenning.Click += new System.EventHandler(this.EntrenarListening_Click);
            // 
            // picture_ListeningLiga
            // 
            this.picture_ListeningLiga.BackColor = System.Drawing.Color.Transparent;
            this.picture_ListeningLiga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture_ListeningLiga.Image = global::Interfaz_Fixed.Properties.Resources.Silver_leage_NB;
            this.picture_ListeningLiga.Location = new System.Drawing.Point(613, 20);
            this.picture_ListeningLiga.Name = "picture_ListeningLiga";
            this.picture_ListeningLiga.Size = new System.Drawing.Size(138, 129);
            this.picture_ListeningLiga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_ListeningLiga.TabIndex = 0;
            this.picture_ListeningLiga.TabStop = false;
            // 
            // General_Panel
            // 
            this.General_Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.General_Panel.BackgroundImage = global::Interfaz_Fixed.Properties.Resources.HabilidadGeneral;
            this.General_Panel.Controls.Add(this.pictureBox1);
            this.General_Panel.Controls.Add(this.GeneralTrainningLabel);
            this.General_Panel.Controls.Add(this.button1);
            this.General_Panel.Location = new System.Drawing.Point(4, 26);
            this.General_Panel.Name = "General_Panel";
            this.General_Panel.Padding = new System.Windows.Forms.Padding(3);
            this.General_Panel.Size = new System.Drawing.Size(819, 435);
            this.General_Panel.TabIndex = 1;
            this.General_Panel.Text = "General";
            this.General_Panel.ToolTipText = "El tutor seleccionara los temas de las 3 habildiades disponibles para que entrene" +
    "s !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Interfaz_Fixed.Properties.Resources.NOLIGA_Warning;
            this.pictureBox1.Location = new System.Drawing.Point(293, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GeneralTrainningLabel
            // 
            this.GeneralTrainningLabel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralTrainningLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.GeneralTrainningLabel.Location = new System.Drawing.Point(226, 83);
            this.GeneralTrainningLabel.Name = "GeneralTrainningLabel";
            this.GeneralTrainningLabel.Size = new System.Drawing.Size(384, 24);
            this.GeneralTrainningLabel.TabIndex = 1;
            this.GeneralTrainningLabel.Text = "Entrenamiento de las 3 Habilidades";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrenar !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EntrenamientoGeneral_Click);
            // 
            // UsurioInfo_Panel
            // 
            this.UsurioInfo_Panel.BackColor = System.Drawing.Color.Transparent;
            this.UsurioInfo_Panel.Controls.Add(this.Usuario_Label);
            this.UsurioInfo_Panel.Location = new System.Drawing.Point(738, 28);
            this.UsurioInfo_Panel.Name = "UsurioInfo_Panel";
            this.UsurioInfo_Panel.Size = new System.Drawing.Size(415, 63);
            this.UsurioInfo_Panel.TabIndex = 1;
            // 
            // Usuario_Label
            // 
            this.Usuario_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Usuario_Label.Location = new System.Drawing.Point(13, 16);
            this.Usuario_Label.Name = "Usuario_Label";
            this.Usuario_Label.Size = new System.Drawing.Size(362, 35);
            this.Usuario_Label.TabIndex = 0;
            this.Usuario_Label.Text = "Usuario:";
            this.Usuario_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1184, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 41);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CargarEvaluaciones_Label
            // 
            this.CargarEvaluaciones_Label.BackColor = System.Drawing.Color.Transparent;
            this.CargarEvaluaciones_Label.Location = new System.Drawing.Point(1187, 20);
            this.CargarEvaluaciones_Label.Name = "CargarEvaluaciones_Label";
            this.CargarEvaluaciones_Label.Size = new System.Drawing.Size(44, 36);
            this.CargarEvaluaciones_Label.TabIndex = 3;
            this.CargarEvaluaciones_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarEvaluaciones_Label.Click += new System.EventHandler(this.CargarEvaluaciones_Label_Click);
            // 
            // LICGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaz_Fixed.Properties.Resources.UI_licsoftware_fixed_2_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1283, 686);
            this.Controls.Add(this.CargarEvaluaciones_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsurioInfo_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LICGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cerrando_GUI);
            this.Load += new System.EventHandler(this.GUILIC_Loading);
            this.panel1.ResumeLayout(false);
            this.Entrenamiento_Pane.ResumeLayout(false);
            this.Panel_habilidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_WritingLiga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ReadingLiga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ListeningLiga)).EndInit();
            this.General_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UsurioInfo_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl Entrenamiento_Pane;
        private System.Windows.Forms.TabPage Panel_habilidades;
        private System.Windows.Forms.TabPage General_Panel;
        private System.Windows.Forms.Panel UsurioInfo_Panel;
        private System.Windows.Forms.Label Usuario_Label;
        private System.Windows.Forms.PictureBox picture_ListeningLiga;
        private System.Windows.Forms.Button Boton_Entrenar_Listenning;
        private System.Windows.Forms.Button Boton_Entrenar_Writing;
        private System.Windows.Forms.Button Boton_Entrenar_Reading;
        private System.Windows.Forms.Label GeneralTrainningLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_WritingLiga;
        private System.Windows.Forms.PictureBox picture_ReadingLiga;
        private System.Windows.Forms.Label CargarEvaluaciones_Label;
    }
}

