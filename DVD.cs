public class DVD : Disco
{
    public List<ElementoDisco> elementiDisco = new List<ElementoDisco>();
    public DVD(string titolo, string autore, string codice) : base(titolo, autore, codice)
    {
    }

    public override void Riproduci()
    {
        foreach (ElementoDisco e in elementiDisco)
        {
            e.Riproduci();
        }
    }
}