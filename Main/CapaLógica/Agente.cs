using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Percepciones = System.Collections.Generic.List<string>;

namespace CapaLógica
{
    public class Agente
    {
        private static BaseDeConocimientos KB = new BaseDeConocimientos(Environment.CurrentDirectory + "/kb.csv", Environment.CurrentDirectory + "/kb_consec.csv");
        private static MotorInferencia Motor = new MotorInferencia();

        public Agente() { }

        public static string agente(Percepciones percepciones)
        {
            BaseDeHechos BH = new BaseDeHechos();
            BH.hechos = percepciones;

            if (percepciones[0] == "writing" && percepciones[1] == "1" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "mantener";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "2" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "bajar";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "3" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "bajar";
            }

            if (percepciones[0] == "reading" && percepciones[1] == "1" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "mantener";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "2" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "bajar";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "3" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "bajar";
            }

            if (percepciones[0] == "listening" && percepciones[1] == "1" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "mantener";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "2" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "bajar";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "3" && percepciones[2] == "correctas menor 30" && percepciones[3] == "mayor o igual 0")
            {
                return "bajar";
            }
            //--------------------------------------------------------------------------
            if (percepciones[0] == "writing" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "mantener";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "transicion bajada";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "transicion bajada";
            }

            if (percepciones[0] == "reading" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "mantener";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "transicion bajada";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "transicion bajada";
            }

            if (percepciones[0] == "listening" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "mantener";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "transicion bajada";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 30" && percepciones[3] == "correctas menor 50")
            {
                return "transicion bajada";
            }
            //-------------------------------------------------------------
            if (percepciones[0] == "writing" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 50" && percepciones[3] == "correctas menor 70")
            {
                return "mantener";
            }

            //-----------------------------------------------------------------

            if (percepciones[0] == "writing" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 70" && percepciones[3] == "correctas menor 90")
            {
                return "transicion subida";
            }

            //--------------------------------------------------------------------

            if (percepciones[0] == "writing" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }
            if (percepciones[0] == "writing" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }
            if (percepciones[0] == "reading" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "1" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "2" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }
            if (percepciones[0] == "listening" && percepciones[1] == "3" && percepciones[2] == "correctas mayor o igual 90" && percepciones[3] == "menor o igual 100")
            {
                return "subir";
            }

            return null;

        }
    }

}
