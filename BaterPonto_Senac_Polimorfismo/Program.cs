// See https://aka.ms/new-console-template for more information
using BaterPonto.Modelos;

public class Program
{
    public static void Main(string[] args)
    {   
        Setor setor = new Setor();
        setor.CadastrarSetores("Administrativo",1);
        setor.CadastrarSetores("Producao",2);
        setor.CadastrarSetores("Comercial",3);
        setor.MostrarSetores();

        Funcionario carlos = new Funcionario("Carlos",1,"Diretor","Administrativo",1);
        Funcionario juju = new Funcionario("Juliana",1,"Grente","Administrativo",1);
        Funcionario will = new Funcionario("Will",1,"Coordenador","Producao",2);
        Funcionario bia = new Funcionario("Bia",1,"Encarregada","Producao",2);
        Funcionario bern = new Funcionario("Bernardo",1,"Vendedor","Comercial",3);
        Funcionario pc = new Funcionario("PC",1,"Compradora","Comercial",3);
    }
}

