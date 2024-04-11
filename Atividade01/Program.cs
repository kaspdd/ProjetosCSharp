// See https://aka.ms/new-console-template for more information
// Faça um algoritmo que leia os valores de A, B, C e em seguida imprima na tela a soma entre 
//A e B é mostre se a soma é menor que C.
using System.Collections.ObjectModel;

namespace atividade01
{
    class Program
    {
        static void soma(double num1, double num2)
        {
            
            double num3 = 10.0;
            double res = num1+num2;
            
            if(res < num3)
            {
                Console.WriteLine($"A soma entre os dois primeiros valores é: {res} e esse valor é menor do que o terceiro valor {num3}.");
            }
            else
            {
                Console.WriteLine($"A soma entre os dois primeiros valores é: {res} e esse valor é maior do que o terceiro valor {num3}.");
            }

        }
         static void Main(string[] args)
        {
            Console.WriteLine($"Digite o valor do primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o valor do segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o valor do terceiro valor: ");
            soma(n1, n2);
        }
    }
}

