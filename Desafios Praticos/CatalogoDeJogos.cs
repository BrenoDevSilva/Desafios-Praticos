public class CatalogoDeJogos
{
    public List<Jogo> Jogos { get; set; }
    public CatalogoDeJogos()
    {
        Jogos = new List<Jogo>();
    }

    public void AdicionarJogo(Jogo jogo)
    {
        Jogos.Add(jogo);
    }

    public void ListarJogos()
    {
        foreach (var jogo in Jogos)
        {
            Console.WriteLine($"Nome: {jogo.Nome}, Ano: {jogo.AnoDeLancamento}");
        }
    }
}
