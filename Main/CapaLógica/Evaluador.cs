using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaLógica
{
    class Evaluador
    {
        private List<RadioButton> listaButton;
        
        public Evaluador()
        {
            listaButton = new List<RadioButton>();
        }

        public void recorrerPreguntas(TableLayoutPanel panel)
        {
            for (int i = 0; i < 4; i++)
            {
                RadioButton radioButton = panel.GetControlFromPosition(0, i) as RadioButton;
                listaButton.Add(radioButton);
            }
            foreach (RadioButton radioButton)
            {

            }
        }

    }
}
