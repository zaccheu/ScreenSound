/*Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};
//musica1.Duracao = 213;

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,   
};
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
albumDoQueen.ExibirMusicasDoAlbum(); */

Episodio ep1 = new(45, "Técnicas de facilitação", 2);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(77, "Técnicas de aprendizagem", 1);
ep2.AdicionarConvidados("Rafa");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Claudio");

Podcast podcast = new("Especial", "Daniel");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

/*Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();*/