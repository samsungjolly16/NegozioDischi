public class Video : ElementoDisco
{
    public Video(int durata, int numero, string nome) : base(durata, numero, nome)
    {

    }

    public override void Riproduci()
    {
        Console.WriteLine($"Riproducendo il video {nome}");
        Thread.Sleep(this.Durata);
    }
}