using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioDischi
{
    public class Brano
    {
        public int Secondi { get; private set; }
        public string Nome { get; private set; }
        public int Numero { get; private set; }
        public Brano(int secondi, string nome,int numero)
        {
            Secondi = secondi;
            Nome = nome;
            Numero = numero;
        }

    }
}
