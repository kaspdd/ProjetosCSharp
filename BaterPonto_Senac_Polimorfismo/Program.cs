// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;
using BaterPonto.Modelos;

public class Program
{
    internal static void Main(string[] args)
    {   
        Setor setor = new Setor();
        Funcionario carlos = new Funcionario("Carlos",1,"Gerente",1);
        Funcionario juju = new Funcionario("Juliana",2,"Encarregada",1);
        Funcionario pc = new Funcionario("Paulo",3,"Gerente",2);
        Funcionario bern = new Funcionario("Bernardo",4,"Gestor",2);
        Funcionario yuri = new Funcionario("Yuri",5,"Gerente",3);
        Funcionario bia = new Funcionario("Bia",6,"Gestora",3);
        List<int> idFuncionarios = new List<int>();
        idFuncionarios.Add(carlos.IdFuncionario);
        idFuncionarios.Add(juju.IdFuncionario);
        idFuncionarios.Add(pc.IdFuncionario);
        idFuncionarios.Add(bern.IdFuncionario);
        idFuncionarios.Add(yuri.IdFuncionario);
        idFuncionarios.Add(bia.IdFuncionario);

        void MenuPrincipal()
        {
            ModeloTituloMenu("Bem vindo ao - Venha bater seu ponto!");
            voltandoAoMenu:
            Console.WriteLine($"Escolha um apcao:");
            Console.WriteLine($"Digite 1 para cadastrar um setor:");
            Console.WriteLine($"Digite 2 para cadastrar um funcionario:");
            Console.WriteLine($"Digite 3 para listar os setores");
            Console.WriteLine($"Digite 4 para listar os funcionarios");
            Console.WriteLine($"digite 5 para sair");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    //CadastrandoSetor();
                    break;
                case "2":
                    CadastrandoFuncionario();
                    break;
                case "3":
                    setor.TabelaSetor();
                    break;
                case "4":
                    ListandoFuncionarios();
                    break;
                case "5":
                    Console.WriteLine($"Saindo....");
                    break;
                default:
                    Console.WriteLine($"Opcao invalida, voltando ao menu...");
                    goto voltandoAoMenu;
            }             
        }

        void CadastrandoFuncionario()
        {
            ModeloTituloMenu("Menu - Cadastrando funcionarios\n");
            Console.WriteLine($"Digite o nome do funcionario: ");
            string nomeFucionario = Console.ReadLine();
            Console.WriteLine($"Digite o id do funcionario: ");
            int idFuncinoario = int.Parse(Console.ReadLine()!);
            if (idFuncionarios.Contains(idFuncinoario))
            {
                Console.WriteLine($"Funcionario ja cadastrado, por favor digitar.");
                
            }
            string nomeFucionario = Console.ReadLine();
            Funcionario funcionario = new Funcionario();
            Console.WriteLine($"Digite o numero do setor que deseja cadastrar o funcionario:");
            setor.TabelaSetor();
            string opcao = Console.ReadLine()!;
            switch (opcao)
            {
                case "1":
                    
                    
                    break;
                case "2":
            }
        }




        void ModeloTituloMenu(string texto)
        {
            string traco = string.Empty.PadLeft(5,'-').PadRight(5,'-');
            Console.WriteLine($"{traco}{texto}{traco}");
            
        }
    }
}

