using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_ListaDuplamenteEncadeada
{
    public class Nodo
    {
        // dado que será armazenado
        string dado;

        public string Dado
        {
            get { return dado; }
            set { dado = value; }
        }

        // endereço do próximo nodo
        Nodo proximo;

        public Nodo Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        // endereço do nodo anterior

        Nodo anterior;

        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        // Construtor sem parametros
        public Nodo()
        {
            dado = string.Empty;
            proximo = null;
            anterior = null;
        }

        // Construtor com parametros
        public Nodo(string dado, Nodo proximo)
        {
            this.dado = dado;
            this.proximo = proximo;
        }
    }
}