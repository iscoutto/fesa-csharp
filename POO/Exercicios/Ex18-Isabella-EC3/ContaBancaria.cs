using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    abstract class ContaBancaria : Object
    {
        private string nomeCliente;
        private string numConta;

        // Saldo
        private double saldo;
        public double Saldo { get => saldo; set => saldo = value; }

        // Nome
        public string NomeCliente
        {
            get => nomeCliente;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome do cliente deve ser preenchido!");
                else
                    nomeCliente = value;
            }
        }

        // Número conta
        public string NumConta
        {
            get => numConta;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Número da conta é orbigatório!");
                else
                    numConta = value;
            }
        }

        // Método depósito
        public void Deposito(double valor)
        {
            saldo += valor;
        }

        // Método saque
        public virtual void Saque(double valor)
        {
            // virtuial = esse método poderá ser substituído por qualquer classe que o herde
        }

        public override string ToString()
        {
            return $"Nome do Cliente: {NomeCliente}" + Environment.NewLine +
                   $"Numero da Conta: {NumConta}" + Environment.NewLine +
                   $"Saldo: R${Saldo:F2}" + Environment.NewLine;
        }
    }
}
