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
            PlanDeEstudio PE = new PlanDeEstudio(3, 3, 1);

            Dictionary<int, Asset> dic = PE.getDicListening();

            //List<int> IdPreguntasConjunto;
            //foreach (KeyValuePair<int, Asset> tmp in dic) // obtienes los id del conjunto de preguntas
            //{
            //    IdPreguntasConjunto = AssetDAL.TodosLosIdDeLasPreguntasDeUnConjunto(tmp.Value.Id);
            //    for (int i = 0; i < IdPreguntasConjunto.Count; i++)
            //    {
            //        Console.WriteLine("IdPregunta: " + IdPreguntasConjunto[i]);
            //    }
            //}

            ////List<Asset> ev = EvaluacionNOGUI.EvaluacionPorHabilidadTEST(dic);

            ////Usuario user = new Usuario("burro@test.cl");
            ////PlanDeEstudio x = user.getPlanDeEstudio();
            ////Dictionary<int, Asset> dicc = x.getDicListening();
            ////Console.WriteLine("count: "+dicc.Count);
            ////List<Asset> tmp = EvaluacionNOGUI.EvaluacionPorHabilidadTEST(dicc);

            ////if (tmp == null)
            ////{
            ////    Console.WriteLine("null");
            ////}
            ////else
            ////{
            ////    for (int i = 0; i < tmp.Count; i++)
            ////    {
            ////        Console.WriteLine();
            ////        Console.WriteLine("VALOR : " + tmp[i].Id);
            ////    }
            ////}

            ////Application.Run(new EvaluacionEnfocada("Listening", tmp));


        }
    }
}
