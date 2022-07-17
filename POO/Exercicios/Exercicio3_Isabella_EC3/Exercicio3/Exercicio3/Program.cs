using System;

namespace Exercicio3
{
    class Program
    {
        /*
         Crie uma classe para representar um funcionário. A classe deve ter os seguintes atributos:
            Código (int) : deve ser > 0
            Nome (string) : (obrigatório)
            RG (string) : (obrigatório)
            Salario (double) : deve ser >=0

            Encapsule os atributos com métodos Get/Set.

            Crie também os seguintes métodos:
            GetInss(): deve calcular o valor do INSS (11% do salário) e devolver este valor.
            CalcularSalario() : Este método deverá retornar o salário do funcionário subtraído do INSS.
            Crie um formulário para preencher os campos do cadastro.
            Crie um botão para exibir os valores gravados na classe em um Textbox multiline. 
         */

        static void Main(string[] args)
        {
            Funcionario novoFuncionario;
            novoFuncionario = new Funcionario();

            do
            {
                try
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("Digite o código do funcionario: ");
                            novoFuncionario.SetCodigo(Convert.ToInt32(Console.ReadLine()));
                            break;
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine(erro.Message);
                        }
                    }
                    while (true);

                    Console.WriteLine("Digite o nome do funcionário: ");
                    novoFuncionario.SetNome(Console.ReadLine());

                    Console.WriteLine("Digite o RG: ");
                    novoFuncionario.SetRg(Console.ReadLine());

                    Console.WriteLine("Digite o salário: ");
                    novoFuncionario.SetSalario(Convert.ToDouble(Console.ReadLine().Replace(".", ",")));

                    break;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            }
            while (true);

            Console.WriteLine("\n\nDados do funcionário: \n");
            Console.WriteLine($"Códiog: {novoFuncionario.GetCodigo()}");
            Console.WriteLine($"Nome: {novoFuncionario.GetNome()}");
            Console.WriteLine($"RG: {novoFuncionario.GetRg()}");
            Console.WriteLine($"Salário: {novoFuncionario.GetSalario():F2}");
            Console.WriteLine($"INSS: {novoFuncionario.GetInss():F2}");
            Console.WriteLine($"Salário com INSS: {novoFuncionario.CalcularSalario()}");


            Console.ReadKey();

        }
    }
}
