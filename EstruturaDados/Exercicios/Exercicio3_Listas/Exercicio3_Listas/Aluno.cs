using System;
namespace Exercicio3_Listas
{
    public class Aluno
    {
        private string ra;
        private string nome;

        public Aluno()
        {
            { }
        }
        public Aluno(string ra, string nome)
        {
            Ra = ra;
            Nome = nome;
        }

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

        public string Ra
        {
            get => ra;
            set
            {
                if (value.Trim().Length == 0)
                    throw new Exception("Informe um RA válido!");
                ra = value;
            }
        }
    }
}
