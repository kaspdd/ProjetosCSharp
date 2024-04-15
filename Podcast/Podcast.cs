class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    private List<Episodio> episodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios  => episodios.Count;



    public void AdicionarEpisodio(Episodio episodio )
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Podcast: {Nome} Host: {Host}\n");
        Console.WriteLine("Lista de Episodios:\n");
        //Usando a funcao OrderBy para ordernar os episodios usando expressao lambida.
        foreach (Episodio episodio in episodios.OrderBy(x => x.Numero))
        {
            Console.WriteLine($"Episodio {episodio.Resumo}");
        }
        Console.WriteLine($"O total de episodios é de: {TotalEpisodios}");
    }

}