using Ex14_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Produto p = new Produto();
                p.Codigo = Convert.ToInt16(txtCodProd.Text);
                p.Nome = txtNomeProd.Text;
                p.Preco = Convert.ToDouble(txtPrecoProd.Text);

                p.Salvar();

                txtCodProd.Clear();
                txtNomeProd.Clear();
                txtPrecoProd.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario f = new Funcionario();
                f.Codigo = Convert.ToInt16(txtCodFunc.Text);
                f.Nome = txtNomeFunc.Text;
                f.Salvar();

                txtCodFunc.Clear();
                txtNomeFunc.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCodProd.Clear();
            txtNomeProd.Clear();
            txtPrecoProd.Clear();

            Produto p = new Produto();
            if (p.Pesquisar(txtProdPesq.Text) == true)
            {
                txtCodProd.Text = p.Codigo.ToString();
                txtNomeProd.Text = p.Nome;
                txtPrecoProd.Text = p.Preco.ToString();
            }
            else
                MessageBox.Show("Não encontrado :/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Clear();
            txtCodFunc.Clear();

            Funcionario f = new Funcionario();

            if (f.Pesquisar(txtFuncPesq.Text))
            {
                txtNomeFunc.Text = f.Nome;
                txtCodFunc.Text = f.Codigo.ToString();
            }
            else
                MessageBox.Show("Não encontrado :/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultadoPesquisaFunc.Clear();
            var lista = Funcionario.Listar(txtFuncPesq.Text);
            foreach(var f in lista)
            {
                txtResultadoPesquisaFunc.Text += Environment.NewLine +
                                                 $"{f.Codigo} - {f.Nome}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
