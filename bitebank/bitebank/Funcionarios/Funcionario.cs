using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitebank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDefuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDefuncionarios++;
        }


        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
