using System;

namespace Ex01_PilhaEncadeada
{
    /*
     *  Implemente na classe da pilha dinâmica um método para retornar um string com todos 
     *  os elementos empilhados. Você pode separar os elementos com um “-“.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string valor;
            Pilha minhaPilha = new Pilha(); // instanciando a classe pilha

            do
            {
                try
                {
                    Console.WriteLine("Escolha uma opção:\n1) Empilhar\n2) Desempilhar" +
                    "\n3) Retornar topo\n4) Retornar tamanho\n5) Listar elementos\n9) Sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    // Empilhar
                    {
                        Console.WriteLine("Digite o valor que deseja empilhar: ");
                        valor = Console.ReadLine();
                        minhaPilha.Empilha(valor);
                    }
                    else if (opcao == 2)
                    // Desempilhar
                    {
                        valor = minhaPilha.Desempilha();
                        Console.WriteLine("Valor desempilhado: {0}", valor);
                    }
                    else if (opcao == 3)
                    // Retorna topo
                    {
                        valor = minhaPilha.RetornaTopo();
                        Console.WriteLine("Valor no topo: {0}", valor);
                    }
                    else if (opcao == 4)
                    // Retorna tamanho
                    {
                        Console.WriteLine("Tamanho da pilha: {0}", minhaPilha.Quantidade);
                    }
                    else if (opcao == 5)
                    // Lista os elementos da pilha
                    {
                        Console.WriteLine(minhaPilha.Lista());
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
            } while (opcao != 9);
        }
    }
}
