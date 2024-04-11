//3 - Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
//caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
//imprimir seu valor na tela.

using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Atividade03
{
    class Program
    {
        //metodos
        static void calculo(int num1, int num2)
        {
            int total;
            if (num1 == num2)
            {
                total = num1 + num2;
                Console.WriteLine($"Como os valores são iguais, a soma total é: {total}\n");
            }
            else
            {
                total = num1 * num2;
                Console.WriteLine($"Como os valores são diferentes, a multiplicação total é: {total}\n");
            }
            Console.ReadKey();
        }

        static void continuar()
        {
            repeat1:
            Console.Clear();
            Console.Write("Escolha uma opcao:\n1 - Deseja continuar? \n2 - Deseja sair? \n");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Voltando para o menu...\n");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Digite uma opcao valida...\n");
                    goto repeat1;
            }
            Console.ReadKey();
        }

        //metodo principal
        public static void Main(string[] args)
        {
            int num1, num2;
            int cont = 1;

                repeat2:
                Console.Clear();
                Console.WriteLine("Digite o valor do primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                calculo(num1, num2);
                continuar();
                goto repeat2;
            
        }
    }
}

