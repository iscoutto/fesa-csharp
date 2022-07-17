using System;

namespace Exercicio12_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string valor;
            int posicao;
            Pilha novaPilha = new Pilha(10);

            do
            {
                try
                {
                    Console.WriteLine("\n\n>> Escolha uma opção:\n1) Empilhar\n2) Desempilhar\n" +
                    "3) Retornar topo\n4) Retornar tamanho\n5) Empilhar em uma posição\n6) Desempilha de uma posição\n9) Sair\n");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor que deseja empilhar: ");
                        valor = Console.ReadLine();
                        novaPilha.Empilha(valor);
                    }
                    else if (opcao == 2)
                    {
                        valor = novaPilha.Desempilha();
                        Console.WriteLine($"Valor desempilhado: {valor}");
                    }
                    else if (opcao == 3)
                    {
                        valor = novaPilha.RetornaTopo();
                        Console.WriteLine($"Valor no topo: {valor}");
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine("Tamanho da pilha: {0}", novaPilha.Tamanho());
                    }
                    else if (opcao == 5)
                    {
                        Console.WriteLine("Digite o valor que deseja empilhar: ");
                        valor = Console.ReadLine();
                        Console.WriteLine("Digite a posição que deseja empilhar: ");
                        posicao = Convert.ToInt32(Console.ReadLine());
                        novaPilha.EmpilhaPosicao(valor, posicao);
                    }
                    else if (opcao == 6)
                    {
                        Console.WriteLine(">>Digite a posição que deseja desempilhar: ");
                        posicao = Convert.ToInt32(Console.ReadLine());
                        novaPilha.DesempilhaPosicao(posicao);
                    }
                    else if (opcao == 9)
                    {
                        Console.WriteLine("Saindo...");
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (opcao != 9);
        }
    }
}