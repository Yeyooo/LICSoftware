using Datos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaLógica
{
    //UNA INSTANCIACION DE EVALUADOR POR CADA EVALUACION
    public class EvaluadorPruebasEspecificas
    {
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
                listaButton.Add(radioButton);
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
            MessageBox.Show("Respuestas correctas :"+RespuestasCorrectas+" y tiene "+RespuestasIncorrectas+" respuestas incorrectas");
        }
    }
    
}
