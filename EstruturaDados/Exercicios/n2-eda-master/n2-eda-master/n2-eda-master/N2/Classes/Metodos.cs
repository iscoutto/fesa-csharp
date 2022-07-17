using N2.Classes;
using N2.Classes.Arquivo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace N2
{
    public static class Metodos
    {
        public static void Leitura(HashSet<ObjetoArquivo> arquivos)
        {
            var filename = Directory.GetFiles(@"Arquivos\");

            foreach (string arquivo in filename)
            {
                using (StreamReader sw = new StreamReader(arquivo))
                {
                    
                    string line;
                    while ((line = sw.ReadLine()) != null)
                    {
                        var vetor = line.Split('|');

                        Metodos.Importar(vetor, arquivo);
                    }
                }
            }
        }

        public static void Importar(string[] vetor, string arquivo)
        {
            switch (arquivo)
            {
                case @"Arquivos\categorias.txt":
                    Dados.QntCategorias++;
                    if (!ushort.TryParse(vetor[0], out var CodigoC) ||
                        Dados.Categorias.ContainsKey(CodigoC)       )
                        return;

                    Categoria categoria = new Categoria();

                    categoria.Codigo = CodigoC;
                    categoria.Descricao = vetor[1];

                    Dados.Categorias.Add(categoria.Codigo, categoria);
                    break;

                case @"Arquivos\clientes.txt":
                    Dados.QntClientes++;
                    if (Dados.Clientes.ContainsKey(vetor[0]))
                        return;

                        Cliente cliente = new Cliente();

                    cliente.CPF = vetor[0];
                    cliente.Nome = vetor[1];
                    cliente.DataNascimento = FormatarData(vetor[2]);
                    
                    Dados.Clientes.Add(cliente.CPF, cliente);
                    break;

                case @"Arquivos\fabricantes.txt":
                    Dados.QntFabricantes++;
                    if (!ushort.TryParse(vetor[0], out var CodigoF) ||
                        Dados.Fabricantes.ContainsKey(CodigoF)       )
                        return;

                    Fabricante fabricante = new Fabricante();

                    fabricante.Codigo = CodigoF;
                    fabricante.Descricao = vetor[1];

                    Dados.Fabricantes.Add(fabricante.Codigo, fabricante);
                    break;

                case @"Arquivos\produtos.txt":
                    Dados.QntProdutos++;
                    if (!ushort.TryParse(vetor[0], out var CodigoP) ||
                        Dados.Produtos.ContainsKey(CodigoP)         )
                        return;

                    Double.TryParse(vetor[1], out var PrecoP);
                    int.TryParse(vetor[3], out var CategoriaP);
                    Double.TryParse(vetor[4], out var NotaTempP);
                    byte.TryParse((NotaTempP * 10).ToString(), out var NotaP);
                    uint.TryParse(vetor[5], out var num_notaP);
                    ushort.TryParse(vetor[6], out var FabricanteP);

                    if (!Dados.Fabricantes.ContainsKey(FabricanteP) ||
                        !Dados.Categorias.ContainsKey(CategoriaP)   )
                        return;

                    Produto produto = new Produto();                    

                    produto.Codigo = CodigoP;
                    produto.Preco = Convert.ToDouble(vetor[1]);
                    produto.Descr = vetor[2];
                    produto.Categoria = Dados.Categorias[CategoriaP];
                    produto.Nota = NotaP;
                    produto.Num_nota = num_notaP;
                    produto.Fabricante = Dados.Fabricantes[FabricanteP];

                    Dados.Produtos.Add(produto.Codigo, produto);
                    break;

                case @"Arquivos\vendas.txt":
                    Dados.QntVendas++;
                    if (!ushort.TryParse(vetor[0], out var CodigoV) ||
                        Dados.Vendas.ContainsKey(CodigoV))
                        return;

                    var ClienteV = vetor[1];
                    int.TryParse(vetor[2], out var ProdutoV);
                    var Data = FormatarDataH(vetor[3]);
                    double.TryParse(vetor[4], out var PrecoV);

                    if (!Dados.Produtos.ContainsKey(ProdutoV) ||
                        !Dados.Clientes.ContainsKey(ClienteV) )
                        return;

                    Venda venda = new Venda();

                    venda.Codigo = CodigoV;
                    venda.Cliente = Dados.Clientes[ClienteV];
                    venda.Produto = Dados.Produtos[ProdutoV];
                    venda.DataHora = Data;
                    venda.Preco = PrecoV;

                    Dados.Vendas.Add(venda.Codigo, venda);
                    break;

                default:
                    throw new Exception("Arquivo indevido");
            }
        }

        private static DateTime FormatarData(string D)
        {
            //  19711020
            //  20/10/1971

            var a = D.Substring(6, 2);
            var b = D.Substring(4, 2);
            var c = D.Substring(0, 4);

            string novaData = $"{a}/{b}/{c}";

            DateTime data = Convert.ToDateTime(novaData);

            return data;
        }

        private static DateTime FormatarDataH(string D)
        {
            //  20210408104106
            //  08/04/2021 10:41:06

            var a = D.Substring(6, 2);
            var b = D.Substring(4, 2);
            var c = D.Substring(0, 4);
            var d = D.Substring(8, 2);
            var e = D.Substring(10, 2);
            var f = D.Substring(12, 2);

            string novaData = $"{a}/{b}/{c} {d}:{e}:{f}";

            DateTime data = Convert.ToDateTime(novaData);

            return data;
        }

        public static void LimparPastas(string pasta)
        {
            DirectoryInfo di = new DirectoryInfo(pasta);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        #region Json

        public static void Json(Dictionary<int, Categoria> dicionario)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(dicionario, settings);
            File.WriteAllText(@"json\Categoria.json", conteudo);
        }
        public static void Json(Dictionary<string, Cliente> dicionario)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(dicionario, settings);
            File.WriteAllText(@"json\Cliente.json", conteudo);
        }
        public static void Json(Dictionary<int, Fabricante> dicionario)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(dicionario, settings);
            File.WriteAllText(@"json\Fabricante.json", conteudo);
        }
        public static void Json(Dictionary<int, Produto> dicionario)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(dicionario, settings);
            File.WriteAllText(@"json\Produto.json", conteudo);
        }
        public static void Json(Dictionary<int, Venda> dicionario)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(dicionario, settings);
            File.WriteAllText(@"json\Venda.json", conteudo);
        }

        #endregion
    }











}
