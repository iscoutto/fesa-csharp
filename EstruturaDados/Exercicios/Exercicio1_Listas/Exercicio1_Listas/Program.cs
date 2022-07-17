using System;

namespace Exercicio1_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "", valor;
            Pilha minhaPilha = new Pilha();

            Console.WriteLine("<< Pilha usando Listas >>");
            do
            {
                try
                {
                    Console.WriteLine("\nEscolha uma opção: \n " +
                                        "1) Empilha \n " +
                                        "2) Desempilha \n " +
                                        "3) Retornar tamanho\n " +
                                        "9) Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para empilhar:");
                            valor = Console.ReadLine();
                            minhaPilha.Empilha(valor);
                            break;
                        case "2":
                            Console.WriteLine("Digite um valor para desempilhar:");
                            valor = Console.ReadLine();
                            minhaPilha.Desempilha();
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da pilha: {0}", minhaPilha.Tamanho());
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