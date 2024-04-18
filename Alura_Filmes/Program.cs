// Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.
// Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
// Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos 
// como o nome, idade e uma lista de filmes onde o artista atuou.
// Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for '
// adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.
using System.Runtime.Intrinsics.Arm;
using Alura.Filmes;

public class Program
{
    public static void Main(string[] args)
    {
        Filme tinet = new Filme("Tinet");
        Filme madagascar = new Filme("Madasgascar");
        Dictionary<string, Filme> filmesRegistrados = new Dictionary<string, Filme>();

        filmesRegistrados.Add(tinet.NomeFilme, tinet);
        filmesRegistrados.Add(madagascar.NomeFilme, madagascar);

        void MenuPrincipal()
        {
            Console.Clear();
            ModeloTituloMenu("Bem vindo ao Cadastre seu Filme");
            Console.WriteLine("\nEscolha uma opcao:");
        VoltandoAoMenuPrincipal:
            Console.WriteLine("Digite 1 para cadastrar um filme: \nDigite 2 para contratar uma Artista: \nDigite 3 para sair: ");
            string opcaoMenu = Console.ReadLine();
            switch (opcaoMenu)
            {
                case "1":
                    Console.Clear();
                    CadastrandoFilme();
                    break;
                case "2":
                    Console.Clear();
                    CadastrandoArtista();
                    break;
                case "3":
                    Console.WriteLine("Saindo...");

                    break;
                default:
                    Console.WriteLine("Opcao invalida...\nDigite uma opcao valida:");
                    goto VoltandoAoMenuPrincipal;
            }
        }

        void CadastrandoFilme()
        {
            ModeloTituloMenu("Cadastro de Filmes");
            Console.Write($"Digite o nome do filme:");
            string nomeDoFilme = Console.ReadLine();
            Filme filme = new Filme(nomeDoFilme);
            filmesRegistrados.Add(nomeDoFilme, filme);
            Console.WriteLine($"Filme {nomeDoFilme} cadastrado com sucesso!");
            AperteUmBotao();
            MenuSair();

        }

        void CadastrandoArtista()
        {
            ModeloTituloMenu("Cadastro de Artista");
            Console.Write($"Digite o nome do filme para qual o artista atua:");
            string nomeDoFilme = Console.ReadLine();
            if (filmesRegistrados.ContainsKey(nomeDoFilme))
            {
                Console.WriteLine($"Filme {nomeDoFilme} encontrado!\n");            
                Console.Write($"Digite o nome do Artista:");
                string nomeDoArtista = Console.ReadLine()!;
                Console.WriteLine($"Digite a idade do artista:");
                int idade = int.Parse(Console.ReadLine());
                Filme filme = filmesRegistrados[nomeDoFilme];
                filme.AdicionarFilme(new Artista(nomeDoArtista,idade));
                
                Console.WriteLine($"Filme {nomeDoFilme} cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Filme nao encontrado );");
                
            }

            AperteUmBotao();
            MenuSair();

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

        void AperteUmBotao()
        {
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }



    }
}