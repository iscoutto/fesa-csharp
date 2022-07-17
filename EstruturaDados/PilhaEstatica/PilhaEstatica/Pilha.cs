using System;
namespace PilhaEstatica
{
    // definição da classe pilha

    public class Pilha
    {
        private const int CAPACIDADE = 5;   //define o tamanho maximo desta pilha
        private string[] dados = new string[CAPACIDADE];    // vetor para guardar dados da pilha
        private int topo = -1;  // variável que irá indicar a posição do vetor do topo da pilha

        // método que informa o tamanho da pilha
        public int Tamanho()
        {
            return topo + 1;    // vetor inicia-se na posição 0
        }

        // esse método retorna 'true' se a pilha estiver vazia
        public bool Vazia()
        {
            if (Tamanho() == 0)
                return true;
            else
                return false;
            // return Tamanho == 0
        }

        // esse método emplilha o valor string na pilha
        public void Empilha(string p_valor)
        {

            if (Tamanho() != CAPACIDADE)
            {
                topo++;
                dados[topo] = p_valor;
            }
            else
                throw new Exception("A pilha está cheia!!");
        }

        // esse método desempilha um valor da pilha
        public string Desempilha()
        {
            if (Vazia() == true)
                throw new Exception("A pilha está vazia.");
            else
            {
                string retorno = dados[topo];
                dados[topo] = null;
                topo--;
                return retorno;
            }
        }

        // esse método devolve o valor que está no topo
        public string RetornaTopo()
        {
            if (Vazia() == true)
                throw new Exception("A pilha está vazia.");
            else
                return dados[topo];
        }
    }
}
