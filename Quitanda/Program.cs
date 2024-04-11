// See https://aka.ms/new-console-template for more information

//declarando atributos
using System.Runtime.CompilerServices;

const string mensagemDeBoasVindas = "Bem vindo a Galery dos Trappers Br!\n";
//List<string> listaDasBandas = new List<string> {"Jé","Igu","Naruto"};

Dictionary<string, List<double>> artistasRegistrados = new Dictionary<string, List<double>>();
artistasRegistrados.Add("Derek", new List<double>{10.0,9.0,6.0});
artistasRegistrados.Add("Jé",new List<double>{3.0,5.0,6.0});



static void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░░█████╗░██╗░░░░░███████╗██████╗░██╗░░░██╗  ████████╗██████╗░░█████╗░██████╗░██████╗░███████╗██████╗░░██████╗
██╔════╝░██╔══██╗██║░░░░░██╔════╝██╔══██╗╚██╗░██╔╝  ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗██╔════╝
██║░░██╗░███████║██║░░░░░█████╗░░██████╔╝░╚████╔╝░  ░░░██║░░░██████╔╝███████║██████╔╝██████╔╝█████╗░░██████╔╝╚█████╗░
██║░░╚██╗██╔══██║██║░░░░░██╔══╝░░██╔══██╗░░╚██╔╝░░  ░░░██║░░░██╔══██╗██╔══██║██╔═══╝░██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗
╚██████╔╝██║░░██║███████╗███████╗██║░░██║░░░██║░░░  ░░░██║░░░██║░░██║██║░░██║██║░░░░░██║░░░░░███████╗██║░░██║██████╔╝
░╚═════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░

██████╗░██████╗░
██╔══██╗██╔══██╗
██████╦╝██████╔╝
██╔══██╗██╔══██╗
██████╦╝██║░░██║
╚═════╝░╚═╝░░╚═╝
            ");
    Console.WriteLine(mensagemDeBoasVindas);

}
//Funcoes
void RegistrarArtistas()
{
    registrarNovamente:
    Console.Clear();
    ExibirTituloDaOpcao("Registrar Artistas");
    Console.Write("Digite o nome do Artista: ");
    string nomeArtista = Console.ReadLine()!;
    Console.WriteLine($"\nO Artista {nomeArtista} foi Registrado com sucesso!!\n");
    artistasRegistrados.Add(nomeArtista, new List<double>());
    Console.WriteLine("Deseja registrar um novo Artista?\nDigite 1 para (SIM)\nDigite 2 ou qualquer outra tecla para (NAO)");
    string opcaoRegistrarArtistas = Console.ReadLine()!;
    switch (opcaoRegistrarArtistas)
    {
        case "1":
            Console.Clear();
            goto registrarNovamente;
        default:
            Console.WriteLine("Aguarde 2 segundos para ser direcionado ao menu...");
            //A funcao Thread.Sleep(2000) faz com que o programa fique 2000 milesegundos parado antes da proxima acao.
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
            break;
    }
    
}

void MostrarArtistasRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo Artistas Registrados");
    // for (int i = 0; i< listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Artista: {listaDasBandas[i]}");
    // }

    foreach (string artista in artistasRegistrados.Keys)
    {
        Console.WriteLine($"Artista: {artista} ");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu:");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Voltando...");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

