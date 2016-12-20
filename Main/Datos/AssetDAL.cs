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

        public static bool AssetTieneConjunto(int IdAsset) // dado el asset de un id te dice si tiene un conjunto asociado
        {

            SqlConnection Conn = Conexión.obtenerConexion("contenido");
            SqlCommand _comandoC = new SqlCommand(String.Format("SELECT conjunto FROM pregunta WHERE idpregunta = " + IdAsset + ";"), Conn);
            SqlDataReader _readerC = _comandoC.ExecuteReader();
            int conjunto = 0;
            while (_readerC.Read())
            {
                conjunto = _readerC.GetInt32(0);
            }

            SqlCommand _comando = new SqlCommand(String.Format("SELECT idpregunta FROM pregunta WHERE conjunto = " + conjunto + ";"), Conexión.obtenerConexion("contenido"));
            SqlDataReader _reader = _comando.ExecuteReader();

            List<int> IdsPreguntas = new List<int>();

            while (_reader.Read())
            {
                IdsPreguntas.Add(_reader.GetInt32(0));
            }
            if (IdsPreguntas.Count > 1)
            {
                Conn.Close();
                return true;
            }
            else
            {
                Conn.Close();
                return false;
            }
        }

        // dada una pregunta, podemos obtener todas las preguntas que esten relacionadas a ella(Conjunto de Assets)
        public static List<int> TodosLosIdDeLasPreguntasDeUnConjunto(int idpregunta) // por ejemplo, un audio que tiene 10 preguntas
        {

            SqlConnection Conn = Conexión.obtenerConexion("contenido");

            SqlCommand _comandoC = new SqlCommand(String.Format("SELECT conjunto FROM pregunta WHERE idpregunta = " + idpregunta + ";"), Conn);
            SqlDataReader _readerC = _comandoC.ExecuteReader();
            int conjunto = 0;
            while (_readerC.Read())
            {
                conjunto = _readerC.GetInt32(0);
            }

            SqlConnection Conn2 = Conexión.obtenerConexion("contenido");
            SqlCommand _comando = new SqlCommand(String.Format("SELECT idpregunta FROM pregunta WHERE conjunto = "+conjunto+";"), Conn2);
            SqlDataReader _reader = _comando.ExecuteReader();

            List<int> IdsPreguntas = new List<int>();

            while( _reader.Read() )
            {
                IdsPreguntas.Add(_reader.GetInt32(0));
            }

            Conn.Close();
            Conn2.Close();
            return IdsPreguntas;

        }

        // metodo para cargar desde disco duro evaluaciones
        public static Asset BuscarAssetPorID(int idAsset) // retorna Asset dado un ID
        {
            SqlConnection Conn = Conexión.obtenerConexion("contenido");
            string consulta = "SELECT DISTINCT pregunta.idpregunta, enunciado, habilidad, nivel, metodologia, alternativa_correcta.idalternativa FROM contenido.dbo.pregunta, contenido.dbo.alternativas, contenido.dbo.alternativa_correcta WHERE alternativa_correcta.idalternativa = alternativas.idalternativa and alternativas.idpregunta = pregunta.idpregunta and pregunta.idpregunta = " + idAsset+" ;";
            // metodologia tiene que ir en la pregunta...BD
            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conn);
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
                Conn.Close();
                return pAsset;
            }
            Conn.Close();
            return null;
        }


        //public static string BuscarUrlDeUnAsset(int pIdPregunta) // Devuelve la URL de un Asset
        //{
        //    SqlCommand _comando = new SqlCommand(String.Format("SELECT url from urls, pregunta WHERE urls.idpregunta = pregunta.idpregunta and pregunta.idpregunta = " + pIdPregunta + ";"), Conexión.obtenerConexion("contenido"));
        //    SqlDataReader _reader = _comando.ExecuteReader();

        //    //string UrlTmp = "";

        //    while (_reader.Read())
        //    {
        //        return _reader.GetString(0); // retorna la URL asociada al Asset
        //    }

        //    return null;

        //}

        // el metodo funciona correctamente. 100% comprobado
        public static List<Alternativa> BuscarTodasLasAlternativasDeUnAsset(int pIdPregunta) // todas las alternativas asociada a una pregunta
        {
            SqlConnection Conn = Conexión.obtenerConexion("contenido");
            SqlCommand _comando = new SqlCommand(String.Format("SELECT alternativa, idalternativa from alternativas, pregunta where alternativas.idpregunta = pregunta.idpregunta and pregunta.idpregunta = "+pIdPregunta+";"), Conn);
            SqlDataReader _reader = _comando.ExecuteReader();

            List<Alternativa> tmp = new List<Alternativa>();

            while ( _reader.Read() )
            {
                tmp.Add( new Alternativa( _reader.GetInt32(1), _reader.GetString(0)));
            }

            Conn.Close();
            return tmp;

        }

        //obtener la teoria asociada a la alternativa correcta
        // funciona, 100% comprobado
        public static string getTeoriaAssetBD(int idAlternativaCorrecta)
        {
            string consulta = "select teoria from alternativa_correcta, alternativas where alternativa_correcta.idalternativa = alternativas.idalternativa and alternativa_correcta.idalternativa = "+idAlternativaCorrecta+";";
            // metodologia tiene que ir en la pregunta...BD
            SqlConnection Conn = Conexión.obtenerConexion("contenido");
            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conn);
            SqlDataReader _reader = _comando.ExecuteReader();

            string tmp = "";

            while ( _reader.Read() )
            {
                tmp = _reader.GetString(0);
            }

            Conn.Close();
            return tmp;

        }

        public static List<Asset> BuscarPorNivelHabilidad(int pNivelHabilidad, string pHabilidadAsociada) // queremos todos los assets disponibles para el usuario 
        {                                                                                                    // de acuerdo a sus habilidades
            List<Asset> _lista = new List<Asset>();
            SqlConnection Conn = Conexión.obtenerConexion("contenido");
            string consulta = "SELECT DISTINCT pregunta.idpregunta, enunciado, habilidad, nivel, metodologia, alternativa_correcta.idalternativa, url FROM pregunta, alternativas, alternativa_correcta WHERE alternativa_correcta.idalternativa = alternativas.idalternativa and alternativas.idpregunta = pregunta.idpregunta and habilidad = '"+pHabilidadAsociada+"' and nivel = "+pNivelHabilidad+";";
            // metodologia tiene que ir en la pregunta...BD
            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conn);
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
                pAsset.UrlArchivo = _reader.GetString(6);

                _lista.Add(pAsset);
            }

            Conn.Close();
            return _lista;
        }

        public static void BuscarPorNivelHabilidadOpt(Dictionary<int, Asset> dicACargar, int pNivelHabilidad, string pHabilidadAsociada) // queremos todos los assets disponibles para el usuario 
        {                                                                                                    // de acuerdo a sus habilidades
            SqlConnection Conn = Conexión.obtenerConexion("contenido");
            string consulta = "SELECT DISTINCT pregunta.idpregunta, enunciado, habilidad, nivel, metodologia, alternativa_correcta.idalternativa, url FROM pregunta, alternativas, alternativa_correcta WHERE alternativa_correcta.idalternativa = alternativas.idalternativa and alternativas.idpregunta = pregunta.idpregunta and habilidad = '" + pHabilidadAsociada + "' and nivel = " + pNivelHabilidad + ";";
            // metodologia tiene que ir en la pregunta...BD
            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conn);
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
                pAsset.UrlArchivo = _reader.GetString(6);

                dicACargar[pAsset.Id] = pAsset;
                indice++;
                //_lista.Add(pAsset);
            }

            Conn.Close();

        }
       
    }
}
