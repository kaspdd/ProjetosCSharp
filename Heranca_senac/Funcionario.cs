class Funcionario : Setor
{

    public Funcionario()
    {

    }
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public double ValeRefeicao { get; set; }

    public string Resumo => $"id do Setor: | {IdSetor} Nome do Setor: {NomeSetor.ToUpper()} |\n Nome funcionario: {Nome} | Cargo {Cargo} | Salario {Salario:c} | Vale Refeicao {ValeRefeicao:C}";



}