using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie uma classe chamada Jogo com seguintes atributos:
                • Código - (int)
                • Nome - (string)
                • Categoria – (string)
                • Data de lançamento - (DateTime)
             Instancie um objeto da classe Jogo, preencha os seus atributos e exiba em vídeo os dados.
             */

            Jogo novoJogo;

            novoJogo = new Jogo();

            do
            {
                try
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("Digite o código do jogo: ");
                            novoJogo.SetCodigo(Console.ReadLine());
                            break;
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine(erro.Message);
                        }
                    }
                    while (true);

                    Console.WriteLine("Digite o nome do jogo: ");
                    novoJogo.SetNome(Console.ReadLine());

                    Console.WriteLine("Digite a categoria do jogo: ");
                    novoJogo.SetCategoria(Console.ReadLine());

                    Console.WriteLine("Digite a data de lançamento: ");
                    novoJogo.SetDataLancamento(Convert.ToDateTime(Console.ReadLine(),
                        System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat));

                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (true);

            Console.WriteLine("\n\nDados do jogo: \n");
            Console.WriteLine($"Código: {novoJogo.GetCodigo()}");
            Console.WriteLine($"Nome: {novoJogo.GetNome()}");
            Console.WriteLine($"Categoria: {novoJogo.GetCategoria()}");
            Console.WriteLine($"Data de lançamento: {novoJogo.GetDataLancamento()}");

            Console.ReadKey();

        }
    }
}
