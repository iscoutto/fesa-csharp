using System;

namespace Exercicio2_Pilhas
{
    class Program
    {
        static void Armazenamento(ref Funcionario[] vetor, ref Pilha pilhaDeFuncionarios, int tamanho)
        {
            for (int i = tamanho; i > 0; i--)   // desempilha e armazena no 'vetor'
            {
                vetor[i - 1] = new Funcionario();
                vetor[i - 1] = pilhaDeFuncionarios.Desempilha();
            }

            for (int i = 0; i < tamanho; i++)
            {
                pilhaDeFuncionarios.Empilha(vetor[i]);   // empilha os dados de novo
            }
        }

        static void RetornaBase(ref Funcionario[] vetor, ref Pilha pilhaDeFuncionarios, int tamanho)
        {
            for (int i = tamanho; i > 0; i--)
            {
                vetor[i - 1] = new Funcionario();
                vetor[i - 1] = pilhaDeFuncionarios.Desempilha();
            }

            for (int i = 1; i < tamanho; i++)
            {
                pilhaDeFuncionarios.Empilha(vetor[i]);
            }
        }

        static void Main(string[] args)
        {
            int opcao = 0;
            double soma = 0;

            Pilha pilhaDeFuncionarios = new Pilha();
            Funcionario[] vetor = new Funcionario[5];
            Funcionario f;

            do
            {
                try
                {
                    f = new Funcionario();

                    Console.WriteLine("\n\n Escolha: \n 1) Empilhar Funcionário \n 2) Desempilhar \n " +
                    "3) Retornar o topo da pilha \n 4) Retornar o tamanho da pilha \n 5) Listar funcionários \n 6) Somar salários \n " +
                    "7) Limpar a base da pilha \n 8) Sair \n");

                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Digite o nome do funcionário que deseja empilhar: ");
                        f.nome = Console.ReadLine();

                        Console.WriteLine("Digite o salário do funcionário: ");
                        f.salario = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

                        pilhaDeFuncionarios.Empilha(f);
                    }
                    else if (opcao == 2)
                    {
                        f = pilhaDeFuncionarios.Desempilha();
                        Console.WriteLine($"O funcionário {f.nome}, com o salário de R${f.salario} foi retirado da pilha.\n");
                    }
                    else if (opcao == 3)
                    {
                        f = pilhaDeFuncionarios.RetornaTopo();
                        Console.WriteLine($"Funcionário no topo: {f.nome}, com o salário de R${f.salario} está no topo da pilha.\n");
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine("Tamanho da pilha: {0}", pilhaDeFuncionarios.Tamanho());
                    }
                    else if (opcao == 5)
                    {
                        int tamanho = pilhaDeFuncionarios.Tamanho();
                        Armazenamento(ref vetor, ref pilhaDeFuncionarios, tamanho);

                        Console.WriteLine("Lista de funcionários armazenados: \n");

                        for (int i = tamanho; i > 0; i--)
                        {
                            Console.WriteLine($"Nome: {vetor[i - 1].nome} \nSalário: R${vetor[i - 1].salario}\n");
                        }
                    }
                    else if (opcao == 6)
                    {
                        int tamanho = pilhaDeFuncionarios.Tamanho();
                        Armazenamento(ref vetor, ref pilhaDeFuncionarios, tamanho);

                        for (int i = 0; i < tamanho; i++)
                        {
                            soma += vetor[i].salario;
                        }
                        Console.WriteLine("A soma dos salários é de: {0}\n", soma);
                    }
                    else if (opcao == 7)
                    {
                        int tamanho = pilhaDeFuncionarios.Tamanho();
                        RetornaBase(ref vetor, ref pilhaDeFuncionarios, tamanho);

                        Console.WriteLine("O primeiro funcionário adicionado a pilha foi removido.");
                    }
                    else if (opcao == 8)
                    {
                        Console.WriteLine("Saindo...");
                    }
                    else if (opcao > 8)
                    {
                        Console.WriteLine("ERRO: Escolha apenas uma opção válida entre 1 e 7!\n");
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (opcao != 8);
        }
    }
}