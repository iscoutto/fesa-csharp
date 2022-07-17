using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    internal class Caminhao : Automovel
    {
        /*
         * Atributos:
         *      int QuantidadeEixos;
         * Métodos
         *      double Carregar(double peso) -> exibe no console "Carregado". 
         *      Caso o peso ultrapasse o peso máximo,  NÃO gere uma exceção, 
         *      mas exiba em vídeo a mensagem “Sobrecarregado”;
         *      O método Acelerar não deve acelerar o caminhão caso o peso carregado 
         *      no caminhão ultrapasse o peso máximo. Neste caso, gere uma exceção 
         *      com o texto “Sobrecarregado!”.
         *      O método ToString deve refletir todos os atributos da classe.
         *      
         * Crie o método  Descarregar() , que irá retirar todo o peso e escrever "Vazio" 
         * no console;
         * Cálculo do pedágio: Considerar o valor R$ 5,00 por eixo. Exibir o valor pago em vídeo.
         */

        // Quantidade de eixos
        private int qtdEixos;
        public int QtdEixos
        {
            get => qtdEixos;
            set
            {
                if (value < 0)
                    throw new Exception("Quantidade de eixos deve ser superior a zero!");
                else
                    qtdEixos = value;
            }
        }

        // Pedágio
        public override double PagarPedagio()
        {
            return QtdEixos * 5;
        }

        // Carregar
        public override double Carregar(double peso)
        {
            if ((peso + CapacidadeCarregadaemKg) > CapacidadeMaximaEmKg)
                throw new Exception("Sobrecarregado!");
            else
                return CapacidadeCarregadaemKg += peso;
        }

        // Descarregar
        public double Descarregar()
        {
            return CapacidadeCarregadaemKg = 0;
        }

        // Acelerar
        public override double Acelerar()
        {
            if ((CapacidadeCarregadaemKg <= CapacidadeMaximaEmKg))
                return base.Acelerar();
            else
                throw new Exception("Sobrecarregado!");
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

        // Funcionalidade extra Acionar Limpador
        public string AcionarLimpador()
        {
            return "Limpadores acionados!";
        }

        // Funcionalidade extra Abrir Portas
        public string AbrirPorta()
        {
            return "Portas abertas!";
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Qquantidade eixos: {QtdEixos}";
        }
    }
}
