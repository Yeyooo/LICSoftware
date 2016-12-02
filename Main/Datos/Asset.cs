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
        public string RespuestaCorrecta;
        public List<string> Alternativas; // siempre sera de tipo string, ya que si bien pueden ser imagenes, estas son urls
        public string HabilidadAsociada;
        public int NivelHabilidad;
        public string EstrategiaEnseñanza;
        public string Teoria;
        public string UrlArchivo = null; // url inicializada en null, el asset puede tener audio o imagen


        public Asset() { }

        public Asset(int pId, string pEnunciado, string pRespuesta, List<string> pAlternativas, string pHabilidad, int pNivelHabilidad, string pEstrategia, string pTeoria)

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

        public Asset(int pId, string pEnunciado, string pRespuesta, List<string> pAlternativas, string pHabilidad, int pNivelHabilidad, string pEstrategia, string pTeoria, string pUrlArchivo)

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

        public string getRespuestaCorrecta()
        {
            return this.RespuestaCorrecta;
        }

        public List<string> getAlternativas()
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

    }
}
