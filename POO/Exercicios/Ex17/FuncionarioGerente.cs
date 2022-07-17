using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    /*
     * Double BonusEmReais.Este campo deve entrar no cálculo do salário.
     * Int QtdeFuncionariosSubordinados 
     */

    internal class FuncionarioGerente : Funcionario
    {
        public double BonusEmReais { get; set; }

        public int QtdFuncionariosSubordinados { get; set; }

        public override double CalculoSalario()
        {
            return Salario + BonusEmReais;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Bônus: {BonusEmReais:F2}" +
                $"Funcionários subordinados: {QtdFuncionariosSubordinados}";
        }
    }
}
