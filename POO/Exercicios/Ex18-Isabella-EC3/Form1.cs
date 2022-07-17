namespace Ex18
{
    public partial class Form1 : Form
    {
        /*
         * Exercício: Banco
         * 
         * Abstract Conta Bancaria : Object
         * 
         * Atributos:
         *      •	String Nome  do cliente
         *      •	String Número da conta (formato 9999-9)
         *      •	Double Saldo  Métodos:
         *          o	void Deposito(double valor);
         *          o	void Saque(double valor);  
         *          
         * ContaCorrente: ContaBancaria
         * 
         * Atributos:
         *      •	Double Limite de crédito
         *      •	Bool UtilizaTalaoCheque
         * Métodos:
         *      •	void Saque(double valor);   - O saldo + limite de crédito não pode ser < 0
         *      
         * ContaPoupanca: ContaBancaria
         * 
         * Atributos:
         *      •	Int Dia de aniversário:
         *      •	string	Nº da c.Corrente atrelada
         * Métodos:
         *      •	void Saque(double valor);   - O saldo não pode ser < 0
         *      
         * Faça uma tela para cadastrar conta corrente e poupança. Salve em uma lista.
         * Crie um botão para depositar e 1 botão para sacar. Para tanto, o usuário deverá 
         * informar o nº da conta e o sistema irá efetuar a  operação na conta selecionada.
         * Sobrescreva o método toString() para listar todas as informações da conta.
         * Faça uma opção para listar todas as contas cadastradas (cc. ou poupança) 
         * informando inclusive o tipo da conta (Ex: Conta corrente / Poupança)
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

                // Verifica se já existe no dicionário
                if (!dicionario.ContainsKey(contaCorrente.NumConta))
                    dicionario.Add(contaCorrente.NumConta, contaCorrente);
                else
                    throw new Exception("Número de conta corrente já existe!");

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

            ContaPoupança contaPoupança = new();

            try
            {
                // Dados inseridos
                contaPoupança.NomeCliente = NomeCP.Text;
                contaPoupança.NumConta = NumContaCP.Text;
                contaPoupança.NumContaAtrelada = ContaAtreladaCP.Text;
                contaPoupança.Saldo = Convert.ToDouble(SaldoCP.Value);
                contaPoupança.Aniversario = Convert.ToInt32(AniverCP);

                // Verifica se já existe no dicionário
                if (!dicionario.ContainsKey(contaPoupança.NumConta))
                {
                    if (!dicionario.ContainsKey(contaPoupança.NumConta))
                        dicionario.Add(contaPoupança.NumConta, contaPoupança);
                    else if (dicionario.ContainsKey(contaPoupança.NumContaAtrelada))
                        throw new Exception("A conta corrente atrelada inserida já foi cadastrada anteriormente!");
                }
                else
                    throw new Exception("Conta poupança já existe!");
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