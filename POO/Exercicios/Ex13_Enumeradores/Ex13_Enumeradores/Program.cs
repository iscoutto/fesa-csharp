using System;

namespace Ex13_Enumeradores
{
    class Program
    {
        /*
         * Crie um enumerador para representar o sexo (Masculino e Feminino) e outro para 
         * representar os estados civis (casado, solteiro, viúvo) de um funcionário.
         * 
         * Crie a classe funcionário com os seguintes atributos:
         *  string nome
         *  SexoEnum sexo
         *  ECivilEnum estado civil 
         *  datetime data de nascimento
         * 
         * Crie uma classe chamada métodos e crie os seguintes métodos estáticos:
         *  bool validanome (string nome) - deverá validar se o nome possui nome e sobrenome.
         *  bool validaData (string data, out idade) - deverá ver se a data informada é valida. 
         * Se for válida, retornar a idade no parâmetro de saída.
         * 
         * Crie um construtor padrão e outro parametrizado onde será possível informar todos os 
         * atributos. 
         * 
         * Crie um formulário e valide os dados utilizando estes métodos
         */


        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            int opcao;

            do
            {
                try
                {
                    Console.WriteLine("Insira o nome do funcionario: ");
                    f.Nome = Console.ReadLine();
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
                    Console.WriteLine("Insira o sexo do funcionário:\n0- Masculino\n1- Feminino\n");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (Enum.IsDefined(typeof(EnumSexo), opcao))
                        Console.WriteLine((EnumSexo)opcao); // apresenta a opção referente a escolhida 
                    else
                        Console.WriteLine("Opção inválida!");
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
                    Console.WriteLine("\nInsira o estado civil:\n0- Solteiro\n1- Casado\n3- Viúvo");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (Enum.IsDefined(typeof(EnumEstadoCivil), opcao))
                        Console.WriteLine((EnumEstadoCivil)opcao);
                    else
                        Console.WriteLine("Opção inválida!");
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
                    Console.WriteLine("\nInsira a data de nascimento: ");
                    string nascimento = Console.ReadLine();

                    Console.WriteLine("\nInsira a idade: ");
                    int idade = Convert.ToInt32(Console.ReadLine());

                    Metodos.ValidaData(nascimento, out idade);
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (true);
        }
    }
}