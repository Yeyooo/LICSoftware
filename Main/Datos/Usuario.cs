﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public string Nombre;
        public string Correo;
        public string Password;
        public int NivelWriting;
        public int NivelReading;
        public int NivelListening;
        public bool HizoAutoevaluacion;
        public PlanDeEstudio PDE;

        public Usuario() { }

        public Usuario(string pCorreoIngresado)
        {
            List<string> tmp = UsuarioDAL.datosUsuario(pCorreoIngresado);

            this.Nombre = tmp[0];
            this.Correo = tmp[1];
            this.Password = tmp[2];

            List<int> tmpInt = UsuarioDAL.nivelesUsuario(pCorreoIngresado);

            this.NivelWriting = tmpInt[0];
            this.NivelReading = tmpInt[1];
            this.NivelListening = tmpInt[2];

            this.PDE = new PlanDeEstudio(this.NivelWriting, this.NivelReading, this.NivelListening);
            Console.WriteLine("el usuario tiene los iguientes niveles: {0} , {1}, {2}", NivelWriting, NivelReading, NivelListening);
        }

        public Usuario( string pNombre, string pCorreo, string pPassword ) // inicializamos con los 3 niveles en 0(sin nivel) 
                                                                            // el usuario ingresa por primera vez
        {
            this.Nombre = pNombre;
            this.Correo = pCorreo;
            this.Password = pPassword;
            this.NivelWriting = 0;
            this.NivelReading = 0;
            this.NivelListening = 0;
        }

        public Usuario(string pNombre, string pCorreo, string pPassword, int pNivelWriting, int pNivelReading, int pNivelListening) // metodo sobrecargado para cargar el progreso del usuario desde la bd
        {
            this.Nombre = pNombre;
            this.Correo = pCorreo;
            this.Password = pPassword;
            this.NivelWriting = pNivelWriting;
            this.NivelReading = pNivelReading;
            this.NivelListening = pNivelListening;
        }

        public string getNombre()
        {
            return this.Nombre;
        }

        public string getCorreo()
        {
            return this.Correo;
        }

        public int getNivelWriting()
        {
            return this.NivelWriting;
        }

        public int getNivelReading()
        {
            return this.NivelReading;
        }

        public int getNivelListening()
        {
            return this.NivelListening;
        }

        public string getPassword()
        {
            return this.Password;
        }

        public bool realizo_Autoevaluacion()
        {
            if (HizoAutoevaluacion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public PlanDeEstudio getPlanDeEstudio()
        {
            return this.PDE;
        }

    }
}
