using System;
using System.Linq;

namespace AgendaTelefonica
{
    public class Contato
    {
        private string nome;
        private string telefone;

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome do contato é obrigatório!");
                else
                    nome = value;
            }
        }

        public string Telefone
        {
            get => telefone;
            set
            {
                if (value.All(char.IsDigit))
                    telefone = value;
                else
                    throw new Exception("Digite apenas números inteiros!");
            }
        }

        public Contato()
        {
            { }
        }

        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}
