using System;

namespace Exercicio10_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            ContaCorrente novaConta = new ContaCorrente();

            do
            {
                try
                {
                    Console.WriteLine("Digite o nome do titular: ");
                    novaConta.Titular = Console.ReadLine();
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
                    Console.WriteLine("Digite o número da agência: ");
                    novaConta.Agencia = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("Digite o número da conta: ");
                    novaConta.Conta = Console.ReadLine();
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
                    Console.WriteLine("\nO que deseja fazer agora?\n1) Realizar depósito\n2) Realizar Saque\n3) Visualizar dados\n" +
                        "9) Sair\n");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Digite o valor para depósito: ");
                            novaConta.Deposito(Convert.ToDouble(Console.ReadLine().Replace(',','.')));
                            break;
                        case 2:
                            Console.WriteLine("Digite o valor para saque: ");
                            novaConta.Saque(Convert.ToDouble(Console.ReadLine().Replace(',', '.')));
                            break;
                        case 3:
                            Console.WriteLine("\nDados da conta: \n");
                            Console.WriteLine($"Nome do titular: {novaConta.Titular}");
                            Console.WriteLine($"Número da conta: {novaConta.Conta}");
                            Console.WriteLine($"Agência: {novaConta.Agencia}");
                            Console.WriteLine($"Saldo: {novaConta.Saldo}\n\n");
                            break;
                        case 9:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Escolha uma opção válida!");
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (opcao != 9);
        }
    }
}