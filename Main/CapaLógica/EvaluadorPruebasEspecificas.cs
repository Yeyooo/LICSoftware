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
            private List<RadioButton> listaButton;
            private int RespuestasCorrectas;
            private int RespuestasIncorrectas;

            public EvaluadorPruebasEspecificas()
            {
                listaButton = new List<RadioButton>();
                RespuestasCorrectas = 0;
                RespuestasIncorrectas = 0;
            }

            public void recorrerPreguntas(TableLayoutPanel panel)
            {
                for (int i = 0; i < panel.RowCount; i++)
                {
                    Slots_Alternativas radioButton = panel.GetControlFromPosition(0, i) as Slots_Alternativas;
                    if (radioButton != null) {
                        listaButton.Add(radioButton);
                    }
                    else
                    {
                        
                    }
                }

            }

        public void Evaluar()
        {
             foreach (Slots_Alternativas radioChoice in listaButton)
             {
                 if (radioChoice.Checked && radioChoice.esCorrecta())
                 {
                      RespuestasCorrectas++;
                 }
                 else if (radioChoice.Checked && !radioChoice.esCorrecta())
                 {
                      RespuestasIncorrectas++;
                 }
              }
        }

        public void MostrarResultados()
        {
             MessageBox.Show("Respuestas correctas :" + RespuestasCorrectas + " y tiene " + RespuestasIncorrectas + " respuestas incorrectas");
        }

        public int getRespuestasCorrectas()
        {
            return this.RespuestasCorrectas;
        }

        public int getRespuestasIncorrectas()
        {
            return this.RespuestasIncorrectas;
        }

    }

}
