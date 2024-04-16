Funcionario funcionario = new Funcionario();

Console.WriteLine("Cadatro de funcionario: ");
Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();
Console.Write("Cargo: ");
funcionario.Cargo = Console.ReadLine(); 
Console.Write($"Salario: ");
funcionario.Salario = double.Parse(Console.ReadLine());
Console.Write("Vale Refeicao: ");
funcionario.ValeRefeicao = double.Parse(Console.ReadLine());
Console.Write("ID do Setor: ");
funcionario.IdSetor = int.Parse(Console.ReadLine());
Console.Write("Nome do Setor: ");
funcionario.NomeSetor = Console.ReadLine();


Console.WriteLine(funcionario.Resumo);

