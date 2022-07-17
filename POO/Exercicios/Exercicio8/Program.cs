using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Centertext(string texto)
        {
            //Console.SetCursorPosition((Console.WindowWidth - texto.Length) / 2, Console.CursorTop);

            //int left = Console.WindowWidth / 2 - (texto.Length / 2);
            //Console.SetCursorPosition(left, Console.CursorTop);
            //Console.WriteLine(texto);
            Centertext(texto, Console.ForegroundColor);
        }

        static void Centertext(string texto, ConsoleColor cor)
        {
            int left = Console.WindowWidth / 2 - (texto.Length / 2);
            Console.SetCursorPosition(left, Console.CursorTop);

            ConsoleColor corAtual = Console.ForegroundColor;
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ForegroundColor = corAtual;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite um texto: ");
            //CenterText(Console.ReadLine());

            Centertext("Texto definido", ConsoleColor.Yellow);
        }
    }
}
