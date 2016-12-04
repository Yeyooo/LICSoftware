using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Alternativa
    {
        public int IdAlternativa;
        public string TxtAlternativa;


        public Alternativa() { }

        public Alternativa(int pIdAlternativa, string pTxtAlternativa)
        {
            this.IdAlternativa = pIdAlternativa;
            this.TxtAlternativa = pTxtAlternativa;
        }

        public int getIdAlternativa()
        {
            return this.IdAlternativa;
        }

        public string getTxtAlternativa()
        {
            return this.TxtAlternativa;
        }

        public void setIdAlternativa(int pId)
        {
            this.IdAlternativa = pId;
        }

        public void setTxtAlternativa(string pTxt)
        {
            this.TxtAlternativa = pTxt;
        }


    }

    
}
