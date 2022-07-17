using System;
namespace Ex13_Enumeradores
{
    public class Funcionario
    {
        string nome;
        EnumSexo sexo;
        EnumEstadoCivil estadoCivil;
        DateTime nascimento;

            // Propriedades do funcionario
        public string Nome { get => nome; set => nome = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public EnumSexo Sexo { get => sexo; set => sexo = value; }
        public EnumEstadoCivil EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

            // Construtor padrão
        public Funcionario()
        {
            { }
        }

            // Construtor parametrizado
        public Funcionario(string nome, DateTime nascimento, EnumSexo sexo, EnumEstadoCivil estadoCivil)
        {
            Nome = nome;
            Nascimento = nascimento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }
    }
}
