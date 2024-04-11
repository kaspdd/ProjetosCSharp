// See https://aka.ms/new-console-template for more information
// Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%.

using System.Diagnostics.Contracts;

namespace Atividade06
{
    class Program
    {
        static void Reajuste(double valor)
        {
            double total = valor*1.05;
            Console.WriteLine($"O valor reajustado ficou em {total:c}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor que aplicaremos o reajuste de 5%");
            double valor = double.Parse(Console.ReadLine());
            Reajuste(valor);
        }
    }
    
}

