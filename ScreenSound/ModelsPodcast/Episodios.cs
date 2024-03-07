using System.Runtime.CompilerServices;

class Episodio
{
    private List<string> convidados = new();
    public Episodio(int duracao, string titulo, int ordem)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) " +
        $"- {string.Join(", ", convidados)}";
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}