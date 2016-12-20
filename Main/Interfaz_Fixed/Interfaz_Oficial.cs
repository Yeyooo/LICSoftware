using CapaLógica;
using Datos;
using FormLogin;
using FormRegistro;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Fixed
{
    static class Interfaz_Oficial
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            BaseDeConocimientos KB = new BaseDeConocimientos("kb.csv", "kb_consec.csv");
            BaseDeHechos BH = new BaseDeHechos();
            List<string> ComportamientosEstudiante = new List<string>();
            ComportamientosEstudiante.Add("reading");
            ComportamientosEstudiante.Add("1");
            //ComportamientosEstudiante.Add("no 3");
            //ComportamientosEstudiante.Add("no 2");
            ComportamientosEstudiante.Add("correctas mayor o igual 30");
            ComportamientosEstudiante.Add("correctas menor 50");
            BH.setListaDeHechos(ComportamientosEstudiante);
            // funciona para correctar menor 30
            string h1= "descenso";
            string h2 = "ascenso";
            string h3 = "transicion sin descenso";
            string h4 = "transicion sin ascenso";
            string h5 = "mantener";
            Console.WriteLine("Se puede probar {0}?: {1}",h1,MotorInferencia.EHD(KB, BH, h1));
            Console.WriteLine("Se puede probar {0}?: {1}", h2, MotorInferencia.EHD(KB, BH, h2));
            Console.WriteLine("Se puede probar {0}?: {1}", h3, MotorInferencia.EHD(KB, BH, h3));
            Console.WriteLine("Se puede probar {0}?: {1}", h4, MotorInferencia.EHD(KB, BH, h4));
            Console.WriteLine("Se puede probar {0}?: {1}", h5, MotorInferencia.EHD(KB, BH, h5));

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormInicioSesion());

            /*PlanDeEstudio PE = new PlanDeEstudio(3, 3, 1);
=======
>>>>>>> origin/master


            List<int> IdPreguntasConjunto;
            foreach (KeyValuePair<int, Asset> tmp in dic) // obtienes los id del conjunto de preguntas
            {
                IdPreguntasConjunto = AssetDAL.TodosLosIdDeLasPreguntasDeUnConjunto(tmp.Value.Id);
                for (int i = 0; i < IdPreguntasConjunto.Count; i++)
                {
                    Console.WriteLine("IdPregunta: " + IdPreguntasConjunto[i]);
                }
            }

<<<<<<< HEAD
            List<Asset> ev = EvaluacionNOGUI.EvaluacionPorHabilidadTEST(dic);

            Usuario user = new Usuario("burro@test.cl");
            PlanDeEstudio x = user.getPlanDeEstudio();
            Dictionary<int, Asset> dicc = x.getDicListening();
            Console.WriteLine("count: "+dicc.Count);
            List<Asset> tmp2 = EvaluacionNOGUI.EvaluacionPorHabilidadTEST(dicc);
=======
            ////Usuario user = new Usuario("burro@test.cl");
            ////PlanDeEstudio x = user.getPlanDeEstudio();
            ////Dictionary<int, Asset> dicc = x.getDicListening();
            ////Console.WriteLine("count: " + dicc.Count);
            ////List<Asset> tmp = EvaluacionNOGUI.EvaluacionPorHabilidadTEST(dicc);
>>>>>>> origin/master

            if (tmp2 == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                for (int i = 0; i < tmp2.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("VALOR : " + tmp2[i].Id);
                }
            }

            Application.Run(new EvaluacionEnfocada("Listening", tmp2));
            */

        }
    }
}
