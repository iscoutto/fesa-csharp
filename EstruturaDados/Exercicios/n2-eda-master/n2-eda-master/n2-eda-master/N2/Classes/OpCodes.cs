using N2.Classes.Arquivo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2.Classes
{
    public static class OpCodes
    {
        public static int A()
        {
            return Dados.Produtos.Count;
        }

        public static int B()
        {
            return Dados.Clientes.Count;
        }

        public static int C()
        {
            return Dados.Vendas.Count;
        }

        public static int D()
        {
            int quantidade = 0;
            List<Produto> Produtos = new List<Produto>(); 
            foreach (var prod in Dados.Produtos.Values)
            {
                if (!Produtos.Contains(prod))
                {
                    foreach (var venda in Dados.Vendas.Values)
                    {
                        if (venda.Produto == prod)
                        {
                            Produtos.Add(prod);
                            break;
                        }
                    }
                }
            }

            foreach (var prod in Dados.Produtos.Values)
            {
                if (!Produtos.Contains(prod))
                    quantidade++;
            }

            return quantidade;
        }

        public static int E()
        {
            int quantidade = 0;
            List<Cliente> Clientes = new List<Cliente>();
            foreach (var client in Dados.Clientes.Values)
            {
                if (!Clientes.Contains(client))
                {
                    foreach (var venda in Dados.Vendas.Values)
                    {
                        if (venda.Cliente == client)
                        {
                            Clientes.Add(client);
                            break;
                        }
                    }
                }
            }

            foreach (var client in Dados.Clientes.Values)
            {
                if (!Clientes.Contains(client))
                    quantidade++;
            }

            return quantidade;
        }

        // Observação de F, apenas está contando vendas válidas
        public static int F()
        {
            int quantidade = 0;
            List<Categoria> Categorias = new List<Categoria>();
            foreach (var cat in Dados.Categorias.Values)
            {
                if (!Categorias.Contains(cat))
                {
                    foreach (var venda in Dados.Vendas.Values)
                    {
                        if (venda.Produto.Categoria == cat)
                        {
                            Categorias.Add(cat);
                            break;
                        }
                    }
                }
            }

            foreach (var cat in Dados.Categorias.Values)
            {
                if (!Categorias.Contains(cat))
                    quantidade++;
            }

            return quantidade;
        }

        // A fazer
        public static int G()
        {
            List<Produto> produtos = new List<Produto>();
            
            foreach (var venda in Dados.Vendas.Values)
            {
                if (!produtos.Contains(venda.Produto))
                    produtos.Add(venda.Produto);
            }

            return produtos.Count;
        }

        public static int H()
        {
            List<Cliente> Clientes = new List<Cliente>();

            foreach (var cliente in Dados.Clientes.Values)
            {
                if (Clientes.FindAll(x => x.Nome == cliente.Nome).Count > 1 && !Clientes.Contains(cliente))
                {
                    Clientes.Add(cliente);
                }
            }

            return Clientes.Count;
        }

        public static int I()
        {
            return E();
        }

        public static int J()
        {
            List<Cliente> Clientes = new List<Cliente>();
            
            foreach (var venda in Dados.Vendas.Values)
            {
                if (venda.DataHora.Day == venda.Cliente.DataNascimento.Day &&
                    venda.DataHora.Month == venda.Cliente.DataNascimento.Month &&
                    !Clientes.Contains(venda.Cliente))
                {
                    Clientes.Add(venda.Cliente);
                }
            }

            return Clientes.Count;
        }

        public static List<DiasK> K()
        {
            List<DiasK> Dias = new List<DiasK>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                

                if (Dias.Any(item => item.Data.Month == vendas.DataHora.Month && item.Data.Year == vendas.DataHora.Year))
                {
                    Dias.Find(item => item.Data.Month == vendas.DataHora.Month && item.Data.Year == vendas.DataHora.Year).Quantidade++;
                } else
                {
                    DiasK data = new DiasK();
                    data.Data = vendas.DataHora.Date;
                    data.Quantidade = 1;
                    Dias.Add(data);
                }
            }

            return Dias.OrderBy(x => x.Data.Date).ToList();
        }

        public static List<MesesL> L()
        {
            List<MesesL> Meses = new List<MesesL>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                if (Meses.Any(item => item.Data.Month == vendas.DataHora.Month  &&
                                      item.Data.Year == vendas.DataHora.Year    ))
                {
                    Meses.Find(item => item.Data.Month == vendas.DataHora.Month && item.Data.Year == vendas.DataHora.Year).Preco += vendas.Preco;
                }
                else
                {
                    MesesL data = new MesesL();
                    data.Data = vendas.DataHora.Date;
                    data.Preco = vendas.Preco;
                    Meses.Add(data);
                }
            }

            var a = Meses.OrderByDescending(item => item.Preco).ToList();
            var b = a.FindAll(item => item.Preco == a[0].Preco);
            return b;
        }

        public static List<ProdutosM> M()
        {
            List<ProdutosM> Produtos = new List<ProdutosM>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                if (Produtos.Any(item => item.ProdutoM == vendas.Produto))
                {
                    var p = Produtos.Find(item => item.ProdutoM == vendas.Produto);
                    p.Quantidade++;
                    p.Total += vendas.Produto.Preco;
                }
                else
                {
                    ProdutosM produto = new ProdutosM();
                    produto.ProdutoM = vendas.Produto;
                    produto.Quantidade = 1;
                    produto.Total = vendas.Produto.Preco;
                    Produtos.Add(produto);
                }
            }

            var a = Produtos.OrderByDescending(x => x.Quantidade).ToList();
            return a.FindAll(x => x.Quantidade == a[0].Quantidade);
        }

        public static List<Venda> N()
        {
            var a = Dados.Vendas.Values.OrderByDescending(item => item.Preco).ToList();
            var b = a.FindAll(item => item.Preco == a[0].Preco);
            return b;
        }

        public static List<ClientesO> O()
        {
            List<ClientesO> Clientes = new List<ClientesO>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                if (Clientes.Any(item => item.ClienteO == vendas.Cliente))
                {
                    var p = Clientes.Find(item => item.ClienteO == vendas.Cliente);
                    p.Gasto += vendas.Preco;
                }
                else
                {
                    ClientesO cliente = new ClientesO();
                    cliente.ClienteO = vendas.Cliente;
                    cliente.Gasto = vendas.Preco;
                    Clientes.Add(cliente);
                }
            }

            var a = Clientes.OrderByDescending(x => x.Gasto).ToList();

            List<ClientesO> temp = new List<ClientesO>();

            for (int i = 0; i < 5; i++)
                temp.Add(a[i]);

            return temp;
        }

        public static List<FabricantesP> P()
        {
            List<FabricantesP> Fabricantes = new List<FabricantesP>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                if (Fabricantes.Any(item => item.FabricanteP == vendas.Produto.Fabricante))
                {
                    var p = Fabricantes.Find(item => item.FabricanteP == vendas.Produto.Fabricante).Quantidade++;
                }
                else
                {
                    FabricantesP fabricante = new FabricantesP();
                    fabricante.FabricanteP = vendas.Produto.Fabricante;
                    fabricante.Quantidade = 1;
                    Fabricantes.Add(fabricante);
                }
            }

            var a = Fabricantes.OrderByDescending(x => x.Quantidade).ToList();

            List<FabricantesP> temp = new List<FabricantesP>();

            for (int i = 0; i < 5; i++)
                temp.Add(a[i]);

            return temp;
        }

        public static List<ProdutosQ> Q()
        {
            List<ProdutosQ> Produtos = new List<ProdutosQ>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                if (Produtos.Any(item => item.ProdutoQ == vendas.Produto))
                {
                    var p = Produtos.Find(item => item.ProdutoQ == vendas.Produto).Quantidade++;
                }
                else
                {
                    ProdutosQ produto = new ProdutosQ();
                    produto.ProdutoQ = vendas.Produto;
                    produto.Quantidade = 1;
                    Produtos.Add(produto);
                }
            }

            var a = Produtos.OrderByDescending(x => x.Quantidade).ToList();

            List<ProdutosQ> temp = new List<ProdutosQ>();

            for (int i = 0; i < 5; i++)
                temp.Add(a[i]);

            return temp;
        }

        public static List<CategoriasR> R()
        {
            List<CategoriasR> Categorias = new List<CategoriasR>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                if (Categorias.Any(item => item.CategoriaR == vendas.Produto.Categoria))
                {
                    var p = Categorias.Find(item => item.CategoriaR == vendas.Produto.Categoria).Quantidade++;
                }
                else
                {
                    CategoriasR categoria = new CategoriasR();
                    categoria.CategoriaR = vendas.Produto.Categoria;
                    categoria.Quantidade = 1;
                    Categorias.Add(categoria);
                }
            }

            var a = Categorias.OrderByDescending(x => x.Quantidade).ToList();

            List<CategoriasR> temp = new List<CategoriasR>();

            for (int i = 0; i < 5; i++)
                temp.Add(a[i]);

            return temp;
        }

        public static List<ClientesS> S()
        {
            List<ClientesS> Cliente = new List<ClientesS>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                if (Cliente.Any(item => item.ClienteS.CPF == vendas.Cliente.CPF && item.Dia.Date == vendas.DataHora.Date))
                {
                    var p = Cliente.Find(item => item.ClienteS == vendas.Cliente && item.Dia.Date == vendas.DataHora.Date).Quantidade++;
                }
                else
                {
                    ClientesS cliente = new ClientesS();
                    cliente.ClienteS = vendas.Cliente;
                    cliente.Dia = vendas.DataHora.Date;
                    cliente.Quantidade = 1;
                    Cliente.Add(cliente);
                }
            }

            var a = Cliente.OrderByDescending(x => x.Quantidade).ToList();
            var b = a.FindAll(x => x.Quantidade == a[0].Quantidade);

            return b;
        }

        public static List<ProdutosT> T()
        {
            List<ProdutosT> Produtos = new List<ProdutosT>();

            foreach (var vendas in Dados.Vendas.Values)
            {
                if (Produtos.Any(item => item.ProdutoT == vendas.Produto))
                {
                    var p = Produtos.Find(item => item.ProdutoT == vendas.Produto).Quantidade++;
                }
                else
                {
                    ProdutosT produto = new ProdutosT();
                    produto.ProdutoT = vendas.Produto;
                    produto.Quantidade = 1;
                    produto.Nota = vendas.Produto.Nota;
                    Produtos.Add(produto);
                }
            }

            var a = Produtos.OrderBy(x => x.Nota).ThenByDescending(x => x.Quantidade).ToList();

            List<ProdutosT> temp = new List<ProdutosT>();

            for (int i = 0; i < 3; i++)
                temp.Add(a[i]);

            return temp;
        }

        public static void U(TextBox deTela)
        {
            Dictionary<int, CombinaU> dicio = new Dictionary<int, CombinaU>();

            DateTime Ini = DateTime.Now;

            foreach (var prod in Dados.Produtos.Values)
            {
                var vendas = Dados.Vendas.Values.ToList().FindAll(x => x.Produto == prod);
                List<Venda> outrosProdutos = Dados.Vendas.Values.ToList().FindAll(x => x.Produto != prod);

                CombinaU produto = new CombinaU();
                produto.Produto = prod;

                foreach (var outro in outrosProdutos)
                {
                    if (dicio.ContainsKey(prod.Codigo) && dicio[prod.Codigo].combinacoes.Any(x => x.Produto == outro.Produto))
                    {
                        dicio[prod.Codigo].combinacoes.Find(x => x.Produto == outro.Produto).Quantidade++;
                    }
                    else
                    {
                        ValorU valor = new ValorU();
                        valor.Produto = outro.Produto;
                        valor.Quantidade = 1;

                        produto.combinacoes.Add(valor);
                    }
                }

                dicio.Add(produto.Produto.Codigo, produto);

                foreach (var comb in dicio.Values)
                    deTela.Text += $"Produto {comb.Produto.Codigo} repetiu com {comb.combinacoes.Count} itens" + Environment.NewLine;

                deTela.Text += Environment.NewLine + $"U demorou: {DateTime.Now.Subtract(Ini)}";
            }
        }
    }

    public class DiasK
    {
        public DateTime Data;
        public uint Quantidade;
    }

    public class MesesL
    {
        public DateTime Data;
        public Double Preco;
    }

    public class ProdutosM
    {
        public Produto ProdutoM;
        public uint Quantidade;
        public Double Total;
    }

    public class ClientesO
    {
        public Cliente ClienteO;
        public Double Gasto;
    }

    public class FabricantesP
    {
        public Fabricante FabricanteP;
        public uint Quantidade;
    }

    public class ProdutosQ
    {
        public Produto ProdutoQ;
        public uint Quantidade;
    }

    public class CategoriasR
    {
        public Categoria CategoriaR;
        public uint Quantidade;
    }

    public class ClientesS
    {
        public Cliente ClienteS;
        public DateTime Dia;
        public uint Quantidade;
    }

    public class ProdutosT
    {
        public Produto ProdutoT;
        public byte Nota;
        public uint Quantidade;
    }

    public class CombinaU
    {
        public Produto Produto;
        public List<ValorU> combinacoes = new List<ValorU>();
    }

    public class ValorU
    {
        public Produto Produto;
        public uint Quantidade;
    }
}

