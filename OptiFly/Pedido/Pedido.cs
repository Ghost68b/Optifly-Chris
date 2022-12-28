using System;
using System.Net.Configuration;
using System.Windows.Forms;

namespace OptiFly
{
    public partial class Pedido : Form
    {
        string pd1, pd2, pd3, pd4, pd5, pd6, pd7, pd8, pd9, pd10, pd11, pd12, pd13, pd14, pd15, pd16, pd17, pd18, pd19, pd20, pd21, pd22, pd23, pd24,
            pd25, pd26, pd27, pd28, pd29, pd30, pd31, pd32;
        Validacion v = new Validacion();
        Cliente1ss c = new Cliente1ss();
        pedidocs P = new pedidocs();

        public Pedido()
        {

            InitializeComponent();
          
        }
        public void limpiar()
        {
            telefono.Text = ""; txtnombre.Text = ""; fecha.Text = ""; domicilio.Text = ""; a1.Text = ""; a2.Text = "";
            a3.Text = ""; a4.Text = ""; a5.Text = ""; a6.Text = ""; a7.Text = ""; a8.Text = ""; a9.Text = ""; a10.Text = "";
            b1.Text = ""; b2.Text = ""; b3.Text = ""; b4.Text = ""; b5.Text = ""; b6.Text = ""; b7.Text = ""; b8.Text = "";
            textBox2.Text = "0"; textBox3.Text = "0"; res.Text = ""; NumPedido.Text = ""; textBox1.Text = ""; idcliente.Text = "";
            dt1.Text = ""; d1.Checked = false; dt2.Text = ""; d2.Checked = false; dt3.Text = ""; d3.Checked = false; dt4.Text = ""; d4.Checked = false;
            dt5.Text = ""; d5.Checked = false; dt6.Text = ""; d6.Checked = false; dt7.Text = ""; d7.Checked = false; dt8.Text = ""; d8.Checked = false;
            dt9.Text = ""; d9.Checked = false; dt10.Text = ""; d10.Checked = false; dt11.Text = ""; d11.Checked = false; dt12.Text = ""; d12.Checked = false;
            dt13.Text = ""; d13.Checked = false; dt14.Text = ""; d14.Checked = false; dt15.Text = ""; d15.Checked = false; dt16.Text = ""; d16.Checked = false;
            dt17.Text = ""; d17.Checked = false; dt18.Text = ""; d18.Checked = false; dt19.Text = ""; d19.Checked = false; dt20.Text = ""; d20.Checked = false;
            dt21.Text = ""; d21.Checked = false; dt22.Text = ""; d22.Checked = false; dt23.Text = ""; d23.Checked = false; dt24.Text = ""; d24.Checked = false;
            dt25.Text = ""; d25.Checked = false; dt26.Text = ""; d26.Checked = false; dt27.Text = ""; d27.Checked = false; dt28.Text = ""; d28.Checked = false;
            dt29.Text = ""; d29.Checked = false; dt30.Text = ""; d30.Checked = false; dt31.Text = ""; d31.Checked = false; dt32.Text = ""; d32.Checked = false;
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            NumPedido.Enabled = true;
            idcliente.Enabled = false;
            telefono.Enabled = false;
            domicilio.Enabled = false;
            txtnombre.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = false;
            //A
            a1.Enabled = false; a6.Enabled = false; a2.Enabled = false; a7.Enabled = false;
            a3.Enabled = false; a8.Enabled = false; a4.Enabled = false; a5.Enabled = false;
            a10.Enabled = false; a9.Enabled = false;
            //B
            b1.Enabled = false; b5.Enabled = false; b2.Enabled = false; b6.Enabled = false;
            b3.Enabled = false; b7.Enabled = false; b4.Enabled = false; b8.Enabled = false;
            

            textBox2.Enabled = false; textBox3.Enabled = false; res.Enabled = false; textBox1.Enabled = false;

            limpiar();


            // pictureBox1.Enabled = false;
        }
        private void Pedido_Load(object sender, EventArgs e)
        {
           

            // textBox4.Text = resultado.ToString();

            RbInsertar.Checked = true;
            fecha.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarClie obj = new BuscarClie();
            obj.ShowDialog();
        }
        private void idcliente_TextChanged(object sender, EventArgs e)
        {
            if (RbInsertar.Checked == true || RbModificar.Checked == true || RbEliminar.Checked == true)
            {
                if (idcliente.Text == "")
                {
                    telefono.Text = "";
                    txtnombre.Text = "";
                    fecha.Text = "";
                    domicilio.Text = "";
                }
                else
                {
                    if (c.personaRegistrada(Convert.ToInt32(idcliente.Text)) > 0)
                    {
                        c.llenarTexBoxConsulta2(Convert.ToInt32(idcliente.Text), telefono, txtnombre, domicilio);

                    }
                    else
                    {
                       
                        telefono.Text = "";
                        txtnombre.Text = "";
                        fecha.Text = "";
                        BtnModificar.Enabled = false;
                    }
                }
            }
        }
        private void RbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            //False
            NumPedido.Enabled = false;
            telefono.Enabled = false;
            domicilio.Enabled = false;
            txtnombre.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            //true
            idcliente.Enabled = true;
            BtnAgregar.Enabled = true;

