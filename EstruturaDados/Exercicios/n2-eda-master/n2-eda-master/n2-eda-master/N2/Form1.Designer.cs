namespace N2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deImportar = new System.Windows.Forms.Button();
            this.deTela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deImportar
            // 
            this.deImportar.Location = new System.Drawing.Point(12, 363);
            this.deImportar.Name = "deImportar";
            this.deImportar.Size = new System.Drawing.Size(167, 75);
            this.deImportar.TabIndex = 0;
            this.deImportar.Text = "Importar";
            this.deImportar.UseVisualStyleBackColor = true;
            this.deImportar.Click += new System.EventHandler(this.deImportar_Click);
            // 
            // deTela
            // 
            this.deTela.Location = new System.Drawing.Point(185, 12);
            this.deTela.Multiline = true;
            this.deTela.Name = "deTela";
            this.deTela.ReadOnly = true;
            this.deTela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deTela.Size = new System.Drawing.Size(603, 426);
            this.deTela.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deTela);
            this.Controls.Add(this.deImportar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deImportar;
        private System.Windows.Forms.TextBox deTela;
    }
}