void AvaliarArtista()
{
    //digite qual artista deseja avaliar
    //verificar se a banda existe no dicionario, ai sim pode atribuir ao dicionario
    //senao, volta ao menu principal
    avaliandoNovamente:
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Artista");
    Console.Write("Digite o nome do Artista que deseja avaliar: ");
    string nomeDoArtista = Console.ReadLine()!;

    if (artistasRegistrados.ContainsKey(nomeDoArtista)){
        Console.Write($"Qual é a nota que o artista {nomeDoArtista} merece? ");
        double nota = double.Parse(Console.ReadLine()!);
        //atribuindo uma nota ao artista digitado no variavel nomeArtista.
        artistasRegistrados[nomeDoArtista].Add(nota);
        Console.WriteLine($"A nota {(nota):f1} para o Artista {nomeDoArtista} foi registrada com sucesso!!.");
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"O artista {nomeDoArtista} nao foi encontrado );");
    }
    Console.WriteLine("Deseja realizar uma nova avaliacao? \nDigite 1 para (SIM)\nDigite 2 ou qualquer outra tecla para (NAO): ");
    string opcaoAvaliacao = Console.ReadLine()!;
    switch (opcaoAvaliacao)
    {
        case "1":
            Console.Clear();
            goto avaliandoNovamente;
        default:
            Console.WriteLine("Aguarde 2 segundos para ser direcionado ao menu...");
            //A funcao Thread.Sleep(2000) faz com que o programa fique 2000 milesegundos parado antes da proxima acao.
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
            break;
    }
    
}

void MediaAvaliacaoArtista()
{
    mediaNovamente:
    Console.Clear();
    ExibirTituloDaOpcao("Media das aviliacoes dos artistas");
    Console.Write("Digite o nome do artista que deseja verificar a media das avaliacoes: ");
    string nomeDoArtista = Console.ReadLine()!;

    if(artistasRegistrados.ContainsKey(nomeDoArtista))
    {
        List<double> mediaDasAvaliacoes = artistasRegistrados[nomeDoArtista];
        Console.WriteLine($"A mediaDasNotas das avaliacoes do artista {nomeDoArtista} é: {mediaDasAvaliacoes.Average():f2}");
    }
    else
    {
        Console.WriteLine($"O artista {nomeDoArtista} nao foi encontrado );");
    }
    Console.WriteLine("Deseja realizar uma nova avaliacao? \nDigite 1 para (SIM)\nDigite 2 ou qualquer outra tecla para (NAO): ");
    string opcaoAvaliacao = Console.ReadLine()!;
    switch (opcaoAvaliacao)
    {
        case "1":
            Console.Clear();
            goto mediaNovamente;
        default:
            Console.WriteLine("Aguarde 2 segundos para ser direcionado ao menu...");
            //A funcao Thread.Sleep(2000) faz com que o programa fique 2000 milesegundos parado antes da proxima acao.
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
            break;
    }
}


//funcao para colocar a quantidade de asterisco de acordo com o tamanho da string titulo.
void ExibirTituloDaOpcao(string titulo)
{
    //int quantidadeDeLetras = titulo.Length;
    //o PadLeft é uma funcao que serve para colocar o caractere definido a esqueda, no caso foi o '-'
    string traco = string.Empty.PadRight(5,'-').PadLeft(5,'-');
    Console.WriteLine(traco+titulo+traco);
}

void ExibirOpcoesDoMenu()
{
opcaoInvalida:
    ExibirLogo();
    Console.WriteLine("Escolha uma opcao no nosso menu: \n");
    Console.WriteLine("Digite 1 - Para cadastrar um Artista");
    Console.WriteLine("Digite 2 - Para listar os Artitas");
    Console.WriteLine("Digite 3 - Para avaliar um artista");
    Console.WriteLine("Digite 4 - Para exibir a media de um Artista");
    Console.WriteLine("Digite 5 - Para sair: ");
    string opcaoEscolhida = Console.ReadLine()!;

    switch (opcaoEscolhida)
    {
        case "1":
            RegistrarArtistas();
            //Console.WriteLine($"Voce escolheu a opcao {opcaoEscolhida} ");
            break;
        case "2":
            MostrarArtistasRegistrados();
            //Console.WriteLine($"Voce escolheu a opcao {opcaoEscolhida} ");
            break;
        case "3":
            AvaliarArtista();
            break;
        case "4":
            MediaAvaliacaoArtista();
            break;
        case "5":
            Console.WriteLine("Flwwwww...");
            break;
        default:
            Console.WriteLine($"Voce escolheu uma opcao invalida ); ");
            Console.WriteLine("Tente Novamente\n");
            goto opcaoInvalida;
    }

}




ExibirOpcoesDoMenu();

