using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Asset
    {
        public int Id;
        public string EnunciadoPregunta;
        public int RespuestaCorrecta;
        public List<Alternativa> Alternativas;
        public string HabilidadAsociada;
        public int NivelHabilidad;
        public string EstrategiaEnseñanza;
        public string Teoria;
        public string UrlArchivo = null; // url inicializada en null, el asset puede tener audio o imagen
        public bool Salio = false;


        public Asset() { }

        public Asset(int pId, string pEnunciado, int pRespuesta, List<Alternativa> pAlternativas, string pHabilidad, int pNivelHabilidad, string pEstrategia, string pTeoria)

        {
            this.Id = pId;
            this.EnunciadoPregunta = pEnunciado;
            this.RespuestaCorrecta = pRespuesta;
            this.Alternativas = pAlternativas;
            this.HabilidadAsociada = pHabilidad;
            this.NivelHabilidad = pNivelHabilidad;
            this.EstrategiaEnseñanza = pEstrategia;
            this.Teoria = pTeoria;
        }

        public Asset(int pId, string pEnunciado, int pRespuesta, List<Alternativa> pAlternativas, string pHabilidad, int pNivelHabilidad, string pEstrategia, string pTeoria, string pUrlArchivo)

        {
            this.Id = pId;
            this.EnunciadoPregunta = pEnunciado;
            this.RespuestaCorrecta = pRespuesta;
            this.Alternativas = pAlternativas;
            this.HabilidadAsociada = pHabilidad;
            this.NivelHabilidad = pNivelHabilidad;
            this.EstrategiaEnseñanza = pEstrategia;
            this.Teoria = pTeoria;
            this.UrlArchivo = pUrlArchivo;
        }

        public int getId()
        {
            return this.Id;
        }

        public string getEnunciadoPregunta()
        {
            return this.EnunciadoPregunta;
        }

        public int getRespuestaCorrecta() // devuelve el indice de la alternativa correcta de la lista de alternativas
        {
            int contador = 0;
            foreach(Alternativa tmp in this.Alternativas)
            {
                if (this.RespuestaCorrecta == tmp.IdAlternativa)
                {
                    return contador;
                }
                contador++;
            }
            return -1;
        }

        public List<Alternativa> getAlternativas()
        {
            return this.Alternativas;
        }

        public int getNroAlternativas()
        {
            return this.Alternativas.Count;
        }

        public string getHabilidadAsociada()
        {
            return this.HabilidadAsociada;
        }

        public int getNivelHabilidad()
        {
            return this.NivelHabilidad;
        }

        public string getEstrategiaEnseñanza()
        {
            return this.EstrategiaEnseñanza;
        }

        public string getTeoria()
        {
            return this.Teoria;
        }

        public string getUrlArchivo()
        {
            return this.UrlArchivo;
        }

        public bool isListening()
        {
            if (this.HabilidadAsociada == "listening")
                return true;
            else
                return false;
        }

        public bool isWriting()
        {
            if (this.HabilidadAsociada == "writing")
                return true;
            else
                return false;
        }

        public bool isReading()
        {
            if (this.HabilidadAsociada == "reading")
                return true;
            else
                return false;
        }

        public bool salio()
        {
            return this.Salio;
        }

        public void setSalio(bool salio)
        {
            this.Salio = salio;
        }



    }
}
