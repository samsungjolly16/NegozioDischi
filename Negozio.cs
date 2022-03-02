using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioDischi
{
    public class Negozio
    {
        public string Nome { get; private set; }
        public Negozio(string nome)
        {
            Nome = nome;
        }
        public List<Scaffale> Scaffali { get; } = new List<Scaffale>();
        public void AddScaffali(Scaffale s)
        {
            Scaffali.Add(s);
        }
        public void RicercaTitolo(Disco d)
        {
            foreach(Scaffale s in Scaffali)
            {
                foreach(Disco ds in s.Dischi)
                {
                    if (ds.Titolo == d.Titolo)
                        Console.WriteLine("disco trovato");
                    else
                        Console.WriteLine("disco non trovato");
                }
            }
        }
        public void RicercaCantante(Disco d)
        {
            foreach (Scaffale s in Scaffali)
            {
                foreach (Disco ds in s.Dischi)
                {
                    if (ds.Cantante == d.Cantante)
                        Console.WriteLine("disco trovato");
                    else
                        Console.WriteLine("disco non trovato");
                }
            }
        }
        public void Prestito(Disco d)
        {
            d.IsDisponibile = false;
        }
        public void Restituzione(Disco d)
        {
            d.IsDisponibile = true;
        } 
        public void RiproduciDisco(Disco d)
        {
            int sommaSecondi = 0;
            foreach(Brano b in d.Brani)
            {
                sommaSecondi += b.Secondi;
            }
            Task.Factory.StartNew(Riproduci(()=>sommaSecondi,d.Titolo));
        }
        public void RiproduciBrano(Brano b)
        {

        }
        public void Riproduci(int volte,string nome)
        {
            for(int i = 0; i < volte; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
