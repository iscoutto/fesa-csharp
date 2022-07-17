using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_ListaDuplamenteEncadeada
{
    class Lista
    {
        Nodo primeiro = null;   // ponteiro para o primeiro elemento
        Nodo ultimo = null; // ponteiro para o último elemento
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
                    primeiro.Anterior = novo;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
                novo.Anterior = anterior;
                if (novo.Proximo != null)
                {
                    novo.Proximo.Anterior = novo;
                }
            }

            if (novo.Proximo == null)
                    ultimo = novo;
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
                InserePosicao(ultimo, valor);
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
        public string RemovePosicao(int posicao)
        {
            if (posicao >= qtd || posicao < 0 || qtd == 0)
                throw new Exception("Não é possível remover dessa posição!");

            string valor = "";
            qtd--;

            if (qtd == 0)
            {
                valor = primeiro.Dado;
                primeiro = ultimo = null;
                return valor;
            }
            else
            {
                // armazenamento do nodo que será apagado
                Nodo nodoDeletado = primeiro;
                for (int i = 1; i <= posicao; i++)  // encontra o elemento anterior ao que será apagado
                    nodoDeletado = nodoDeletado.Proximo;

                valor = nodoDeletado.Dado;

                if (nodoDeletado.Proximo == null)   // ajusta o último elemento
                    ultimo = nodoDeletado.Anterior;

                if (nodoDeletado.Anterior == null)  // ajusta o primeiro elemento
                    primeiro = nodoDeletado.Proximo;

                if (nodoDeletado.Anterior != null)
                    nodoDeletado.Anterior.Proximo = nodoDeletado.Proximo;

                if (nodoDeletado.Proximo != null)
                    nodoDeletado.Proximo.Anterior = nodoDeletado.Anterior;

                return valor;
            }
        }

        // método para listar todos os elementos
        public string ListarIterativo()
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

        // método listar recursivo
        private string Listar(Nodo r)
        {
            if (r != null)
                return Listar(r.Proximo) + " " + r.Dado;
            else
                return string.Empty;
        }

        // retorna primeiro elemento
        public Nodo RetornaPrimeiro()
        {
            return primeiro;
        }

        // método listar recursivo
        public string ListarRecursivo()
        {
            return Listar(RetornaPrimeiro());
        }

        // retorna true ou falso para a existencia de um elemento da lista
        public bool Pesquisar(string dado)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado == dado)
                    return true;
                aux = aux.Proximo;
            }
            return false;
        }
    }
}