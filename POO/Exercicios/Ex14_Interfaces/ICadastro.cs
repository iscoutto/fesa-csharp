using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Interfaces
{
    internal interface ICadastro
    {
        string Nome { get; set; }
        int Codigo { get; set; }

            // métodos sem corpo e são implicitamente abstratos e públicos
        void Salvar();
        bool Pesquisar(string nome);
    }
}
