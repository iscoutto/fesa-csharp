namespace Ex18
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LimiteCC = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumContaCC = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChequeNao = new System.Windows.Forms.RadioButton();
            this.ChequeSim = new System.Windows.Forms.RadioButton();
            this.SaldoCC = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCC = new System.Windows.Forms.Label();
            this.textNomeCC = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.AniverCP = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ContaAtreladaCP = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NumContaCP = new System.Windows.Forms.MaskedTextBox();
            this.SaldoCP = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NomeCP = new System.Windows.Forms.TextBox();
            this.tabControl3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ValorSaque = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumContaSaque = new System.Windows.Forms.MaskedTextBox();
            this.textBoxListar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimiteCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaldoCC)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AniverCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaldoCP)).BeginInit();
            this.tabControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorSaque)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabControl3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 236);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.LimiteCC);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNumContaCC);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.SaldoCC);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNomeCC);
            this.tabPage1.Controls.Add(this.textNomeCC);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conta Corrente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limite de crédito";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LimiteCC
            // 
            this.LimiteCC.Location = new System.Drawing.Point(252, 156);
            this.LimiteCC.Name = "LimiteCC";
            this.LimiteCC.Size = new System.Drawing.Size(120, 23);
            this.LimiteCC.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número da conta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumContaCC
            // 
            this.txtNumContaCC.Location = new System.Drawing.Point(252, 99);
            this.txtNumContaCC.Mask = "9999-9";
            this.txtNumContaCC.Name = "txtNumContaCC";
            this.txtNumContaCC.Size = new System.Drawing.Size(120, 23);
            this.txtNumContaCC.TabIndex = 5;
            this.txtNumContaCC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChequeNao);
            this.groupBox1.Controls.Add(this.ChequeSim);
            this.groupBox1.Location = new System.Drawing.Point(37, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utiliza cheque?";
            // 
            // ChequeNao
            // 
            this.ChequeNao.AutoSize = true;
            this.ChequeNao.Location = new System.Drawing.Point(19, 54);
            this.ChequeNao.Name = "ChequeNao";
            this.ChequeNao.Size = new System.Drawing.Size(47, 19);
            this.ChequeNao.TabIndex = 1;
            this.ChequeNao.TabStop = true;
            this.ChequeNao.Text = "Não";
            this.ChequeNao.UseVisualStyleBackColor = true;
            // 
            // ChequeSim
            // 
            this.ChequeSim.AutoSize = true;
            this.ChequeSim.Location = new System.Drawing.Point(19, 29);
            this.ChequeSim.Name = "ChequeSim";
            this.ChequeSim.Size = new System.Drawing.Size(45, 19);
            this.ChequeSim.TabIndex = 0;
            this.ChequeSim.TabStop = true;
            this.ChequeSim.Text = "Sim";
            this.ChequeSim.UseVisualStyleBackColor = true;
            // 
            // SaldoCC
            // 
            this.SaldoCC.Location = new System.Drawing.Point(252, 46);
            this.SaldoCC.Name = "SaldoCC";
            this.SaldoCC.Size = new System.Drawing.Size(120, 23);
            this.SaldoCC.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saldo";
            // 
            // txtNomeCC
            // 
            this.txtNomeCC.AutoSize = true;
            this.txtNomeCC.Location = new System.Drawing.Point(37, 28);
            this.txtNomeCC.Name = "txtNomeCC";
            this.txtNomeCC.Size = new System.Drawing.Size(40, 15);
            this.txtNomeCC.TabIndex = 1;
            this.txtNomeCC.Text = "Nome";
            // 
            // textNomeCC
            // 
            this.textNomeCC.Location = new System.Drawing.Point(37, 48);
            this.textNomeCC.Name = "textNomeCC";
            this.textNomeCC.Size = new System.Drawing.Size(174, 23);
            this.textNomeCC.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.AniverCP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ContaAtreladaCP);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.NumContaCP);
            this.tabPage2.Controls.Add(this.SaldoCP);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.NomeCP);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conta Poupança";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Dia do aniversário";
            // 
            // AniverCP
            // 
            this.AniverCP.Location = new System.Drawing.Point(453, 44);
            this.AniverCP.Name = "AniverCP";
            this.AniverCP.Size = new System.Drawing.Size(120, 23);
            this.AniverCP.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Número da conta atrelada";
            // 
            // ContaAtreladaCP
            // 
            this.ContaAtreladaCP.Location = new System.Drawing.Point(255, 106);
            this.ContaAtreladaCP.Mask = "9999-9";
            this.ContaAtreladaCP.Name = "ContaAtreladaCP";
            this.ContaAtreladaCP.Size = new System.Drawing.Size(145, 23);
            this.ContaAtreladaCP.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 49);
            this.button3.TabIndex = 19;
            this.button3.Text = "Cadastrar conta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Número da conta";
            // 
            // NumContaCP
            // 
            this.NumContaCP.Location = new System.Drawing.Point(40, 103);
            this.NumContaCP.Mask = "9999-9";
            this.NumContaCP.Name = "NumContaCP";
            this.NumContaCP.Size = new System.Drawing.Size(174, 23);
            this.NumContaCP.TabIndex = 15;
            // 
            // SaldoCP
            // 
            this.SaldoCP.Location = new System.Drawing.Point(255, 41);
            this.SaldoCP.Name = "SaldoCP";
            this.SaldoCP.Size = new System.Drawing.Size(120, 23);
            this.SaldoCP.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome";
            // 
            // NomeCP
            // 
            this.NomeCP.Location = new System.Drawing.Point(40, 43);
            this.NomeCP.Name = "NomeCP";
            this.NomeCP.Size = new System.Drawing.Size(174, 23);
            this.NomeCP.TabIndex = 10;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.button5);
            this.tabControl3.Controls.Add(this.button4);
            this.tabControl3.Controls.Add(this.ValorSaque);
            this.tabControl3.Controls.Add(this.label10);
            this.tabControl3.Controls.Add(this.label9);
            this.tabControl3.Controls.Add(this.NumContaSaque);
            this.tabControl3.Location = new System.Drawing.Point(4, 24);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.Size = new System.Drawing.Size(624, 208);
            this.tabControl3.TabIndex = 2;
            this.tabControl3.Text = "Saques e depositos";
            this.tabControl3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 47);
            this.button5.TabIndex = 22;
            this.button5.Text = "Depositar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(117, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 47);
            this.button4.TabIndex = 21;
            this.button4.Text = "Sacar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ValorSaque
            // 
            this.ValorSaque.Location = new System.Drawing.Point(319, 62);
            this.ValorSaque.Name = "ValorSaque";
            this.ValorSaque.Size = new System.Drawing.Size(148, 23);
            this.ValorSaque.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número da conta";
            // 
            // NumContaSaque
            // 
            this.NumContaSaque.Location = new System.Drawing.Point(117, 62);
            this.NumContaSaque.Mask = "9999-9";
            this.NumContaSaque.Name = "NumContaSaque";
            this.NumContaSaque.Size = new System.Drawing.Size(174, 23);
            this.NumContaSaque.TabIndex = 17;
            // 
            // textBoxListar
            // 
            this.textBoxListar.Location = new System.Drawing.Point(18, 260);
            this.textBoxListar.Multiline = true;
            this.textBoxListar.Name = "textBoxListar";
            this.textBoxListar.Size = new System.Drawing.Size(445, 127);
            this.textBoxListar.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Listar contas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxListar);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Ex18";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimiteCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaldoCC)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AniverCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaldoCP)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorSaque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabControl3;
        private MaskedTextBox txtNumContaCC;
        private GroupBox groupBox1;
        private RadioButton ChequeNao;
        private RadioButton ChequeSim;
        private NumericUpDown SaldoCC;
        private Label label1;
        private Label txtNomeCC;
        private TextBox textNomeCC;
        private NumericUpDown LimiteCC;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBoxListar;
        private Button button2;
        private Label label8;
        private NumericUpDown AniverCP;
        private Label label4;
        private MaskedTextBox ContaAtreladaCP;
        private Button button3;
        private Label label5;
        private MaskedTextBox NumContaCP;
        private NumericUpDown SaldoCP;
        private Label label6;
        private Label label7;
        private TextBox NomeCP;
        private Button button5;
        private Button button4;
        private NumericUpDown ValorSaque;
        private Label label10;
        private Label label9;
        private MaskedTextBox NumContaSaque;
    }
}