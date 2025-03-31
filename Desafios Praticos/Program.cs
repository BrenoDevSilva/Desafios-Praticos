public class Program
{
    public static void Main(string[] args)
    {
        /* 
        
        #1
        Titular titular = new Titular("João Silva", "123.456.789-00", "Rua A, 123");

        Conta conta = new Conta(titular, 1234, 56789, 5000.00);

        Console.WriteLine(conta.Informacoes);
        */


        //  #2
        CatalogoDeJogos catalogo = new CatalogoDeJogos();

        Jogo jogo1 = new Jogo("The Witcher 3", 2015);
        Jogo jogo2 = new Jogo("Cyberpunk 2077", 2020);
        Jogo jogo3 = new Jogo("Minecraft", 2011);

        catalogo.AdicionarJogo(jogo1);
        catalogo.AdicionarJogo(jogo2);
        catalogo.AdicionarJogo(jogo3);

        catalogo.ListarJogos();
    }
}
