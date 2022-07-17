namespace Ex04_Recursividade
{
    public partial class Form1 : Form
    {
        /*
         * Faça um método para limpar todos os makedit e os Textbox de um form,
         * mesmo que eles estejam dentro de panels, groupbox.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void DeleteAll(Control container)
        {
            // Control é uma classe base para controles, os componentes com representação visual para o Windows Forms
            foreach (Control control in container.Controls)
            {
                if (control.Controls.Count > 0)
                    DeleteAll(control);
                else if (!(control is Button || control is Label))
                    control.Text = "";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteAll(this);
        }
    }
}