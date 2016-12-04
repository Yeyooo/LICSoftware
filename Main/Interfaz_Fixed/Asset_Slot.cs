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

        private TableLayoutPanel panelAlternativas { get; set; }
        private List<Alternativa> alternativasAux;
        private List<RadioButton> BotonesAlternativas { get; set; }

        public Alternativas_Slots(Asset asset)
        {
            /*CREAR LA TABLA CON 1 COLUMNA Y 3 ALTERNATIVAS
            AUTOSCROLL VERDADERO Y LA TABLA DEBE TENER LOS SIGUIENTES ATRIBUTOS
            la altura sera 270 y sera autosize creo yo
            DEjar anotado que al clickear un radio button todos los radio buttons deberan deseleccionarse
             */
            panelAlternativas = new TableLayoutPanel();
            panelAlternativas.SuspendLayout();
            //Obtener la lista de Alternativas
            alternativasAux = asset.getAlternativas();
            //Asignar las ROWS Y LAS PROPIEDADES DE ESTAS
            panelAlternativas.RowCount = alternativasAux.Count;
            for (int i = 0; i<alternativasAux.Count;i++) {
                panelAlternativas.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
            //Personalizar Columnas
            panelAlternativas.ColumnCount = 1;
            panelAlternativas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            //--Fin personalziacion Columnas
            panelAlternativas.AutoScroll = true;
            foreach (Alternativa alternativa in alternativasAux)
            {
                RadioButton alternativaButton = new RadioButton();
                BotonesAlternativas.Add(alternativaButton);
            }
            
        }

    }
}
