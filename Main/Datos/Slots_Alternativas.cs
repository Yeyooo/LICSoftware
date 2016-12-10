using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class Slots_Alternativas : RadioButton
    {
        private int id;
        private int NivelDificultad;
        private string RespuestaCorrecta_Escritura;
        private string Habilidad;

        public Slots_Alternativas(string Alternativa, Asset asset, List<Alternativa> alternativasAux)
        {
            this.Text = Alternativa;
            this.id = asset.getId();
            this.Habilidad = asset.getHabilidadAsociada();
            this.NivelDificultad = asset.getNivelHabilidad();
            this.Dock = DockStyle.Fill;
            this.RespuestaCorrecta_Escritura = alternativasAux[asset.getRespuestaCorrecta()].getTxtAlternativa();
        }

        public bool esCorrecta()
        {
            if (this.Text == RespuestaCorrecta_Escritura)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    public class Alternativas_Slots
    {
        private List<Alternativa> alternativasAux;

        public Alternativas_Slots(Asset asset, TableLayoutPanel panel)
        {
            //Obtener la lista de Alternativas
            alternativasAux = asset.getAlternativas();
            foreach (Alternativa alternativa in alternativasAux)
            {
                panel.Controls.Add(new Slots_Alternativas(alternativa.getTxtAlternativa(), asset,alternativasAux));
            }
        }

    }

}

