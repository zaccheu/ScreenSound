class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast (string podcastNome, string host)
    {
        PodcastNome = podcastNome;
        Host = host;
    }
    public string Host { get; }
    public string PodcastNome { get; }
    public int TotalEp => episodios.Count;
    
    //métodos
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {PodcastNome} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEp} episódios.");
    }
}