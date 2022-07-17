using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_16
{
         /*
         * Crie uma classe para representar jogos. Deve haver os seguintes campos:
         *      Codigo  : int  ( > 0)
         *      Descricao  : string  (obrigatório)
         *      Dificuldade: Enumerador(easy, normal, hard) (obrigatório)
         *      Valor : double  >= 1,00
         *      Fabricante : Obrigatório. Exiba uma lista (ou caixa combo) de 
         * fabricantes e permita que o usuário selecione 1 valor da lista.
         */

    class Jogo
    {
        const string ARQUIVO = "Jogo.txt";

        // Código
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set
            {
                if (value <= 0)
                    throw new Exception("Código deve ser maior que zero!");
                codigo = value;
            }
        }

        // Descricao
        string descricao;   // descrição deverá ser obrigatório

        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Descrição deve ser preenchida corretamente!");
                descricao = value;
            }
        }

        // Acessando o enumerador dificuldade do jogo
        public EnumDificuldade Dificuldade { get; set; }

        // Valor
        double valor;

        public double Valor
        {
            get { return valor; }
            set
            {
                if (value < 1)
                    throw new Exception("Valor inválido!");
                valor = value;
            }
        }

        // Acessando a classe fabricante
        public Fabricante Fabricante { get; set; }

        // Salvando
        public void Salvar()
        {
            string linha =
                Codigo.ToString() + "|" +
                Descricao.ToString() + "|" +
                Valor.ToString() + "|" +
                ((int)Dificuldade).ToString() + "|" +
                Fabricante.Id +
                Environment.NewLine;

            File.AppendAllText(ARQUIVO, linha);
        }

        // Lista de fabricantes

        public static List<Jogo> Listar(List<Fabricante> listaFabricantes)
        {
            List<Jogo> lista = new List<Jogo>();

            if (!File.Exists(ARQUIVO))  // '!' = null-forgiving operator, used to declare that a reference type isn't null
                return lista;

            StreamReader reader = new StreamReader(ARQUIVO);    // streamreader implementa um TextReader que lê caracteres de um fluxo de bytes em uma codificação específica

            try
            {
                string linha;
                // Lê e exibe as linhas do arquivo até o final do mesmo
                while ((linha = reader.ReadLine()) != null)
                {
                    if (linha.Trim().Length == 0)
                        continue;

                    Jogo jogo = new Jogo();
                    jogo.codigo = Convert.ToInt32(linha.Substring(0, linha.IndexOf('|')));  // substring method retrieves a substring from a string 
                    linha = linha.Remove(0, linha.IndexOf('|') + 1);

                    jogo.Descricao = linha.Substring(0, linha.IndexOf('|'));
                    linha = linha.Remove(0, linha.IndexOf('|') + 1);

                    jogo.valor = Convert.ToDouble(linha.Substring(0, linha.IndexOf('|')));
                    linha = linha.Remove(0, linha.IndexOf('|') + 1);

                    jogo.Dificuldade = (EnumDificuldade)Convert.ToInt32(linha.Substring(0, linha.IndexOf('|')));
                    linha = linha.Remove(0, linha.IndexOf('|') + 1);

                    int IdFabricante = Convert.ToInt32(linha);

                    jogo.Fabricante = listaFabricantes.Find(f => f.Id == IdFabricante); // '.Find' encontra o primeiro elemento correspondente às condições definidas
                    lista.Add(jogo);
                }
                return lista;
            }
            finally
            {
                reader.Close();
            }
        }

        /*
         * Deve haver 2 métodos sobrecarregados para atualizar o preço dos jogos. 
         * Um deles deverá receber por parâmetro um inteiro que representa o percentual 
         * que será aplicado sobre o preço do jogo. O outro deverá receber por parâmetro 
         * um double que representa o valor em reais que deverá ser adicionado ao preço 
         * do jogo.
         */

        public void AtualizaPreco(int percentual)
        {
            valor += (valor * ((double)percentual / 100));
        }

        public void AtualizaPreco(double acrescismo)
        {
            valor += acrescismo;
        }
    }
}
