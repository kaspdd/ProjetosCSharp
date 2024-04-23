using System.Security.Cryptography;
using Polimorfismo.Modelos;

void MenuPrincipal()
{
    Console.WriteLine($"Bem vindo ao Conversor de temperaturas!");
voltandoAoMenu:
    Console.WriteLine($"Escolha uma das opcoes para converter:");
    Console.WriteLine($"Digite 1 para converter Celsius para Fahrenheit\nDigite 2 para converter Fahrenheit para Celsius\nDigite 3 para sair:");
    string opcao = Console.ReadLine();
    Conversor conversor = new Conversor();
    switch (opcao)
    {
        case "1":
            Console.Write($"Digite a temperatura em Celsius:");
            double valorC = double.Parse(Console.ReadLine());
            Console.WriteLine($"Temperatura {valorC}C em Fahrenheit ficou {conversor.ConverterTemperatura(valorC):f1}F");
            AperteUmaTecla();
            VoltandoAoMenu();
            break;
        case "2":
            Console.WriteLine($"Digite a temperatura em Fahrenheit:");
            float valorF = float.Parse(Console.ReadLine());
            Console.WriteLine($"Temperatura {valorF}F em Celsius ficou {conversor.ConverterTemperatura(valorF):f1}C");
            AperteUmaTecla();
            VoltandoAoMenu();
            break;
        case "3":
            Console.WriteLine($"Saindo....");
            break;
        default:
            Console.WriteLine($"Opcao invalida.");
            goto voltandoAoMenu;
    }


}

void VoltandoAoMenu()
{
voltandoAoTopo:
    Console.WriteLine("Deseja voltar ao menu?");
    Console.WriteLine($"Digite 1 para (sim)\nDigite 2 para (Sair)");
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            MenuPrincipal();
            break;
        case "2":
            Console.WriteLine($"Saindo...");
            break;
        default:
            Console.WriteLine($"Opcao invalida..");
            goto voltandoAoTopo;

    }
}

void AperteUmaTecla()
{
    Console.WriteLine($"Aperte qualquer tecla para sair ");
    Console.ReadKey();
    VoltandoAoMenu();
}


