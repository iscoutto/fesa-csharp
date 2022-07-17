using System;
namespace Exercicio9_Construtores
{
    public class Aluno
    { 
        private string nome;
        private double nota2;
        private double nota1;

        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().IndexOf(' ') == -1)
                    throw new Exception("Informe um nome com sobrenome!");
                nome = value;
            }
        }

        public double Nota1
        {
            get => nota1;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Digite a nota de 0 a 10!");
                nota1 = value;
            }
        }

        public double Nota2
        {
            get => nota2;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Digite a nota de 0 a 10!");
                nota2 = value;
            }
        }

        public double Media
        {
            get
            {
                return (nota1 + nota2) / 2;
            }
        }

        public Aluno()
        {
            { }
        }

        public Aluno(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
        }
    }
}