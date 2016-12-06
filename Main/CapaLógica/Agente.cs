using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Percepciones = System.Collections.Generic.List<string>;
using Accion = System.Object;

namespace CapaLógica
{
    public class Agente
    {
        private static BaseDeConocimientos KB = new BaseDeConocimientos(Environment.CurrentDirectory + "/kb.csv", Environment.CurrentDirectory + "/kb_consec.csv");
        private static MotorInferencia Motor = new MotorInferencia();

        public Agente() { }

        public static Accion agente(Percepciones percepciones)
        {
            BaseDeHechos BH = new BaseDeHechos();
            BH.hechos = percepciones;

            if (MotorInferencia.EHD(Agente.KB,BH, "a") && !percepciones.Contains("a")) // el hecho a probar no puede ser parte de las percepciones
            {                                                                           // ya que seria hecho directamente
                return "a";
            }

            if (MotorInferencia.EHD(Agente.KB, BH, "b") && !percepciones.Contains("b"))
            {
                return "b";
            }
            if (MotorInferencia.EHD(Agente.KB, BH, "c") && !percepciones.Contains("c"))
            {
                return "c";
            }
            if (MotorInferencia.EHD(Agente.KB, BH, "d") && !percepciones.Contains("d"))
            {
                return "d";
            }
            if (MotorInferencia.EHD(Agente.KB, BH, "e") && !percepciones.Contains("e"))
            {
                return "e";
            }
            if (MotorInferencia.EHD(Agente.KB, BH, "f") && !percepciones.Contains("f"))
            {
                return "f";
            }
            if (MotorInferencia.EHD(Agente.KB, BH, "g") && !percepciones.Contains("g"))
            {
                return "g";
            }
            if (MotorInferencia.EHD(Agente.KB, BH, "h") && !percepciones.Contains("h"))
            {
                return "h";
            }

            return null;
        }
    }

}
