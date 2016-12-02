using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class PlanDeEstudio
    {
        Dictionary<int, Asset> DicWriting;
        Dictionary<int, Asset> DicReading;
        Dictionary<int, Asset> DicListening;

        public PlanDeEstudio() {  }

        public PlanDeEstudio(List<Asset> resultadoConsultaWriting, List<Asset> resultadoConsultaReading, List<Asset> resultadoConsultaListening) // ineficiente, mejor tirar directamente a la función que hace la consulta
                                                                                                                                      // para ahorrar el coste de recorrer denuevo.
        {
            foreach (Asset tmpA in resultadoConsultaWriting)
            {
                this.DicWriting[tmpA.Id] = tmpA;
            }
            foreach (Asset tmpA in resultadoConsultaReading)
            {
                this.DicReading[tmpA.Id] = tmpA;
            }
            foreach (Asset tmpA in resultadoConsultaListening)
            {
                this.DicListening[tmpA.Id] = tmpA;
            }
        }

        public Dictionary<int, Asset> getDicWriting()
        {
            return this.DicWriting;
        }

        public Dictionary<int, Asset> getDicReading()
        {
            return this.DicReading;
        }

        public Dictionary<int, Asset> getDicListening()
        {
            return this.DicListening;
        }

    }
}
