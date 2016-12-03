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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LICGUI());
            //Application.Run(new Registro_GUI());
            //Application.Run(new FormInicioSesion());

            //List<string> x = new List<string>();
            //x = AssetDAL.BuscarTodasLasAlternativasDeUnAsset(4);
            //foreach (string tmp in x)
            //{
            //    Console.WriteLine(tmp);
            //}

            //System.Console.WriteLine(AssetDAL.getTeoriaAssetBD(6));

            List<Asset> tmp = AssetDAL.BuscarPorNivelHabilidad(2, "listening");

            foreach ( Asset x in tmp )
            {
                Console.WriteLine(x.getEnunciadoPregunta());
                Console.WriteLine(x.getEstrategiaEnseñanza());
                Console.WriteLine(x.getHabilidadAsociada());
                Console.WriteLine(x.getNivelHabilidad());
                Console.WriteLine(x.getTeoria());
                Console.WriteLine(x.getRespuestaCorrecta());
                List<string> alts = x.getAlternativas();
                Console.WriteLine("Las alternativa correcta es:"+ alts[x.getRespuestaCorrecta()/alts.Count]);
                int contador = 0;
                foreach ( string read in alts )
                {
                    Console.WriteLine(read);
                    Console.WriteLine();
                    contador++;
                }
            }




        }
    }
}
