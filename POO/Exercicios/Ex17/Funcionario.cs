using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    /*
     * Código  int
       Nome  string
       Salário: Double
       Double CalculoSalario()  método que calcula o salário. Neste método, apenas retorne o salário.
       Sobrescreva  o método ToString() para devolver os atributos básicos, além do salário calculado.
     */
    internal class Funcionario
    {
        // Código
        public int Codigo { get; set; }

        // Nome
        public string Nome { get; set; }
        
        // Salário
        public double Salario { get; set; }

        // Cálculo do salário
        public virtual double CalculoSalario()
        {
            return Salario;

            // virtual = permite que a declaração do método seja substituída em uma classe derivada
        }

        // Sobreescrevendo o método
        public override string ToString()
        {
            return $"Código: {Codigo} Nome: {Nome} " +
                   $"Salário: R${Salario:F2} " +
                   $"Salário final: R${CalculoSalario():F2}";
        }
    }
}
