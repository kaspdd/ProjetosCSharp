// See https://aka.ms/new-console-template for more information
//Faça um algoritmo que receba um número inteiro e imprima na tela o seu antecessor e o seu sucessor.


namespace Atividaede04
{
    class Program
    {
        static void  CimaBaixo(int num)
        {
            
            Console.WriteLine($"O numero gerado foi: {num}");
            int positivo = num+1;
            int negativo = num-1;
            Console.WriteLine($"O numero anterior de {num} é {negativo} e o posterior é {positivo}");
            
        }

        static void ListaDeNumeros(int lista){
            Console.WriteLine("Deseja adicionar este");
        }

        static void NumeroRandom()
        {
            Random numero = new Random();
            int random = numero.Next(numero.Next(1,100));
            CimaBaixo(random);            
        }
        static void Main(string[] args)
        {
            NumeroRandom();
        }
    }
}
