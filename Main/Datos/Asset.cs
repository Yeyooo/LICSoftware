using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Asset
    {
        public int Id { get; set; }
        public string EnunciadoPregunta { get; set; }
        public string RespuestaCorrecta { get; set; }
        public List<string> Alternativas { get; set; } // siempre sera de tipo string, ya que si bien pueden ser imagenes, estas son urls
        public string HabilidadAsociada { get; set; }
        public string NivelHabilidad { get; set; }
        public string EstrategiaEnseñanza { get; set; }
        public string Teoria { get; set; }
        public int CantidadAlternativas { get; set; } //Cantidad de alternativas que hay

        public Asset() { }

        public Asset(int pId, string pEnunciado, string pRespuesta, List<string> pAlternativas, string pHabilidad, string pNivelHabilidad, string pEstrategia, string pTeoria)

        {
            this.Id = pId;
            this.EnunciadoPregunta = pEnunciado;
            this.RespuestaCorrecta = pRespuesta;
            this.Alternativas = pAlternativas;
            this.HabilidadAsociada = pHabilidad;
            this.NivelHabilidad = pNivelHabilidad;
            this.EstrategiaEnseñanza = pEstrategia;
            this.Teoria = pTeoria;
            this.CantidadAlternativas = Alternativas.Count();
        }

    }
}
