namespace Alura.Filmes;

public class Artista
{
    public Artista(string nome, int idade)
    {
        NomeArtista = nome;
        IdadeArtista = idade;
    }
    
    public string NomeArtista { get; set; }
    public int IdadeArtista { get; set; }
    public Filme FilmeArtista { get; set; }



}


