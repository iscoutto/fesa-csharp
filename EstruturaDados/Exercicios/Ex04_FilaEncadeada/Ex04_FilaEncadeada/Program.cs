using System;

namespace Ex04_FilaEncadeada
{
    class Program
    {
        /*
         * Implemente na classe Fila um método para listar os seus elementos. 
         * Devolva um string. Você pode separar os elementos com um “-“.
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
                    "\n3) Retornar tamanho\n4) Listar alunos\n9) Sair\n\n");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            {
                                var aluno = new Aluno();
                                Console.WriteLine("Digite o nome do aluno: ");
                                valor = Console.ReadLine();

                                Console.WriteLine("\nDigite o RA do aluno: ");
                                aluno.RA = Convert.ToInt32(Console.ReadLine());

                                novaFila.Enfileira(aluno);
                            }
                            break;
                        case "2":
                            {
                                Aluno aluno = novaFila.Desenfileira();
                                Console.WriteLine("\nAluno desenfileirado: \n{0} {1}", aluno.Nome, aluno.RA);
                            }
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila: {0}", novaFila.Tamanho());
                            break;
                        case "4":
                            Console.WriteLine("\nAlunos na fila:\n");
                            var vetor = novaFila.Lista();
                            foreach (var dado in vetor)
                                Console.WriteLine($"{dado.Nome} - {dado.RA}");
                            break;
                        case "9":
                            Console.WriteLine("\n\nSaindo...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida!!!");
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