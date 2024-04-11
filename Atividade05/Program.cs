// See https://aka.ms/new-console-template for more information
//Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse
//usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.293,20).
namespace Atividade05
{
    class Program
    {
        static void Salario (double salario)
        {
            double minimo = 1293.20;
            int total;
            
            total = (int)((int)salario/minimo);
            if(salario >= minimo)
            {
                
                Console.WriteLine ($"voce recebe {total} salario/s minimo/s!!");
            }
            else
            {
                Console.WriteLine("Voce recebe menos do que um salario minimo );");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine ("Digite seu salario: ");
            double salario = double.Parse(Console.ReadLine());
            Salario(salario);
        }
    }
}
