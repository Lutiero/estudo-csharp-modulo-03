﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitebank.Funcionarios
{
    public class Designer:Funcionario
    {
        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
