namespace Ex18
{
    public partial class Form1 : Form
    {
        /*
         * Exerc�cio: Banco
         * 
         * Abstract Conta Bancaria : Object
         * 
         * Atributos:
         *      �	String Nome  do cliente
         *      �	String N�mero da conta (formato 9999-9)
         *      �	Double Saldo  M�todos:
         *          o	void Deposito(double valor);
         *          o	void Saque(double valor);  
         *          
         * ContaCorrente: ContaBancaria
         * 
         * Atributos:
         *      �	Double Limite de cr�dito
         *      �	Bool UtilizaTalaoCheque
         * M�todos:
         *      �	void Saque(double valor);   - O saldo + limite de cr�dito n�o pode ser < 0
         *      
         * ContaPoupanca: ContaBancaria
         * 
         * Atributos:
         *      �	Int Dia de anivers�rio:
         *      �	string	N� da c.Corrente atrelada
         * M�todos:
         *      �	void Saque(double valor);   - O saldo n�o pode ser < 0
         *      
         * Fa�a uma tela para cadastrar conta corrente e poupan�a. Salve em uma lista.
         * Crie um bot�o para depositar e 1 bot�o para sacar. Para tanto, o usu�rio dever� 
         * informar o n� da conta e o sistema ir� efetuar a  opera��o na conta selecionada.
         * Sobrescreva o m�todo toString() para listar todas as informa��es da conta.
         * Fa�a uma op��o para listar todas as contas cadastradas (cc. ou poupan�a) 
         * informando inclusive o tipo da conta (Ex: Conta corrente / Poupan�a)
         */

        Dictionary<string, ContaBancaria> dicionario = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxListar.Clear();

            ContaCorrente contaCorrente = new();

            try
            {
                // Dados inseridos
                contaCorrente.NomeCliente = txtNomeCC.Text;
                contaCorrente.NumConta = txtNumContaCC.Text;
                contaCorrente.Saldo = Convert.ToDouble(SaldoCC.Value) + Convert.ToDouble(LimiteCC.Value);
                contaCorrente.LimiteCredito = Convert.ToDouble(LimiteCC.Value);

                // Bool cheque
                if (ChequeNao.Checked)
                    contaCorrente.Cheque = false;
                else if (ChequeSim.Checked)
                    contaCorrente.Cheque = true;
                else
                    throw new Exception("Selecione se possui cheque!");

                // Verifica se j� existe no dicion�rio
                if (!dicionario.ContainsKey(contaCorrente.NumConta))
                    dicionario.Add(contaCorrente.NumConta, contaCorrente);
                else
                    throw new Exception("N�mero de conta corrente j� existe!");

                // Limpa campos
                textNomeCC.Clear();
                txtNumContaCC.Clear();
                SaldoCC.Value = 0;
                LimiteCC.Value = 0;
                ChequeNao.Checked = false;
                ChequeSim.Checked = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxListar.Clear();

            ContaPoupan�a contaPoupan�a = new();

            try
            {
                // Dados inseridos
                contaPoupan�a.NomeCliente = NomeCP.Text;
                contaPoupan�a.NumConta = NumContaCP.Text;
                contaPoupan�a.NumContaAtrelada = ContaAtreladaCP.Text;
                contaPoupan�a.Saldo = Convert.ToDouble(SaldoCP.Value);
                contaPoupan�a.Aniversario = Convert.ToInt32(AniverCP);

                // Verifica se j� existe no dicion�rio
                if (!dicionario.ContainsKey(contaPoupan�a.NumConta))
                {
                    if (!dicionario.ContainsKey(contaPoupan�a.NumConta))
                        dicionario.Add(contaPoupan�a.NumConta, contaPoupan�a);
                    else if (dicionario.ContainsKey(contaPoupan�a.NumContaAtrelada))
                        throw new Exception("A conta corrente atrelada inserida j� foi cadastrada anteriormente!");
                }
                else
                    throw new Exception("Conta poupan�a j� existe!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            // Limpa campos
            NomeCP.Clear();
            NumContaCP.Clear();
            ContaAtreladaCP.Clear();
            SaldoCP.Value = 0;
            AniverCP.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxListar.Clear();

            try
            {
                if (dicionario.ContainsKey(NumContaSaque.Text))
                {
                    foreach (ContaBancaria cb in dicionario.Values)
                        if (cb.NumConta == NumContaSaque.Text)
                            cb.Saque(Convert.ToDouble(ValorSaque.Value));
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxListar.Clear();

            try
            {
                if (dicionario.ContainsKey(NumContaSaque.Text))
                {
                    foreach (ContaBancaria cb in dicionario.Values)
                        if (cb.NumConta == NumContaSaque.Text)
                            cb.Deposito(Convert.ToDouble(ValorSaque.Value));
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxListar.Clear();

            foreach (ContaBancaria cb in dicionario.Values)
                textBoxListar.Text += cb.ToString();
        }
    }
}