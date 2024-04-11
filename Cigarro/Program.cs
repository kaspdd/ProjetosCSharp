// See https://aka.ms/new-console-template for more information

//quantos metros de cigarro a pessoa ja fumou na vida
//entrada
//1 - quantidade de cigarro fumados por dia
//2 - quanto tempo o sujeito fuma
//3 - tamanho base de cada cigarro 0.08m

using System.Numerics;

namespace Cigarro
{
    class Program
    {
        static int QuantiCigarrosPorDia(int quantidadeDia, int tempo)
        {
            double tamanho = 0.08;
            double totalMetros=0;
            totalMetros = (quantidadeDia*tamanho) * tempo;     
        
            return (int)totalMetros;
            
        }

       
        static void Main(string[] args)
        {
            Console.Write("Quer saber quantos metros de cigarro voce fumou a vida toda? ");
            Console.Write("Digite a quantidade de cigarros voce fuma por dia: ");
            int quantidadeDia = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora me diga, voce fuma a quanto tempo?");
            int tempo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Voce fumou {QuantiCigarrosPorDia(quantidadeDia, tempo)} metros de cigarro na vida");

            

        }
    }
}
