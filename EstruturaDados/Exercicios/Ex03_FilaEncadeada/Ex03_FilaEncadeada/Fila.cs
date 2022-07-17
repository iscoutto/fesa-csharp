using System;
namespace Ex03_FilaEncadeada
{
    public class Fila
    {
        private int quantidade = 0;
        private Nodo inicio;
        private Nodo fim;

        public int Tamanho()
        {
            return quantidade;
        }

        public void Enfileira(Aluno p_aluno)
        {
            Nodo novo = new Nodo();
            novo.Dado = p_aluno;
            if (quantidade == 0)
                inicio = novo;
            else
                fim.Proximo = novo;

            fim = novo;
            quantidade++;
        }

        public Aluno Desenfileira()
        {
            if (Tamanho() == 0)
                throw new Exception("A fila está vazia.");
            else
            {
                var valor = inicio.Dado;
                inicio = inicio.Proximo;

                quantidade--;
                return valor;
            }
        }

        public Aluno[] Lista()
        {
            var retorno = new Aluno[quantidade];

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
