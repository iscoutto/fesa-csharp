namespace Ex17
{
    public partial class Exerc�cio_17 : Form
    {
        /*
         * Crie uma classe b�sica funcion�rio com os seguintes atributos:
            �	C�digo  int
            �	Nome  string
            �	Sal�rio: Double
            �	Double CalculoSalario()  m�todo que calcula o sal�rio. Neste m�todo, apenas retorne o sal�rio.
            �	Sobrescreva  o m�todo ToString() para devolver os atributos b�sicos, al�m do sal�rio calculado.

        Crie uma classe chamada FuncionarioPeao que herda de funcion�rio e ter�, adicionalmente:
            �	Double HoraExtraEmReais. Este campo deve entrar no c�lculo do sal�rio.

        Crie uma classe chamada FuncionarioGerente que herda de funcion�rio e ter�, adicionalmente:
            �	Double BonusEmReais.  Este campo deve entrar no c�lculo do sal�rio.
            �	Int QtdeFuncionariosSubordinados

        Crie uma classe chamada FuncionarioVendedor que herda de funcion�rio e ter�, adicionalmente:
            �	Double MetaDeVendaMesEmReais 
            �	Double VendasdoMesEmReais    
            �	Double PorcentagemSobreVendas (para incorporar no sal�rio). Exemplo: 10%, deve-se calcular 10% sobre o campo    VendasdoMesEmReais e incorporar ao sal�rio durante o c�lculo. Este valor s� ser� aplicado se a meta for atingida.	

        Crie um formul�rio para instanciar as 3 classes derivadas, e guarde em uma lista. Crie um bot�o para exibir as propriedades e o sal�rio final de cada funcion�rio instanciado.
         */

        List<Funcionario> listaFuncionarios = new List<Funcionario>();

        public Exerc�cio_17()
        {
            InitializeComponent();
        }

        private void PreencheAtributosBasicos(Funcionario f)
        {
            f.Codigo = Convert.ToInt32(txtCodigo.Text);
            f.Nome = txtNome.Text;
            f.Salario = Convert.ToDouble(txtSalario.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var f = new FuncionarioPeao();
                PreencheAtributosBasicos(f);
                f.ValorHoraExtra = Convert.ToDouble(txtValorHExtra.Text);
                listaFuncionarios.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            foreach (Funcionario f in listaFuncionarios)
            {
                txtResultado.Text += Environment.NewLine +
                    f.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var f = new FuncionarioGerente();
                PreencheAtributosBasicos(f);
                f.BonusEmReais = Convert.ToDouble(txtBonus.Text);
                f.QtdFuncionariosSubordinados = Convert.ToInt32(txtQtdFunc.Text);
                listaFuncionarios.Add(f);
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
                var f = new FuncionarioVendedor();
                PreencheAtributosBasicos(f);
                f.MetaVendasMes = Convert.ToDouble(txtMeta.Text);
                f.PorcentagemSobreVendas = Convert.ToInt32(txtPorcentXVendas.Text);
                f.VendasMes = Convert.ToDouble(txtVendasMes.Text);
                listaFuncionarios.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}