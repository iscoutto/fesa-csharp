using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    internal class Moto : Automovel
    {
        /*
         * Atributos:
         *      int cilindradas
         * Métodos
         *      string Empinar() -> exibe no console "Empinando...";
         *      O método ToString deve refletir todos os atributos da classe.
         *      Cálculo do pedágio: Para moto, considerar o valor R$ 2,00. 
         *      Exibir o valor pago em vídeo
         */

        // Cilindradas
        private int cilindradas;
        public int Cilindradas
        {
            get => cilindradas;
            set
            {
                if (value < 0)
                    throw new Exception("Cilindradas devem ser superiores a zero!");
                else 
                    cilindradas = value;
            }
        }

        // Empinar
        public string Empinar()
        {
            return "Empinando...";
        }

        // Pedágio
        public override double PagarPedagio()
        {
            return 2;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Cilindradas: {cilindradas}";
        }
    }
}
