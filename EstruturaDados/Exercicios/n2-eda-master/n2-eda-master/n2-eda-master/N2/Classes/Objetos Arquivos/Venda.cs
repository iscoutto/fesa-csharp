using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2.Classes.Arquivo
{
    public class Venda : ObjetoArquivo
    {
        public ushort Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataHora { get; set; }
        public double Preco { get; set; }

    }
}
