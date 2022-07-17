using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Utilizando a classe jogo criada no exercício anterior, faça um programa que instancie até 10 jogos.
           Após efetuar os cadastros, exiba os dados em vídeo. Encapsule os atributos. Validações:
              Código - (int) ( > 0)
              Nome - (string) (obrigatório)
              Categoria – (string) (válido apenas “ação” “luta” “tiro” e “Esportes” )
              Data de lançamento - (DateTime) (deve ser inferior à data atual)

           */

            int opcao = 0;
            string valor;
            int qtt = 0;

            Jogo[] novoJogo = new Jogo[10];

            for (int i = 0; i < novoJogo.Length; i++)
            {
                qtt++;
                novoJogo[i] = new Jogo();
                do
                {
                    try
                    {
                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o código do jogo: ");
                                novoJogo[i].SetCodigo(Console.ReadLine());
                                break;
                            }
                            catch (Exception erro)
                            {
                                Console.WriteLine(erro.Message);
                            }
                        }
                        while (true);

                        Console.WriteLine("Digite o nome do jogo: ");
                        novoJogo[i].SetNome(Console.ReadLine());

                        Console.WriteLine("\n\n Escolha uma categoria: \n 1) Ação \n 2) Luta \n " +
                        " 3) Tiro \n 4) Esportes: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1)
                        {
                            valor = Console.ReadLine();
                        }
                        else if (opcao == 2)
                        {
                            valor = Console.ReadLine();
                        }
                        else if (opcao == 3)
                        {
                            valor = Console.ReadLine();
                        }
                        else if (opcao == 4)
                        {
                            valor = Console.ReadLine();
                        }
                        else
                        {
                            throw new Exception("Digite o número válido referente a categoria!");
                        }

                        Console.WriteLine("Digite a data de lançamento: ");
                        novoJogo[i].SetDataLancamento(Convert.ToDateTime(Console.ReadLine(),
                            System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat));

                        break;
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                    break;
                }
                while (true);
            }

            for (int n = 0; n < qtt; n++)
            {
                Console.WriteLine("\n\nDados do jogo: \n");
                Console.WriteLine($"Código: {novoJogo[n].GetCodigo()}");
                Console.WriteLine($"Nome: {novoJogo[n].GetNome()}");
                Console.WriteLine($"Categoria: {novoJogo[n].GetCategoria()}");
                Console.WriteLine($"Data de lançamento: {novoJogo[n].GetDataLancamento()}");
            }
            Console.ReadKey();
        }
    }
}
