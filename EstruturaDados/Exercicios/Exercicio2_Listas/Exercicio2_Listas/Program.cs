using System;

namespace Exercicio2_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "", valor;
            Fila minhaFila = new Fila();

            Console.WriteLine("<< Fila usando Listas >>");
            do
            {
                try
                {
                    Console.WriteLine("\nEscolha uma opção: \n " +
                                        "1) Enfileira \n " +
                                        "2) Desenfileira \n " +
                                        "3) Retornar tamanho\n " +
                                        "9) Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para enfileirar:");
                            valor = Console.ReadLine();
                            minhaFila.Enfileirar(valor);
                            break;
                        case "2":
                            Console.WriteLine("Digite um valor para desenfileirar:");
                            valor = Console.ReadLine();
                            minhaFila.Desenfileira();
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila: {0}", minhaFila.Tamanho());
                            break;
                        case "9":
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (opcao != "9");
        }
    }
}