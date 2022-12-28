using System;
using System.Windows.Forms;

namespace OptiFly
{
    public partial class MenuPrin : Form
    {
        public MenuPrin(Form1.datos Nombre, Form1.datos2 tipo)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios obj = new Usuarios();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClientes obj = new FormClientes();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pedido obj = new Pedido();
            obj.ShowDialog();
        }
    }
}
