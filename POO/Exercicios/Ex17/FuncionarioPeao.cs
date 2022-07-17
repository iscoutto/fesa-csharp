using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    // Double HoraExtraEmReais. Este campo deve entrar no cálculo do salário.

    internal class FuncionarioPeao : Funcionario
    {
        public double ValorHoraExtra { get; set; }

        public override double CalculoSalario()
        {
            return Salario + ValorHoraExtra;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Hora extra: R${ValorHoraExtra:F2}";
            // A palavra-chave base é usada para acessar membros de classe base de dentro de uma classe derivada
        }
    }
}
