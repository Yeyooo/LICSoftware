using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class PlanDeEstudio
    {
        Dictionary<int, Asset> dicWriting { get; set; }
        Dictionary<int, Asset> dicReading { get; set; }
        Dictionary<int, Asset> dicListening { get; set; }

        public PlanDeEstudio() {  }

        public PlanDeEstudio(List<Asset> resultadoConsultaWriting, List<Asset> resultadoConsultaReading, List<Asset> resultadoConsultaListening) // ineficiente, mejor tirar directamente a la función que hace la consulta
                                                                                                                                      // para ahorrar el coste de recorrer denuevo.
        {
            foreach (Asset tmpA in resultadoConsultaWriting)
            {
                this.dicWriting[tmpA.Id] = tmpA;
            }
            foreach (Asset tmpA in resultadoConsultaReading)
            {
                this.dicReading[tmpA.Id] = tmpA;
            }
            foreach (Asset tmpA in resultadoConsultaListening)
            {
                this.dicListening[tmpA.Id] = tmpA;
            }
        }

    }
}
