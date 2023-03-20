using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryColombi
{
    public class Valuta : IComparable<Valuta>
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
        public int CompareTo(Valuta v)
        {
            if (this.TipoValuta == v.TipoValuta)
            {
                if (this.Valore > v.Valore)
                {
                    return 1;
                }
                else if (this.Valore < v.Valore)
                {
                    return -1;
                }
                return 0;
            } else
            {
                decimal v1 = 0;
                switch (this.TipoValuta)
                {
                    case "Euro":
                        v1 = this.Valore;
                        break;
                    case "Dollari":
                        v1=  this.Valore * (decimal)0.94;
                        break;
                    case "Sterline":
                        v1 = this.Valore * (decimal)1.13;
                        break;
                }
                decimal v2 = 0;
                switch (v.TipoValuta)
                {
                    case "Euro":
                        v2 = v.Valore;
                        break;
                    case "Dollari":
                        v2 = v.Valore * (decimal)0.94;
                        break;
                    case "Sterline":
                        v2 = v.Valore * (decimal)1.13;
                        break;
                }
                if (v1 > v2)
                {
                    return 1;
                }
                else if (v1 < v2)
                {
                    return -1;
                }
                return 0;

            }
            return 0;
        }
    }
}
