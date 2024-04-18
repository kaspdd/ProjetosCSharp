
//o namespace aqui esta retratando o nome da pasta prinicipal que contem o projeto, seguido do nome da pasta que estao as classes modelo.
namespace TrapperBR.Modelos;

class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> albums = new List<Album>();
    private List<int> notas = new List<int>();

    //para possibilitar que o parametro abaixo consiga utlizar o get(somente leitura) somente se o construtor estiver pedindo algo ou setando um valor direto no parametro.
    public string Nome { get; }
    public double Media => notas.Average();
    public List<Album> album => albums;
    

    //metodos
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
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