using System;
using System.Globalization;
namespace Exercicio3
{
    /*
         Crie uma classe para representar um funcionário. A classe deve ter os seguintes atributos:
            Código (int) : deve ser > 0
            Nome (string) : (obrigatório)
            RG (string) : (obrigatório)
            Salario (double) : deve ser >=0

            Encapsule os atributos com métodos Get/Set.

            Crie também os seguintes métodos:

            GetInss(): deve calcular o valor do INSS (11% do salário) e devolver este valor.
            CalcularSalario() : Este método deverá retornar o salário do funcionário subtraído do INSS.
            Crie um formulário para preencher os campos do cadastro.
            Crie um botão para exibir os valores gravados na classe em um Textbox multiline. 
         */


    public class Funcionario
    {
        private int codigo;
        private string nome;
        private string rg;
        private double inss;
        private double salario;


        #region Codigo


        public void SetCodigo(int valorCodigo)
        {
            if (valorCodigo > 0)
                codigo = valorCodigo;
            else
                throw new Exception("Código deve ser maior que zero!");
        }

        public int GetCodigo()
        {
            return codigo;
        }

        #endregion



        #region Nome

        public void SetNome(string nome)
        {
            if (nome.Trim().Length == 0)
                throw new Exception("Nome é obrigatório!");
            else
                this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        #endregion

        #region RG

        public void SetRg(string rg)
        {
            if (rg.Trim().Length == 0)
                throw new Exception("Nome é obrigatório!");
            else
                this.rg = rg;
        }

        public string GetRg()
        {
            return rg;
        }

        #endregion

        #region Salario

        public void SetSalario(double salario)
        {
            if (salario >= 0)
                this.salario = salario;
            else
                throw new Exception("Salário deve ser maior ou igual a zero!");
        }

        public double GetSalario()
        {
            return salario;
        }

        #endregion

        #region Inss

        public double GetInss()
        {
            inss = (0.11 * salario);
            return inss;
        }

        #endregion

        #region CalcularSalario

        public double CalcularSalario()
        {
            return salario - inss;
        }

        #endregion

    }
}



