class Banco
{
    private List<Conta> contas = new List<Conta>();
    public Banco(Conta conta)
    {
        this.conta = conta;
    }
    public Conta conta {get;}


    public void AdicionarConta (Conta numeroDaConta)
    {
        contas.Add(numeroDaConta);
    }

    public string VerificarConta(Conta numeroDaConta)
}