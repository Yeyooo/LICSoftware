using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EvaluacionGUI
{
    public partial class Contador_Tiempo_GUI : Form
    {

        float Tiempo_Restante = 1800.0f;
        int Minutos_Restante = 0;

        public Contador_Tiempo_GUI()
        {
            InitializeComponent();
        }

        private void reproducirSonido()
        {
            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Play();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            Tiempo_Restante--;
            Minutos_Restante = Int32.Parse(Tiempo_Restante.ToString()) / 60;
            TiempoRestante_Label.Text = Minutos_Restante.ToString() + " Minutos";
            if (Tiempo_Restante == 60)
            {
            }
        }

        private void Cerrando(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Timer_cerrado(object sender, FormClosedEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.CompareTo("EvaluacionGUI") == 0)
                {
                    frm.Close();
                    this.Close();
                }
            }
        }
    }
}
