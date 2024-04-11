// See https://aka.ms/new-console-template for more information
//2 - Faça um algoritmo (com random) para receber um número qualquer e imprimir na tela 
//se o número é par ou ímpar, positivo ou negativo.

namespace Atividade02
{
    class Program
    {
        static void ParOuImpar()
        {
            Random rValor = new Random();
            Console.WriteLine("Quantos numeros randomicos voce deseja verificar: ");
            int cont = int.Parse(Console.ReadLine());
            for (int i = 0; i < cont; i++)
            {
                int valor = rValor.Next(1, 100);

                if (valor % 2 == 0)
                {
                    Console.WriteLine($"O valor {valor} é par");
                }
                else
                {
                    Console.WriteLine($"O valor {valor} é impar");
                }
            }


        }

        static void PositivoNegativo()
        {
            Random rValor = new Random();
            Console.WriteLine("Quantos numeros randomicos voce deseja verificar: ");
            int cont = int.Parse(Console.ReadLine());
            for (int i = 0; i < cont; i++)
            {
                int valor = rValor.Next(-100, 100);

                if (valor > 0)
                {
                    Console.WriteLine($"O valor {valor} é positivo");
                }
                else if (valor == 0)
                {
                    Console.WriteLine($"O valor {valor} é neutro");
                }
                else
                {
                    Console.WriteLine($"O valor {valor} é negativo");
                }
            }
        }
        static void Main(string[] args)
        {
            //ParOuImpar();
            PositivoNegativo();
        }
    }
}

