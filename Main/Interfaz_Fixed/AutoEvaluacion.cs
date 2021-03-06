﻿using CapaLógica;
using Datos;
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

        public AutoEvaluacion(string Correo)
        {
            InitializeComponent();
            Eventos(Correo);
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
                checkBox_desbloqueado.Enabled = true;
            }
            else
            {
                cajaChequeo.Checked = false;
                cajaChequeo.Enabled = true;
                checkBox_desbloqueado.Enabled = false;
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

        private void checkBox_Gold(object sender, EventArgs e, CheckBox anterior)
        {
            CheckBox caja = sender as CheckBox;
            if (!caja.Checked)
            {
                caja.Checked = true;
                anterior.Enabled = false;
            }
            else
            {
                caja.Checked = false;
                anterior.Enabled = true;
            }
        }

        private void Evaluar_AutoButton_Click(object sender, EventArgs e, string Correo)
        {
            int NivelWriting = determinarNivel(WritingSilver_Chk,WritingGold_Chk);
            int NivelReading = determinarNivel(ReadingSilver_chk, ReadingGold_chk);
            int NivelListening = determinarNivel(ListeningSilver_Chk, ListeningGold_chk);
            UsuarioDAL.setNivelesUsuarioEnBD(NivelWriting,NivelReading,NivelListening,Correo);
            Usuario user = new Usuario(Correo);

            new LICGUI(user).Show();
            this.Hide();
            
    }

        private void Cerrando(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
