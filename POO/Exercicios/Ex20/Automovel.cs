using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    public abstract class Automovel
    {
        // classe abstrata que poderá ser herdada e servirá como classe base para as outras classes 

        /*
         * Atributos:
         *      string  descricao
         *      double  capacidadeMaximaEmKg 
         *      double  velocidadeAtualEmKM   (atributo apenas leitura)
         *      double  capacidadeCarregadaemKg  (atributo apenas leitura)
         * Métodos:
         *      void Carregar (double peso) -> gerar exceção se exceder a capacidadeMaximaEmKg.  Exibir em vídeo a capacidade informada após carregar.
         *      void  Acelerar() ; // aumenta em 1 km a velocidade atual do veículo e exibe no console a nova velocidade
         *      double PagarPedagio(); // seu cálculo depende de características do tipo de veículo. Todo veículo deve pagar pedágio.
         *      o método ToString() deverá exibir todos os atributos da classe, concatenados.
         */

        private string descricao;
        private double velocidadeAtualEmKM; // apenas leitura
        private double capacidadeMaximaEmKg;
        private double capacidadeCarregadaemKg; // apenas leitura

        // Descrição
        public string Descricao
        {
            get => descricao;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Descrição é obrigatória!");
                else
                    descricao = value;
            }
        }

        // Velocidade
        public double VelocidadeAtualEmKM
        {
            get => velocidadeAtualEmKM;
            set
            {
                if (value < 0)
                    throw new Exception("Velocidade deve ser superior a zero!");
                else
                    velocidadeAtualEmKM = value;
            }
        }

        // Capacidade máxima de carga
        public double CapacidadeMaximaEmKg
        {
            get => capacidadeMaximaEmKg;
            set => capacidadeMaximaEmKg = value;
        }

        // Capacidade de carga carregada
        public double CapacidadeCarregadaemKg
        {
            get => capacidadeCarregadaemKg;
            set
            {
                if (CapacidadeMaximaEmKg >= CapacidadeCarregadaemKg || CapacidadeCarregadaemKg >= 0)
                    CapacidadeCarregadaemKg = value;
                else
                    throw new Exception("Verifique se a capacidade carregada excedeu o limirte permitido!");
            }
        }
 
        // Pagar pedágio
        public abstract double PagarPedagio();  // classes derivadas serão "obrigadas" a subscrever o método abstrato pedágio

        // Métodos virtuais fornecem a opção de serem subscritos pelas suas classes derivadas

        // Carregar
        public virtual double Carregar(double peso)
        {
            if ((peso + CapacidadeCarregadaemKg) > CapacidadeMaximaEmKg)
                throw new Exception("A carga não deve ser maior que a capacidade suportada!");
            else
                return CapacidadeCarregadaemKg += peso;
        }

        // Acelerar
        public virtual double Acelerar()
        {
            return velocidadeAtualEmKM += 1;
        }

        public override string ToString()
        {
            return $"Descrição: {Descricao}"+
                   $"Velocidade: {VelocidadeAtualEmKM}km/h"+
                   $"Capacidade máxima: {CapacidadeMaximaEmKg}kg"+
                   $"Carga: {CapacidadeCarregadaemKg}kg";
        }
    }
}
