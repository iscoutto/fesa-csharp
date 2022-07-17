using System;
namespace Exercicio11_Listas
{
    public class ContaCorrente
    {
        #region Propriedades

        public int Agencia { get; set; }

        string conta;
        public string Conta
        {
            get => conta;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha o número da conta!");
                conta = value;
            }
        }

        public string Titular { get; set; }

        public double Saldo { get; private set; }   // somente leitura

        #endregion

        #region Construtor

        public ContaCorrente()
        {
            { }
        }

        public ContaCorrente(int agencia, string conta, string titular)
        {
            Saldo = 0;
            Agencia = agencia;
            Conta = conta;
            Titular = titular;
        }

        #endregion

        #region Métodos

        public void Deposito(double valor)
        {
            if (valor <= 0)
                throw new Exception("Valor deve ser positivo!");

            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (Saldo < valor)
                throw new Exception("Saldo insuficiente!");

            Saldo -= valor;
        }

        public static implicit operator string(ContaCorrente v)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}