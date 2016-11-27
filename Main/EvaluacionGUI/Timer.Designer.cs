namespace EvaluacionGUI
{
    partial class Contador_Tiempo_GUI
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TiempoRestante_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1800;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Starcraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo Restante:";
            // 
            // TiempoRestante_Label
            // 
            this.TiempoRestante_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiempoRestante_Label.Location = new System.Drawing.Point(156, 11);
            this.TiempoRestante_Label.Name = "TiempoRestante_Label";
            this.TiempoRestante_Label.Size = new System.Drawing.Size(198, 27);
            this.TiempoRestante_Label.TabIndex = 1;
            // 
            // Contador_Tiempo_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 52);
            this.Controls.Add(this.TiempoRestante_Label);
            this.Controls.Add(this.label1);
            this.Name = "Contador_Tiempo_GUI";
            this.Text = "Tiempo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrando);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Timer_cerrado);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TiempoRestante_Label;
    }
}