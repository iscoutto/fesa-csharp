using System;
namespace Exercicio1_Listas
{
    public class Pilha
    {
        Lista minhaLista = new Lista();
        public int Tamanho() => minhaLista.Tamanho();
        public void Empilha(string p_valor) => minhaLista.InsereNoFim(p_valor);
        public string Desempilha() => minhaLista.RemoveDaPosicao(Tamanho() - 1);
    }
}