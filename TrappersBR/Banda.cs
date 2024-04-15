class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> albums = new List<Album>();

    //para possibilitar que o parametro abaixo consiga utlizar o get(somente leitura) somente se o construtor estiver pedindo algo ou setando um valor direto no parametro.
    public string Nome { get; }
    public string Danone { get; }

    //metodos
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia ()
    {
        Console.WriteLine($"Discografia do Artista {Nome}:");

        foreach(var album in albums)
        {
            Console.WriteLine ($"Album: {album.Nome} - (Duracao do Album: {album.DuracaoTotal} segundos.)");
        }
    }
}