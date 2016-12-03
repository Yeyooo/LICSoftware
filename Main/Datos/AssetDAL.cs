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

        public static List<Asset> BuscarPorNivelHabilidad(string pNivelHabilidad, string pHabilidadAsociada) // queremos todos los assets disponibles para el usuario 
        {                                                                                                                     // de acuerdo a sus habilidades
            List<Asset> _lista = new List<Asset>();
            string consulta = "SELECT idpregunta, enunciado, alt_correcta, habilidad, nivel, metodologia, teoria FROM pregunta, alternativas, alternativa_correcta WHERE alternativa_correcta.idpregunta = pregunta.idpregunta and alternativas.idpregunta = pregunta.idpregunta and habilidad = ' "+pHabilidadAsociada+" ' and nivel = ' "+pNivelHabilidad+" '";
            // metodologia tiene que ir en la pregunta...BD
            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conexión.obtenerConexion("contenido"));
            SqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Asset pAsset = new Asset();
                pAsset.Id = _reader.GetInt32(0);
                pAsset.EnunciadoPregunta = _reader.GetString(1);
                //pAsset.Alternativas = _reader.GetString(2); // debe ser un metodo aparte
                _lista.Add(pAsset);
            }

            return _lista;
        }
        #region Aca se llenan los diccionarios con la ID del asset, el asset de un determinado nivel y de retornan
        public Dictionary<int, Asset> getDiccionarioWriting()
        {
            Dictionary<int,Asset> DiccionarioWriting = new Dictionary<int, Asset>();
            return DiccionarioWriting;
        }

        public Dictionary<int, Asset> getDiccionarioListening()
        {
            Dictionary<int, Asset> DiccionarioListening = new Dictionary<int, Asset>();
            return DiccionarioListening;
        }

        public Dictionary<int, Asset> getDiccionarioReading()
        {
            Dictionary<int, Asset> DiccionarioReading = new Dictionary<int, Asset>();
            return DiccionarioReading;
        }
        #endregion

    }
}
