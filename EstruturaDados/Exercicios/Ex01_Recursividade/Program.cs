using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Recursividade
{
    internal class Program
    {
        // Recursividade faz com que uma função invoque a si mesma
        static double CalculaPotencia(int p_base, int p_expoente)
        {
            if (p_expoente == 0)
                return 1;
            else
                return p_base * CalculaPotencia(p_base, p_expoente - 1);
        }

        static void Main(string[] args)
        {
            /*
             * Faça um programa para calcular a potencia de um número. 
             * O método recursivo deve receber como parâmetro a base e 
             * o expoente, e devolver o valor da potência.
             *      EX: double CalculaPotencia (int p_base, int p_expoente) 
             *      CalculaPotencia (2,3) = 8
             */

            Console.WriteLine(CalculaPotencia(17, 8));
            Console.WriteLine(CalculaPotencia(2, 6));
            Console.ReadKey();
        }
    }
}
