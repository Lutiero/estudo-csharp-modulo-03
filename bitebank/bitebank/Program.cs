using bitebank.Funcionarios;

Funcionario eduardo = new Funcionario();

eduardo.Nome = "Eduardo Abreu";
eduardo.Cpf = "051.123.547-51";
eduardo.Salario = 10;
Console.WriteLine(eduardo.Nome);
Console.WriteLine(eduardo.GetBonificacao());
