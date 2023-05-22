using bitebank.Funcionarios;
using bitebank.Utilitario;

#region
//Funcionario eduardo = new Funcionario("Eduardo", "054.156.854-62", 2000);

//Console.WriteLine($"Funcionário: {eduardo.Nome}");
//Console.WriteLine($"Salário: {eduardo.Salario}");
//Console.WriteLine($"Bonificação: {eduardo.GetBonificacao()}");

//Diretor andreza = new Diretor("Andreza", "000.111.555-52");

//Console.WriteLine($"Diretora: {andreza.Nome}");
//Console.WriteLine($"Salário: {andreza.Salario}");
//Console.WriteLine($"Bonificação: {andreza.GetBonificacao()}");

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(eduardo);
//gerenciador.Registrar(andreza);

//Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
//Console.WriteLine($"Total de funcionários: {Funcionario.TotalDefuncionarios}");

//eduardo.AumentarSalario();
//andreza.AumentarSalario();
//Console.WriteLine($"Novo salário Eduardo: {eduardo.Salario}");
//Console.WriteLine($"Novo salário Andreza: {andreza.Salario}");
#endregion

CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Diretor diretor = new Diretor("Arnaldo, o diretor", "879.151.874-25");
    Auxiliar auxiliar = new Auxiliar("João, o Auxiliar", "000.111.222-33");
    Designer designer = new Designer("Maria, A designer", "999.888.777-66");
    GerenteDeContas gerenteDeContas = new GerenteDeContas("Eduardo, o gerente de contas", "555.555.555-66");

    gerenciador.Registrar(diretor); //5000
    gerenciador.Registrar(auxiliar); //2000
    gerenciador.Registrar(designer); //3000
    gerenciador.Registrar(gerenteDeContas); //4000

    Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");

}

