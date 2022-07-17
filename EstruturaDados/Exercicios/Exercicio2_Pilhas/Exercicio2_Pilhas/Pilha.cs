using System;
namespace Exercicio2_Pilhas
{
    public class Pilha
    {
        private const int CAPACIDADE = 5;
        private Funcionario[] dados = new Funcionario[CAPACIDADE];
        private int topo = -1;

        public int Tamanho()
        {
            return topo + 1;
        }

        public void Empilha(Funcionario p_valor)
        {
            if (Tamanho() != CAPACIDADE)
            {
                topo++;
                dados[topo] = p_valor;
            }
            else
                throw new Exception("O armazenamento de funcionários está cheio! (pilha cheia)");
        }

        public Funcionario Desempilha()
        {
            if (Tamanho() == 0)
                throw new Exception("Nenhum funcionário está cadastrado (pilha vazia)");
            else
            {
                Funcionario retorno = dados[topo];
                dados[topo] = null;
                topo--;
                return retorno;
            }
        }

        public Funcionario RetornaTopo()
        {
            if (Tamanho() == 0)
                return dados[topo];
            else
                throw new Exception("A pilha está vazia.");
        }
    }
}

