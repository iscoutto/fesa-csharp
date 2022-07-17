using System;
namespace Ex02_FilaEncadeada
{
    public class Fila
    {
        private int quantidade = 0; // quantidade de elementos
        private Nodo inicio;
        private Nodo fim;

        public int Tamanho()
        {
            return quantidade;
        }

        public void Enfileira(string p_valor)
        {
            Nodo novo = new Nodo();
            novo.Dado = p_valor;
            if (quantidade == 0)
                inicio = novo;
            else
                fim.Proximo = novo;

            fim = novo;
            quantidade++;
        }

        public string Desenfileira()
        {
            if (Tamanho() == 0)
                throw new Exception("A lista está vazia.");
            else
            {
                string valor = inicio.Dado;
                inicio = inicio.Proximo;
                quantidade--;
                return valor;
            }
        }

        public string[] Listar()
        {
            string[] retorno = new string[quantidade];

            Nodo aux = inicio;
            int n = 0;
            while (aux != null)
            {
                retorno[n++] = aux.Dado;
                aux = aux.Proximo;
            }
            return retorno;
        }
    }
}