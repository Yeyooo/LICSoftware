using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    partial class Material_Apoyo
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
            this.layout_MaterialListening = new System.Windows.Forms.TableLayoutPanel();
            this.label_MaterialApoyo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.layout_MaterialListening.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_MaterialListening
            // 
            this.layout_MaterialListening.ColumnCount = 1;
            this.layout_MaterialListening.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout_MaterialListening.Controls.Add(this.label_MaterialApoyo, 0, 0);
            this.layout_MaterialListening.Controls.Add(this.button1, 0, 1);
            this.layout_MaterialListening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_MaterialListening.Location = new System.Drawing.Point(0, 0);
            this.layout_MaterialListening.Name = "layout_MaterialListening";
            this.layout_MaterialListening.RowCount = 2;
            this.layout_MaterialListening.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.23404F));
            this.layout_MaterialListening.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.76596F));
            this.layout_MaterialListening.Size = new System.Drawing.Size(460, 235);
            this.layout_MaterialListening.TabIndex = 0;
            // 
            // label_MaterialApoyo
            // 
            this.label_MaterialApoyo.AutoSize = true;
            this.label_MaterialApoyo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MaterialApoyo.Location = new System.Drawing.Point(3, 0);
            this.label_MaterialApoyo.Name = "label_MaterialApoyo";
            this.label_MaterialApoyo.Size = new System.Drawing.Size(454, 110);
            this.label_MaterialApoyo.TabIndex = 0;
            this.label_MaterialApoyo.Text = "Dale al play para escuchar el recurso de apoyo.";
            this.label_MaterialApoyo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 119);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Material_Apoyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 235);
            this.Controls.Add(this.layout_MaterialListening);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Material_Apoyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material Apoyo Listening";
            this.layout_MaterialListening.ResumeLayout(false);
            this.layout_MaterialListening.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        void Hablador(string Apoyo)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            //synth.SelectVoice();
            synth.Speak(Apoyo);

        }


        private System.Windows.Forms.TableLayoutPanel layout_MaterialListening;
        private System.Windows.Forms.Label label_MaterialApoyo;
        private System.Windows.Forms.Button button1;
    }
}