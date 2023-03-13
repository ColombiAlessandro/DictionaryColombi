using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryColombi
{
    public class Persona : IEquatable<Persona>
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        private static int numeroPersone=0;

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public bool Equals(Persona persona)
        {
            if (persona.Id == this.Id)
            {
                return true;
            }
            else return false;
        }
        public Persona(string name, string surname)
        {
            if (!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(surname)) {
                Id = "P" + numeroPersone;
                Name = name;
                Surname = surname;
                numeroPersone++;
            } else throw new Exception("Valore vuoto");
        }
        public override string ToString()
        {
            return $"{Name};{Surname};";
        }
    }
}
