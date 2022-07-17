namespace Ex_16
{
    public partial class Form1 : Form
    {
        /*
         * Crie uma classe para representar jogos. Deve haver os seguintes campos:
         *      Codigo  : int  ( > 0)
         *      Descricao  : string  (obrigat�rio)
         *      Dificuldade: Enumerador(easy, normal, hard) (obrigat�rio)
         *      Valor : double  >= 1,00
         *      Fabricante : Obrigat�rio. Exiba uma lista (ou caixa combo) de 
         * fabricantes e permita que o usu�rio selecione 1 valor da lista.
         * 
         * Deve haver 2 m�todos sobrecarregados para atualizar o pre�o dos jogos. 
         * Um deles dever� receber por par�metro um inteiro que representa o percentual 
         * que ser� aplicado sobre o pre�o do jogo. O outro dever� receber por par�metro 
         * um double que representa o valor em reais que dever� ser adicionado ao pre�o 
         * do jogo.
         * 
         * Crie a classe fabricante:
         *      Fabricante (  int codigo, string nome)
         *      
         * Crie uma lista com os seguintes fabricantes (pode ser fixo, no c�digo)
         *      {1 � Konami}  { 2 � Capcom }  { 3  - Nintendo }   { 4 � EA}  {5 � Acclaim}  { 6 � IronHide }  {  7 � SEGA }
         *      
         *  No formul�rio para teste da classe, inclua os bot�es para salvar a Lista 
         *  (que ir� salvar todos os objetos da lista em um arquivo texto, usando 
         *  para isso o salvar que h� dispon�vel na classe Jogo) e um bot�o para 
         *  carregar, que ir� preencher uma lista com os objetos carregados do arquivo.
         *  
         *  Deve haver um bot�o para listar todos os jogos cadastrados 
         *  (verificar na lista). O mesmo bot�o deve listar apenas os jogos de 
         *  uma determinada dificuldade caso seja selecionada a dificuldade em 
         *  uma caixa combo que ficar� ao lado do bot�o. Para estes 2 utilize 
         *  sobrecarga de m�todos (m�todos com o mesmo nome por�m com 
         *  par�metros diferentes).
         *  
         *  Adicione tamb�m dois bot�es para realizar os aumentos de pre�o nos jogos.
         */

        List<Jogo> listaJogos;
        List<Fabricante> listaFabricante;

        public Form1()
        {
            InitializeComponent();

            listaFabricante = new List<Fabricante>();

            listaFabricante.Add(new Fabricante(1, "Konami"));
            listaFabricante.Add(new Fabricante(2, "Capcom"));
            listaFabricante.Add(new Fabricante(3, "Nintendo"));
            listaFabricante.Add(new Fabricante(4, "EA"));
            listaFabricante.Add(new Fabricante(5, "Acclaim"));
            listaFabricante.Add(new Fabricante(6, "IronHide"));
            listaFabricante.Add(new Fabricante(7, "SEGA"));

            cbFabricante.DisplayMember = "Nome";
            cbFabricante.ValueMember = "Id";
            cbFabricante.DataSource = listaFabricante;

            listaJogos = Jogo.Listar(listaFabricante);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();

            try
            {
                jogo.Codigo = Convert.ToInt32(txtCodigo.Text);
                jogo.Descricao = txtDescricao.Text;
                jogo.Valor = Convert.ToDouble(txtValor.Text);
                jogo.Dificuldade = (EnumDificuldade)cbDificuldade.SelectedIndex;
                jogo.Fabricante = cbFabricante.SelectedItem as Fabricante;
                jogo.Salvar();
                listaJogos.Add(jogo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbListaDificuldade.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbListaDificuldade.SelectedIndex == -1)
                Listar(null);
            else
                Listar((EnumDificuldade)cbListaDificuldade.SelectedIndex);
        }
         // M�todos listar tudo

        private void Listar()
        {
            Listar(null);
        }

        private void Listar(EnumDificuldade? dificuldade)
        {
            /* '?' = null-conditional, evaluate the first operand
             * if that's null, stop, with a result of null. Otherwise, evaluate 
             * the second operand (as a member access of the first operand) 
             */

            listBox1.Items.Clear();

            bool listarTudo = dificuldade == null;
            foreach (Jogo jogo in listaJogos)
            {
                if (listarTudo || jogo.Dificuldade == dificuldade)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Jogo: " + jogo.Codigo.ToString());
                    listBox1.Items.Add(jogo.Descricao);
                    listBox1.Items.Add(jogo.Valor);
                    listBox1.Items.Add(jogo.Dificuldade.ToString());
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Jogo jogo in listaJogos)
            {
                listBox1.Items.Add("");
                listBox1.Items.Add("Jogo: " + jogo.Codigo.ToString());
                listBox1.Items.Add(jogo.Descricao);
                listBox1.Items.Add(jogo.Valor);
                listBox1.Items.Add(jogo.Dificuldade.ToString());
                listBox1.Items.Add(jogo.Fabricante.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaJogos = Jogo.Listar(listaFabricante);
        }

        private void btnAtualizaPorValor_Click(object sender, EventArgs e)
        {
            foreach (Jogo jogo in listaJogos)
                jogo.AtualizaPreco(Convert.ToDouble(txtValorAcrescimo.Text));

            MessageBox.Show("Valor atualizado!");
        }

        private void btnAtualizaPorPercentual_Click(object sender, EventArgs e)
        {
            foreach (Jogo jogo in listaJogos)
                jogo.AtualizaPreco(Convert.ToInt16(txtPercentualAcrescimo.Text));

            MessageBox.Show("Valor atualizado!");
        }
    }
}