            //A
            a1.Enabled = true; a6.Enabled = true; a2.Enabled = true; a7.Enabled = true;
            a3.Enabled = true; a8.Enabled = true; a4.Enabled = true; a5.Enabled = true;
            a10.Enabled = true; a9.Enabled = true;
            //B
            b1.Enabled = true; b5.Enabled = true; b2.Enabled = true; b6.Enabled = true;
            b3.Enabled = true; b7.Enabled = true; b4.Enabled = true; b8.Enabled = true;
            //C

            textBox2.Enabled = true; textBox3.Enabled = true; res.Enabled = false; textBox1.Enabled = true;

            limpiar();
        }

        private void RbModificar_CheckedChanged(object sender, EventArgs e)
        {
            //false
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = false;
            idcliente.Enabled = false;
            telefono.Enabled = false;
            domicilio.Enabled = false;
            txtnombre.Enabled = false;
            res.Enabled = false;
            //true
            NumPedido.Enabled = true;
            BtnModificar.Enabled = true;

            //A
            a1.Enabled = true; a6.Enabled = true; a2.Enabled = true; a7.Enabled = true;
            a3.Enabled = true; a8.Enabled = true; a4.Enabled = true; a5.Enabled = true;
            a10.Enabled = true; a9.Enabled = true;
            //B
            b1.Enabled = true; b5.Enabled = true; b2.Enabled = true; b6.Enabled = true;
            b3.Enabled = true; b7.Enabled = true; b4.Enabled = true; b8.Enabled = true;
            //C

            textBox2.Enabled = true; textBox3.Enabled = true; res.Enabled = false; textBox1.Enabled = true;

            limpiar();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void NumPedido_TextChanged(object sender, EventArgs e)
        {
            string vd1, vd2, vd3, vd4, vd5, vd6, vd7, vd8, vd9, vd10, vd11, vd12, vd13, vd14, vd15, vd16, vd17, vd18, vd19, vd20, vd21, vd22, vd23, vd24,
            vd25, vd26, vd27, vd28, vd29, vd30, vd31, vd32;

            if (RbModificar.Checked == true || RbEliminar.Checked == true)
            {
                if (NumPedido.Text == "")
                {
                    telefono.Text = ""; txtnombre.Text = ""; fecha.Text = ""; domicilio.Text = ""; a1.Text = ""; a2.Text = "";
                    a3.Text = ""; a4.Text = ""; a5.Text = ""; a6.Text = ""; a7.Text = ""; a8.Text = ""; a9.Text = ""; a10.Text = "";
                    b1.Text = ""; b2.Text = ""; b3.Text = ""; b4.Text = ""; b5.Text = ""; b6.Text = ""; b7.Text = ""; b8.Text = "";
                    idcliente.Text = ""; textBox1.Text = ""; idcliente.Text = "";
                    textBox2.Text = "0"; textBox3.Text = "0"; res.Text = "";
                  
                    dt1.Text = ""; d1.Checked = false; dt2.Text = ""; d2.Checked = false; dt3.Text = ""; d3.Checked = false; dt4.Text = ""; d4.Checked = false;
                    dt5.Text = ""; d5.Checked = false; dt6.Text = ""; d6.Checked = false; dt7.Text = ""; d7.Checked = false; dt8.Text = ""; d8.Checked = false;
                    dt9.Text = ""; d9.Checked = false; dt10.Text = ""; d10.Checked = false; dt11.Text = ""; d11.Checked = false; dt12.Text = ""; d12.Checked = false;
                    dt13.Text = ""; d13.Checked = false; dt14.Text = ""; d14.Checked = false; dt15.Text = ""; d15.Checked = false; dt16.Text = ""; d16.Checked = false;
                    dt17.Text = ""; d17.Checked = false; dt18.Text = ""; d18.Checked = false; dt19.Text = ""; d19.Checked = false; dt20.Text = ""; d20.Checked = false;
                    dt21.Text = ""; d21.Checked = false; dt22.Text = ""; d22.Checked = false; dt23.Text = ""; d23.Checked = false; dt24.Text = ""; d24.Checked = false;
                    dt25.Text = ""; d25.Checked = false; dt26.Text = ""; d26.Checked = false; dt27.Text = ""; d27.Checked = false; dt28.Text = ""; d28.Checked = false;
                    dt29.Text = ""; d29.Checked = false; dt30.Text = ""; d30.Checked = false;  dt31.Text = ""; d31.Checked = false; dt32.Text = ""; d32.Checked = false;

                }
                else
                {
                    if (P.personaRegistrada(Convert.ToInt32(NumPedido.Text)) > 0)
                    {
                        P.llenarTexBoxConsulta(Convert.ToInt32(NumPedido.Text), idcliente, telefono, txtnombre, fecha, domicilio,
                            a1, a2, a3, a4, a5, a6, a7, a8, a9, a10,
                            b1, b2, b3, b4, b5, b6, b7, b8,
                            textBox1, textBox2, textBox3, dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8, dt9, dt10, dt11, dt12, dt13, dt14, dt15, dt16, dt17, dt18,
                            dt19, dt20, dt21, dt22, dt23, dt24, dt25, dt26, dt27, dt28, dt29, dt30, dt31, dt32);

                        vd1 = dt1.Text;
                        if (dt1.Text == "")
                        { d1.Checked = false; }
                        else { d1.Checked = true; }

                        vd2 = dt2.Text;
                        if (dt2.Text == "")
                        { d2.Checked = false; }
                        else { d2.Checked = true; }

                        vd3 = dt3.Text;
                        if (dt3.Text == "")
                        { d3.Checked = false; }
                        else { d3.Checked = true; }

                        vd4 = dt4.Text;
                        if (dt4.Text == "")
                        { d4.Checked = false; }
                        else { d4.Checked = true; }

                        vd5 = dt5.Text;
                        if (dt5.Text == "")
                        { d5.Checked = false; }
                        else { d5.Checked = true; }

                        vd6 = dt6.Text;
                        if (dt6.Text == "")
                        { d6.Checked = false; }
                        else { d6.Checked = true; }

                        vd7 = dt7.Text;
                        if (dt7.Text == "")
                        { d7.Checked = false; }
                        else { d7.Checked = true; }

                        vd8 = dt8.Text;
                        if (dt8.Text == "")
                        { d8.Checked = false; }
                        else { d8.Checked = true; }

                        vd9 = dt9.Text;
                        if (dt9.Text == "")
                        { d9.Checked = false; }
                        else { d9.Checked = true; }

                        vd10 = dt10.Text;
                        if (dt10.Text == "")
                        { d10.Checked = false; }
                        else { d10.Checked = true; }

                        vd11 = dt11.Text;
                        if (dt11.Text == "")
                        { d11.Checked = false; }
                        else { d11.Checked = true; }

                        vd12 = dt12.Text;
                        if (dt12.Text == "")
                        { d12.Checked = false; }
                        else { d12.Checked = true; }

                        vd13 = dt13.Text;
                        if (dt13.Text == "")
                        { d13.Checked = false; }
                        else { d13.Checked = true; }

                        vd14 = dt14.Text;
                        if (dt14.Text == "")
                        { d14.Checked = false; }
                        else { d14.Checked = true; }

                        vd15 = dt15.Text;
                        if (dt15.Text == "")
                        { d15.Checked = false; }
                        else { d15.Checked = true; }

                        vd16 = dt16.Text;
                        if (dt16.Text == "")
                        { d16.Checked = false; }
                        else { d16.Checked = true; }

                        vd17 = dt17.Text;
                        if (dt17.Text == "")
                        { d17.Checked = false; }
                        else { d17.Checked = true; }

                        vd18 = dt18.Text;
                        if (dt18.Text == "")
                        { d18.Checked = false; }
                        else { d18.Checked = true; }

                        vd19 = dt19.Text;
                        if (dt19.Text == "")
                        { d19.Checked = false; }
                        else { d19.Checked = true; }

                        vd20 = dt20.Text;
                        if (dt20.Text == "")
                        { d20.Checked = false; }
                        else { d20.Checked = true; }

                        vd21 = dt21.Text;
                        if (dt21.Text == "")
                        { d21.Checked = false; }
                        else { d21.Checked = true; }

                        vd22 = dt22.Text;
                        if (dt22.Text == "")
                        { d22.Checked = false; }
                        else { d22.Checked = true; }

                        vd23 = dt23.Text;
                        if (dt23.Text == "")
                        { d23.Checked = false; }
                        else { d23.Checked = true; }

                        vd24 = dt24.Text;
                        if (dt24.Text == "")
                        { d24.Checked = false; }
                        else { d24.Checked = true; }

                        vd25 = dt25.Text;
                        if (dt25.Text == "")
                        { d25.Checked = false; }
                        else { d25.Checked = true; }

                        vd26 = dt26.Text;
                        if (dt26.Text == "")
                        { d26.Checked = false; }
                        else { d26.Checked = true; }

                        vd27 = dt27.Text;
                        if (dt27.Text == "")
                        { d27.Checked = false; }
                        else { d27.Checked = true; }

                        vd28 = dt28.Text;
                        if (dt28.Text == "")
                        { d28.Checked = false; }
                        else { d28.Checked = true; }

                        vd29 = dt29.Text;
                        if (dt29.Text == "")
                        { d29.Checked = false; }
                        else { d29.Checked = true; }

                        vd30 = dt30.Text;
                        if (dt30.Text == "")
                        { d30.Checked = false; }
                        else { d30.Checked = true; }

                        vd31 = dt31.Text;
                        if (dt31.Text == "")
                        { d31.Checked = false; }
                        else { d31.Checked = true; }

                        vd32 = dt32.Text;
                        if (dt32.Text == "")
                        { d32.Checked = false; }
                        else { d32.Checked = true; }
                    }
                    else
                    {
                        telefono.Text = "";
                        txtnombre.Text = "";
                        fecha.Text = "";
                    }
                }
            }
        }

        private void d8_CheckedChanged(object sender, EventArgs e)
        {
            pd8 = dt8.Text;
            if (d8.Checked == false)
            {
                dt8.Text = "";
            }
            else
            {
                dt8.Text = d8.Text;
            }
        }

        private void d9_CheckedChanged(object sender, EventArgs e)
        {
            pd9 = dt9.Text;
            if (d9.Checked == false)
            {
                dt9.Text = "";
            }
            else
            {
                dt9.Text = d9.Text;
            }
        }

        private void d10_CheckedChanged(object sender, EventArgs e)
        {
            pd10 = dt10.Text;
            if (d10.Checked == false)
            {
                dt10.Text = "";
            }
            else
            {
                dt10.Text = d10.Text;
            }
        }

        private void d11_CheckedChanged(object sender, EventArgs e)
        {
            pd11 = dt11.Text;
            if (d11.Checked == false)
            {
                dt11.Text = "";
            }
            else
            {
                dt11.Text = d11.Text;
            }
        }

        private void d12_CheckedChanged(object sender, EventArgs e)
        {
            pd12 = dt12.Text;
            if (d12.Checked == false)
            {
                dt12.Text = "";
            }
            else
            {
                dt12.Text = d12.Text;
            }
        }

        private void d13_CheckedChanged(object sender, EventArgs e)
        {
            pd13 = dt13.Text;
            if (d13.Checked == false)
            {
                dt13.Text = "";
            }
            else
            {
                dt13.Text = d13.Text;
            }
        }

        private void d14_CheckedChanged(object sender, EventArgs e)
        {
            pd14 = dt14.Text;
            if (d14.Checked == false)
            {
                dt14.Text = "";
            }
            else
            {
                dt14.Text = d14.Text;
            }
        }

        private void d15_CheckedChanged(object sender, EventArgs e)
        {
            pd15 = dt15.Text;
            if (d15.Checked == false)
            {
                dt15.Text = "";
            }
            else
            {
                dt15.Text = d15.Text;
            }
        }

        private void d16_CheckedChanged(object sender, EventArgs e)
        {
            pd16 = dt16.Text;
            if (d16.Checked == false)
            {
                dt16.Text = "";
            }
            else
            {
                dt16.Text = d16.Text;
            }
        }

        private void d17_CheckedChanged(object sender, EventArgs e)
        {
            pd17 = dt17.Text;
            if (d17.Checked == false)
            {
                dt17.Text = "";
            }
            else
            {
                dt17.Text = d17.Text;
            }
        }

        private void d18_CheckedChanged(object sender, EventArgs e)
        {
            pd18 = dt18.Text;
            if (d18.Checked == false)
            {
                dt18.Text = "";
            }
            else
            {
                dt18.Text = d18.Text;
            }
        }

        private void d19_CheckedChanged(object sender, EventArgs e)
        {
            pd19 = dt19.Text;
            if (d19.Checked == false)
            {
                dt19.Text = "";
            }
            else
            {
                dt19.Text = d19.Text;
            }
        }

        private void d20_CheckedChanged(object sender, EventArgs e)
        {
            pd20 = dt20.Text;
            if (d20.Checked == false)
            {
                dt20.Text = "";
            }
            else
            {
                dt20.Text = d20.Text;
            }
        }

        private void d21_CheckedChanged(object sender, EventArgs e)
        {
            pd21 = dt21.Text;
            if (d21.Checked == false)
            {
                dt21.Text = "";
            }
            else
            {
                dt21.Text = d21.Text;
            }
        }

        private void d22_CheckedChanged(object sender, EventArgs e)
        {
            pd22 = dt22.Text;
            if (d22.Checked == false)
            {
                dt22.Text = "";
            }
            else
            {
                dt22.Text = d22.Text;
            }
        }

        private void d23_CheckedChanged(object sender, EventArgs e)
        {
            pd23 = dt23.Text;
            if (d23.Checked == false)
            {
                dt23.Text = "";
            }
            else
            {
                dt23.Text = d23.Text;
            }
        }

        private void d24_CheckedChanged(object sender, EventArgs e)
        {
            pd24 = dt24.Text;
            if (d24.Checked == false)
            {
                dt24.Text = "";
            }
            else
            {
                dt24.Text = d24.Text;
            }
        }

        private void d25_CheckedChanged(object sender, EventArgs e)
        {
            pd25 = dt25.Text;
            if (d25.Checked == false)
            {
                dt25.Text = "";
            }
            else
            {
                dt25.Text = d25.Text;
            }
        }

        private void d26_CheckedChanged(object sender, EventArgs e)
        {
            pd26 = dt26.Text;
            if (d26.Checked == false)
            {
                dt26.Text = "";
            }
            else
            {
                dt26.Text = d26.Text;
            }
        }

        private void d27_CheckedChanged(object sender, EventArgs e)
        {
            pd27 = dt27.Text;
            if (d27.Checked == false)
            {
                dt27.Text = "";
            }
            else
            {
                dt27.Text = d27.Text;
            }
        }

        private void d28_CheckedChanged(object sender, EventArgs e)
        {
            pd28 = dt28.Text;
            if (d28.Checked == false)
            {
                dt28.Text = "";
            }
            else
            {
                dt28.Text = d28.Text;
            }
        }

        private void d29_CheckedChanged(object sender, EventArgs e)
        {
            pd29 = dt29.Text;
            if (d29.Checked == false)
            {
                dt29.Text = "";
            }
            else
            {
                dt29.Text = d29.Text;
            }
        }

        private void d30_CheckedChanged(object sender, EventArgs e)
        {
            pd30 = dt30.Text;
            if (d30.Checked == false)
            {
                dt30.Text = "";
            }
            else
            {
                dt30.Text = d30.Text;
            }
        }

        private void d31_CheckedChanged(object sender, EventArgs e)
        {
            pd31 = dt31.Text;
            if (d31.Checked == false)
            {
                dt31.Text = "";
            }
            else
            {
                dt31.Text = d31.Text;
            }
        }

        private void d32_CheckedChanged(object sender, EventArgs e)
        {
            pd32 = dt32.Text;
            if (d32.Checked == false)
            {
                dt32.Text = "";
            }
            else
            {
                dt32.Text = d32.Text;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = telefono.Text;

            if (nombre == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                //optiene todos los datos que se ingresaron mediante el formulario
                MessageBox.Show(P.insertar(idcliente.Text, telefono.Text, txtnombre.Text, fecha.Text, domicilio.Text,
                            a1.Text, a2.Text, a3.Text, a4.Text, a5.Text, a6.Text, a7.Text, a8.Text, a9.Text, a10.Text,
                            b1.Text, b2.Text, b3.Text, b4.Text, b5.Text, b6.Text, b7.Text, b8.Text,
                            textBox1.Text, textBox2.Text, textBox3.Text, 
                            
                            dt1.Text, dt2.Text, dt3.Text, dt4.Text, dt5.Text, dt6.Text, dt7.Text, dt8.Text, dt9.Text, dt10.Text, dt11.Text, dt12.Text,
                            dt13.Text, dt14.Text, dt15.Text, dt16.Text, dt17.Text, dt18.Text, dt19.Text, dt20.Text, dt21.Text, dt22.Text, dt23.Text, dt24.Text,
                            dt25.Text, dt26.Text, dt27.Text, dt28.Text, dt29.Text, dt30.Text, dt31.Text, dt32.Text));

                limpiar();
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string numcon;
            numcon = NumPedido.Text;
            if (numcon == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                MessageBox.Show(P.eliminar(Convert.ToInt32(NumPedido.Text)));
                limpiar();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            string numcon;
            numcon = NumPedido.Text;
            if (numcon == "")
            {
                MessageBox.Show("debes llenar el campo");

            }
            else
            {
                MessageBox.Show(P.actualizar(Convert.ToInt32(NumPedido.Text), a1.Text, a2.Text, a3.Text, a4.Text, a5.Text, a6.Text, a7.Text, a8.Text, a9.Text, a10.Text,
                            b1.Text, b2.Text, b3.Text, b4.Text, b5.Text, b6.Text, b7.Text, b8.Text, textBox1.Text, textBox2.Text, textBox3.Text,


                            dt1.Text, dt2.Text, dt3.Text, dt4.Text, dt5.Text, dt6.Text, dt7.Text, dt8.Text, dt9.Text, dt10.Text, dt11.Text, dt12.Text,
                            dt13.Text, dt14.Text, dt15.Text, dt16.Text, dt17.Text, dt18.Text, dt19.Text, dt20.Text, dt21.Text, dt22.Text, dt23.Text, dt24.Text,
                            dt25.Text, dt26.Text, dt27.Text, dt28.Text, dt29.Text, dt30.Text, dt31.Text, dt32.Text
                            ));
                limpiar();

            }
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }
        private void res_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;
            if (textBox2.Text == "" || textBox3.Text == "")
            {

                MessageBox.Show("Falta Anticipo");
            }

            else
            {

                valor1 = double.Parse(textBox2.Text);
                valor2 = double.Parse(textBox3.Text);

                resultado = valor1 - valor2;
                res.Text = resultado.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;
            if (textBox2.Text == "" || textBox3.Text == "")
            {

                MessageBox.Show("Falta Precio");
            }
            else
            {

                valor1 = double.Parse(textBox2.Text);
                valor2 = double.Parse(textBox3.Text);

                resultado = valor1 - valor2;
                res.Text = resultado.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void b8_TextChanged(object sender, EventArgs e)
        {

        }

        private void b4_TextChanged(object sender, EventArgs e)
        {

        }

        private void b7_TextChanged(object sender, EventArgs e)
        {

        }

        private void b3_TextChanged(object sender, EventArgs e)
        {

        }

        private void b6_TextChanged(object sender, EventArgs e)
        {

        }

        private void b2_TextChanged(object sender, EventArgs e)
        {

        }

        private void b5_TextChanged(object sender, EventArgs e)
        {

        }

        private void d3_CheckedChanged(object sender, EventArgs e)
        {
            pd3 = dt3.Text;
            if (d3.Checked == false)
            {
                dt3.Text = "";
            }
            else
            {
                dt3.Text = d3.Text;
            }
        }

        private void d6_CheckedChanged(object sender, EventArgs e)
        {
            pd6 = dt6.Text;
            if (d6.Checked == false)
            {
                dt6.Text = "";
            }
            else
            {
                dt6.Text = d6.Text;
            }
        }

        private void d5_CheckedChanged(object sender, EventArgs e)
        {
            pd5 = dt5.Text;
            if (d5.Checked == false)
            {
                dt5.Text = "";
            }
            else
            {
                dt5.Text = d5.Text;
            }
        }

        private void d4_CheckedChanged(object sender, EventArgs e)
        {
            pd4 = dt4.Text;
            if (d4.Checked == false)
            {
                dt4.Text = "";
            }
            else
            {
                dt4.Text = d4.Text;
            }
        }

        private void d7_CheckedChanged(object sender, EventArgs e)
        {
            pd7 = dt7.Text;
            if (d7.Checked == false)
            {
                dt7.Text = "";
            }
            else
            {
                dt7.Text = d7.Text;
            }
        }

        private void b1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pd2 = dt2.Text;
            if (d2.Checked == false)
            {
                dt2.Text = "";
            }
            else
            {
                dt2.Text = d2.Text;
            }
        }
    

        private void pru_CheckedChanged(object sender, EventArgs e)
        {
            
            pd1 = dt1.Text;
            if (d1.Checked == false)
            {
                dt1.Text = "";
            }
            else
            {
                dt1.Text = d1.Text;
            }
        }

        private void dt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
