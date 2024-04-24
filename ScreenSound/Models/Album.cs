﻿namespace ScreenSound.Models;

class Album
{
    private List<Musica> musicas= new List<Musica>();
    public string Nome { get; set; }

    public Album(string nome)
    {
        Nome = nome;
    }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Músicas do álbum {Nome}: \n");
        int contador = 1;
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música {contador}: {musica.Nome}");
            contador++;
        }
        Console.WriteLine($"Para ouvir esse álbum inteiro, você precisa de {DuracaoTotal} segundos.");
    }
}