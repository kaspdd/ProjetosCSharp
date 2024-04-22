// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;
using BaterPonto.Modelos;

public class Program
{
    internal static void Main(string[] args)
    {   
        Setor setor = new Setor();
        
        

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
            
        }




        void ModeloTituloMenu(string texto)
        {
            string traco = string.Empty.PadLeft(5,'-').PadRight(5,'-');
            Console.WriteLine($"{traco}{texto}{traco}");
            
        }
    }
}

