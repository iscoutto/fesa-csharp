using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17
{
    /*
     * Double MetaDeVendaMesEmReais 
     * Double VendasdoMesEmReais    
     * Double PorcentagemSobreVendas (para incorporar no salário). Exemplo: 10%, deve-se calcular 10% sobre o campo    VendasdoMesEmReais e incorporar ao salário durante o cálculo. Este valor só será aplicado se a meta for atingida.	
     */

    internal class FuncionarioVendedor : Funcionario
    {
        public Double MetaVendasMes { get; set; }
        public Double VendasMes { get; set; }
        public Double PorcentagemSobreVendas { get; set; }

        public override double CalculoSalario()
        {
            if (VendasMes >= MetaVendasMes)
            {
                return Salario + VendasMes *
                    (PorcentagemSobreVendas / 100);
            }
            else
                return Salario;
        }

        public override string ToString()
        {
            return base.ToString() +
                $" - Meta: R${MetaVendasMes:F2} " +
                $" - Vendas no mês: R${VendasMes:F2} " +
                $" - Porcentagem sobre as vendas: {PorcentagemSobreVendas} ";
        }
    }
}
