public class Negozio
{
    public List<Scaffale> scaffali { get; } = new List<Scaffale>();
    public List<Disco> Ricerca(string titolo, string autore)
    {
        List<Disco> dischi = new List<Disco>();
        foreach (Scaffale s in scaffali)
            dischi.AddRange(s.Ricerca(titolo, autore));
        return dischi;
    }

    public void Prestito(Disco d)
    {
        if (d.IsDisponibile)
            d.IsDisponibile = false;
        else
            throw new Exception("Disco non disponibile.");
    }

    public void Restituisci(Disco d)
    {
        if (!d.IsDisponibile)
            d.IsDisponibile = true;
        else
            throw new Exception("Disco gia' disponibile");
    }

    public void Riproduci(Disco d)
    {
        Task.Factory.StartNew(() => d.Riproduci());
    }
    public void Riproduci(ElementoDisco e)
    {
        Task.Factory.StartNew(() => e.Riproduci());
    }
}


