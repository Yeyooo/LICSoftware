using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Paquete
    {
        private int Correctas, Incorrectas; //Cantidad Total de buenas
        private string HabilidadAsociada, NivelDificultad;
        public Paquete()
        {

        }

        private string getHabilidad_Paquete()
        {
            return HabilidadAsociada;
        }
        
        private string getDificultad_Paquete()
        {
            return NivelDificultad;
        }

        public int getCorrectas()
        {
            return Correctas;
        }

        public int getIncorrectas()
        {
            return Incorrectas;
        }
    }
    class AssetEvaluado
    {
        Paquete paqueteListening, paqueteWriting, paqueteReading;
        public AssetEvaluado()
        {

        }


        //Es la correcta
        public bool Evaluar()
        {
            return false;
        }

        public void Agrupar()
        {

        }

    }
}
