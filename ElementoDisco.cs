public abstract class ElementoDisco
{
    private int durata;
    public int Durata
    {
        get { return durata; }
        set
        {
            if (value < 0)
            {
                throw new Exception("durata non valida");
            }
            durata = value;
        }
    }
    protected int numero;
    protected string nome;

    public ElementoDisco(int durata, int numero, string nome)
    {
        Durata = durata;
        this.numero = numero;
        this.nome = nome;
    }

    public abstract void Riproduci();
}