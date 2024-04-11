// See https://aka.ms/new-console-template for more information
//Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO.

namespace Atividade07
{
    class Program
    {
        static void verdFalso (int valor)
        {
            Random cont = new Random ();
            int random = cont.Next (1,20);
            bool verdadeiro = true & valor==random;
            bool falso = false & valor>random & valor<random;

            if (verdadeiro)
            {
                Console.WriteLine ($"Voce acertou!!!!\nO valor {valor} é igual ao {random}");
                Console.WriteLine (verdadeiro);
            }
            else
            {
                Console.WriteLine ($"Voce errou);\nO valor {valor} é diferente {random}");
                Console.WriteLine(falso);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor de 1 a 20 para tentar advinhar o numero surpresa!!!");
            int valor = int.Parse(Console.ReadLine());
            verdFalso(valor);

        }
    }
}