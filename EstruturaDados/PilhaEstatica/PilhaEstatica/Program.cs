using System;

namespace PilhaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string valor;

            Pilha minhaPilha = new Pilha(); // cria uma instância da classe pilha

            do
            {
                try
                {
                    Console.WriteLine("\n\n Escolha: \n 1) Empilha \n 2) Desempilha \n" +
                                                        " 3) Topo \n 4) Tamanho \n"+
                                                        " 5) Teste 1 \n 6) Teste 2 \n 9) Sair \n ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o valor que deseja empilhar: ");
                        valor = Console.ReadLine();
                        minhaPilha.Empilha(valor);
                    }
                    else if (opcao == 2)
                    {
                        valor = minhaPilha.Desempilha();
                        Console.WriteLine($"Desempilhado: {0}\n\n", valor);
                    }
                    else if (opcao == 3)
                    {
                        valor = minhaPilha.RetornaTopo();
                        Console.WriteLine($"Valor no topo: {0}\n\n", valor);
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine($"Tamanho da pilha: {0}", minhaPilha.Tamanho());
                    }
                    else if (opcao == 5)
                    {
                        Console.WriteLine("Saindo...");
                        // sai do programa
                    }
                    else if (opcao == 6)
                    {
                        minhaPilha.Empilha(minhaPilha.RetornaTopo());
                    }
                    else if (opcao == 7)
                    {
                        minhaPilha.Empilha(minhaPilha.Desempilha());
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (opcao != 5);
        }
    }
}
