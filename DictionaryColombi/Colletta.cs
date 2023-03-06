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
        private List<string> _elencoPersone;
        private int numeroPersone;
        public List<string> ElencoPersone
        {
            get { return _elencoPersone; }
            private set { _elencoPersone = value; }
        }
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
        public Colletta()
        {
            SommaTotale = -1;
            ElencoPersone = new List<string>();
            Elenco = new Dictionary<string, float>();
        }
        public void ImpostaSomma(float somma)
        {
            if (somma > 0)
            {
                SommaTotale = somma;
                float nuovaMedia = SommaTotale / ElencoPersone.Count();
                foreach (string persona in ElencoPersone)
                {
                    Elenco[persona] = nuovaMedia;
                }
            }
            else throw new Exception("Il valore dev'essere maggiore di 0");
        }
        public void AggiungiPersone(string nomePersona)
        {
            if (string.IsNullOrEmpty(nomePersona))
            {
                throw new Exception("nome non valido");
            }
            if (ElencoPersone.IndexOf(nomePersona) == -1)
            {
                if (SommaTotale > 0)
                {
                    float nuovaMedia = SommaTotale / ElencoPersone.Count();
                    foreach (string persona in ElencoPersone)
                    {
                        Elenco[persona] = nuovaMedia;
                    }
                    Elenco.Add(nomePersona, nuovaMedia);
                    ElencoPersone.Add(nomePersona);
                }
                else throw new Exception("non è stata impostata la somma da dividere");
                
            }
            else throw new Exception("Il nome è già presente");
        }

    }
}
