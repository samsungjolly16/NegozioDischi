public class Brano : ElementoDisco{
    public Brano(int durata, int numero, string nome): base(durata, numero, nome){}

    public override void Riproduci()
    {
        Console.WriteLine($"Riproducendo il brano {nome}");
        Thread.Sleep(this.Durata);
    }
}