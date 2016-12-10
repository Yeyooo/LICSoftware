using CapaLógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    public partial class AutoEvaluacion : Form
    {

        private int NivelWriting = 0;
        private int NivelListening = 0;
        private int NivelReading = 0;

        private string Listening = "Listening";
        private string Reading = "Reading";
        private string Writing = "Writing";

        public AutoEvaluacion()
        {
            InitializeComponent();
            Eventos();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Evaluar_Click(object sender, EventArgs e, TableLayoutPanel panel)
        {
            //Aqui va la evaluacion al Agente con 3 String distintos 
        }

        private void CheckBox_Changed(object sender, EventArgs e)
        {

        }
        private void valorCambiado_checkbox(object sender, EventArgs e, CheckBox checkBox_desbloqueado)
        {
            //BLOQUEAR EL ANTERIOR PARA QUE SIEMPRE SEA EN CASCADA TAMBIEN EL DESCENSO
            CheckBox cajaChequeo = sender as CheckBox;
            if (!Evaluar_AutoButton.Enabled ) {
                Evaluar_AutoButton.Enabled = true;
            }
            if (!cajaChequeo.Checked)
            {
                cajaChequeo.Checked = true;
                if (Writing.CompareTo(cajaChequeo.Tag) == 0)
                {
                    NivelWriting++;
                }
                if (Listening.CompareTo(cajaChequeo.Tag) == 0)
                {
                    NivelListening++;
                }
                if (Reading.CompareTo(cajaChequeo.Tag) == 0)
                {
                    NivelReading++;
                }

                checkBox_desbloqueado.Enabled = true;
            }
            else
            {
                cajaChequeo.Checked = false;
                cajaChequeo.Enabled = true;
                checkBox_desbloqueado.Enabled = false;
                if (Writing.CompareTo(cajaChequeo.Tag) == 0)
                {
                    NivelWriting--;
                }
                if (Listening.CompareTo(cajaChequeo.Tag) == 0)
                {
                    NivelListening--;
                }
                if (Reading.CompareTo(cajaChequeo.Tag) == 0)
                {
                    NivelReading--;
                }
            }
        }




        private void bloquearValores(object sender, EventArgs e, CheckBox GoldCheck, CheckBox SilverCheck, CheckBox BronzeCheck)
        {
            CheckBox cajaChequeada = sender as CheckBox;
            cajaChequeada.Checked = true;
            if (cajaChequeada.Checked)
            {
                if (BronzeCheck.Checked && SilverCheck.Checked) {
                    BronzeCheck.Enabled = false;
                    SilverCheck.Enabled = false;
                    GoldCheck.Enabled = false;
                    if (Writing.CompareTo(cajaChequeada.Tag) == 0)
                    {
                        NivelWriting++;
                    }
                    if (Listening.CompareTo(cajaChequeada.Tag) == 0)
                    {
                        NivelListening--;
                    }
                    if (Reading.CompareTo(cajaChequeada.Tag) == 0)
                    {
                        NivelReading--;
                    }
                }
            }
            else
            {
                cajaChequeada.Checked = false;
            }
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            string message = "Esta es la autoevaluacion, nos ayudara a posicionarte en una liga segun tu percepcion. Tranquilo, sabemos que quizas tengas una falsa percepcion de lo que sabes pero no te preocupes, el tutor se encarga de nivelarte luego. Si no te sientes preparado clickea en cancelar";
            string caption = "Ayuda ";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }

        }

        private void Enviando_Al_Tutor(object sender, EventArgs e, Agente tutor)
        {
            //funcion para que acepte el tutor
        }
    }
}
