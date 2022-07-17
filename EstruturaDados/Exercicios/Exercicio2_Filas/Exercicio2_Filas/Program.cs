using System;

namespace Exercicio2_Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "", valor;
            Fila minhaFila = new Fila();

            do
            {
                try
                {
                    Console.WriteLine("\n\nEscolha uma opção:\n1) Enfileirar\n2) Desenfileirar\n3) Retornar tamanho\n4) Retornar inicio\n" +
                        "5) Retornar fim\n9) Sair\n");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para enfileirar: ");
                            valor = Console.ReadLine();
                            minhaFila.Enfileirar(valor);
                            break;
                        case "2":
                            Console.WriteLine("Valor desenfileirado: {0}", minhaFila.Desenfileira());
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila: {0}", minhaFila.Tamanho());
                            break;
                        case "4":
                            Console.WriteLine("Valor no inicio da fila: {0}", minhaFila.RetornaInicio());
                            break;
                        case "5":
                            Console.WriteLine("Valor no fim da fila: {0}", minhaFila.RetornaFim());
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
