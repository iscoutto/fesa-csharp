using System;

namespace AgendaTelefonica
{
    public class Lista
    {
        private const int CAPACIDADE = 1000;
        private Contato[] dados = new Contato[CAPACIDADE];
        private int quantidade = 0;

        public int Tamanho()
        {
            return quantidade;
        }

        public void InsereNaPosicao(int p_posicao, Contato p_valor)
        {
            if (Tamanho() == CAPACIDADE)
                throw new Exception("A lista está cheia!!!\n\n");
            else if (p_posicao > Tamanho())
                throw new Exception("Não é possível inserir nesta posição");
            else
            {
                quantidade++;
                for (int i = Tamanho() - 1; i > p_posicao; i--)
                {
                    dados[i] = dados[i - 1];
                }
                dados[p_posicao] = p_valor;
            }
        }

        public Contato RemoveDaPosicao(string nome)
        {
            int posicao = -1;

            if (Tamanho() == 0)
                throw new Exception("A lista está vazia!!!");
            else if (posicao > Tamanho() - 1)
                throw new Exception("Posição inválida!!!");
            else
            {
                Contato a = new Contato();
                for (int i = 0; i < this.Tamanho(); i++)
                {
                    if (dados[i] == null || dados[i].Nome != nome)
                        continue;

                    posicao = i;
                    break;
                }
                if (posicao < 0)
                    throw new Exception("Contato não encontrado!");

                Contato aux = dados[posicao];

                for (int i = posicao; i < Tamanho() - 1; i++)
                    dados[i] = dados[i + 1];

                quantidade--;
                return aux;
            }
        }

        public void InsereNoInicio(Contato p_valor)
        {
            InsereNaPosicao(0, p_valor);
        }

        public void InsereNoFim(Contato p_valor)
        {
            InsereNaPosicao(Tamanho(), p_valor);
        }

        public void ImprimeLista()
        {
            Console.WriteLine("\n\nImpressão dos dados da lista de contatos:\n");
            for (int i = 0; i < Tamanho(); i++)
            {
                Console.WriteLine(dados[i].Nome + " | " + dados[i].Telefone);
            }
        }

        public Contato PesquisaContato(string nome)
        {
            nome = nome.Trim();

            if (string.IsNullOrEmpty(nome))
                throw new Exception("Nome inválido");

            Contato novoContato = new Contato();

            for (int i = 0; i < this.Tamanho(); i++)
            {
                if (dados[i] == null || dados[i].Nome != nome)
                    continue;
                novoContato = dados[i];
                break;
            }
            return novoContato;
        }

        public void AlteraContato(string nome)
        {
            Console.WriteLine("\n<< ATUALIZAR CONTATO >>\n");

            string resposta;
            Contato a = new Contato();
            do
            {
                Console.WriteLine("Novo nome: ");
                string novoNome = Console.ReadLine();
                novoNome = a.Nome;

                Console.WriteLine("Novo telefone: ");
                string novoTelefone = Console.ReadLine();
                novoTelefone = a.Telefone;

                Console.WriteLine("Salvar alterções? (S/N)");
                resposta = Console.ReadLine();

                if (resposta.ToUpper() == "S")
                    InsereNoFim(a);

            } while (resposta.ToUpper() == "N");
            Console.WriteLine("\nContato atualizado!");
        }
    }
}