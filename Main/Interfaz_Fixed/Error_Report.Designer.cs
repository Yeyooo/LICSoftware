namespace Interfaz_Fixed
{
    partial class Error_Report
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
            this.Mensaje_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Asunto_TextBox = new System.Windows.Forms.TextBox();
            this.Cancelar_Reporte = new System.Windows.Forms.Button();
            this.Enviar_Reporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mensaje_TextBox
            // 
            this.Mensaje_TextBox.Location = new System.Drawing.Point(27, 66);
            this.Mensaje_TextBox.Multiline = true;
            this.Mensaje_TextBox.Name = "Mensaje_TextBox";
            this.Mensaje_TextBox.Size = new System.Drawing.Size(431, 191);
            this.Mensaje_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asunto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Asunto_TextBox
            // 
            this.Asunto_TextBox.Location = new System.Drawing.Point(91, 9);
            this.Asunto_TextBox.Name = "Asunto_TextBox";
            this.Asunto_TextBox.Size = new System.Drawing.Size(338, 20);
            this.Asunto_TextBox.TabIndex = 2;
            // 
            // Cancelar_Reporte
            // 
            this.Cancelar_Reporte.Location = new System.Drawing.Point(477, 210);
            this.Cancelar_Reporte.Name = "Cancelar_Reporte";
            this.Cancelar_Reporte.Size = new System.Drawing.Size(75, 47);
            this.Cancelar_Reporte.TabIndex = 3;
            this.Cancelar_Reporte.Text = "Cancelar";
            this.Cancelar_Reporte.UseVisualStyleBackColor = true;
            // 
            // Enviar_Reporte
            // 
            this.Enviar_Reporte.Location = new System.Drawing.Point(477, 140);
            this.Enviar_Reporte.Name = "Enviar_Reporte";
            this.Enviar_Reporte.Size = new System.Drawing.Size(75, 51);
            this.Enviar_Reporte.TabIndex = 4;
            this.Enviar_Reporte.Text = "Enviar";
            this.Enviar_Reporte.UseVisualStyleBackColor = true;
            this.Enviar_Reporte.Click += new System.EventHandler(this.Enviar_Reporte_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensaje:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Error_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enviar_Reporte);
            this.Controls.Add(this.Cancelar_Reporte);
            this.Controls.Add(this.Asunto_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mensaje_TextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Error_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Mensaje_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Asunto_TextBox;
        private System.Windows.Forms.Button Cancelar_Reporte;
        private System.Windows.Forms.Button Enviar_Reporte;
        private System.Windows.Forms.Label label2;
    }
}