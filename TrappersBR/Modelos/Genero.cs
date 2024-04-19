namespace TrapperBR.Modelos;

internal class Genero
{
    public Genero(string nome)
    {
        Nome = nome;
    }
    private List<Album> albums = new List<Album>();
    public string Nome { get; }


    

}