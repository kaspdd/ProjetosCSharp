class Conta
{
    //metodo construtor
    public Conta(Titular nome, int agencia, int numeroDaConta)
    {
        //sempre que for instanciado esta classe Conta, a nova conta sempre 
        //comecara com os valores atribuidos nas propriedades definidas aqui
        //ou seja, a conta1 sempre tera o saldo inicial como 0 e o limite em 5000.0.
        Titular = nome;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        saldo = 0;
        limite = 5000.0;
    }
    private List<Titular> titularCadastrado = new List<Titular>();
    public Titular Titular { get; }
    public int Agencia {get; } 
    public int NumeroDaConta {get; }
    public double saldo { get; set;}
    public double limite { get; }


    public double Sacar(double valor)
    {
        saldo -= valor;
        Tarifar();
        return saldo;

    }

    public double Depositar(double valor)
    {
        saldo += valor;
        Tarifar();
        return saldo;

    }

    public void VerificarSaldo(int id)
    {

    }

    private double Tarifar()
    {
        return saldo -= 0.5;
    }

}





