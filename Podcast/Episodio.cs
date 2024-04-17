class Episodio
{
    public Episodio(string titulo, int duracao, int numero)
    {
        Titulo = titulo;
        Duracao = duracao;
        Numero = numero;
    }
    private List<string> convidados = new List<string>();
    public int Duracao { get; } 
    public int Numero { get;  }
                                        //o string.join serve para juntar um valor com o outro atribudo, nesse caso foi a virgula e a lista de convidados.
    public string Resumo => $"N®: {Numero} | titulo: {Titulo} | Duracao do episodio: {Duracao} E convidados: {string.Join(", ", convidados)}";
    
    public string Titulo { get;  }

    public void AdicionarConvidados (string convidado)
    {
        convidados.Add(convidado);
    }
}