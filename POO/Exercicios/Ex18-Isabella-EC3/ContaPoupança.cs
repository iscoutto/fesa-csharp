using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    internal class ContaPoupança : ContaBancaria
    {
        // Dia do aniversário
        public int Aniversario { get; set; }

        // Número da conta atrelada à poupança
        private string numContaAtrelada;
        public string NumContaAtrelada
        {
            get => numContaAtrelada;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Informe o número da conta corrente atrelada à conta poupança!");
                else
                    numContaAtrelada = value;
            }
        }

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
            return ">> Conta Poupança: " + Environment.NewLine +
                base.ToString() + $"Número da conta corrente atrelada {NumContaAtrelada}" +
                Environment.NewLine + $"Dia do aniversário: {Aniversario}" + Environment.NewLine;
        }
    }
}
