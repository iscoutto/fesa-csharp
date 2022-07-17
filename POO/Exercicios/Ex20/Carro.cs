using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    internal class Carro : Automovel
    {
        /*
         * Um carro é um tipo de veículo automotor que possui, além dos atributos 
         * e métodos de um veículo automotor, adicionalmente:
         * 
         * Atributos:
         *      int quantidade de portas.  
         *      bool UtilizandoReboque ;
         * Métodos:
         *      O método ToString deve refletir todos os atributos da classe.
         *      No método de cálculo do pedágio: caso esteja usando reboque cobrar 
         *      R$ 10,00. Caso contrário, cobrar R$7,00. Exibir o valor pago em vídeo.
         */

        private int qtdPortas;
        private bool utilizandoReboque;

        // Quantidade de portas
        public int QtdPortas
        {
            get => qtdPortas;
            set
            {
                if (value < 0)
                    throw new Exception("Quantidade de portas deve ser superior que zero!");
                else
                    qtdPortas = value;
            }
        }

        // Utiliza reboque
        public bool UtilizandoReboque
        {
            get => utilizandoReboque;
            set => utilizandoReboque = value;
        }

        // Pedágio
        public override double PagarPedagio()
        {
            if (utilizandoReboque)
                return 10;
            else
                return 7;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Quantidade de portas: {QtdPortas}" +
                $"Reboque: {UtilizandoReboque}";
        }

        // Funcionalidade extra Velocidade Limpador
        private int velocidadeLimpador;
        public int VelocidadeLimpador
        {
            get => velocidadeLimpador;
            set
            {
                if (value < 0)
                    throw new Exception("Velocidade do limpador deve ser superior a zero!");
                else
                    velocidadeLimpador = value;
            }
        }

        // Funcioonalidade extra Acionar Limpador
        public string AcionarLimpador()
        {
            return "Limpadores acionados!";
        }

        // Funcionalidade extra Abrir Portas
        public string AbrirPorta()
        {
            return "Portas abertas!";
        }
    }
}
