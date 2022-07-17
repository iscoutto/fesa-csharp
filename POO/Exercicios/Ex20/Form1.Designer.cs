namespace Ex20
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.btnCarro = new System.Windows.Forms.Button();
            this.groupBoxReboque = new System.Windows.Forms.GroupBox();
            this.reboqueSim = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVelocidadeLimpador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdPortas = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMoto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCilindradas = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVelLimpadorCaminhao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEixos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapacidadeCarregada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCargaMaxima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.listBoxAutos = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCarregar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnEmpinar = new System.Windows.Forms.Button();
            this.btnPedagio = new System.Windows.Forms.Button();
            this.btnDescarregar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.groupBoxReboque.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabControl);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(295, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.btnCarro);
            this.tabControl.Controls.Add(this.groupBoxReboque);
            this.tabControl.Controls.Add(this.label2);
            this.tabControl.Controls.Add(this.txtVelocidadeLimpador);
            this.tabControl.Controls.Add(this.label1);
            this.tabControl.Controls.Add(this.txtQtdPortas);
            this.tabControl.Location = new System.Drawing.Point(4, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl.Size = new System.Drawing.Size(287, 319);
            this.tabControl.TabIndex = 0;
            this.tabControl.Text = "Carro";
            this.tabControl.UseVisualStyleBackColor = true;
            this.tabControl.Click += new System.EventHandler(this.Carro_Click);
            // 
            // btnCarro
            // 
            this.btnCarro.Location = new System.Drawing.Point(23, 215);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(137, 37);
            this.btnCarro.TabIndex = 5;
            this.btnCarro.Text = "Registrar carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxReboque
            // 
            this.groupBoxReboque.Controls.Add(this.reboqueSim);
            this.groupBoxReboque.Location = new System.Drawing.Point(23, 136);
            this.groupBoxReboque.Name = "groupBoxReboque";
            this.groupBoxReboque.Size = new System.Drawing.Size(141, 63);
            this.groupBoxReboque.TabIndex = 4;
            this.groupBoxReboque.TabStop = false;
            this.groupBoxReboque.Text = "Utilizando reboque?";
            // 
            // reboqueSim
            // 
            this.reboqueSim.AutoSize = true;
            this.reboqueSim.Location = new System.Drawing.Point(16, 25);
            this.reboqueSim.Name = "reboqueSim";
            this.reboqueSim.Size = new System.Drawing.Size(45, 19);
            this.reboqueSim.TabIndex = 0;
            this.reboqueSim.TabStop = true;
            this.reboqueSim.Text = "Sim";
            this.reboqueSim.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocidade limpador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtVelocidadeLimpador
            // 
            this.txtVelocidadeLimpador.Location = new System.Drawing.Point(23, 95);
            this.txtVelocidadeLimpador.Name = "txtVelocidadeLimpador";
            this.txtVelocidadeLimpador.Size = new System.Drawing.Size(106, 23);
            this.txtVelocidadeLimpador.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade portas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQtdPortas
            // 
            this.txtQtdPortas.Location = new System.Drawing.Point(24, 39);
            this.txtQtdPortas.Name = "txtQtdPortas";
            this.txtQtdPortas.Size = new System.Drawing.Size(106, 23);
            this.txtQtdPortas.TabIndex = 0;
            this.txtQtdPortas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMoto);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtCilindradas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(287, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Moto";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnMoto
            // 
            this.btnMoto.Location = new System.Drawing.Point(63, 161);
            this.btnMoto.Name = "btnMoto";
            this.btnMoto.Size = new System.Drawing.Size(137, 37);
            this.btnMoto.TabIndex = 12;
            this.btnMoto.Text = "Registrar moto";
            this.btnMoto.UseVisualStyleBackColor = true;
            this.btnMoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cilindradas";
            // 
            // txtCilindradas
            // 
            this.txtCilindradas.Location = new System.Drawing.Point(77, 91);
            this.txtCilindradas.Name = "txtCilindradas";
            this.txtCilindradas.Size = new System.Drawing.Size(106, 23);
            this.txtCilindradas.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCaminhao);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtVelLimpadorCaminhao);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtEixos);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(287, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Caminhao";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.Location = new System.Drawing.Point(68, 177);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(137, 37);
            this.btnCaminhao.TabIndex = 12;
            this.btnCaminhao.Text = "Registrar caminhão";
            this.btnCaminhao.UseVisualStyleBackColor = true;
            this.btnCaminhao.Click += new System.EventHandler(this.btnCaminhao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Velocidade Limpador";
            // 
            // txtVelLimpadorCaminhao
            // 
            this.txtVelLimpadorCaminhao.Location = new System.Drawing.Point(77, 131);
            this.txtVelLimpadorCaminhao.Name = "txtVelLimpadorCaminhao";
            this.txtVelLimpadorCaminhao.Size = new System.Drawing.Size(115, 23);
            this.txtVelLimpadorCaminhao.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quantidade eixos";
            // 
            // txtEixos
            // 
            this.txtEixos.Location = new System.Drawing.Point(77, 65);
            this.txtEixos.Name = "txtEixos";
            this.txtEixos.Size = new System.Drawing.Size(115, 23);
            this.txtEixos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dados obrigatórios para \r\n   todos os automóveis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(366, 101);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(106, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Capacidade carregada";
            // 
            // txtCapacidadeCarregada
            // 
            this.txtCapacidadeCarregada.Location = new System.Drawing.Point(509, 101);
            this.txtCapacidadeCarregada.Name = "txtCapacidadeCarregada";
            this.txtCapacidadeCarregada.Size = new System.Drawing.Size(124, 23);
            this.txtCapacidadeCarregada.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Carga máxima";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCargaMaxima
            // 
            this.txtCargaMaxima.Location = new System.Drawing.Point(366, 167);
            this.txtCargaMaxima.Name = "txtCargaMaxima";
            this.txtCargaMaxima.Size = new System.Drawing.Size(106, 23);
            this.txtCargaMaxima.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Velocidade";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(509, 167);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(124, 23);
            this.txtVelocidade.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(430, 213);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(137, 37);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // listBoxAutos
            // 
            this.listBoxAutos.FormattingEnabled = true;
            this.listBoxAutos.ItemHeight = 15;
            this.listBoxAutos.Location = new System.Drawing.Point(313, 267);
            this.listBoxAutos.Name = "listBoxAutos";
            this.listBoxAutos.Size = new System.Drawing.Size(629, 169);
            this.listBoxAutos.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Carregar";
            // 
            // txtCarregar
            // 
            this.txtCarregar.Location = new System.Drawing.Point(12, 99);
            this.txtCarregar.Name = "txtCarregar";
            this.txtCarregar.Size = new System.Drawing.Size(106, 23);
            this.txtCarregar.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Pesquisar veiculo";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 39);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(106, 23);
            this.txtPesquisar.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(124, 39);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(124, 99);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(89, 23);
            this.btnCarregar.TabIndex = 18;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(326, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 225);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnDescarregar);
            this.panel2.Controls.Add(this.btnPedagio);
            this.panel2.Controls.Add(this.btnEmpinar);
            this.panel2.Controls.Add(this.btnAcelerar);
            this.panel2.Controls.Add(this.btnCarregar);
            this.panel2.Controls.Add(this.txtCarregar);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtPesquisar);
            this.panel2.Location = new System.Drawing.Point(681, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 224);
            this.panel2.TabIndex = 20;
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(12, 140);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(106, 31);
            this.btnAcelerar.TabIndex = 21;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnEmpinar
            // 
            this.btnEmpinar.Location = new System.Drawing.Point(124, 140);
            this.btnEmpinar.Name = "btnEmpinar";
            this.btnEmpinar.Size = new System.Drawing.Size(106, 31);
            this.btnEmpinar.TabIndex = 22;
            this.btnEmpinar.Text = "Empinar";
            this.btnEmpinar.UseVisualStyleBackColor = true;
            this.btnEmpinar.Click += new System.EventHandler(this.btnEmpinar_Click);
            // 
            // btnPedagio
            // 
            this.btnPedagio.Location = new System.Drawing.Point(12, 177);
            this.btnPedagio.Name = "btnPedagio";
            this.btnPedagio.Size = new System.Drawing.Size(106, 31);
            this.btnPedagio.TabIndex = 23;
            this.btnPedagio.Text = "Pagar pedágio";
            this.btnPedagio.UseVisualStyleBackColor = true;
            this.btnPedagio.Click += new System.EventHandler(this.btnPedagio_Click);
            // 
            // btnDescarregar
            // 
            this.btnDescarregar.Location = new System.Drawing.Point(124, 177);
            this.btnDescarregar.Name = "btnDescarregar";
            this.btnDescarregar.Size = new System.Drawing.Size(106, 31);
            this.btnDescarregar.TabIndex = 24;
            this.btnDescarregar.Text = "Descarregar";
            this.btnDescarregar.UseVisualStyleBackColor = true;
            this.btnDescarregar.Click += new System.EventHandler(this.btnDescarregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.listBoxAutos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCargaMaxima);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCapacidadeCarregada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Ex20";
            this.tabControl1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
            this.groupBoxReboque.ResumeLayout(false);
            this.groupBoxReboque.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabControl;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private TextBox txtQtdPortas;
        private Button btnCarro;
        private GroupBox groupBoxReboque;
        private RadioButton reboqueSim;
        private Label label2;
        private TextBox txtVelocidadeLimpador;
        private Label label3;
        private Label label4;
        private TextBox txtDescricao;
        private Label label5;
        private TextBox txtCapacidadeCarregada;
        private Label label6;
        private TextBox txtCargaMaxima;
        private Label label7;
        private TextBox txtVelocidade;
        private Button btnListar;
        private ListBox listBoxAutos;
        private Button btnMoto;
        private Label label8;
        private TextBox txtCilindradas;
        private Button btnCaminhao;
        private Label label10;
        private TextBox txtVelLimpadorCaminhao;
        private Label label9;
        private TextBox txtEixos;
        private Label label12;
        private TextBox txtCarregar;
        private Label label13;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Button btnCarregar;
        private Panel panel1;
        private Panel panel2;
        private Button btnDescarregar;
        private Button btnPedagio;
        private Button btnEmpinar;
        private Button btnAcelerar;
    }
}