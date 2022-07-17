using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2.Classes.Arquivo
{
    public class Fabricante : ObjetoArquivo
    {
        public ushort Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
