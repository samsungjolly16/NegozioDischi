public abstract class Disco
{
    public string Titolo { get; private set; }
    public string Cantante { get;private set; }
    private static int  Codice=0;
    public List<NegozioDischi.Brano> Brani { get; } = new List<NegozioDischi.Brano>();

    private bool isDisponibile;
    public bool IsDisponibile
    {
        get
        {
            return isDisponibile;
        }
        set
        {
            isDisponibile = value;
        }
    }

    public Disco(string titolo, string autore)
    {
        Titolo = titolo;
        Cantante = autore;
        Codice = IncrementaCodice();
        isDisponibile = true;
    }
    private int IncrementaCodice()
    {
        return Codice++;
    }
}