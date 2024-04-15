// See https://aka.ms/new-console-template for more information
//1 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
//variaveis
using System.Runtime.CompilerServices;
List<string> listaMaterias = new List<string> {"matematica","Portugues"};


Dictionary<string, Dictionary<string, List<double>>> listaAlunos = new Dictionary<string,Dictionary<string, List<double>>>
{
{"Carlos", new Dictionary<string, List<double>>
    {
        {listaMaterias.ElementAt(0), new List<double> {10.0,9.0,8.0}},
        {listaMaterias.ElementAt(1), new List<double> {10.0,9.0,8.0}}
    }
},
{"Juju", new Dictionary<string, List<double>>
    {
        {listaMaterias.ElementAt(0), new List<double> {7.0,6.0,8.0}},
        {listaMaterias.ElementAt(1), new List<double> {10.0,6.0,9.0}}
    }
}
};



//chamando funcoes






//funcoes
void TituloAluno ()
{
    ModeloTitulo("Bem vindo ao");
    Console.WriteLine(@"
    🅼🅴🅳🅸🅰 🅰🅻🆄🅽🅾🆂
    ");
}

void CadastrarAlunos()
{
    registrarNovamente:
    ModeloTitulo("Cadastrando Aluno");
    Console.Write("Digite o nome do aluno: ");
    string nomeAluno = Console.ReadLine()!;
    Console.WriteLine($"O aluno {nomeAluno} foi cadastrado com sucesso!");
    //listaAlunos.Add(nomeAluno, new Dictionary<string, List<double>>());
    listaAlunos.Add(nomeAluno, new Dictionary<string, List<double>>());
    Console.WriteLine("Deseja registrar um novo Aluno?\nDigite 1 para (SIM)\nDigite 2 ou qualquer outra tecla para (NAO)");
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
            MenuAluno();
            break;
    }
}

void CadastrarNota()
{
    ModeloTitulo("Cadastrar nota do aluno");
    cadastrandoMateriaNovamente:
    Console.Write("Digite o nome do aluno que desejas cadastrar a nota: ");
    string nomeAluno = Console.ReadLine()!;
    if (listaAlunos.ContainsKey(nomeAluno))
    {
        Console.WriteLine($"Aluno {nomeAluno} encontrado!");
        cadastrandoNotaNovamente:
        Console.Write("Digite o nome da materia: ");
        string materia = Console.ReadLine()!;
        if (listaMaterias.Contains(materia))
        {
            
            Console.Write($"Digite a nota para a materia {materia}: ");
            double nota = double.Parse(Console.ReadLine()!);
            listaAlunos[nomeAluno][materia].Add(nota);
            Console.Write("Nota cadastrada!");
        }
        else
        {
            Console.WriteLine("Nota nao cadastrada!");
            Console.WriteLine("Por favor digite uma materia cadastrada: ");
            goto cadastrandoNotaNovamente;

        }
    }
    else
    {
        Console.WriteLine("O aluno pesquisado nao foi cadastrado );");
        Console.WriteLine("Por favor digite o nome de um aluno cadastrado: ");
        goto cadastrandoMateriaNovamente;
    }
}

void MostrarAlunosCadastrados()
{
    Console.Clear();
    ModeloTitulo("Exibindo Artistas Registrados");
    // for (int i = 0; i< listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Artista: {listaDasBandas[i]}");
    // }

    foreach (string alunos in listaAlunos.Keys)
    {
        Console.WriteLine($"Artista: {alunos} ");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu:");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Voltando...");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}


void ModeloTitulo(string titulo)
{
    string traco = string.Empty.PadRight(5,'-').PadLeft(5,'-');
    Console.WriteLine(traco+titulo+traco);
}


//menu
void MenuAluno()
{
    TituloAluno();
    Console.WriteLine("Esolha uma opcao:");
    Console.WriteLine ("1 - Cadastrar um aluno: ");
    Console.WriteLine ("2 - Para cadastrar uma nota ao aluno: ");
    Console.WriteLine ("3 - Para verificar a media do aluno");
    string opcaoMenu = Console.ReadLine ();

    switch (opcaoMenu) 
    {
        case "1":
            CadastrarAlunos();
            
            break;
        case "2":
            CadastrarNota();
            break;
        case "3":
            MostrarAlunosCadastrados();
            break;
    }
}


