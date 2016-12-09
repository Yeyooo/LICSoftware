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
            this.Boton_Entrenar_Writing = new System.Windows.Forms.Button();
            this.Boton_Entrenar_Reading = new System.Windows.Forms.Button();
            this.Boton_Entrenar_Listenning = new System.Windows.Forms.Button();
            this.Icono_Liga_Writing = new System.Windows.Forms.PictureBox();
            this.Icono_Liga_Reading = new System.Windows.Forms.PictureBox();
            this.Icono_Liga_Listening = new System.Windows.Forms.PictureBox();
            this.General_Panel = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GeneralTrainningLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UsurioInfo_Panel = new System.Windows.Forms.Panel();
            this.Usuario_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Entrenamiento_Pane.SuspendLayout();
            this.Panel_habilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Liga_Writing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Liga_Reading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Liga_Listening)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(17, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 576);
            this.panel1.TabIndex = 0;
            // 
            // Entrenamiento_Pane
            // 
            this.Entrenamiento_Pane.Controls.Add(this.Panel_habilidades);
            this.Entrenamiento_Pane.Controls.Add(this.General_Panel);
            this.Entrenamiento_Pane.Font = new System.Drawing.Font("Starcraft", 10.75F);
            this.Entrenamiento_Pane.Location = new System.Drawing.Point(4, 0);
            this.Entrenamiento_Pane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Entrenamiento_Pane.Name = "Entrenamiento_Pane";
            this.Entrenamiento_Pane.SelectedIndex = 0;
            this.Entrenamiento_Pane.Size = new System.Drawing.Size(1103, 572);
            this.Entrenamiento_Pane.TabIndex = 0;
            // 
            // Panel_habilidades
            // 
            this.Panel_habilidades.BackColor = System.Drawing.Color.LightSlateGray;
            this.Panel_habilidades.BackgroundImage = global::Interfaz_Fixed.Properties.Resources.Panel_Habilidades;
            this.Panel_habilidades.Controls.Add(this.Boton_Entrenar_Writing);
            this.Panel_habilidades.Controls.Add(this.Boton_Entrenar_Reading);
            this.Panel_habilidades.Controls.Add(this.Boton_Entrenar_Listenning);
            this.Panel_habilidades.Controls.Add(this.Icono_Liga_Writing);
            this.Panel_habilidades.Controls.Add(this.Icono_Liga_Reading);
            this.Panel_habilidades.Controls.Add(this.Icono_Liga_Listening);
            this.Panel_habilidades.Location = new System.Drawing.Point(4, 24);
            this.Panel_habilidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_habilidades.Name = "Panel_habilidades";
            this.Panel_habilidades.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_habilidades.Size = new System.Drawing.Size(1095, 544);
            this.Panel_habilidades.TabIndex = 0;
            this.Panel_habilidades.Text = "Habilidades";
            // 
            // Boton_Entrenar_Writing
            // 
            this.Boton_Entrenar_Writing.BackColor = System.Drawing.Color.Transparent;
            this.Boton_Entrenar_Writing.Location = new System.Drawing.Point(488, 394);
            this.Boton_Entrenar_Writing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Boton_Entrenar_Writing.Name = "Boton_Entrenar_Writing";
            this.Boton_Entrenar_Writing.Size = new System.Drawing.Size(221, 66);
            this.Boton_Entrenar_Writing.TabIndex = 5;
            this.Boton_Entrenar_Writing.Text = "Entrenar !";
            this.Boton_Entrenar_Writing.UseVisualStyleBackColor = false;
            this.Boton_Entrenar_Writing.Click += new System.EventHandler(this.EntrenarWriting_Click);
            // 
            // Boton_Entrenar_Reading
            // 
            this.Boton_Entrenar_Reading.BackColor = System.Drawing.Color.Transparent;
            this.Boton_Entrenar_Reading.Location = new System.Drawing.Point(488, 245);
            this.Boton_Entrenar_Reading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Boton_Entrenar_Reading.Name = "Boton_Entrenar_Reading";
            this.Boton_Entrenar_Reading.Size = new System.Drawing.Size(221, 66);
            this.Boton_Entrenar_Reading.TabIndex = 4;
            this.Boton_Entrenar_Reading.Text = "Entrenar !";
            this.Boton_Entrenar_Reading.UseVisualStyleBackColor = false;
            this.Boton_Entrenar_Reading.Click += new System.EventHandler(this.EntrenarReading_Click);
            // 
            // Boton_Entrenar_Listenning
            // 
            this.Boton_Entrenar_Listenning.BackColor = System.Drawing.Color.Transparent;
            this.Boton_Entrenar_Listenning.Location = new System.Drawing.Point(488, 81);
            this.Boton_Entrenar_Listenning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Boton_Entrenar_Listenning.Name = "Boton_Entrenar_Listenning";
            this.Boton_Entrenar_Listenning.Size = new System.Drawing.Size(221, 66);
            this.Boton_Entrenar_Listenning.TabIndex = 3;
            this.Boton_Entrenar_Listenning.Text = "Entrenar !";
            this.Boton_Entrenar_Listenning.UseVisualStyleBackColor = false;
            this.Boton_Entrenar_Listenning.Click += new System.EventHandler(this.EntrenarListening_Click);
            // 
            // Icono_Liga_Writing
            // 
            this.Icono_Liga_Writing.BackColor = System.Drawing.Color.Transparent;
            this.Icono_Liga_Writing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Icono_Liga_Writing.Image = global::Interfaz_Fixed.Properties.Resources.Liga_oro_ascenso11;
            this.Icono_Liga_Writing.Location = new System.Drawing.Point(817, 358);
            this.Icono_Liga_Writing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Icono_Liga_Writing.Name = "Icono_Liga_Writing";
            this.Icono_Liga_Writing.Size = new System.Drawing.Size(184, 176);
            this.Icono_Liga_Writing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Liga_Writing.TabIndex = 2;
            this.Icono_Liga_Writing.TabStop = false;
            // 
            // Icono_Liga_Reading
            // 
            this.Icono_Liga_Reading.BackColor = System.Drawing.Color.Transparent;
            this.Icono_Liga_Reading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Icono_Liga_Reading.Image = global::Interfaz_Fixed.Properties.Resources.Liga_oro_ascenso11;
            this.Icono_Liga_Reading.Location = new System.Drawing.Point(817, 191);
            this.Icono_Liga_Reading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Icono_Liga_Reading.Name = "Icono_Liga_Reading";
            this.Icono_Liga_Reading.Size = new System.Drawing.Size(184, 176);
            this.Icono_Liga_Reading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Liga_Reading.TabIndex = 1;
            this.Icono_Liga_Reading.TabStop = false;
            // 
            // Icono_Liga_Listening
            // 
            this.Icono_Liga_Listening.BackColor = System.Drawing.Color.Transparent;
            this.Icono_Liga_Listening.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Icono_Liga_Listening.Image = global::Interfaz_Fixed.Properties.Resources.Liga_oro_ascenso11;
            this.Icono_Liga_Listening.Location = new System.Drawing.Point(817, 7);
            this.Icono_Liga_Listening.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Icono_Liga_Listening.Name = "Icono_Liga_Listening";
            this.Icono_Liga_Listening.Size = new System.Drawing.Size(184, 176);
            this.Icono_Liga_Listening.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Liga_Listening.TabIndex = 0;
            this.Icono_Liga_Listening.TabStop = false;
            // 
            // General_Panel
            // 
            this.General_Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.General_Panel.BackgroundImage = global::Interfaz_Fixed.Properties.Resources.HabilidadGeneral;
            this.General_Panel.Controls.Add(this.pictureBox1);
            this.General_Panel.Controls.Add(this.GeneralTrainningLabel);
            this.General_Panel.Controls.Add(this.button1);
            this.General_Panel.Location = new System.Drawing.Point(4, 24);
            this.General_Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.General_Panel.Name = "General_Panel";
            this.General_Panel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.General_Panel.Size = new System.Drawing.Size(1095, 544);
            this.General_Panel.TabIndex = 1;
            this.General_Panel.Text = "General";
            this.General_Panel.ToolTipText = "El tutor seleccionara los temas de las 3 habildiades disponibles para que entrene" +
    "s !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Interfaz_Fixed.Properties.Resources.NOLIGA_Warning;
            this.pictureBox1.Location = new System.Drawing.Point(391, 234);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GeneralTrainningLabel
            // 
            this.GeneralTrainningLabel.BackColor = System.Drawing.Color.Transparent;
            this.GeneralTrainningLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.GeneralTrainningLabel.Location = new System.Drawing.Point(301, 102);
            this.GeneralTrainningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GeneralTrainningLabel.Name = "GeneralTrainningLabel";
            this.GeneralTrainningLabel.Size = new System.Drawing.Size(512, 30);
            this.GeneralTrainningLabel.TabIndex = 1;
            this.GeneralTrainningLabel.Text = "Entrenamiento de las 3 Habilidades";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrenar !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EntrenamientoGeneral_Click);
            // 
            // UsurioInfo_Panel
            // 
            this.UsurioInfo_Panel.BackColor = System.Drawing.Color.Transparent;
            this.UsurioInfo_Panel.Controls.Add(this.Usuario_Label);
            this.UsurioInfo_Panel.Location = new System.Drawing.Point(984, 34);
            this.UsurioInfo_Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsurioInfo_Panel.Name = "UsurioInfo_Panel";
            this.UsurioInfo_Panel.Size = new System.Drawing.Size(553, 78);
            this.UsurioInfo_Panel.TabIndex = 1;
            // 
            // Usuario_Label
            // 
            this.Usuario_Label.Font = new System.Drawing.Font("Starcraft", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_Label.ForeColor = System.Drawing.SystemColors.Window;
            this.Usuario_Label.Location = new System.Drawing.Point(17, 20);
            this.Usuario_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuario_Label.Name = "Usuario_Label";
            this.Usuario_Label.Size = new System.Drawing.Size(212, 36);
            this.Usuario_Label.TabIndex = 0;
            this.Usuario_Label.Text = "Usuario:";
            this.Usuario_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LICGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interfaz_Fixed.Properties.Resources.UI_licsoftware_fixed_2_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1711, 844);
            this.Controls.Add(this.UsurioInfo_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LICGUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.Entrenamiento_Pane.ResumeLayout(false);
            this.Panel_habilidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Liga_Writing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Liga_Reading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Liga_Listening)).EndInit();
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
        private System.Windows.Forms.PictureBox Icono_Liga_Listening;
        private System.Windows.Forms.PictureBox Icono_Liga_Writing;
        private System.Windows.Forms.PictureBox Icono_Liga_Reading;
        private System.Windows.Forms.Button Boton_Entrenar_Listenning;
        private System.Windows.Forms.Button Boton_Entrenar_Writing;
        private System.Windows.Forms.Button Boton_Entrenar_Reading;
        private System.Windows.Forms.Label GeneralTrainningLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

