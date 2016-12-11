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
            bool flag = false;
            while (flag == false) {
                this.PreguntasWriting = EvaluacionPorHabilidad(PDE.getDicWriting());
                this.PreguntasReading = EvaluacionPorHabilidad(PDE.getDicReading());
                this.PreguntasListening = EvaluacionPorHabilidad(PDE.getDicListening());
                if(this.getPreguntasWriting() == null)
                {
                    PDE.setDiccionarioCompletoFalse(PDE.getDicWriting());//poner todo el diccionario en false
                }
                if (this.getPreguntasReading() == null)
                {
                    PDE.setDiccionarioCompletoFalse(PDE.getDicReading());//poner todo el diccionario en false
                }
                if (this.getPreguntasListening() == null)
                {
                    PDE.setDiccionarioCompletoFalse(PDE.getDicListening());//poner todo el diccionario en false
                }
                else // si ya no entra a niuna condicion, se puede salir del while
                {
                    flag = true;
                }
            }

        }

        public EvaluacionNOGUI(PlanDeEstudio PDE, string estadoWriting, string estadoReading, string estadoListening)
        {                       // estado de las habilidades : transicion subida, transicion bajada, mantener
            bool flag = false;
            while (flag == false)
            {
                if (estadoWriting == "transicion subida")
                {
                    this.PreguntasWriting = EvaluacionNOGUI.EvaluacionPorHabilidadTransicionSubida(PDE.getDicWriting());
                }
                else if (estadoWriting == "transicion bajada")
                {
                    this.PreguntasWriting = EvaluacionNOGUI.EvaluacionPorHabilidadTransicionBajada(PDE.getDicWriting());
                }
                else
                {// mantener
                    this.PreguntasWriting = EvaluacionNOGUI.EvaluacionPorHabilidad(PDE.getDicWriting());
                }

                if (estadoReading == "transicion subida")
                {
                    this.PreguntasReading = EvaluacionNOGUI.EvaluacionPorHabilidadTransicionSubida(PDE.getDicReading());
                }
                else if (estadoReading == "transicion bajada")
                {
                    this.PreguntasReading = EvaluacionNOGUI.EvaluacionPorHabilidadTransicionBajada(PDE.getDicReading());
                }
                else
                {// mantener
                    this.PreguntasReading = EvaluacionNOGUI.EvaluacionPorHabilidad(PDE.getDicReading());
                }

                if (estadoListening == "transicion subida")
                {
                    this.PreguntasListening = EvaluacionNOGUI.EvaluacionPorHabilidadTransicionSubida(PDE.getDicListening());
                }
                else if (estadoListening == "transicion bajada")
                {
                    this.PreguntasListening = EvaluacionNOGUI.EvaluacionPorHabilidadTransicionBajada(PDE.getDicListening());
                }
                else
                {// mantener
                    this.PreguntasListening = EvaluacionNOGUI.EvaluacionPorHabilidad(PDE.getDicListening());
                }

                if (this.getPreguntasWriting() == null)
                {
                    PDE.setDiccionarioCompletoFalse(PDE.getDicWriting());//poner todo el diccionario en false
                }
                if (this.getPreguntasReading() == null)
                {
                    PDE.setDiccionarioCompletoFalse(PDE.getDicReading());//poner todo el diccionario en false
                }
                if (this.getPreguntasListening() == null)
                {
                    PDE.setDiccionarioCompletoFalse(PDE.getDicListening());//poner todo el diccionario en false
                }
                else // si ya no entra a niuna condicion, se puede salir del while
                {
                    flag = true;
                } // si se cae, es porque los assets que sacamos directo de la BD, vienen con false ya

            }

        }

        public static List<Asset> EvaluacionPorHabilidad( Dictionary<int, Asset> diccionarioHabilidad ) // 10 solamente, de una habilidad
        {
            if (PlanDeEstudio.sePuedenGenerarParaUnaHabilidad10Preguntas(diccionarioHabilidad)) {
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

                }

                return null;
            }else
            {
                return null;
            }

        }

        public static List<Asset> EvaluacionPorHabilidadTransicionSubida(Dictionary<int, Asset> diccionarioHabilidad) // 10 solamente, de una habilidad
        {
            if (PlanDeEstudio.sePuedenGenerarParaUnaHabilidad10Preguntas(diccionarioHabilidad))
            {
                List<Asset> Evaluacion = new List<Asset>();

                List<int> IdsCjto = new List<int>();

                for (int i = 0; i < diccionarioHabilidad.Count; i++)
                {

                    IdsCjto = AssetDAL.TodosLosIdDeLasPreguntasDeUnConjunto(diccionarioHabilidad[i].getId()); // para la pregunta que encuentra, busca todos los assets asociados al mismo conjunto de esa pregunta
                    for (int j = 0; j < IdsCjto.Count; j++)
                    {
                        foreach (KeyValuePair<int, Asset> tmp in diccionarioHabilidad)
                        {
                            if (IdsCjto[j] == tmp.Value.getId() && tmp.Value.salio() == false) // no lo hayamos tomado nunca
                            {
                                Evaluacion.Add(tmp.Value);
                                tmp.Value.setSalio(true); // lo marcamos como que ya salio
                                if (Evaluacion.Count == 7)
                                {
                                    int nivel = (tmp.Value.getNivelHabilidad())+1;//Obtenemos el nivel de asset que estamos tratando
                                    string habilidad = tmp.Value.getHabilidadAsociada();
                                    List<Asset> AssetsTransicion = AssetDAL.BuscarPorNivelHabilidad(nivel, habilidad);// añadir 3 mas del siguiente nivel
                                    for (int z = 0; z < 3; z++)
                                    {
                                        Evaluacion.Add(AssetsTransicion[z]);
                                    }
                                    return Evaluacion;
                                }
                            }
                        }

                    }

                }

                return null;
            }
            else
            {
                return null;
            }

        }

        public static List<Asset> EvaluacionPorHabilidadTransicionBajada(Dictionary<int, Asset> diccionarioHabilidad) // 10 solamente, de una habilidad
        {
            if (PlanDeEstudio.sePuedenGenerarParaUnaHabilidad10Preguntas(diccionarioHabilidad))
            {
                List<Asset> Evaluacion = new List<Asset>();

                List<int> IdsCjto = new List<int>();

                for (int i = 0; i < diccionarioHabilidad.Count; i++)
                {

                    IdsCjto = AssetDAL.TodosLosIdDeLasPreguntasDeUnConjunto(diccionarioHabilidad[i].getId()); // para la pregunta que encuentra, busca todos los assets asociados al mismo conjunto de esa pregunta
                    for (int j = 0; j < IdsCjto.Count; j++)
                    {
                        foreach (KeyValuePair<int, Asset> tmp in diccionarioHabilidad)
                        {
                            if (IdsCjto[j] == tmp.Value.getId() && tmp.Value.salio() == false) // no lo hayamos tomado nunca
                            {
                                Evaluacion.Add(tmp.Value);
                                tmp.Value.setSalio(true); // lo marcamos como que ya salio
                                if (Evaluacion.Count == 7)
                                {
                                    int nivel = (tmp.Value.getNivelHabilidad()) - 1;//Obtenemos el nivel de asset que estamos tratando
                                    string habilidad = tmp.Value.getHabilidadAsociada();
                                    List<Asset> AssetsTransicion = AssetDAL.BuscarPorNivelHabilidad(nivel, habilidad);// añadir 3 mas del siguiente nivel
                                    for (int z = 0; z < 3; z++)
                                    {
                                        Evaluacion.Add(AssetsTransicion[z]);
                                    }
                                    return Evaluacion;
                                }
                            }
                        }

                    }

                }

                return null;
            }
            else
            {
                return null;
            }

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
