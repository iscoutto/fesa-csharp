namespace Ex20
{
    public partial class Form1 : Form
    {
        List<Automovel> listaAutomoveis = new();
        Automovel automovelAux;

        public Form1()
        {
            InitializeComponent();
        }

        private void Carro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Dados carro
                Carro carro = new();
                carro.Descricao = txtDescricao.Text;
                carro.CapacidadeCarregadaemKg = Convert.ToDouble(txtCapacidadeCarregada.Text);
                carro.CapacidadeMaximaEmKg = Convert.ToDouble(txtCargaMaxima.Text);
                carro.VelocidadeAtualEmKM = Convert.ToDouble(txtVelocidade.Text);
                carro.QtdPortas = Convert.ToInt32(txtQtdPortas.Text);
                carro.UtilizandoReboque = Convert.ToBoolean(reboqueSim.Checked);

                // Acessando a lista
                foreach (Automovel c in listaAutomoveis)
                {
                    if (c.Descricao == carro.Descricao)
                        throw new Exception("Essa descição já foi regitrada anteriormente!");
                    else
                    {
                        listaAutomoveis.Add(carro);
                        listBoxAutos.Items.Add(carro.ToString());
                    }

                    // Limpa campos
                    txtDescricao.Clear();
                    txtCapacidadeCarregada.Clear();
                    txtCargaMaxima.Clear();
                    txtVelocidade.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Dados moto
                Moto moto = new();
                moto.Descricao = txtDescricao.Text;
                moto.CapacidadeCarregadaemKg = Convert.ToDouble(txtCapacidadeCarregada.Text);
                moto.CapacidadeMaximaEmKg = Convert.ToDouble(txtCargaMaxima.Text);
                moto.VelocidadeAtualEmKM = Convert.ToDouble(txtVelocidade.Text);
                moto.Cilindradas = Convert.ToInt32(txtCilindradas.Text);

                // Acessando lista
                foreach (Automovel m in listaAutomoveis)
                {
                    if (m.Descricao == moto.Descricao)
                        throw new Exception("Essa decrição já foi inserida anteriormente!");
                    else
                    {
                        listaAutomoveis.Add(moto);
                        listBoxAutos.Items.Add(moto.ToString());
                    }

                    // Limpa campos
                    txtDescricao.Clear();
                    txtCapacidadeCarregada.Clear();
                    txtCargaMaxima.Clear();
                    txtVelocidade.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            try
            {
                // Dados caminhão
                Caminhao caminhao = new();
                caminhao.Descricao = txtDescricao.Text;
                caminhao.CapacidadeCarregadaemKg = Convert.ToDouble(txtCapacidadeCarregada.Text);
                caminhao.CapacidadeMaximaEmKg = Convert.ToDouble(txtCargaMaxima.Text);
                caminhao.VelocidadeAtualEmKM = Convert.ToDouble(txtVelocidade.Text);
                caminhao.QtdEixos = Convert.ToInt32(txtEixos.Text);
                caminhao.VelocidadeLimpador = Convert.ToInt32(txtVelLimpadorCaminhao.Text);

                // Acessando lista
                foreach (Automovel cc in listaAutomoveis)
                {
                    if (cc.Descricao == caminhao.Descricao)
                        throw new Exception("Descrição já foi inserida anteriormente!");
                    else
                    {
                        listaAutomoveis.Add(caminhao);
                        listBoxAutos.Items.Add(caminhao.ToString());
                    }

                    // Limpa campos
                    txtDescricao.Clear();
                    txtCapacidadeCarregada.Clear();
                    txtCargaMaxima.Clear();
                    txtVelocidade.Clear();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Pesquisar veiculo na lista
            try
            {
                foreach(Automovel automovel in listaAutomoveis)
                {
                    if (automovel.Descricao == txtPesquisar.Text)
                    {
                        btnAcelerar.Enabled = true;
                        btnDescarregar.Enabled = true;

                        if (automovel is Moto)
                            btnEmpinar.Enabled = true;
                        else
                            btnEmpinar.Enabled = false;

                        btnPedagio.Enabled = true;
                        btnCarregar.Enabled = true;
                        break;
                    }
                    else
                        throw new Exception("Automóvel não registrado!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // Carregar
            try
            {
                double carga = automovelAux.CapacidadeCarregadaemKg +
                    Convert.ToDouble(txtCarregar.Text);

                if (automovelAux.CapacidadeCarregadaemKg >= carga)
                {
                    automovelAux.CapacidadeCarregadaemKg += Convert.ToDouble(txtCarregar.Text);
                    MessageBox.Show($"Carga atual: {automovelAux.CapacidadeCarregadaemKg}kg");
                }
                else
                    throw new Exception("Carga máxima atingida!");

                listBoxAutos.Items.Clear();
                listBoxAutos.Items.Add(automovelAux.ToString());
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            // Acelerar
            automovelAux.VelocidadeAtualEmKM += 1;
            MessageBox.Show($"Velocidade atual: {automovelAux.VelocidadeAtualEmKM}Km/h ");

            listBoxAutos.Items.Clear();
            listBoxAutos.Items.Add(automovelAux);
        }

        private void btnPedagio_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Valor do pedágio a ser pago: {automovelAux.Descricao}: R${automovelAux.PagarPedagio()}");
        }

        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            // Empinar
            Moto motoAux = automovelAux as Moto;
            MessageBox.Show(motoAux.Empinar());
        }

        private void btnDescarregar_Click(object sender, EventArgs e)
        {
            // Descarregar
            automovelAux.CapacidadeCarregadaemKg = 0;
            MessageBox.Show($"{automovelAux.Descricao} foi descarregado!");

            listBoxAutos.Items.Clear();
            listBoxAutos.Items.Add(automovelAux);
        }
    }
}