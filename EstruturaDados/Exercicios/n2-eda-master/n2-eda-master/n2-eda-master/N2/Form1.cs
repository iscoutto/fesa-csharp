using N2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N2.Classes.Arquivo;
using System.IO;

namespace N2
{
    public partial class Form1 : Form
    {
        HashSet<ObjetoArquivo> arquivos = new HashSet<ObjetoArquivo>();

        public Form1()
        {
            InitializeComponent();
            Dados.Categorias = new Dictionary<int, Categoria>();
            Dados.Clientes = new Dictionary<string, Cliente>();
            Dados.Fabricantes = new Dictionary<int, Fabricante>();
            Dados.Produtos = new Dictionary<int, Produto>();
            Dados.Vendas = new Dictionary<int, Venda>();
        }

        private void deImportar_Click(object sender, EventArgs e)
        {
            if (File.Exists("resultados.txt"))
                File.Delete("resultados.txt");

            DateTime Inicio = DateTime.Now;
            DateTime Fim;

            deTela.Clear();
            Metodos.Leitura(arquivos);

            deTela.Text = $"Leitura demorou {DateTime.Now.Subtract(Inicio).Minutes} minuots e {DateTime.Now.Subtract(Inicio).Seconds}";

            #region Json
            /*
            deTela.Text += $"Inicando JSON... {DateTime.Now}" + Environment.NewLine;
            Metodos.Json(Dados.Categorias);
            Metodos.Json(Dados.Clientes);
            Metodos.Json(Dados.Fabricantes);
            Metodos.Json(Dados.Produtos);
            Metodos.Json(Dados.Vendas);
            */
            #endregion

            #region Resultado
            using (StreamWriter sw = new StreamWriter("Resultado.txt"))
            {
                sw.WriteLine(Inicio);
                sw.WriteLine($"A - {OpCodes.A()}");
                sw.WriteLine($"B - {OpCodes.B()}");
                sw.WriteLine($"C - {OpCodes.C()}");
                sw.WriteLine($"D - {OpCodes.D()}");
                sw.WriteLine($"E - {OpCodes.E()}");
                sw.WriteLine($"F - {OpCodes.F()}");
                sw.WriteLine($"G - {OpCodes.G()}");
                sw.WriteLine($"H - {OpCodes.H()}");
                sw.WriteLine($"H - {OpCodes.H()}");
                sw.WriteLine($"I - {OpCodes.I()}");
                sw.WriteLine($"J - {OpCodes.J()}");
                

                foreach (var k in OpCodes.K())
                    sw.WriteLine($"K - {k.Data.Date.ToString("MM/yyyy")} - {k.Quantidade}");
                

                foreach (var l in OpCodes.L())
                    sw.WriteLine($"L - {l.Data.Date.ToString("MM/yyyy")} - {l.Preco}");
                

                foreach (var m in OpCodes.M())
                    sw.WriteLine($"M - {m.ProdutoM.Codigo}|{m.ProdutoM.Descr}|{m.Quantidade}|{m.Total}");
                

                foreach (var n in OpCodes.N())
                    sw.WriteLine($"N - {n.Codigo}|{n.Cliente.CPF}|{n.Preco}");
                

                foreach (var o in OpCodes.O())
                    sw.WriteLine($"O - {o.ClienteO.CPF}|{o.Gasto}");
                

                foreach (var p in OpCodes.P())
                    sw.WriteLine($"P - {p.FabricanteP.Codigo}|{p.FabricanteP.Descricao}|{p.Quantidade}");
                

                foreach (var q in OpCodes.Q())
                    sw.WriteLine($"Q - {q.ProdutoQ.Codigo}|{q.Quantidade}");
                

                foreach (var r in OpCodes.R())
                    sw.WriteLine($"R - {r.CategoriaR.Codigo}|{r.Quantidade}");
                

                foreach (var s in OpCodes.S())
                    sw.WriteLine($"S - {s.ClienteS.CPF}|{s.ClienteS.Nome}|{s.Quantidade}");
                

                foreach (var t in OpCodes.T())
                    sw.WriteLine($"T - {t.ProdutoT.Codigo}|{t.Nota}|{t.Quantidade}");
                

                Fim = DateTime.Now;
                sw.WriteLine(Fim);
                sw.WriteLine(Fim.Subtract(Inicio).TotalSeconds);
            }

            var Tempo = Fim.Subtract(Inicio);
            deTela.Text += $"Terminado em... {DateTime.Now}." + Environment.NewLine +
                $"Demorou {(int)Tempo.TotalSeconds} segundos" + Environment.NewLine + 
                $"{Tempo.Minutes} minutos e {Tempo.Seconds} segundos";
            #endregion

            //OpCodes.U(deTela);
        }
            
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //deImportar_Click(null, null);
        }
    }
}
