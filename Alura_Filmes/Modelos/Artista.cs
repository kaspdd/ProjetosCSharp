namespace Alura.Filmes;

public class Artista
{
    public Artista(string nome, int idade, Filme filme)
    {
        NomeArtista = nome;
        IdadeArtista = idade;
        FilmeArtista = filme;
    }
    
    public string NomeArtista { get; set; }
    public int IdadeArtista { get; set; }
    public Filme FilmeArtista { get; set; }

   



}


