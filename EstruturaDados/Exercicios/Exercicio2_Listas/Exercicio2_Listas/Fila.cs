using System;
namespace Exercicio2_Listas
{
    public class Fila
    {
        Lista minhaLista = new Lista();
        public int Tamanho() => minhaLista.Tamanho();
        public void Enfileirar(string p_valor) => minhaLista.InsereNoInicio(p_valor);
        public string Desenfileira() => minhaLista.RemoveDaPosicao(Tamanho() - 1);
    }
}