﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PlanDeEstudio
    {
        Dictionary<int, Asset> DicWriting = new Dictionary<int, Asset>();
        Dictionary<int, Asset> DicReading = new Dictionary<int, Asset>();
        Dictionary<int, Asset> DicListening = new Dictionary<int, Asset>();

        public PlanDeEstudio() {  }

        public PlanDeEstudio(int pNivelHabilidadWriting, int pNivelHabilidadReading, int pNivelHabilidadListening)
        {
            AssetDAL.BuscarPorNivelHabilidadOpt(this.DicWriting, pNivelHabilidadWriting, "writing");
            AssetDAL.BuscarPorNivelHabilidadOpt(this.DicReading, pNivelHabilidadReading, "reading");
            AssetDAL.BuscarPorNivelHabilidadOpt(this.DicListening, pNivelHabilidadListening, "listening");
            Console.WriteLine("Cargado exitosamente...");
        }

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

        public static void setDiccionarioCompletoFalse(Dictionary<int, Asset> dic)
        {
            foreach (KeyValuePair<int, Asset> tmp in dic)
            {
                tmp.Value.setSalio(false);
            }
        }

        public static bool sePuedenGenerarParaUnaHabilidad10Preguntas(Dictionary<int, Asset> dic)
        {
            int contador = 0;
            foreach (KeyValuePair<int, Asset> tmpw in dic)
            {
                if (tmpw.Value.salio() == false)
                {
                    contador++;
                }
            }
            if (contador >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool sePuedenGenerarParaTodasLasHabilidades10Preguntas(PlanDeEstudio PDE)
        {

            if ( sePuedenGenerarParaUnaHabilidad10Preguntas(PDE.getDicWriting()) == true && sePuedenGenerarParaUnaHabilidad10Preguntas(PDE.getDicReading()) == true && sePuedenGenerarParaUnaHabilidad10Preguntas(PDE.getDicListening()) == true )
            {
                return true;
            }else
            {
                return false;
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
