using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace OptiFly
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox2.PasswordChar = '*';
        }
        public struct datos
        {
            public string Nombre;
        }

        public struct datos2
        {
            public string Tipo;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = BdComun.ObtenerConexion();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("Select * from usuarios where Usuario = '" + textBox1.Text + "' and password = '" + textBox2.Text + "' and TipoUsuario = '" + comboBox1.Text + "' and Num_Control");
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read())
            {
                if (comboBox1.Text == "Administrador")
                {

                    datos info;
                    datos2 info2;
                    info.Nombre = textBox1.Text;
                    info2.Tipo = comboBox1.Text;

                    MenuPrin admin = new MenuPrin(info, info2);
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    datos info;
                    datos2 info2;
                    info.Nombre = textBox1.Text;
                    info2.Tipo = comboBox1.Text;

                    MenuPrin frm1 = new MenuPrin(info, info2);
                    frm1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("La constraseña o usuario estan mal");
            }
            conectar.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
