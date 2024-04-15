class Titular
{
    //Construtor
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
    //Propriedades
    public string Nome { get; }
    public string Cpf { get; }
    public string Endereco { get; }
}