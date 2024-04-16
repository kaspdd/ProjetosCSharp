

using System.Security.Cryptography.X509Certificates;

void MenuPrincipal()
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao Tipo de Veiculos!");
    Console.WriteLine($"Escolha entre os tres tipos de veiculos abaixo para cadastrar: ");
    Console.WriteLine($"Digite 1 - para Automovel");
    Console.WriteLine($"Digite 2 - para Motoclicleta");
    Console.WriteLine($"Digite 3 - para Helicoptero");
    Console.WriteLine("Digite 4 ou qualquer outra tecla para sair");
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.Clear();
            CadastrandoAutomovel();
            MenuSair();
            break;
        case "2":
            Console.Clear();
            CadastrandoMotocicleta();
            MenuSair();
            break;
        case "3":
            Console.Clear();
            CadastrandoHelicoptero();
            MenuSair();
            break;
        default:
            Console.WriteLine("Saindo...");
            break;
    }

    void CadastrandoAutomovel()
    {
        Console.WriteLine("Voce escolheu Automovel!");
        Automovel carro = new Automovel();
        Console.Write("Digite a marca do automovel: ");
        carro.Marca = Console.ReadLine();
        Console.Write("Digite a Modelo do automovel: ");
        carro.Modelo = Console.ReadLine();
        Console.Write("Digite o Ano de fabricacao do automovel: ");
        carro.AnoFabricacao = int.Parse(Console.ReadLine());
        Console.Write("Digite o Preco do automovel: ");
        carro.Preco = double.Parse(Console.ReadLine());
        Console.Write("Digite o Aro da roda do automovel: ");
        carro.RodasAro = int.Parse(Console.ReadLine());
        Console.Write("Digite o cambio do automovel: ");
        carro.Cambio = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Segue os detalhes do carro:\n\n{carro.ResumoAutomovel}\n");
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadKey();
    }
    void CadastrandoMotocicleta()
    {
        Console.WriteLine("Voce escolheu Motoclicleta!");
        Motocicleta moto = new Motocicleta();
        Console.Write("Digite a marca da Motoclicleta: ");
        moto.Marca = Console.ReadLine();
        Console.Write("Digite o Modelo da Motoclicleta: ");
        moto.Modelo = Console.ReadLine();
        Console.Write("Digite o Ano de fabricacao da Motoclicleta: ");
        moto.AnoFabricacao = int.Parse(Console.ReadLine());
        Console.Write("Digite o Preco da Motoclicleta: ");
        moto.Preco = double.Parse(Console.ReadLine());
        Console.Write("Digite o tipo de transmissao da Motoclicleta: ");
        moto.Transmissao = Console.ReadLine();
        Console.Write("Digite a potencia da Motoclicleta: ");
        moto.PotenciaMotor = int.Parse(Console.ReadLine());
        Console.WriteLine($"Segue os datalhes da moto:\n\n{moto.ResumoMotocicleta}");
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadKey();
    }

    void CadastrandoHelicoptero()
    {
        Console.WriteLine("Voce escolheu Heliocoptero!");
        Helicoptero heli = new Helicoptero();
        Console.Write("Digite o marca do Heliocoptero: ");
        heli.Marca = Console.ReadLine();
        Console.Write("Digite o Modelo do Heliocoptero: ");
        heli.Modelo = Console.ReadLine();
        Console.Write("Digite o Ano de fabricacao do Heliocoptero: ");
        heli.AnoFabricacao = int.Parse(Console.ReadLine());
        Console.Write("Digite o Preco do Heliocoptero: ");
        heli.Preco = double.Parse(Console.ReadLine());
        Console.Write("Digite a capacidade de pessoal suportada pelo Helicoptero: ");
        heli.CapacidadeDePessoas = int.Parse(Console.ReadLine());
        Console.Write("Digite a carga em Kg suportada pelo Heliocoptero: ");
        heli.Carga = double.Parse(Console.ReadLine());
        Console.WriteLine($"Segue os detalhes do Helicoptero:\n\n{heli.ResumoHelicoptero}");
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadKey();
    }

    void MenuSair()
    {
        Console.Clear();
        Console.WriteLine("Dejesa sair?");
        Console.WriteLine("Digite 1 para (sim)\nDigite 2 para (nao)");
        string opcaoSair = Console.ReadLine();
        switch (opcaoSair)
        {
            case "1":
                Console.WriteLine("Voltando para o menu principal em 2 segundos...");
                Thread.Sleep(2000);
                MenuPrincipal();
                break;
            default:
                Console.WriteLine("Saindo...");
                break;

        }
    }

}
MenuPrincipal();


