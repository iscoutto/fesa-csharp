using System;
using System.Linq;
using System.Collections.Generic;

namespace Desafio_MontarDuplas
{
    class Program
    {
        /*
        * Com base numa lista de alunos, deseja-se fazer uma sistema que crie duplas de forma aleatória.
        * 
        * Caso o número de alunos seja impar, poderá haver 1 trio.
        * 
        * Faça um método que receba uma lista de inteiros contendo os códigos dos alunos e devolva uma nova 
        * lista contendo as duplas.
        * 
        * O retorno da lista deve ser uma lista de strings, contendo os integrantes da dupla separados por vírgula.
        * 
        * Exemplo:
        * 
        * List<string> MontaDuplas (List<int> alunos)
        * {
        * 
        * }
        * 
        * Exemplo do retorno para uma lista impar de alunos:
        * 
        * [0] = "7,21";
        * [1] = "1,3";
        * [2] = "4,12";
        * [3] = "14,5,9";
        */

        /*
         * 1- Lista de alunos para salvar seus códigos
         * 2- Método lista de duplas gerados a partir de uma lista de alunos
         * 3- o retorno da lista de duplas deve ser em string separados por vírgula
         */

        static List<string> MontaDuplas(List<int> alunos)
        {
            List<string> lista = new();
            string aluno = "";
            int qtd = 0;

            // Verifica se o número de alunos é impar para formar o trio
            bool impar = alunos.Count % 2 != 0;

            do
            {
                if (impar)
                {
                    foreach (int a in alunos)
                    {
                        aluno += $"{a},";
                        qtd++;

                        if (qtd == 3)
                        {
                            qtd = 0;
                            lista.Add(aluno);
                            aluno = "";
                            break;
                        }
                    }
                }
                else if (qtd == 2)
                {
                    qtd = 0;
                    lista.Add(aluno);
                    aluno = "";
                    break;
                }
            }
            while (alunos.Count != 0);
   
            return lista;
        }

        static void Main(string[] args)
        {

            string opcao = "";
            int qtdAlunos = 0;
            List<int> alunos = new();

            do
            {
                try
                {
                    Console.WriteLine("\n\nEscolha uma opção:\n1) Registrar alunos\n2) Gerar duplas\n9) Sair\n");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("\nDigite a quantidade de alunos: ");
                            qtdAlunos = Convert.ToInt32(Console.ReadLine());

                            if (qtdAlunos <= 0)
                                throw new Exception("Número de alunos deve ser maior que zero!");
                            else
                                break;
                        case "2":
                            Random random = new();
                            int duplas = random.Next(1, qtdAlunos);

                            alunos.Add(duplas);

                            Console.WriteLine("\n\n>> Duplas geradas:\n");
                            foreach (string aluno in MontaDuplas(alunos))
                                Console.WriteLine($"{aluno.Trim(',')}");
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
            }
            while (opcao != "9");
        }
    }
}