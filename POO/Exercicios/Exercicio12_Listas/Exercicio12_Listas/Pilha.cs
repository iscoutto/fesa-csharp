using System;
namespace Exercicio12_Listas
{
    public class Pilha
    {
        private readonly int CAPACIDADE;
        // readonly = impede que a variável seja alterada fora do construtor da classe
        private string[] dados;
        private int topo = -1;
        private int quantidade = 0;

        public Pilha()
        {
            { }
        }

        public Pilha(int capacidade)
        {
            this.CAPACIDADE = capacidade;
            this.dados = new string[CAPACIDADE];
        }

        public int Tamanho()
        {
            return topo + 1;
        }

        public bool Vazia()
        {
            return Tamanho() == 0;
        }

        public void Empilha(string p_valor)
        {
            if (Tamanho() != CAPACIDADE)
            {
                topo++;
                dados[topo] = p_valor;
            }
            else
                throw new Exception("A pilha está cheia!");
        }

        public void EmpilhaPosicao(string p_valor, int p_posicao)
        {
            if (Tamanho() == CAPACIDADE)
                throw new Exception("A pilha está cheia!\n\n");
            else if (p_posicao > Tamanho())
                throw new Exception("Posição inválida!");
            else
            {
                quantidade++;
                topo++;
                for (int i = Tamanho() - 1; i > p_posicao; i--)
                {
                    dados[i] = dados[i - 1];
                }
                dados[p_posicao] = p_valor;
            }
        }

        public string Desempilha()
        {
            if (Vazia() == true)
                throw new Exception("A pilha está vazia!");
            else
            {
                string retorno = dados[topo];
                dados[topo] = null;
                topo--;
                return retorno;
            }
        }

        public string DesempilhaPosicao(int posicao)
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha está vazia!");
            else if (posicao > Tamanho() - 1)
                throw new Exception("Posição inválida!");
            else
            {
                string aux = dados[posicao];
                for (int i = posicao; i < Tamanho() - 1; i++)
                {
                    dados[i] = dados[i + 1];
                }
                dados[Tamanho() - 1] = null;
                quantidade--;
                topo--;
                return aux;
            }
        }

        public string RetornaTopo()
        {
            if (Vazia() == true)
                throw new Exception("A pilha está vazia!");
            else
                return dados[topo];
        }
    }
}