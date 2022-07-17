using System;
namespace Ex13_Enumeradores
{
    public class Metodos
    {
            // Valida nome
        public static bool ValidaNome(string nome)
        {
            return nome.Trim().IndexOf(' ') > 0;
        }

            // Valida data de nascimento
        public static bool ValidaData(string nascimento, out int idade)
        {
            idade = 0;
            if (DateTime.TryParse(nascimento, out DateTime data))
            {
                idade = (int)(DateTime.Now.Subtract(data).TotalDays / 365);
                return true;
            }
            else
                return false;
        }
    }
}
