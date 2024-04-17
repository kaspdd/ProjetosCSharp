using Servicos.Modelos;


void MenuPrincipal()
{
    ModeloTituloMenu("Bem vindo ao Se lasque nas dividas!!");
    Console.WriteLine("\nEscolha uma opcao:");
VoltandoAoMenuPrincipal:
    Console.WriteLine("Digite 1 para realizar um Emprestimo: \nDigite 2 para contratar um Seguro de Veiculos: \nDigite 3 para sair: ");
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
            ContratandoSeguroDeVeiculos();
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

        ModeloTituloMenu("Bem vindo ao menu do Emprestimo!!");
        Console.Write("\nDigite o nome do contratante: ");
        string contratante = Console.ReadLine();
    parcelandoNovamente:
        Console.Write("Digite o valor do emprestimo: ");
        double valor = double.Parse(Console.ReadLine());
        Emprestimo emprestimo = new Emprestimo(valor, contratante);
        if (valor >= 1000 && valor <= 20000)
        {
            Console.Clear();
            Console.WriteLine("Deseja imprimir os dados do Emprestimo? ");
            Console.WriteLine("Digite 1 para (sim) ou Digite 2 ou qualquer outra tecla para sair");
            string opcaoImprimir = Console.ReadLine();
            switch (opcaoImprimir)
            {
                case "1":
                    Console.WriteLine($"Emprestimo solicitado pelo {emprestimo.Responsavel}\nContratante: {emprestimo.Contratante}\nSegue os detalhes: ");
                    Console.WriteLine(emprestimo.Parcelar());
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opcao invalida, por favor digitar um valor entre 1000 e 20000 reais!");
            goto parcelandoNovamente;
        }
    }

    void ContratandoSeguroDeVeiculos()
    {
        ModeloTituloMenu("Bem vindo ao menu do Seguro de Veiculos!!");
        Console.Write("\nDigite o nome do contratante: ");
        string contratante = Console.ReadLine();
        Console.Write("Digite o modelo do veiculo: ");
        string veiculo = Console.ReadLine();
        seguroNovamente:
        Console.Write("Digite o ano do Veiculo: ");
        int anoVeiculo = int.Parse(Console.ReadLine());
        if (anoVeiculo >= 2000 && anoVeiculo <= 2024)
        {
            SeguroVeiculos seguro = new SeguroVeiculos(veiculo, anoVeiculo, contratante);
            Console.WriteLine("Deseja imprimir os dados do Emprestimo? ");
            Console.WriteLine("Digite 1 para (sim) ou Digite 2 ou qualquer outra tecla para sair");
            string opcaoImprimir = Console.ReadLine();
            switch (opcaoImprimir)
            {
                case "1":
                    Console.WriteLine($"Seguro solicitado pelo {seguro.Responsavel}\nContratante: {seguro.Contratante} | Dono do Veiuculo {seguro.Veiculo} do ano {seguro.AnoVeiculo}\nSegue os detalhes: ");
                    Console.WriteLine(seguro.AnoSeguroDeVeiculos());
                    Console.WriteLine("Digite qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opcao invalida, somente carros entre os anos 2000 até 2024 sao permitidos.");
            goto seguroNovamente;
        }
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
        void ModeloTituloMenu(string titulo)
        {
            string traco = string.Empty.PadRight(5, '-').PadLeft(5, '-');
            Console.WriteLine(traco + titulo + traco);
        }

    }

    MenuPrincipal();