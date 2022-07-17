using System;

namespace BuscaBinaria_SemRecursividade
{
    class Program
    {
        // método de pesquisa binária sem recursividade
        static int BuscaSemRecursividade(int[] vetor, int chave)
        {
            // pesquisa um valor no vetor e devolve posição -1 caso não encontre
            int meio;
            int esquerda = 0;
            int direita = vetor.Length - 1;

            do
            {
                meio = (esquerda + direita) / 2;

                if (vetor[meio] == chave)
                    return meio;
                else if (chave > vetor[meio])
                    esquerda = meio + 1;
                else
                    direita = meio - 1;
            } while (esquerda <= direita);
            return -1;
        }

        // método de ordenação utilizando QuickSort
        static void QuickSort(int[] vetor, int esquerda, int direita)
        {
            /*
             * O funcionamento do Quick Sort baseia-se em uma rotina fundamental 
             * cujo nome é particionamento. Particionar significa escolher um número 
             * qualquer presente no array, chamado de pivot, e colocá-lo em uma posição 
             * tal que todos os elementos à esquerda são menores ou iguais e todos 
             * os elementos à direita são maiores. 
             */

            int pivot, aux, a, b;
            int meio;
            a = esquerda;
            b = direita;
            meio = (int)((a + b) / 2);
            pivot = vetor[meio];

            do
            {
                while (vetor[a] < pivot) a += 1;
                while (vetor[b] > pivot) b -= 1;

                if (a <= b)
                {
                    aux = vetor[a];
                    vetor[a] = vetor[b];
                    vetor[b] = aux;
                    a += 1;
                    b -= 1;
                }
            } while (b > a);

            if (esquerda < b) QuickSort(vetor, esquerda, b);
            if (a < direita) QuickSort(vetor, a, direita);

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

            int[] dados = new int[6];
            int chave;

            Console.WriteLine($"Inicie com {dados.Length} números, digite um número por linha!");
            for (int n = 0; n < dados.Length; n++)
            {
                dados[n] = Convert.ToInt32(Console.ReadLine());
            }
            QuickSort(dados, 0, dados.Length - 1);

            Console.WriteLine("\n\nNúmeros ordenados:\n");

            for (int n = 0; n < dados.Length; n++)
            {
                Console.WriteLine(dados[n]);
            }

            do
            {
                Console.WriteLine("\n\nInforme um valor para pesquisar ou digite -1 para sair: ");
                chave = Convert.ToInt32(Console.ReadLine());

                int posicao;

                if (chave != -1)
                {
                    posicao = BuscaSemRecursividade(dados, chave);
                    if (posicao == -1)
                        Console.WriteLine("\n\nValor não encontrado :(");
                    else
                        Console.WriteLine($"\n\nValor encontrado na posição {posicao}.");
                }
            } while (chave != -1);
        }
    }
}
