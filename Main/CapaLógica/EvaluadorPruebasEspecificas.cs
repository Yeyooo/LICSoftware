using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLógica
{
    public class EvaluadorPruebasEspecificas
    {
        //UNA INSTANCIACION DE EVALUADOR POR CADA EVALUACION
        private int RespuestasCorrectas;
        private int RespuestasIncorrectas;
        private string tipoEvaluacion;

        #region Strings Reservados para el Motor de Inferencia

        private string descenso = "correctas menor 30";
        private string transicionDescenso_uno = "correctas mayor o igual 30";
        private string transicionDescenso_dos = "correctas menor 50";
        private string mantenimiento_uno = "correctas mayor o igual 50";
        private string mantenimiento_dos = "correctas menor 70";
        private string transicionAscenso_uno = "correctas mayor o igual 70";
        private string transicionAscenso_dos = "correctas menor a 90";
        private string ascenso = "mayor o igual 90";

        #endregion

        public EvaluadorPruebasEspecificas(string tipoEvaluacion)
        {
            RespuestasCorrectas = 0;
            RespuestasIncorrectas = 0;
            this.tipoEvaluacion = tipoEvaluacion;
        }

        public void recorrerPreguntas(TableLayoutPanel panel)
        {
            List<RadioButton> listaButton = listaButton = new List<RadioButton>();
            for (int i = 0; i < panel.RowCount; i++)
            {
                Slots_Alternativas radioButton = panel.GetControlFromPosition(0, i) as Slots_Alternativas;
                if (radioButton != null) {
                    listaButton.Add(radioButton);
                }
            }
            Evaluar(listaButton);
        }

        public void Evaluar(List<RadioButton> listaButton)
        {
            bool respondio = false;
            foreach (Slots_Alternativas radioChoice in listaButton)
            {
                if (radioChoice.Checked && radioChoice.esCorrecta())
                {
                   RespuestasCorrectas++;
                    respondio = true;
                }
                else if (radioChoice.Checked && !radioChoice.esCorrecta())
                {
                    RespuestasIncorrectas++;
                    respondio = true;
                }
            }
            if (!respondio)
            {
                RespuestasIncorrectas++;
            }

        }

        public void MostrarResultados()
        {
             MessageBox.Show("Respuestas correctas " + RespuestasCorrectas + " y tiene " + RespuestasIncorrectas + " respuestas incorrectas");
        }

        public int getRespuestasCorrectas()
        {
            return this.RespuestasCorrectas;
        }

        public int getRespuestasIncorrectas()
        {
            return this.RespuestasIncorrectas;
        }

        //Calculos para los hechos
        public List<string> getHechos()
        {
            List<string> hechos = new List<string>();
            if (RespuestasCorrectas < 3)
            {
                hechos.Add(descenso);
                return hechos;
            }
            if (RespuestasCorrectas >= 3 && RespuestasCorrectas < 5)
            {
                hechos.Add(transicionDescenso_uno);
                hechos.Add(transicionDescenso_dos);
                return hechos;
            }
            if (RespuestasCorrectas >= 5 && RespuestasCorrectas < 7)
            {
                hechos.Add(mantenimiento_uno);
                hechos.Add(mantenimiento_dos);
                return hechos;
            }
            if (RespuestasCorrectas>= 7 && RespuestasCorrectas < 9)
            {
                hechos.Add(transicionAscenso_uno);
                hechos.Add(transicionAscenso_dos);
                return hechos;
            }
            if (RespuestasCorrectas>=9)
            {
                hechos.Add(ascenso);
                return hechos;
            }

            return null;
        }

        public string GetTipoEvaluacion()
        {
            return this.tipoEvaluacion;
        }


    }

}
