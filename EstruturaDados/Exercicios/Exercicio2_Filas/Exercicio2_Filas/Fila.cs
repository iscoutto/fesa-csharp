using System;
namespace Exercicio2_Filas
{
    public class Fila
    {
        const int CAPACIDADE = 5;
        private int quantidade = 0;
        private int inicio = 0;
        private int fim = 0;
        private string[] dados = new string[CAPACIDADE];

        public int Tamanho()
        {
            return quantidade;
        }

        public void Enfileirar(string p_valor)
        {
            if (Tamanho() == CAPACIDADE)
            {
                throw new Exception("A fila está cheia.");
            }
            else
            {
                dados[fim] = p_valor;
                fim = (fim + 1) % CAPACIDADE;
                quantidade++;
            }
        }

        public string Desenfileira()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia.");
            }
            else
            {
                string valor = dados[inicio];
                inicio = (inicio + 1) % CAPACIDADE;
                quantidade--;
                return valor;
            }
        }

        public string RetornaInicio()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia.");
            }
            else
            {
                return dados[inicio];
            }

        }

        public string RetornaFim()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia.");
            }
            else
            {
                if (fim == 0)
                    return dados[CAPACIDADE - 1];
                else
                    return dados[fim - 1];
            }
        }
    }
}
