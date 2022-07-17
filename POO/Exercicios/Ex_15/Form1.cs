namespace Ex_15
{
    public partial class Ex_15 : Form
    {
        /*
         * Fa�a um programa que leia de um arquivo texto as categorias de um produto.
         * As categorias s�o: (categorias.txt)
         *      1,brinquedos
         *      2,alimentos
         *      3,bebidas
         *      4,eletrodom�sticos
         *      5,eletr�nicos
         *      
         * Fa�a um cadastro de produtos com os seguintes atributos: 
         *      c�digo, descri��o, categoria. A categoria deve estar em um combobox.
         *      
         * Guarde os produtos em uma lista.
         * 
         * Coloque um bot�o na tela para listar todos os produtos em um listbox 
         * ou textbox, listando o c�digo, a descri��o do produto e a descri��o da categoria.
         */

        List<Produto> ListaProdutos = new List<Produto>();

        public Ex_15()
        {
            InitializeComponent();

            comboBoxCategorias.DataSource = Categoria.Lista();
            comboBoxCategorias.ValueMember = "Codigo";
            comboBoxCategorias.DisplayMember = "Descricao";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                produto.Codigo = Convert.ToInt32(txtCodigo.Text);
                produto.Descricao = txtDescricao.Text;
                produto.Categoria = (Categoria)comboBoxCategorias.SelectedItem;
                ListaProdutos.Add(produto);
                listBox.DataSource = null;
                listBox.DataSource = ListaProdutos;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }
    }
}