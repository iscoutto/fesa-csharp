using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex02_ListaEncadeada
{
    public partial class Form1 : Form
    {
        Lista novaLista = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            novaLista.InsereInicio(txtValor.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            novaLista.InsereFim(txtValor.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                novaLista.InserePosicao(txtValor.Text, (int)numeric1.Value);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                novaLista.RemovePosicao((int)numeric2.Value);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void numeric2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tela.Text = novaLista.Listar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (novaLista.Pesquisar(campoPesquisa.Text))
                MessageBox.Show("Achei esse valor na lista :D");
            else
                MessageBox.Show("Não achei na lista :(");
        }
    }
}