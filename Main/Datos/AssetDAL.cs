using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    class AssetDAL
    {

        public static List<Asset> BuscarPorNivelHabilidad(string pNivelWriting, string pNivelReading, string pNivelListening) // queremos todos los assets disponibles para el usuario 
        {                                                                                                                     // de acuerdo a sus habilidades
            List<Asset> _lista = new List<Asset>();
            string consulta = "";

            SqlCommand _comando = new SqlCommand(String.Format(consulta), Conexión.obtenerConexion());
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
    }
}
