using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryColombi
{
    public class Colletta
    {
        private Dictionary<Persona, Valuta> _elenco;
        private decimal _sommaTot;
        public decimal SommaTotale
        {
            get { return _sommaTot; }
            private set { _sommaTot = value; }
        }
        public Dictionary<Persona, Valuta> Elenco
        {
            get { return _elenco; }
            private set { _elenco = value; }
        }
        public Colletta()
        { 
            Elenco = new Dictionary<Persona, Valuta>();
        }
        public void AggiungiPersone(Persona nomePersona, Valuta somma)
        {
            if (!Elenco.ContainsKey(nomePersona))
            {
                if (somma.Valore >= 0)
                {
                    Elenco.Add(nomePersona, somma);
                    switch (somma.TipoValuta)
                    {
                        case "Euro":
                            SommaTotale += somma.Valore;
                            break;
                        case "Dollari":
                            SommaTotale += somma.Valore *(decimal)0.94;
                            break;
                        case "Sterline":
                            SommaTotale += somma.Valore*(decimal)1.13;
                            break;
                    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                }

            }
            else
            {
                if (somma.Valore >= 0)
                {
                    Elenco[nomePersona] = somma;
                }
            }
        }
        public override string ToString()
        {
            string rtr = "";
            foreach(Persona persona in Elenco.Keys)
            {
                rtr += persona.ToString() + Elenco[persona].ToString() + ":";
            }
            return rtr;
        }
        public void ordinaNome()
        {
            SortedDictionary<Persona, Valuta> ordinato = new SortedDictionary<Persona, Valuta>(Elenco);
            Elenco = new Dictionary<Persona, Valuta>(ordinato);

        }
        public void ordinaValue()
        {
            Dictionary<Persona, Valuta> ordinato = new Dictionary<Persona, Valuta>(Elenco);
            Elenco = ordinato.OrderByDescending(x => x.Value.Valore).ToDictionary(x => x.Key, x => x.Value);


        }
        public Persona Ricerca(decimal importo)
        {
            Persona x = null;
            foreach (Persona p in Elenco.Keys)
            {
                if (Elenco[p].Valore == importo)
                {
                    x = p;
                }
            }
            if (x == null)
            {
                throw new Exception("Nessuno ha versato l'importo selezionato");
            }
            return x;
        }
    }
}
