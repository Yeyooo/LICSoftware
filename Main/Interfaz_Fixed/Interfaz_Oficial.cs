﻿using CapaLógica;
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
            //Application.Run(new FormInicioSesion());
            PlanDeEstudio PE = new PlanDeEstudio(3,3,2);
            Application.Run(new LICGUI(PE));
            //Application.Run(new AutoEvaluacion());
        }
    }
}
