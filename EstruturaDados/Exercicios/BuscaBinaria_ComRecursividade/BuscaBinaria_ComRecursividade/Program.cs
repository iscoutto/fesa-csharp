using System;

namespace BuscaBinaria_ComRecursividade
{
    class Program
    {
        // busca binária utilizando recursividade
        public static int BuscaRecursiva(int[] vetor, int inicio, int fim, int chave)
        {
            if (inicio > fim)
                return -1;

            int meio = (inicio + fim) / 2;

            if (vetor[meio] == chave)
                return meio;
            else if (chave > vetor[meio])
                return BuscaRecursiva(vetor, meio + 1, fim, chave);
            else if (chave < vetor[meio])
                return BuscaRecursiva(vetor, inicio, meio - 1, chave);
            else
                return -1;
        }

        static void Main(string[] args)
        {
            /* Implemente o método para fazer a busca binária. 
             * O método deverá receber um vetor ordenado de inteiros, uma chave 
             * de busca e devolver a posição que se encontra a chave ou -1 caso 
             * não encontre.
             * 
             * Implemente duas versões: com algoritmo iterativo e com recursividade.
            */

            int[] vetor = new int[5];
            vetor[0] = 2;
            vetor[1] = 4;
            vetor[2] = 6;
            vetor[3] = 8;
            vetor[4] = 10;

            int aux = 0, fim = vetor.Length - 1;

            int resultado = BuscaRecursiva(vetor, 0, fim, aux);

            if (resultado != -1)
                Console.WriteLine($"O número {aux} foi encontrado na posição {resultado}.");
            else
                Console.WriteLine("O número não foi encontrado :(");

            Console.ReadKey();
        }
    }
}
