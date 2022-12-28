using System;
using System.Windows.Forms;

namespace OptiFly
{
    public partial class BuscarClie : Form
    {
        Validacion v = new Validacion();
        Cliente1ss c = new Cliente1ss();
        pedidocs P = new pedidocs();
        public BuscarClie()
        {
            InitializeComponent();
        }
        private void BuscarClie_Load(object sender, EventArgs e)
        {

            c.cargarPersona(dgv);
            P.cargarPersona(dgv2);
        }
        private void data2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Pedido del Cliente
            if (textBox1.Text != "")
                dgv2.DataSource = P.BuscarVenta(textBox1.Text);
            else dgv2.DataSource = P.MostrarVenta();
            /// Cliente
            if (textBox1.Text != "")
                dgv.DataSource = P.BuscarClien(textBox1.Text);
            else dgv.DataSource = P.MostrarClien();
        }
        private void telefono_TextChanged(object sender, EventArgs e)
        {
            //Pedido del Cliente
            if (telefono.Text != "") dgv2.DataSource = P.BuscarVentaTel(telefono.Text);
            else dgv2.DataSource = P.MostrarVenta();
            //Cliente
            if (telefono.Text != "") dgv.DataSource = P.BuscarClienTel(telefono.Text);
            else dgv.DataSource = P.MostrarClien();
        }
        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            //Pedido del Cliente
            if (txtnombre.Text != "") dgv2.DataSource = P.BuscarVentaNom(txtnombre.Text);
            else dgv2.DataSource = P.MostrarVenta();

            //Cliente
            if (txtnombre.Text != "") dgv.DataSource = P.BuscarClieNom(txtnombre.Text);
            else dgv.DataSource = P.MostrarClien();
        }

       private void button4_Click(object sender, EventArgs e)
        {
          //  exportaraexcel(dgv);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void BuscarClie_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        /*  public void exportaraexcel(DataGridView tabla)
         {

             Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

             excel.Application.Workbooks.Add(true);

             int IndiceColumna = 0;

             foreach (DataGridViewColumn col in tabla.Columns)
             {

                 IndiceColumna++;

                 excel.Cells[1, IndiceColumna] = col.Name;

             }

             int IndeceFila = 0;

             foreach (DataGridViewRow row in tabla.Rows)
             {

                 IndeceFila++;

                 IndiceColumna = 0;

                 foreach (DataGridViewColumn col in tabla.Columns)
                 {

                     IndiceColumna++;

                     excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                 }

             }

             excel.Visible = true;


         }*/
    }
}
