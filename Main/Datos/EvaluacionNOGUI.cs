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
                this.PreguntasWriting = EvaluacionPorHabilidad(PDE.getDicWriting());
                this.PreguntasReading = EvaluacionPorHabilidad(PDE.getDicReading());
                this.PreguntasListening = EvaluacionPorHabilidad(PDE.getDicListening());
            }
        }

        public static List<Asset> EvaluacionPorHabilidad( Dictionary<int, Asset> diccionarioHabilidad ) // 10 solamente, de una habilidad
        {
            List<Asset> Evaluacion = new List<Asset>();

            List<int> IdsCjto = new List<int>();

            for (int i = 0; i < diccionarioHabilidad.Count; i++) {

                IdsCjto = AssetDAL.TodosLosIdDeLasPreguntasDeUnConjunto(diccionarioHabilidad[i].getId()); // para la pregunta que encuentra, busca todos los assets asociados al mismo conjunto de esa pregunta
                for (int j = 0; j < IdsCjto.Count; j++)
                {
                    foreach (KeyValuePair<int, Asset> tmp in diccionarioHabilidad)
                    {
                        if (IdsCjto[j] == tmp.Value.getId() && tmp.Value.salio() == false) // no lo hayamos tomado nunca
                        {
                            Evaluacion.Add(tmp.Value);
                            tmp.Value.setSalio(true); // lo marcamos como que ya salio
                            if (Evaluacion.Count == 10)
                            {
                                return Evaluacion;
                            }
                        }
                    }

                }

>>>>>>> refs/remotes/origin/master
            }

            return null;

        }

        public List<Asset> getPreguntasWriting()
        {
            return this.PreguntasWriting;
        }

        public List<Asset> getPreguntasReading()
        {
            return this.PreguntasReading;
        }

        public List<Asset> getPreguntasListening()
        {
            return this.PreguntasListening;
        }

    }
}
