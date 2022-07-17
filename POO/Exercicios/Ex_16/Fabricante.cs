using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_16
{
    /*
     * Fabricante : Obrigatório. Exiba uma lista (ou caixa combo) de 
     * fabricantes e permita que o usuário selecione 1 valor da lista. 
     * 
     * Fabricante (  int id, string nome)
     */

    internal class Fabricante
    {
        // Id
        public int Id { get; set; }

        // Nome
        public string Nome { get; set; }

        // Construtor fabricante
        public Fabricante(int id, string nome)
        {
            Id = id; 
            Nome = nome; 
        }

        public override string ToString()
        {
            return Id + " - " + Nome;
        /*
        * override = substituição de método ou ainda ter dois métodos com o 
        * mesmo nome e a mesma assinatura, um método na classe base e outro 
        * na classe derivada.  
        */

        }  
    }
}
