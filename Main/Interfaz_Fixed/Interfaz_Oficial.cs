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
            PlanDeEstudio PE = new Datos.PlanDeEstudio(3, 3, 2);
            Dictionary<int, Asset> dic = PE.getDicReading();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LICGUI(PE));
            //Application.Run(new Registro_GUI());
            //Application.Run(new FormInicioSesion());

            //List<string> x = new List<string>();
            //x = AssetDAL.BuscarTodasLasAlternativasDeUnAsset(4);
            //foreach (string tmp in x)
            //{
            //    Console.WriteLine(tmp);
            //}

            //System.Console.WriteLine(AssetDAL.getTeoriaAssetBD(6));

            /*List<Asset> tmp = AssetDAL.BuscarPorNivelHabilidad(2, "listening");

            foreach ( Asset x in tmp )
            {
                Console.WriteLine("Id: "+x.getId());
                Console.WriteLine("Enunciad: "+x.getEnunciadoPregunta());
                Console.WriteLine("Metodologia: "+x.getEstrategiaEnseñanza());
                Console.WriteLine("Habilidad: "+x.getHabilidadAsociada());
                Console.WriteLine("Nivel: "+x.getNivelHabilidad());
                Console.WriteLine("Teoria: "+x.getTeoria());
                Console.WriteLine("Indice de la respuesta correcta en la alternativas: "+x.getRespuestaCorrecta());
                List<Alternativa> alts = x.getAlternativas();
                Console.WriteLine("Las alternativa correcta es:"+ x.Alternativas[x.getRespuestaCorrecta()].getTxtAlternativa());
                foreach ( Alternativa read in alts )
                {
                    Console.WriteLine("id alt: "+read.getIdAlternativa()+"  ,  alternativa: "+read.getTxtAlternativa());
                    Console.WriteLine();
                }
            }*/

            //Console.WriteLine("!!!!!!!!!!! AHORA DIC WRITING:");

            foreach(KeyValuePair<int, Asset> tmpr in dic)
            {
                Console.WriteLine("Id: " + tmpr.Value.getId());
                Console.WriteLine("Enunciad: " + tmpr.Value.getEnunciadoPregunta());
                Console.WriteLine("Metodologia: " + tmpr.Value.getEstrategiaEnseñanza());
                Console.WriteLine("Habilidad: " + tmpr.Value.getHabilidadAsociada());
                Console.WriteLine("Nivel: " + tmpr.Value.getNivelHabilidad());
                Console.WriteLine("Teoria: " + tmpr.Value.getTeoria());
                Console.WriteLine("Indice de la respuesta correcta en la alternativas: " + tmpr.Value.getRespuestaCorrecta());
                List<Alternativa> alts = tmpr.Value.getAlternativas();
                Console.WriteLine("Las alternativa correcta es:" + tmpr.Value.Alternativas[tmpr.Value.getRespuestaCorrecta()].getTxtAlternativa());
                foreach (Alternativa read in alts)
                {
                    Console.WriteLine("id alt: " + read.getIdAlternativa() + "  ,  alternativa: " + read.getTxtAlternativa());
                    Console.WriteLine();
                }
            }

        }
    }
}
