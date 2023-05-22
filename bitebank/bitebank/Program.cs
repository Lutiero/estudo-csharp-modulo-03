using bitebank.Funcionarios;
using bitebank.Utilitario;

Funcionario eduardo = new Funcionario();

eduardo.Nome = "Eduardo";
eduardo.Cpf = "054.156.854-62";
eduardo.Salario = 10;


GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Console.WriteLine("Funcionario: ");
Console.WriteLine(eduardo.Nome);

gerenciador.Registrar(eduardo);

Console.WriteLine(eduardo.GetBonificacao());


Diretor andreza = new Diretor();

andreza.Nome = "Andreza";
andreza.Cpf = "000.111.555-52";
andreza.Salario = 10;

gerenciador.Registrar(andreza);
Console.WriteLine("Diretora: ");
Console.WriteLine(andreza.Nome);
Console.WriteLine(andreza.GetBonificacao());

Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");

