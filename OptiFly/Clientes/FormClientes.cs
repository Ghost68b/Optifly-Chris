using System;
using System.Data;
using System.Windows.Forms;

namespace OptiFly
{
    public partial class FormClientes : Form
    {
        Validacion v = new Validacion();
        Cliente1ss c = new Cliente1ss();
        DataTable dt = new DataTable();
        public FormClientes()
        {
            InitializeComponent();
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {

            RbInsertar.Checked = true;
            Cliente1ss c = new Cliente1ss();
            c.cargarPersona(dgv);
            fecha.Enabled = false;
        }
       
        public void limpiar()
        {
            idcliente.Text = "";
            telefono.Text = "";
            this.txtnombre.Text = "";
            domicilio.Text = "";
        }
        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            string nombre, usuario, contra, fecha;

            nombre = telefono.Text;
            usuario = this.txtnombre.Text;
            contra = domicilio.Text;
            fecha = this.fecha.Text;

            if (nombre == "" || usuario == "" || contra == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                //optiene todos los datos que se ingresaron mediante el formulario
                MessageBox.Show(c.insertar(telefono.Text, txtnombre.Text, this.fecha.Text, domicilio.Text));
                //para que se actualize los datos automaticamente en el data gribio despues de ser agregados
                c.cargarPersona(dgv);
                //al agregar los datos se limpian los texbox
                limpiar();
            }
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (RbModificar.Checked == true || RbEliminar.Checked == true)
            {
                if (idcliente.Text == "")
                {
                    limpiar();
                }
                else
                {
                    if (c.personaRegistrada(Convert.ToInt32(idcliente.Text)) > 0)
                    {
                        c.llenarTexBoxConsulta(Convert.ToInt32(idcliente.Text), telefono, txtnombre, fecha, domicilio);
                    }
                    else
                    {
                        telefono.Text = "";
                        this.txtnombre.Text = "";
                        domicilio.Text = "";
                    }
                }
            }
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string numcon;
            numcon = idcliente.Text;
            if (numcon == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                MessageBox.Show(c.eliminar(Convert.ToInt32(idcliente.Text)));
                c.cargarPersona(dgv);
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string numcon;
            numcon = idcliente.Text;
            if (numcon == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                MessageBox.Show(c.actualizar(Convert.ToInt32(idcliente.Text), telefono.Text, txtnombre.Text, fecha.Text, domicilio.Text));
                c.cargarPersona(dgv);
            }
        }
        Cliente1ss sql = new Cliente1ss();
        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            //if (fecha.Text != "") dgv.DataSource = sql.BuscarBodegaSAMS(fecha.Text);
            // else dgv.DataSource = sql.MostrarBodegaUS();
        }
        private void domicilio_TextChanged(object sender, EventArgs e)
        {

        }
        private void RbInsertar_CheckedChanged_1(object sender, EventArgs e)
        {
            idcliente.Enabled = false;
            telefono.Enabled = true;
            domicilio.Enabled = true;
            txtnombre.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            butnum.Enabled = false;
            butfec.Enabled = false;
            buttele.Enabled = true;
            buttele.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            limpiar();
        }
        private void RbEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            idcliente.Enabled = true;
            telefono.Enabled = false;
            domicilio.Enabled = false;
            txtnombre.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = false;
            butnum.Enabled = true;
            butfec.Enabled = false;
            buttele.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            limpiar();
        }
        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
            idcliente.Enabled = true;
            telefono.Enabled = true;
            domicilio.Enabled = true;
            txtnombre.Enabled = true;
            butnum.Enabled = true;
            butfec.Enabled = false;
            buttele.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarClie obj = new BuscarClie();
            obj.ShowDialog();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GbOpcion_Enter(object sender, EventArgs e)
        {

        }
    }
}


