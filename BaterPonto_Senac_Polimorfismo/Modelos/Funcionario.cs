namespace BaterPonto.Modelos;

internal class Funcionario : Setor
{
    public Funcionario(string nomeFucionario, int idFuncionario, string cargoFuncionario, int idSetor)
    {
        NomeFuncionario = nomeFucionario;
        IdFuncionario = idFuncionario;
        CargoFuncionario = cargoFuncionario;
        IdSetor = idSetor;
    }
    private List<Funcionario> admFuncionario = new List<Funcionario>();
    private List<Funcionario> proFuncionario = new List<Funcionario>();
    private List<Funcionario> comFuncionario = new List<Funcionario>();
    private List<Funcionario> funcioanrios = new List<Funcionario>();
    public int IdFuncionario { get; }
    public string NomeFuncionario { get; }
    public string CargoFuncionario { get; }
    public string resumoFuncionario => $"\nId funcionario: {IdFuncionario}\nFuncionario: {NomeFuncionario}\nCargo: {CargoFuncionario}\nId do setor: {IdSetor}\nNome do setor: {NomeSetor}\n";



    public void Administrativo(Funcionario funcionario)
    {
        admFuncionario.Add(funcionario);
        funcioanrios.Add(funcionario);

        Console.WriteLine($"Deseja verificar os funcionarios cadastrados no setor Comercial: ");
        listandoNovamente:
        Console.WriteLine($"Digite 1 para (sim)\nDigite 2 para (nao)");

        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.WriteLine($"Lista de funcionarios do setor Comercial: ");
                foreach (var f in proFuncionario)
                {
                    Console.WriteLine(f.resumoFuncionario);
                }
                break;
            case "2":
                Console.WriteLine($"Voltando ao menu...");
                Thread.Sleep(2000);
                break;
            default:
                Console.WriteLine($"Voce escolheu uma opcao invailida, por favor tentar novamente.");
                goto listandoNovamente;
        }


    }
    public void Producao(Funcionario funcionario)
    {
        proFuncionario.Add(funcionario);
        funcioanrios.Add(funcionario);
        Console.WriteLine($"Deseja verificar os funcionarios cadastrados no setor Comercial: ");
        listandoNovamente:
        Console.WriteLine($"Digite 1 para (sim)\nDigite 2 para (nao)");

        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.WriteLine($"Lista de funcionarios do setor Comercial: ");
                foreach (var f in proFuncionario)
                {
                    Console.WriteLine(f.resumoFuncionario);
                }
                break;
            case "2":
                Console.WriteLine($"Voltando ao menu...");
                Thread.Sleep(2000);
                break;
            default:
                Console.WriteLine($"Voce escolheu uma opcao invailida, por favor tentar novamente.");
                goto listandoNovamente;
        }
    }
    public void Comercial(Funcionario funcionario)
    {
        comFuncionario.Add(funcionario);
        funcioanrios.Add(funcionario);
        Console.WriteLine($"Deseja verificar os funcionarios cadastrados no setor Comercial: ");
        listandoNovamente:
        Console.WriteLine($"Digite 1 para (sim)\nDigite 2 para (nao)");

        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.WriteLine($"Lista de funcionarios do setor Comercial: ");
                foreach (var f in comFuncionario)
                {
                    Console.WriteLine(f.resumoFuncionario);
                }
                break;
            case "2":
                Console.WriteLine($"Voltando ao menu...");
                Thread.Sleep(2000);
                break;
            default:
                Console.WriteLine($"Voce escolheu uma opcao invailida, por favor tentar novamente.");
                goto listandoNovamente;
        }

    }

    public void MostrarFuncionarios()
    {
        Console.WriteLine($"Segue a lista de funcionarios:");

        foreach (var f in funcioanrios)
        {
            Console.WriteLine(f.resumoFuncionario);
        }
    }



    // public void VerificarSetor()
    // {
    //     if (IdSetor.Equals(1))
    //     {
    //         NomeSetor = "Administrativo";
    //     }
    //     else if (IdSetor.Equals(2))
    //     {
    //         NomeSetor = "producao";
    //     }
    //     else if (IdSetor.Equals(3))
    //     {
    //         NomeSetor = "Comercial";
    //     }
    //     else
    //     {
    //         Console.WriteLine($"Funcinario nao pertence a um setor cadastrado, por favor digitar o id novamente cadastrado.");

    //     }

    // } 




}