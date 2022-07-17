namespace Ex17
{
    public partial class Exercício_17 : Form
    {
        /*
         * Crie uma classe básica funcionário com os seguintes atributos:
            •	Código  int
            •	Nome  string
            •	Salário: Double
            •	Double CalculoSalario()  método que calcula o salário. Neste método, apenas retorne o salário.
            •	Sobrescreva  o método ToString() para devolver os atributos básicos, além do salário calculado.

        Crie uma classe chamada FuncionarioPeao que herda de funcionário e terá, adicionalmente:
            •	Double HoraExtraEmReais. Este campo deve entrar no cálculo do salário.

        Crie uma classe chamada FuncionarioGerente que herda de funcionário e terá, adicionalmente:
            •	Double BonusEmReais.  Este campo deve entrar no cálculo do salário.
            •	Int QtdeFuncionariosSubordinados

        Crie uma classe chamada FuncionarioVendedor que herda de funcionário e terá, adicionalmente:
            •	Double MetaDeVendaMesEmReais 
            •	Double VendasdoMesEmReais    
            •	Double PorcentagemSobreVendas (para incorporar no salário). Exemplo: 10%, deve-se calcular 10% sobre o campo    VendasdoMesEmReais e incorporar ao salário durante o cálculo. Este valor só será aplicado se a meta for atingida.	

        Crie um formulário para instanciar as 3 classes derivadas, e guarde em uma lista. Crie um botão para exibir as propriedades e o salário final de cada funcionário instanciado.
         */

        List<Funcionario> listaFuncionarios = new List<Funcionario>();

        public Exercício_17()
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