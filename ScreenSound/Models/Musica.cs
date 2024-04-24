namespace ScreenSound.Models;

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get;  } 
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //p atalho prop+tab cria uma propriedade
    public string DescricaoResumida => //lambda
        $"A música {Nome} pertence à banda {Artista}";



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}