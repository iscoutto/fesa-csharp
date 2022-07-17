using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DesafioDoMilhao
{
    class Program
    {
        /* 
         * ETAPA 01
         * 
         * Faça um programa que gere 20 milhões de números randômicos, na faixa de 1 a 50.000.000 milhões.
         * Não aceite números repetidos.
         * 
         * ETAPA 02
         * Depois, gere 10 milhões de números, sendo que eles devem estar entre 1 e 50 milhões, mas não podem 
         * estar dentre os números gerados na Etapa 1. Não aceite números repetidos.
         * 
         * Ao final, salve em um arquivo texto todos os 10 milhões de números gerados na etapa 2, ordenados 
         * em ordem crescente, um por linha.
         * 
         * Faça em modo console.
         * 
         * Você pode utilizar qualquer estrutura de dados ou algoritmos que aprendeu para realizar o processo e 
         * armazenar os números.
         * 
         * Quanto tempo seu algoritmo demorou para processar?
         * 
         * Para calcular o tempo que demorou para processar o algoritmo, faça assim:
         * 
         * DateTime inicio = DateTime.Now; // guarda a hora inicial
         * 
         * do
         * {
         * 
         * //coloque o seu algoritmo de gerar números aqui...
         * //salvar os dados em .txt
         * }
         * while (true);
         * 
         * TimeSpan tempo = DateTime.Now.Subtract(inicio); // calcula o total de segundos que demorou o processo
         * Console.WriteLine(tempo.TotalSeconds);
         * 
         * Considere no seu tempo o tempo gasto para salvar o arq. texto!
         */

        const int max = 50000000;

        static void Main(string[] args)
        {
            string opcao = "";
            do
            {
                try
                {
                    Console.WriteLine(">> Desafio do Milhão!\n\nDigite 1 para inciar ou 2 para sair:\n");
                    opcao = Console.ReadLine();

                    if (opcao == "2")
                    {
                        Console.WriteLine("Saindo...");
                        Environment.Exit(0);
                    }
                    else
                        continue;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (opcao == "2");

            // Inicia cáculo de tempo da performance do programa usando a classe System.Diagnostics
            var time = new Stopwatch();
            time.Start();

            Dictionary<int,int> dictEtapa1 = new();
            Dictionary<int, int> dictEtapa2 = new();

            int etapa1 = 20000000;
            int etapa2 = 10000000;

            Random random = new();
            // Gera números aleatórios e salva no dict da etapa1
            while (dictEtapa1.Count < etapa1)
            {               
                int index = random.Next(1, max);

                if (!dictEtapa1.ContainsKey(index))
                    dictEtapa1.Add(index, 0);
            }
           
            // Gera números aleatórios, compara se já existe nos dict1 e 2 e salva no dict da etapa2
            while (dictEtapa2.Count < etapa2)
            {               
                int index = random.Next(1, max);

                if (!dictEtapa1.ContainsKey(index) && !dictEtapa2.ContainsKey(index))
                    dictEtapa2.Add(index, 0);
            }

            // Sort do dicionário em ordem crescente 
            List<int> listEtapa2 = dictEtapa2.Keys.ToList();
            listEtapa2.Sort();


            // dictEtapa2 = dictEtapa2.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Key);

            // Salva cada número em uma linha e gera um txt
            StringBuilder stringBuilder = new();
            foreach (int num in listEtapa2)
                stringBuilder.AppendLine(num.ToString());    

            File.WriteAllText("milhao.txt", stringBuilder.ToString()); 

            time.Stop();

            // Salva o tempo de performance do programa
            TimeSpan timespan = time.Elapsed;   // intervalo de tempo entre o tempo de inicio e fim
            string runTime = String.Format("{0:00}h {1:00}min {2:00}s.{3:00}ms",
                timespan.Hours, timespan.Minutes, timespan.Seconds,
                timespan.Milliseconds / 10);
            Console.WriteLine("\n\nRunTime: " + runTime);

        }
    }
}
