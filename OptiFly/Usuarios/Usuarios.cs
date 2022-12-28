using System;
using System.Data;
using System.Windows.Forms;

namespace OptiFly
{
    public partial class Usuarios : Form
    {
        Validacion v = new Validacion();
        Conexion c = new Conexion();
        DataTable dt = new DataTable();
        public Usuarios()
        {
            InitializeComponent();
            TipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void RbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            butnum.Enabled = false;
            txtId.Enabled = false;
            txtNombre.Enabled = true;
            txtPassword.Enabled = true;
            txtUsuario.Enabled = true;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            butfech.Enabled = false;
            butnom.Enabled = true;
            butusu.Enabled = true;
            butcont.Enabled = true;
            butadmi.Enabled = true;
            TipoUsuario.Enabled = true;
            txtId.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            butnum.Enabled = true;
            txtId.Enabled = true;
            txtNombre.Enabled = false;
            txtPassword.Enabled = false;
            txtUsuario.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = false;
            butfech.Enabled = false;
            butnom.Enabled = false;
            butusu.Enabled = false;
            butcont.Enabled = false;
            butadmi.Enabled = false;
            TipoUsuario.Enabled = false;
            txtId.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            butnum.Enabled = true;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtPassword.Enabled = true;
            txtUsuario.Enabled = true;
            butfech.Enabled = false;
            butnom.Enabled = true;
            butusu.Enabled = true;
            butcont.Enabled = true;
            butadmi.Enabled = true;
            TipoUsuario.Enabled = true;
            txtId.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (RbModificar.Checked == true)
            {
                if (txtId.Text == "")
                {
                    txtNombre.Text = "";
                    txtPassword.Text = "";
                    txtUsuario.Text = "";
                }
                else
                {
                    if (c.personaRegistrada(Convert.ToInt32(txtId.Text)) > 0)
                    {
                        c.llenarTexBoxConsulta(Convert.ToInt32(txtId.Text), TipoUsuario, txtNombre, txtUsuario, txtPassword, dtpFecha);
                        BtnModificar.Enabled = true;
                    }
                    else
                    {
                        txtNombre.Text = "";
                        txtPassword.Text = "";
                        txtUsuario.Text = "";
                        BtnModificar.Enabled = false;
                    }
                }
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre, usuario, contra, fecha;

            nombre = txtNombre.Text;
            usuario = txtUsuario.Text;
            contra = txtPassword.Text;
            fecha = dtpFecha.Text;

            if (nombre == "" || usuario == "" || contra == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                //optiene todos los datos que se ingresaron mediante el formulario
                MessageBox.Show(c.insertar(TipoUsuario.Text, txtNombre.Text, txtUsuario.Text, txtPassword.Text, dtpFecha.Text));
                //para que se actualize los datos automaticamente en el data gribio despues de ser agregados
                c.cargarPersona(DgvPersonas);
                //al agregar los datos se limpian los texbox
                txtId.Text = "";
                txtNombre.Text = "";
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string numcon;
            numcon = txtId.Text;
            if (numcon == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                MessageBox.Show(c.eliminar(Convert.ToInt32(txtId.Text)));
                c.cargarPersona(DgvPersonas);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string numcon;
            numcon = txtId.Text;
            if (numcon == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                MessageBox.Show(c.actualizar(Convert.ToInt32(txtId.Text), TipoUsuario.Text, txtNombre.Text, txtUsuario.Text, txtPassword.Text, dtpFecha.Text));
                c.cargarPersona(DgvPersonas);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            RbInsertar.Checked = true;
            Conexion c = new Conexion();
            c.cargarPersona(DgvPersonas);
            dtpFecha.Enabled = false;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
