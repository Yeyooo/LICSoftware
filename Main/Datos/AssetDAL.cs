using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    public class AssetDAL
    {
        public AssetDAL()
        {

        }

        public static string BuscarUrlDeUnAsset(int pIdPregunta) // Devuelve la URL de un Asset
        {
            SqlCommand _comando = new SqlCommand(String.Format("SELECT url from urls, pregunta WHERE urls.idpregunta = pregunta.idpregunta and pregunta.idpregunta = " + pIdPregunta + ";"), Conexión.obtenerConexion("contenido"));
            SqlDataReader _reader = _comando.ExecuteReader();

            //string UrlTmp = "";

            while (_reader.Read())
            {
                return _reader.GetString(0); // retorna la URL asociada al Asset
            }

            return null;

        }

        // el metodo funciona correctamente. 100% comprobado
        public static List<Alternativa> BuscarTodasLasAlternativasDeUnAsset(int pIdPregunta) // todas las alternativas asociada a una pregunta
        {
            SqlCommand _comando = new SqlCommand(String.Format("SELECT alternativa, idalternativa from alternativas, pregunta where alternativas.idpregunta = pregunta.idpregunta and pregunta.idpregunta = "+pIdPregunta+";"), Conexión.obtenerConexion("contenido"));
            SqlDataReader _reader = _comando.ExecuteReader();

            List<Alternativa> tmp = new List<Alternativa>();

            while ( _reader.Read() )
            {
                tmp.Add( new Alternativa( _reader.GetInt32(1), _reader.GetString(0)));
            }

            return tmp;

        }

        //obtener la teoria asociada a la alternativa correcta
        // funciona, 100% comprobado
        public static string getTeoriaAssetBD(int idAlternativaCorrecta)
        {
            string consulta = "select teoria from alternativa_correcta, alternativas where alternativa_correcta.idalternativa = alternativas.idalternativa and alternativa_correcta.idalternativa = "+idAlternativaCorrecta+";";
            // metodologia tiene que ir en la pregunta...BD
            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conexión.obtenerConexion("contenido"));
            SqlDataReader _reader = _comando.ExecuteReader();

            string tmp = "";

            while ( _reader.Read() )
            {
                tmp = _reader.GetString(0);
            }

            return tmp;

        }

        public static List<Asset> BuscarPorNivelHabilidad(int pNivelHabilidad, string pHabilidadAsociada) // queremos todos los assets disponibles para el usuario 
        {                                                                                                    // de acuerdo a sus habilidades
            List<Asset> _lista = new List<Asset>();
            string consulta = "SELECT DISTINCT pregunta.idpregunta, enunciado, habilidad, nivel, metodologia, alternativa_correcta.idalternativa FROM pregunta, alternativas, alternativa_correcta WHERE alternativa_correcta.idalternativa = alternativas.idalternativa and alternativas.idpregunta = pregunta.idpregunta and habilidad = '"+pHabilidadAsociada+"' and nivel = "+pNivelHabilidad+";";
            // metodologia tiene que ir en la pregunta...BD
            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conexión.obtenerConexion("contenido"));
            SqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Asset pAsset = new Asset();
                pAsset.Id = _reader.GetInt32(0);
                pAsset.EnunciadoPregunta = _reader.GetString(1);
                pAsset.Alternativas = AssetDAL.BuscarTodasLasAlternativasDeUnAsset(_reader.GetInt32(0));
                pAsset.HabilidadAsociada = _reader.GetString(2);
                pAsset.NivelHabilidad = _reader.GetInt32(3);
                pAsset.EstrategiaEnseñanza = _reader.GetString(4);
                pAsset.RespuestaCorrecta = _reader.GetInt32(5);
                pAsset.Teoria = AssetDAL.getTeoriaAssetBD(_reader.GetInt32(5));

                _lista.Add(pAsset);
            }

            return _lista;
        }

        public static void BuscarPorNivelHabilidadOpt(Dictionary<int, Asset> dicACargar, int pNivelHabilidad, string pHabilidadAsociada) // queremos todos los assets disponibles para el usuario 
        {                                                                                                    // de acuerdo a sus habilidades
            string consulta = "SELECT DISTINCT pregunta.idpregunta, enunciado, habilidad, nivel, metodologia, alternativa_correcta.idalternativa FROM pregunta, alternativas, alternativa_correcta WHERE alternativa_correcta.idalternativa = alternativas.idalternativa and alternativas.idpregunta = pregunta.idpregunta and habilidad = '" + pHabilidadAsociada + "' and nivel = " + pNivelHabilidad + ";";
            // metodologia tiene que ir en la pregunta...BD
            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conexión.obtenerConexion("contenido"));
            SqlDataReader _reader = _comando.ExecuteReader();

            int indice = 1;
            while (_reader.Read())
            {
                Asset pAsset = new Asset();
                pAsset.Id = _reader.GetInt32(0);
                pAsset.EnunciadoPregunta = _reader.GetString(1);
                pAsset.Alternativas = AssetDAL.BuscarTodasLasAlternativasDeUnAsset(_reader.GetInt32(0));
                pAsset.HabilidadAsociada = _reader.GetString(2);
                pAsset.NivelHabilidad = _reader.GetInt32(3);
                pAsset.EstrategiaEnseñanza = _reader.GetString(4);
                pAsset.RespuestaCorrecta = _reader.GetInt32(5);
                pAsset.Teoria = AssetDAL.getTeoriaAssetBD(_reader.GetInt32(5));
                pAsset.UrlArchivo = AssetDAL.BuscarUrlDeUnAsset(pAsset.Id);
                
                dicACargar[indice] = pAsset;
                indice++;
                //_lista.Add(pAsset);
            }

        }

       
    }
}
