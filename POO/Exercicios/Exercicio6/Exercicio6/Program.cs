using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] novoAluno = new Aluno [10];
            int qtd = 0;

            for (int n = 0; n < novoAluno.Length; n++)
            {
                novoAluno[n] = new Aluno();
                qtd++;
                do
                {
                    try
                    {
                        Console.WriteLine("Digite o nome do aluno: ");
                        novoAluno[n].Nome = Console.ReadLine();
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
                        novoAluno[n].Nota1 = Convert.ToDouble(Console.ReadLine());
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
                        novoAluno[n].Nota2 = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                } while (true);

                Console.WriteLine("Digite 'S' para sair ou espaço para continuar: ");
                if (Console.ReadLine().ToUpper() == "S")
                    break;
            }

            Console.WriteLine("\n\nDados do aluno: \n");
            for (int n = 0; n < qtd; n++)
            {
                Console.WriteLine($"Nome: {novoAluno[n].Nome}");
                Console.WriteLine($"Nota 1: {novoAluno[n].Nota1}");
                Console.WriteLine($"Nota 2: {novoAluno[n].Nota2}");
                Console.WriteLine($"Média: {novoAluno[n].Media}");

            }
            Console.ReadKey();
        }
    }
}