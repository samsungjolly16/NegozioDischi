public class CD : Disco
{
    public List<Brano> brani = new List<Brano>();
    public CD(string titolo, string autore, string codice) : base(titolo, autore, codice) { }

    public override void Riproduci()
    {
        foreach (Brano b in brani)
        {
            b.Riproduci();
        }
    }
}