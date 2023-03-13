using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryColombi
{
    public class Colletta
    {
        private Dictionary<string, decimal> _elenco;
        private decimal _sommaTot;
        public decimal SommaTotale
        {
            get { return _sommaTot; }
            private set { _sommaTot = value; }
        }
        public Dictionary<string, decimal> Elenco
        {
            get { return _elenco; }
            private set { _elenco = value; }
        }
        public Colletta()
        { 
            Elenco = new Dictionary<string, decimal>();
        }
        public void AggiungiPersone(string nomePersona, decimal somma)
        {
            if (string.IsNullOrEmpty(nomePersona))
            {
                throw new Exception("nome non valido");
            }
            if (!Elenco.ContainsKey(nomePersona))
            {
                if (somma > 0)
                {
                    SommaTotale += somma;
                    Elenco.Add(nomePersona, somma);
                }
                else
                {
                    Elenco.Add(nomePersona, 0);
                }

            }
            else
            {
                if (somma > 0)
                {
                    Elenco[nomePersona] = somma;
                }
            }
        }
        public override string ToString()
        {
            string rtr = "";
            foreach(string str in Elenco.Keys)
            {
                rtr += str + ";" +  Elenco[str].ToString() + ":";
            }
            return rtr;
        }

    }
}
