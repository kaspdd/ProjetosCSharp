
//instanciando uma nova banda
Banda derek = new Banda("Derek");

//instaciando um novo genero
Genero hardTrap = new Genero("HardTrap");
Genero Plugnnb = new Genero("PlugnnB");

//instanciando um novo album com o metodo construtor obrigando informar o nome e o genero.
Album albumDoDerek = new Album("TTF", Plugnnb);

//instanciando uma musica com metodo construtor obrigando informar o nome do artista e genero da musica.
Musica musica1 = new Musica("trap the fato nois fez em 5", 260, derek, hardTrap)
{
    Disponivel = true
};

//instanciando uma musica com metodo construtor obrigando informar o nome do artista e genero da musica.
Musica musica2 = new Musica("Essa vadia me estiga", 192, derek, hardTrap)
//essas chaves sáo chamadas de inicializadores, podem ser de listas ou propriedades
{
    Disponivel = false
};

//chamando o metodo para adicionar as musicas no album
albumDoDerek.AdicionarMusica(musica1);
musica1.ExibirFichaTecnicaDaMusica();
albumDoDerek.AdicionarMusica(musica2);
musica2.ExibirFichaTecnicaDaMusica();
//albumDoDerek.AdicionarGeneroAlbum(hardTrap);
derek.AdicionarAlbum(albumDoDerek);

derek.ExibirDiscografia();
albumDoDerek.ExibirMusicasDoAlbum();

