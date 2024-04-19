namespace BaterPonto.Modelos;

public class Funcionario : Setor
{
    public Funcionario(string nomeFucionario, int idFuncionario, string cargoFuncionario, string nomeSetor, int idSetor )
    {
        NomeFuncionario = nomeFucionario;
        IdFuncionario = idFuncionario;
        CargoFuncionario = cargoFuncionario;
        NomeSetor = nomeSetor;
        IdSetor = idSetor;
    }
    public int IdFuncionario { get; }
    public string NomeFuncionario { get; }
    public string CargoFuncionario { get; }
    public string resumoFuncionario => $"\nId funcionario: {IdFuncionario}\nFuncionario: {NomeFuncionario}\nCargo: {CargoFuncionario}\nId do setor: {IdSetor}\nNome do setor: {NomeSetor}\n";

    
    public void Administrativo ()
    {
        
    }

}