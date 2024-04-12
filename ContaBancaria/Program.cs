// See https://aka.ms/new-console-template for more information
namespace ContaBancaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Conta conta = new Conta();
            double valor = 0;
            int id = 0;
            voltarAoMenu:
            Console.WriteLine("Bem vindo a sua conta bancaria!");
            Console.WriteLine("Digite 1 para depositar:");
            Console.WriteLine("Digite 2 para sacar:");
            Console.WriteLine("Digite 3 para verificar seu saldo:");
            Console.WriteLine("Digite 4 ou qualquer tecla para sair:");
            string opcaoMenu = Console.ReadLine()!;
            Console.Clear();    
            switch (opcaoMenu)
            {
                case "1":
                   // Console.WriteLine("Digite o id da sua conta: ");
                    //id = int.Parse(Console.ReadLine()!);
                    
                    Console.Write("Digite o valor que deseja Depositar: ");
                    valor = double.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Valor {valor:c} depositado, agora seu saldo ficou em {conta.Depositar(valor):c}!");
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "2":
                    sacarNovamente:
                    Console.Write("Digite o valor que deseja Sacar: ");
                    valor = double.Parse(Console.ReadLine()!);
                    if(valor>=conta.limite)
                    {
                        Console.WriteLine($"Seu limite é de {conta.limite:c}");
                        Console.WriteLine("Tente novamente: ");
                        goto sacarNovamente;
                    }
                    else
                    {
                        Console.WriteLine($"Valor {valor:c} sacado, agora seu saldo ficou em {conta.Sacar(valor):c}!");
                        Console.WriteLine("Aperte qualquer tecla para continuar...");
                        Console.ReadKey();  
                    }
                    
                    break;
                case "3":
                    Console.Write("Digite o ID ");
                    //VerificarSaldo();
                    break;
                default:
                    Console.WriteLine("saindo...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Deseja realizar outra operacao?\nDigite 1 para (SIM)\nDigite 2 para não:");
            string opcaoSair = Console.ReadLine()!;
            switch (opcaoSair)
            {
                case "1":
                    goto voltarAoMenu;
                default:
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
