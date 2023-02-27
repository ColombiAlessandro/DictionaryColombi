using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryColombi
{
    public class Colletta
    {
        private Dictionary<string, float> _elenco;
        private float _sommaTot;
        private int numeroPersone;
        public float SommaTotale
        {
            get { return _sommaTot; }
            private set { _sommaTot = value; }
        }
        public Dictionary<string, float> Elenco
        {
            get { return _elenco; }
            private set { _elenco = value; }
        }
        public void ImpostaSomma(float somma)
        {
            if (somma > 0)
            {
                SommaTotale = somma;
            }
            else throw new Exception("Il valore dev'essere maggiore di 0");
        }


    }
}
