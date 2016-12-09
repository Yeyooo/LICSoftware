using Datos;
using System.Collections.Generic;
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

    public class Alternativas_Slots {
        
        private List<Alternativa> alternativasAux;
    
        public Alternativas_Slots(Asset asset, TableLayoutPanel panel)
        {
            //Obtener la lista de Alternativas
            alternativasAux = asset.getAlternativas();
            foreach (Alternativa alternativa in alternativasAux)
            {
                panel.Controls.Add(new NuevoRadio_Button(alternativa.getTxtAlternativa(), asset));
            }
        }

    }

    public class NuevoRadio_Button : RadioButton
    {
        private int id;
        private string RespuestaCorrecta { get; set; }
        public NuevoRadio_Button(string alternativa, Asset asset)
        {
            this.Text = alternativa;
            this.id = asset.getId();
            this.Dock = DockStyle.Fill;
        }
        bool esCorrecta()
        {
            if (RespuestaCorrecta.CompareTo(this.Text)==0)
            {
                return true;
            }
            else{
                return false;
            }
        }


    }
}
