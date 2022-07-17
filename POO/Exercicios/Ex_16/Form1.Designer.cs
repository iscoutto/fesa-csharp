namespace Ex_16
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbListaDificuldade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorAcrescimo = new System.Windows.Forms.TextBox();
            this.btnAtualizaPorValor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPercentualAcrescimo = new System.Windows.Forms.TextBox();
            this.btnAtualizaPorPercentual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(97, 59);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(241, 23);
            this.txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dificuldade";
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Location = new System.Drawing.Point(97, 93);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(121, 23);
            this.cbDificuldade.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(97, 125);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 23);
            this.txtValor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fabricante";
            // 
            // cbFabricante
            // 
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(97, 188);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(121, 23);
            this.cbFabricante.TabIndex = 9;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(24, 226);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(97, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // cbListaDificuldade
            // 
            this.cbListaDificuldade.FormattingEnabled = true;
            this.cbListaDificuldade.Location = new System.Drawing.Point(437, 191);
            this.cbListaDificuldade.Name = "cbListaDificuldade";
            this.cbListaDificuldade.Size = new System.Drawing.Size(154, 23);
            this.cbListaDificuldade.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dificuldade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Listar por dificuldade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Carregar todos os jogos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Listar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(24, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(709, 124);
            this.listBox1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Atualização de preços";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Valor";
            // 
            // txtValorAcrescimo
            // 
            this.txtValorAcrescimo.Location = new System.Drawing.Point(476, 59);
            this.txtValorAcrescimo.Name = "txtValorAcrescimo";
            this.txtValorAcrescimo.Size = new System.Drawing.Size(145, 23);
            this.txtValorAcrescimo.TabIndex = 20;
            // 
            // btnAtualizaPorValor
            // 
            this.btnAtualizaPorValor.Location = new System.Drawing.Point(627, 58);
            this.btnAtualizaPorValor.Name = "btnAtualizaPorValor";
            this.btnAtualizaPorValor.Size = new System.Drawing.Size(72, 23);
            this.btnAtualizaPorValor.TabIndex = 21;
            this.btnAtualizaPorValor.Text = "Atualizar";
            this.btnAtualizaPorValor.UseVisualStyleBackColor = true;
            this.btnAtualizaPorValor.Click += new System.EventHandler(this.btnAtualizaPorValor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Percentual";
            // 
            // txtPercentualAcrescimo
            // 
            this.txtPercentualAcrescimo.Location = new System.Drawing.Point(506, 93);
            this.txtPercentualAcrescimo.Name = "txtPercentualAcrescimo";
            this.txtPercentualAcrescimo.Size = new System.Drawing.Size(115, 23);
            this.txtPercentualAcrescimo.TabIndex = 23;
            // 
            // btnAtualizaPorPercentual
            // 
            this.btnAtualizaPorPercentual.Location = new System.Drawing.Point(627, 92);
            this.btnAtualizaPorPercentual.Name = "btnAtualizaPorPercentual";
            this.btnAtualizaPorPercentual.Size = new System.Drawing.Size(72, 23);
            this.btnAtualizaPorPercentual.TabIndex = 24;
            this.btnAtualizaPorPercentual.Text = "Atualizar";
            this.btnAtualizaPorPercentual.UseVisualStyleBackColor = true;
            this.btnAtualizaPorPercentual.Click += new System.EventHandler(this.btnAtualizaPorPercentual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 426);
            this.Controls.Add(this.btnAtualizaPorPercentual);
            this.Controls.Add(this.txtPercentualAcrescimo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAtualizaPorValor);
            this.Controls.Add(this.txtValorAcrescimo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbListaDificuldade);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.cbFabricante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exercício_16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtDescricao;
        private Label label3;
        private ComboBox cbDificuldade;
        private Label label4;
        private TextBox txtValor;
        private Label label5;
        private ComboBox cbFabricante;
        private Button btSalvar;
        private ComboBox cbListaDificuldade;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Label label7;
        private Label label8;
        private TextBox txtValorAcrescimo;
        private Button btnAtualizaPorValor;
        private Label label9;
        private TextBox txtPercentualAcrescimo;
        private Button btnAtualizaPorPercentual;
    }
}