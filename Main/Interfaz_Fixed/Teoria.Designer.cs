namespace Interfaz_Fixed
{
    partial class Teoria
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
            this.textBox_Teoria = new System.Windows.Forms.TextBox();
            this.Enunciado_Pregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Teoria
            // 
            this.textBox_Teoria.Enabled = false;
            this.textBox_Teoria.Location = new System.Drawing.Point(12, 40);
            this.textBox_Teoria.Multiline = true;
            this.textBox_Teoria.Name = "textBox_Teoria";
            this.textBox_Teoria.Size = new System.Drawing.Size(742, 259);
            this.textBox_Teoria.TabIndex = 0;
            // 
            // Enunciado_Pregunta
            // 
            this.Enunciado_Pregunta.Location = new System.Drawing.Point(13, 9);
            this.Enunciado_Pregunta.Name = "Enunciado_Pregunta";
            this.Enunciado_Pregunta.Size = new System.Drawing.Size(741, 28);
            this.Enunciado_Pregunta.TabIndex = 1;
            this.Enunciado_Pregunta.Text = "label1";
            this.Enunciado_Pregunta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Teoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(766, 311);
            this.Controls.Add(this.Enunciado_Pregunta);
            this.Controls.Add(this.textBox_Teoria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teoria";
            this.Text = "Teoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Teoria;
        private System.Windows.Forms.Label Enunciado_Pregunta;
    }
}