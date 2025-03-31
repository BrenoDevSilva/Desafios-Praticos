public class Jogo
{
    public string Nome { get; set; }
    public int AnoDeLancamento { get; set; }

    public Jogo(string nome, int anoDeLancamento)
    {
        Nome = nome;
        AnoDeLancamento = anoDeLancamento;
    }
}
