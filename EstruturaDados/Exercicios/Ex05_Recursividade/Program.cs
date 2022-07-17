using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Recursividade
{
    internal class Program
    {
 
            /* - Elemento inicial da PA
             * - Constante (razão) 
             * - Total de sequencias que se deseja gerar 
             */

        // método com recursividade
        static void PARecursivo(int numero, int constante, int qtd)
        {
            if (qtd > 0)
            {
                Console.Write($"{numero}");

                if (qtd != 1)
                    Console.Write(",");

                PARecursivo(numero + constante, constante, qtd -1);
            }
        }

        // método sem recursividade

        static void PA(int numero, int constante, int qtd)
        {
            int soma = numero;

            for (int a = 1; a <= qtd; a++)
            {
                Console.Write($"{soma}");

                if (a != qtd)
                    Console.Write(",");

                soma += constante;
            }
        }

        static void Main(string[] args)
        {
            /* Progressão aritmética é um tipo de sequência numérica que a partir 
             * do segundo elemento cada termo (elemento) é a soma do seu antecessor 
             * por uma constante.
             * 
             * (5,7,9,11,13,15,17) essa sequência é uma Progressão aritmética, pois 
             * os seus elementos são formados pela soma do seu antecessor com a constante 2.
             * 
             *          a1 = 5
             *          a2 = 5 + 2 = 7
             *          a3 = 7 + 2 = 9
             *          a4 = 9 + 2 = 11
             *          a5 = 11 + 2 = 13
             *          a6 = 13 + 2 = 15
             *          a7 = 15 + 2 = 17
             *          
             * Faça um programa que solicite: O elemento inicial da PA, a constante (razão) 
             * e o total de sequencias que se deseja gerar e então faça 2 algoritmos para 
             * resolver este problema: 1 recursivo e um sem recursividade.
             */

            int inicio = 4;
            int constante = 3;
            int qtde = 5;

            Console.WriteLine("Resultado com método recursivo:");
            PARecursivo(inicio, constante, qtde);

            Console.WriteLine("\n\nResultado com método não recursivo:");
            PA(inicio, constante, qtde);
            Console.ReadKey();
        }
    }
}
