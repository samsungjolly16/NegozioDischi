using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioDischi
{
    public class Scaffale
    {
        public string Genere { get; private set; }
        public Scaffale(string genere)
        {
            Genere = genere;
        }
        public List<Disco> Dischi { get; } = new List<Disco>();
        public void AddDischi(Disco d)
        {
            Dischi.Add(d);
        }
    }
}
