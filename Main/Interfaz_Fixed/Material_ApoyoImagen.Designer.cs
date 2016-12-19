namespace Interfaz_Fixed
{
    partial class Material_ApoyoImagen
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
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.PanelImagen = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.PanelImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imagen
            // 
            this.Imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen.Location = new System.Drawing.Point(4, 4);
            this.Imagen.Margin = new System.Windows.Forms.Padding(4);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(439, 278);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Imagen.TabIndex = 0;
            this.Imagen.TabStop = false;
            // 
            // PanelImagen
            // 
            this.PanelImagen.AutoScroll = true;
            this.PanelImagen.Controls.Add(this.Imagen);
            this.PanelImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelImagen.Location = new System.Drawing.Point(0, 0);
            this.PanelImagen.Name = "PanelImagen";
            this.PanelImagen.Size = new System.Drawing.Size(1063, 593);
            this.PanelImagen.TabIndex = 1;
            // 
            // Material_ApoyoImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1063, 593);
            this.Controls.Add(this.PanelImagen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Material_ApoyoImagen";
            this.Text = "Material_ApoyoImagen";
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.PanelImagen.ResumeLayout(false);
            this.PanelImagen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.FlowLayoutPanel PanelImagen;
    }
}