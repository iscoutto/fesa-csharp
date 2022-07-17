using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_ListaEncadeada
{
    internal class Nodo
    {
        public string Dado { get; set; }    // dado que será armazenado
        public Nodo Proximo { get; set; }   // endereço do próximo nodo

            // Construtor sem parametros
        public Nodo()
        {
            Dado = string.Empty;
            Proximo = null;
        }
    }
}
