using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo[] jogos = new Jogo[10];
            int qtd = 0;

            for (int n = 0; n < jogos.Length; n++)
            {
                jogos[n] = new Jogo();
                qtd++;

                do
                {
                    try
                    {
                        Console.WriteLine("Digite o código do jogo: ");
                        jogos[n].Codigo = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Você digitou um número muito grande!");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Você deve digitar apenas números inteiros!");
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
                        Console.WriteLine("Digite o nome do jogo: ");
                        jogos[n].Nome = Console.ReadLine();
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
                        Console.WriteLine("Digite a categoria entre: AÇÃO, LUTA, TIRO e ESPORTES\n");
                        jogos[n].Categoria = Console.ReadLine().ToUpper();
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
                        Console.WriteLine("Digite a data de lançamento: ");
                        jogos[n].DataLancamento = Convert.ToDateTime(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Você deve digitar uma data válida!");
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                } while (true);

                Console.WriteLine("Digite 'S' para sair ou espaço para continuar: \n");
                if (Console.ReadLine().ToUpper() == "S")
                    break;
            }

            Console.WriteLine("Dados cadastrados: ");
            for (int n = 0; n < qtd; n++)
            {
                Console.WriteLine(
                    $"Código: {jogos[n].Codigo}\n" +
                    $"Nome: {jogos[n].Nome}\n" +
                    $"Categoria: {jogos[n].Categoria}\n" +
                    $"Data de lançamento: {jogos[n].DataLancamento.ToShortDateString()}");
            }
            Console.ReadKey();
        }
    }
}