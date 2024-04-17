
Podcast pdpa = new Podcast("Pdpa", "Youtube");
Episodio derek = new Episodio("Derek vai a escola",1000,3);

Episodio je = new Episodio("Je vai a escola",2000,5);

Episodio igu = new Episodio("Igu vai a escola",3000,1);

pdpa.AdicionarEpisodio(derek);
derek.AdicionarConvidados("Naruto");
pdpa.AdicionarEpisodio(je);
je.AdicionarConvidados("Luan");
pdpa.AdicionarEpisodio(igu);
igu.AdicionarConvidados("Sasuke");


pdpa.ExibirDetalhes();

