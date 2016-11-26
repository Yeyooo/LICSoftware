using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public int NivelWriting { get; set; }
        public int NivelReading { get; set; }
        public int NivelListening { get; set; }

        public Usuario() { }

        public Usuario( string pNombre, string pCorreo, string pPassword ) // inicializamos con los 3 niveles en 0(sin nivel)
        {
            this.Nombre = pNombre;
            this.Correo = pCorreo;
            this.Password = pPassword;
            this.NivelWriting = 0;
            this.NivelReading = 0;
            this.NivelListening = 0;
        }

    }
}
