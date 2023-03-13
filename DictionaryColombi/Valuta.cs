using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryColombi
{
    public class Valuta
    {
        public string TipoValuta { get; private set; }
        public decimal Valore { get; private set; }
        public Valuta(string tipoValuta, decimal valore)
        {
            TipoValuta = tipoValuta;
            Valore = valore;
        }
        public override string ToString()
        {
            return $"{Valore};{TipoValuta};";
        }
    }
}
