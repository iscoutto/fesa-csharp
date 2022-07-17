using System;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista novaLista = new Lista();

            string opcao = "", valor;

            do
            {
                try
                {
                    Console.WriteLine("\n>> Escolha uma opção:\n\n" +
                                      "1) Visualizar agenda\n" +
                                      "2) Adicionar novo contato\n" +
                                      "3) Pesquisar contato\n" +
                                      "4) Alterar contato\n" +
                                      "5) Excluir contato\n" +
                                      "9) Sair\n");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            novaLista.ImprimeLista();
                            break;
                        case "2":
                            Console.WriteLine("Digite o nome: ");
                            string nome = Console.ReadLine().Trim();
                            Console.WriteLine("Digite o tefefone: ");
                            string telefone = Console.ReadLine().Trim();
                            novaLista.InsereNoInicio(new Contato(nome, telefone));
                            break;
                        case "3":
                            Console.WriteLine("Digite o nome do contato que deseja encontrar: ");
                            valor = Console.ReadLine();
                            novaLista.PesquisaContato(valor);
                            break;
                        case "4":
                            Console.WriteLine("Digite o nome do contato que deseja alterar: ");
                            valor = Console.ReadLine();
                            novaLista.AlteraContato(valor);
                            break;
                        case "5":
                            Console.WriteLine("Digite o nome do contato que deseja excluir: ");
                            valor = Console.ReadLine();
                            novaLista.RemoveDaPosicao(valor);
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
