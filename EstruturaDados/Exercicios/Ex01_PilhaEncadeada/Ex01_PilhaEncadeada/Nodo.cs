using System;
namespace Ex01_PilhaEncadeada
{
    public class Nodo
    {
        public string Valor { get; set; }   // valor que será armazenado
        public Nodo Anterior { get; set; }  // endereço do nodo anterior da pilha
    }
}
