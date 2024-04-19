using System.Security.Cryptography.X509Certificates;

namespace BaterPonto.Modelos;

public class Setor
{
    public Setor()
    {

    }
    private Dictionary<string, int> setoresCadastrados = new Dictionary<string, int>();
    public int IdSetor { get; set; }
    public string NomeSetor { get; set; }


    public void CadastrarSetores(string nomeSetor, int idSetor)
    {
        NomeSetor = nomeSetor;
        IdSetor = idSetor;
        setoresCadastrados.Add(NomeSetor, IdSetor);
    }

    public void MostrarSetores()
    {
        Console.WriteLine($"Segue a lista de setores cadastrados e seus Ids: ");
        foreach (KeyValuePair<string, int> s in setoresCadastrados)
        {
            Console.Write($"Nome: {s.Key}");
            Console.WriteLine($"                                   \tId: {s.Value}");
             
        }

    }





}