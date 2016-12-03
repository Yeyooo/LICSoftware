using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    public class Asset_Slot : Control
    {
        private TableLayoutPanel tabla_Alternativas;
        private Label enunciado;
        private Button Imagen;
        private Button Sonido;

        public Asset_Slot(Asset asset)
        {
            /*CREAR LA TABLA CON 1 COLUMNA Y 3 ALTERNATIVAS
            AUTOSCROLL VERDADERO Y LA TABLA DEBE TENER LOS SIGUIENTES ATRIBUTOS
            71F para el enunciado
            270F para las alternativas
            10F para los 2 botones si es necesario imagen y sonido
            this.tableLayout_Evaluacion.Controls.Add(this.tableLayout_pregunta1, 0, 1);
            @param Control, columna, fila            
             */

        }

    }

    public class Alternativas_Slots : Control{
        private TableLayoutPanel panelAlternativas { get; set; }
        private List<String> alternativasAux;
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
            foreach (String alternativa in alternativasAux)
            {
                RadioButton alternativaButton = new RadioButton();
                BotonesAlternativas.Add(alternativaButton);
            }
            
        }

    }
}
