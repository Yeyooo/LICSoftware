using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    
    public class Enunciado_Assets : Control
    {
        private Label enunciado;

        public Enunciado_Assets(Asset asset)
        {
            enunciado.Text = asset.getEnunciadoPregunta();
        }

    }

    public class Alternativas_Slots : Control{
        
        private List<Alternativa> alternativasAux;
    
        public Alternativas_Slots(Asset asset, TableLayoutPanel panel)
        {
            //Obtener la lista de Alternativas
            alternativasAux = asset.getAlternativas();
            foreach (Alternativa alternativa in alternativasAux)
            {
                RadioButton alternativaButton = new RadioButton();
                alternativaButton.Text =  alternativa.getTxtAlternativa();
                alternativaButton.Dock = DockStyle.Fill;
                panel.Controls.Add(alternativaButton);
            }
        }

    }
}
