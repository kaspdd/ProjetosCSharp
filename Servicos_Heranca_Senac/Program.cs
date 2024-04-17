using Servicos.Modelos;


void MenuPrincipal()
{
    
    Console.WriteLine("Bem vindo ao Se lasque nas dividas!!\n");
    Console.WriteLine("Escolha uma opcao:");
    VoltandoAoMenuPrincipal:
    Console.Write("Digite 1 para realizar um Emprestimo: \nDigite 2 para contratar um Seguro de Veiculos: \nDigite 3 para sair: ");
    string opcaoMenu = Console.ReadLine();
    switch (opcaoMenu)
    {
        case "1":
            Console.Clear();
            ContratandoEmprestimo();
            MenuSair();
            break;
        case "2":
            Console.Clear();
            ContratandoSeguroDeVida();
            MenuSair();
            break;
        case "3":
            Console.WriteLine("Saindo...");

            break;
        default:
            Console.WriteLine("Opcao invalida...\nDigite uma opcao valida:");
            goto VoltandoAoMenuPrincipal;
    }

    void ContratandoEmprestimo()
    {
        Console.WriteLine("Bem vindo ao menu do Emprestimo!!");
        Console.WriteLine("Digite o nome do contratante: ");
        string contratante = Console.ReadLine();
        Console.WriteLine("Digite o valor do emprestimo: ");
        double valor = double.Parse(Console.ReadLine());
        Emprestimo emprestimo= new Emprestimo(valor);
        Console.Clear();
        Console.WriteLine("Deseja imprimir os dados do Emprestimo? ");
        Console.WriteLine("Digite 1 para (sim) ou Digite 2 ou qualquer outra tecla para sair");
        string opcaoImprimir = Console.ReadLine();
        switch(opcaoImprimir)
        {
            case "1":
                Console.WriteLine($"Emprestimo solicitado via {emprestimo.Responsavel}\nO Contratante {emprestimo.Contratante}\n Segue os detalhes: ");
                Console.WriteLine(emprestimo.Parcelar());
                 Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
                break;
            default:
                Console.WriteLine("Saindo...");
                break;
        }
    }

    void ContratandoSeguroDeVida()
    {

    }

     void MenuSair()
    {
        Console.Clear();
        Console.WriteLine("Dejesa voltar ao menu principal?");
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