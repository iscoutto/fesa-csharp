using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex14_Interfaces
{
    class Funcionario : ICadastro
    {
            // Código
        private int codigo;

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("Código inválido.");
                codigo = value;
            }
        }

            // Nome
        public string Nome { get; set; }

            // Pesquisa
        public bool Pesquisar(string nome)
        {
            if (File.Exists("dados.txt"))
            {
                string[] linhas = File.ReadAllLines("dados.txt");

                foreach (string linha in linhas)
                {
                    if (linha.Length > 0 && linha[0] == 'F' &&
                        linha.ToUpper().Contains(nome.ToUpper()))
                    {
                        string[] dados = linha.Split('|');
                        if (dados[2].ToUpper() == nome.ToUpper())
                        {
                            this.Codigo = Convert.ToInt32(dados[1]);
                            this.Nome = dados[2];
                            return true;
                        }
                    }
                }
            }
            return false;
        }

            // Lista
        public static List<Funcionario> Listar(string filtroNome)
        {
            var lista = new List<Funcionario>();

            if (File.Exists("dados.txt"))
            {
                string[] linhas = File.ReadAllLines("dados.txt");

                foreach (string linha in linhas)
                {
                    if (linha.Length > 0 && linha[0] == 'F' &&
                        linha.ToUpper().Contains(filtroNome.ToUpper()))
                    {
                        string[] dados = linha.Split('|');
                        Funcionario f = new Funcionario();
                        f.Codigo = Convert.ToInt32(dados[1]);
                        f.Nome = dados[2];
                        lista.Add(f);
                    }
                }
            }
            return lista;
        }

            // Salvando
        public void Salvar()
        {
            string c = "F|" + Codigo + "|" + Nome + Environment.NewLine;
            File.AppendAllLines("dados.txt", c);
        }
    }
}
