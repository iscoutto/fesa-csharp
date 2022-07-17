using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    internal class ContaCorrente : ContaBancaria
    {
        // Limite
        public double LimiteCredito { get; set; }

        // Cheque
        public bool Cheque { get; set; }

        // Saque
        public override void Saque(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                throw new Exception("O valor do saque não pode ser maior que o saldo disponível!");
        }

        public override string ToString()
        {
            return $">> Conta Corrente:" + Environment.NewLine +
                 $"Nome do Cliente: {NomeCliente}" + Environment.NewLine +
                 $"Numero da Conta: {NumConta}" + Environment.NewLine +
                 $"Saldo + Limite de Crédito: R${Saldo:F2}" + Environment.NewLine +
                 $"Limite de Crédito: R${LimiteCredito:F2}" + Environment.NewLine +
                 $"Utiliza Talão de Cheque: {Cheque}" + Environment.NewLine + Environment.NewLine;
        }
    }
}
