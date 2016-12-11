using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class EvaluacionNOGUI
    {
        public List<Asset> PreguntasWriting;
        public List<Asset> PreguntasReading;
        public List<Asset> PreguntasListening;

        public EvaluacionNOGUI(PlanDeEstudio PDE) // por defecto carga 10, 10 y 10
        {
            int contador = 1;
            while (contador <= 30) // 30 es el limite
            {
                this.PreguntasWriting.Add(PDE.getDicWriting()[contador]);
                this.PreguntasReading.Add(PDE.getDicReading()[contador]);
                this.PreguntasListening.Add(PDE.getDicListening()[contador]);
            }

        }

    }
}
