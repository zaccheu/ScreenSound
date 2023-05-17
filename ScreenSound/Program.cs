Episodio ep1 = new(1, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidado("Ana Pereira");
ep1.AdicionarConvidado("Mário Francis");

Episodio ep2 = new(2, "Aprendendo a aprender", 78);
ep2.AdicionarConvidado("Marcos Braz");

Episodio ep3 = new(3, "Consciênciologia", 87);
ep3.AdicionarConvidado("Flavio Almeida");
ep3.AdicionarConvidado("Gui Lima");
ep3.AdicionarConvidado("Fernanda Fernandes");

Podcast podcast = new("TI para Poucos", "Daniel Portugal");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);

podcast.ExibirDetalhes();