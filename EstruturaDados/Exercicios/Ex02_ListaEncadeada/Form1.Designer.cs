namespace Ex02_ListaEncadeada
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numeric1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.numeric2 = new System.Windows.Forms.NumericUpDown();
            this.tela = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.campoPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(42, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(109, 23);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Location = new System.Drawing.Point(45, 33);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(33, 15);
            this.Valor.TabIndex = 1;
            this.Valor.Text = "Valor";
            this.Valor.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inserir no inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Inserir no fim";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Inserir na posição";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(403, 90);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(63, 23);
            this.numeric1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Remover da posição";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numeric2
            // 
            this.numeric2.Location = new System.Drawing.Point(403, 136);
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(63, 23);
            this.numeric2.TabIndex = 7;
            this.numeric2.ValueChanged += new System.EventHandler(this.numeric2_ValueChanged);
            // 
            // tela
            // 
            this.tela.Location = new System.Drawing.Point(45, 174);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(219, 153);
            this.tela.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(45, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Listar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // campoPesquisa
            // 
            this.campoPesquisa.Location = new System.Drawing.Point(333, 256);
            this.campoPesquisa.Name = "campoPesquisa";
            this.campoPesquisa.Size = new System.Drawing.Size(119, 23);
            this.campoPesquisa.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pesquisar um valor";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(333, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 32);
            this.button6.TabIndex = 12;
            this.button6.Text = "Pesquisar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 360);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoPesquisa);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.numeric2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Ex_15";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtValor;
        private Label Valor;
        private Button button1;
        private Button button2;
        private Button button3;
        private NumericUpDown numeric1;
        private Button button4;
        private NumericUpDown numeric2;
        private TextBox tela;
        private Button button5;
        private TextBox campoPesquisa;
        private Label label1;
        private Button button6;
    }
}