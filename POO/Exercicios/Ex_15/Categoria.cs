using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_15
{
    /* Faça um cadastro de produtos com os seguintes atributos:
     *      código, descrição, categoria. A categoria deve estar em um combobox.
    */

    class Categoria : object    // contém as assinaturas da classe 'object'
    {
        public int Codigo { get; set; }

        public string Descricao { get;set; }

        public static List<Categoria> Lista()   // static usa a assinatura da classe mas não usa o estado interno da classe
        {
            List<Categoria> lista = new List<Categoria>();

            if (File.Exists("Categorias.txt"))
            {
                String[] linhas = File.ReadAllLines("Categorias.txt"); 
                // String(capital S) is a class in the.NET framework in the System namespace.The fully qualified name is System.String.

                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(',');
                    Categoria categoria = new Categoria();
                    categoria.Codigo = Convert.ToInt32(dados[0]);
                    categoria.Descricao = dados[1];
                    lista.Add(categoria);
                }
            }
            return lista;
        }

        public override string ToString()
        {
            /*
             * override = substituição de método ou ainda ter dois métodos com o 
             * mesmo nome e a mesma assinatura, um método na classe base e outro 
             * na classe derivada.  
             */

            return Codigo + " - " + Descricao; 
        }
    }
}
