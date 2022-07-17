using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_ListaEncadeada
{
    internal class Lista
    {
        Nodo primeiro = null;   // ponteiro para o primeiro elemento
        int qtd = 0;

            // método para inserir um valor na lista
        private void InserePosicao(Nodo anterior, string valor)
        {
            Nodo novo = new Nodo();
            novo.Dado = valor;

            if (anterior == null)
            {
                if (qtd == 0)
                    primeiro = novo;
                else
                {
                    novo.Proximo = primeiro;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            qtd++;
        }

            // método para inserir um valor no inicio
        public void InsereInicio(string valor)
        {
            InserePosicao(null, valor);
        }

            // método para inserir um valor no fim
        public void InsereFim(string valor)
        {
            if (qtd == 0)
                InsereInicio(valor);
            else
            {
                Nodo aux = primeiro;
                
                while (aux.Proximo != null)
                    aux = aux.Proximo;

                InserePosicao(aux, valor);
            }
        }

            // método para inserir um valor com a posição iniciando no 0
        public void InserePosicao(string valor, int posicao)
        {
            if (posicao > qtd || posicao < 0)
                throw new Exception("Não é possível inserir nessa posição!");

            if (posicao == 0)
                InsereInicio(valor);
            else
            {
                    // descobre qual nodo anterior que será incluido
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                InserePosicao(aux, valor);
            }
        }

            // método para remover um elemento da lista com base em sua posição
        public void RemovePosicao(int posicao)
        {
            if (posicao >= qtd || posicao < 0 || qtd == 0)
                throw new Exception("Não é possível remover dessa posição!");

            if (posicao == 0)
                primeiro = primeiro.Proximo;
            else
            {
                    // descobre qual nodo será removido
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                aux.Proximo = aux.Proximo.Proximo;
            }
            qtd--;
        }
            
            // método para listar todos os elementos
        public string Listar()
        {
            string a = string.Empty;
            Nodo aux = primeiro;
            while (aux != null)
            {
                a = a + Environment.NewLine + aux.Dado;
                aux = aux.Proximo;
            }
            return a.Trim();
        }

            // retorna true ou falso para a existencia de um elemento da lista
        public bool Pesquisar(string valor)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado == valor)
                    return true;
                aux = aux.Proximo;
            }
            return false;
        }
    }
}
