using System;
namespace Exercicio5
{
    public class Aluno
    {
        private string nome;
        //private string sobrenome;
        private double nota1;
        private double nota2;

        
        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Informe o nome!");
                else
                    nome = value;
            }
        }

        public double Nota1
        {
            get => nota1;
            set
            {
                if (value < 0)
                    throw new Exception("Nota deve estar entre 0 e 10!");
                else if (value > 10)
                    throw new Exception("Nota deve estar entre 0 e 10!");
                else
                    nota1 = value;
            }
        }

        public double Nota2
        {
            get => nota2;
            set
            {
                if (value < 0)
                    throw new Exception("Nota deve estar entre 0 e 10!");
                else if (value > 10)
                    throw new Exception("Nota deve estar entre 0 e 10!");
                else
                    nota2 = value;
            }
        }

        public double Media
        {
            get => (nota1 + nota2) / 2;
        }        
    }
}
