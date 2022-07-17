using System;

namespace Exercicio3_Listas
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
                    Console.WriteLine("\n>> Escolha uma opção: \n" +
                                        "1) Cadastrar aluno \n" +
                                        "2) Retornar primeiro aluno da lista \n" +
                                        "3) Retornar último aluno da lista\n" +
                                        "4) Remover aluno da lista\n" +
                                        "5) Retornar dados\n" + 
                                        "9) Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite o RA do aluno: ");
                            valor = Console.ReadLine();
                            Aluno novoAluno = new Aluno();
                            novaLista.InsereNoInicio(novoAluno);
                            break;
                        case "2":
                            Console.WriteLine("Primeiro aluno da lista: {0}", novaLista.RetornaPrimeiro());
                            break;
                        case "3":
                            Console.WriteLine("Último aluno da lista: {0}", novaLista.RetornaUltimo());
                            break;
                        case "4":
                            Console.WriteLine("Digite o RA do aluno que deseja remover: ");
                            valor = Console.ReadLine();
                            novaLista.RemoveDaPosicao(valor);
                            break;
                        case "5":
                            Console.WriteLine(">> Lista de alunos:\n ", novaLista.RetornaDados());
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