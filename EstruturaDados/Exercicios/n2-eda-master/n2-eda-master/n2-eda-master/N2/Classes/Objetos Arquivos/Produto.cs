using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2.Classes.Arquivo
{
    public class Produto : ObjetoArquivo
    {
        public ushort Codigo { get; set; }
        public string Descr { get; set; }
        public double Preco { get; set; }
        public byte Nota { get; set; }
        public uint Num_nota { get; set; }
        internal Categoria Categoria { get; set; }
        internal Fabricante Fabricante { get; set; }
    }
}
