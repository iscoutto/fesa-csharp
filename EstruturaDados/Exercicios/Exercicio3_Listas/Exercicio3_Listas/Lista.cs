using System;
namespace Exercicio3_Listas
{
    public class Lista
    {
        #region Lista

        private const int CAPACIDADE = 32;
        private Aluno[] dados = new Aluno[CAPACIDADE];
        private int quantidade = 0;

        public int Tamanho()
        {
            return quantidade;
        }
        public void InsereNaPosicao(int p_posicao, Aluno p_valor)
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
        public Aluno RemoveDaPosicao(string ra)
        {
            int posicao = -1;

            if (Tamanho() == 0)
                throw new Exception("A lista está vazia!");
            else if (string.IsNullOrEmpty(ra))
                throw new Exception("RA inválido!");
            else
            {
                Aluno a = new Aluno();
                for (int i = 0; i < this.Tamanho(); i++)
                {
                    if (dados[i] == null || dados[i].Ra != ra)
                        continue;
                    posicao = i;
                    break;
                }
                if (posicao < 0)
                    throw new Exception("Aluno não encontrado!");

                Aluno aux = dados[posicao];
                for (int i = posicao; i < Tamanho() - 1; i++)
                {
                    dados[i] = dados[i + 1];
                }
                quantidade--;
                return aux;
            }
        }

        public void InsereNoInicio(Aluno p_valor)
        {
            InsereNaPosicao(0, p_valor);
        }

        public void InsereNoFim(Aluno p_valor)
        {
            InsereNaPosicao(Tamanho(), p_valor);
        }

        public void ImprimeLista()
        {
            Console.WriteLine("\n\nImpressão dos dados da lista:\n");
            for (int i = 0; i < Tamanho(); i++)
            {
                Console.WriteLine(dados[i]);
            }
        }

        #endregion

        #region Métodos

        public Aluno RetornaPrimeiro()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A lista está vazia!");
            }
            else
            {
                return dados[0];
            }
        }

        public Aluno RetornaUltimo()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A lista está vazia!");
            }
            else
            {
                return dados[Tamanho() - 1];
            }
        }

        public Aluno[] RetornaDados()
        {
            if (Tamanho() == 0)
                throw new Exception("A lista está vazia.");

            Aluno[] alunos = new Aluno[Tamanho()];
            for (int i = 0; i < Tamanho(); i++)
            {
                alunos[i] = dados[i];
            }
            return alunos;
        }

        #endregion
    }
}