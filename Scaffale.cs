using System.Linq;
public class Scaffale
{

    public string Genere { get; private set; }
    public List<Disco> dischi;

    public Scaffale(string genere)
    {
        Genere = genere;
    }

    public List<Disco> Ricerca(string titolo, string autore)
    {
        return dischi.FindAll(d => d.IsDisponibile && (
            d.GetAutore().Contains(autore) || d.GetTitolo().Contains(titolo)));
    }

    public void AddDisco(Disco d)
    {
        dischi.Add(d);
    }
    public void RemoveDisco(Disco d)
    {
        dischi.Remove(d);
    }
}