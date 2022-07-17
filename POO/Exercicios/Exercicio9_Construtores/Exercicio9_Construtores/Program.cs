using System;

namespace Exercicio9_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício realizado alterando o exercício 5

            Aluno novoAluno = new Aluno();
            do
            {
                try
                {
                    Console.WriteLine("Digite o nome do aluno: ");
                    novoAluno.Nome = Console.ReadLine();
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (true);

            do
            {
                try
                {
                    Console.WriteLine("Digite a nota 1 do aluno: ");
                    novoAluno.Nota1 = Convert.ToDouble(Console.ReadLine().Replace(',','.'));
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (true);

            do
            {
                try
                {
                    Console.WriteLine("Digite a nota 2 do aluno: ");
                    novoAluno.Nota2 = Convert.ToDouble(Console.ReadLine().Replace(',', '.'));
                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (true);

            Console.WriteLine("\n\nDados do aluno: \n");
            Console.WriteLine($"Nome: {novoAluno.Nome}");
            Console.WriteLine($"Nota 1: {novoAluno.Nota1}");
            Console.WriteLine($"Nota 2: {novoAluno.Nota2}");
            Console.WriteLine($"Média: {novoAluno.Media}");

        }
    }
}
