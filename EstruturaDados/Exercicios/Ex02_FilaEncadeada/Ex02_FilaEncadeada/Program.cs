using System;

namespace Ex02_FilaEncadeada
{
    class Program
    {
        /* 
         * Implemente a Fila utilizando a mesma técnica utilizada na pilha dinâmica. 
         * Observe que não será uma Fila circular, pois não há mais o problema de ter que 
         * descolar os elementos quando utilizamos esta técnica de elementos encadeados.
         */

        static void Main(string[] args)
        {
            string opcao = "", valor;
            Fila novaFila = new Fila();

            do
            {
                try
                {
                    Console.WriteLine("Escolha uma opção:\n1) Enfileirar\n2) Desenfileirar" +
                    "\n3) Retornar tamanho\n4) Listar elementos\n9) Sair");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para enfileirar: ");
                            valor = Console.ReadLine();
                            novaFila.Enfileira(valor);
                            break;
                        case "2":
                            Console.WriteLine("Valor desenfileirado: {0}", novaFila.Desenfileira());
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila: {0}", novaFila.Tamanho());
                            break;
                        case "4":
                            Console.WriteLine("Elementos na fila:\n");
                            string[] vetor = novaFila.Listar();
                            foreach (string dado in vetor)
                                Console.WriteLine(dado);
                            break;
                        case "9":
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!!!");
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