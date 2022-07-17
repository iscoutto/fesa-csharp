using N2.Classes.Arquivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2.Classes
{
    public static class Dados
    {
        public static uint QntCategorias;
        public static Dictionary<int, Categoria> Categorias { get; set; }

        public static uint QntClientes;
        public static Dictionary<string, Cliente> Clientes { get; set; }

        public static uint QntFabricantes;
        public static Dictionary<int, Fabricante> Fabricantes { get; set; }

        public static uint QntProdutos;
        public static Dictionary<int, Produto> Produtos { get; set; }

        public static uint QntVendas;
        public static Dictionary<int, Venda> Vendas { get; set; }
    }
}
