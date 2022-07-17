using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Recursividade
{
    internal class Program
    {
        static void Tabuada(int numero, int contador)
        {
            if (contador <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, contador,
                                  numero * contador);
                Tabuada(numero, contador + 1);
            }
        }

        static void Tabuada10(int numero)
        {
            if (numero <= 10)
            {
                Tabuada(numero, 0);
                Tabuada10(numero + 1);
            }
        }

        static void Main(string[] args)
        {
            // Faça um programa para imprimir a tabuada, usando recursividade
            Tabuada(5, 2);
            Tabuada10(2);
            Console.ReadKey();
        }
    }
}
