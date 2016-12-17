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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicioSesion());
<<<<<<< HEAD
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
