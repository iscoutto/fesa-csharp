using System;
namespace Ex01_PilhaEncadeada
{
    public class Pilha
    {
        #region Métodos da pilha

        private Nodo topo = null;   // topo da pilha
        int quantidade = 0;    // quantidade de elementos

        public int Quantidade
        {
            get { return quantidade; }
        }

        public void Empilha(string valor)
            // método para empilhar strings
        {
            Nodo novoNodo = new Nodo(); // instanciando a classe nodo
            novoNodo.Valor = valor;
            novoNodo.Anterior = topo;
            topo = novoNodo;
            quantidade++;
        }

        public string Desempilha()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                string retorno = topo.Valor;
                topo = topo.Anterior;
                quantidade--;
                return retorno;
            }
        }

        public string RetornaTopo()
            // método para retornar o topo da pilha
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                return topo.Valor;
            }
        }

        #endregion

        #region Retorna a lista de elementos da pilha

        public string Lista()
        {
            string retorno = "";
            Nodo aux = topo;
            while (aux != null)
            {
                retorno += aux.Valor + "-";
                aux = aux.Anterior;
            }
            return retorno;
        }

        #endregion
    }
}
