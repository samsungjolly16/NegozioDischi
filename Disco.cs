public abstract class Disco
{
    private string titolo;
    private string autore;
    private string codice;

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

    public Disco(string titolo, string autore, string codice)
    {
        this.titolo = titolo;
        this.autore = autore;
        this.codice = codice;
    }

    public string GetAutore() => autore;
    public string GetTitolo() => titolo;
    public string GetCodice() => codice;

    public abstract void Riproduci();
}