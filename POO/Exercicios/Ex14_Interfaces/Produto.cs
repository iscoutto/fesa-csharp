using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex14_Interfaces
{
    class Produto : ICadastro  // implementação da interface na class Produto
            // uma classe que implementa uma interface pode explicitamente implementar membros da interface
    {
            // Atributos
        public double Preco { get; set; }
        public string Nome { get; set; }
        public int Codigo { get; set; }

            // Pesquisa
        public bool Pesquisar(string nome)
        {
            if (File.Exists("dados.txt"))
            {
                string[] linhas = File.ReadAllLines("dados.txt");

                foreach (string linha in linhas)
                {
                    if (linha.Length > 0 && linha[0] == 'P')
                    {
                        string[] dados = linha.Split('|');

                        if (dados[2].ToUpper() == nome.ToUpper())
                        {
                            Codigo = Convert.ToInt32(dados[1]);
                            Nome = dados[2];
                            Preco = Convert.ToDouble(dados[3]);

                            return true;
                        }
                    }
                }
            }
            return false;
        }

            // Salvando
        public void Salvar()
        {
            string c = "P|" + Codigo + "|" + Nome + "|" + Preco + Environment.NewLine;
            File.AppendAllLines("dados.txt", c);
        }
    }
}
