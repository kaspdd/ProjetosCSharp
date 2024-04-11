// See https://aka.ms/new-console-template for more information
//Faça um algoritmo que leia três valores inteiros diferentes e imprima na tela os valores em ordem decrescente.

namespace Atividade08
{
    class Program
    {

        static void Descrescente()
        {
            Console.WriteLine("Digite quantos numeros deseja armazenar");
            int cont = int.Parse(Console.ReadLine());
            int[] array = new int[cont];
            int valor;
            
            for (int i = 0; i < cont; i++)
            {
                Console.Write($"Digite o valor da posicao {i}");
                valor = int.Parse(Console.ReadLine());
                array[i] = valor;
            }
            Console.WriteLine("A lista ficou: ");
            Array.Sort(array);
            Array.Reverse(array);
            foreach(int j in array)
            {
                 Console.WriteLine(j);
                
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-----Bem vindo ao-----");
            Console.WriteLine("Numeros em ordem descrescente!");
            
            Descrescente();
            
        }
    }
}


