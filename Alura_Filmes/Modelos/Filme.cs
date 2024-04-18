namespace Alura.Filmes;

public class Filme
{
    public Filme(string nomeFilme)
    {
        NomeFilme = nomeFilme;
    }
    private List<Artista> artistas = new List<Artista>();
    public string NomeFilme { get; set; }

        public void AdicionarFilme(Artista artista)
{
    artistas.Add(artista);
}


    
}