using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OptiFly
{
    internal class pedidocs
    {
        //variable para conectar a la base de datos
        MySqlConnection cn = BdComun.ObtenerConexion();
        //variable para insertar datos a la bd
        MySqlCommand cmd;
        MySqlDataReader dr;
        //creamos una instancia para mostrar los datos
        MySqlDataAdapter da;
        DataTable dt;
        private DataSet ds;

        public string insertar(string idCliente, string telefono, string nombre, string fecha, string domicilio,
            string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10,
            string b1, string b2, string b3, string b4, string b5, string b6, string b7, string b8, string opservaciones,
            string precio, string anticipo, string d1, string d2, string d3, string d4, string d5, string d6, string d7,
            string d8, string d9, string d10, string d11, string d12, string d13, string d14, string d15, string d16, string d17, string d18,
            string d19, string d20, string d21, string d22, string d23, string d24, string d25, string d26, string d27, string d28,
            string d29, string d30, string d31, string d32)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new MySqlCommand("Insert into ventas (idCliente, telefono, nombre, fecha, domicilio, " +
                    "a1, a2, a3, a4, a5, a6, a7, a8, a9, a10," +
                    " b1, b2, b3, b4, b5, b6, b7, b8, opservaciones, precio, anticipo, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22, d23, d24, d25, d26, d27, d28, d29, d30, d31, d32) " +
                    "values(" +
                    "'" + idCliente + "'," +
                    "'" + telefono + "'," +
                    "'" + nombre + "'," +
                    "'" + fecha + "'," +
                    "'" + domicilio + "'," +
                    "'" + a1 + "'," +
                    "'" + a2 + "'," +
                    "'" + a3 + "'," +
                    "'" + a4 + "'," +
                    "'" + a5 + "'," +
                    "'" + a6 + "'," +
                    "'" + a7 + "'," +
                    "'" + a8 + "'," +
                    "'" + a9 + "'," +
                    "'" + a10 + "'," +
                    "'" + b1 + "'," +
                    "'" + b2 + "'," +
                    "'" + b3 + "'," +
                    "'" + b4 + "'," +
                    "'" + b5 + "'," +
                    "'" + b6 + "'," +
                    "'" + b7 + "'," +
                    "'" + b8 + "'," +
                    "'" + opservaciones + "'," +
                    "'" + precio + "'," +
                    "'" + anticipo + "'," +
                    "'" + d1 + "'," +
                    "'" + d2 + "'," +
                    "'" + d3 + "'," +
                    "'" + d4 + "'," +
                    "'" + d5 + "'," +
                    "'" + d6 + "'," +
                    "'" + d7 + "'," +
                    "'" + d8 + "'," +
                    "'" + d9 + "'," +
                    "'" + d10 + "'," +
                    "'" + d11 + "'," +
                    "'" + d12 + "'," +
                    "'" + d13 + "'," +
                    "'" + d14 + "'," +
                    "'" + d15 + "'," +
                    "'" + d16 + "'," +
                    "'" + d17 + "'," +
                    "'" + d18 + "'," +
                    "'" + d19 + "'," +
                    "'" + d20 + "'," +
                    "'" + d21 + "'," +
                    "'" + d22 + "'," +
                    "'" + d23 + "'," +
                    "'" + d24 + "'," +
                    "'" + d25 + "'," +
                    "'" + d26 + "'," +
                    "'" + d27 + "'," +
                    "'" + d28 + "'," +
                    "'" + d29 + "'," +
                    "'" + d30 + "'," +
                    "'" + d31 + "'," +
                    "'" + d32 + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public int personaRegistrada(int idventas)
        {
            int contador = 0;
            try
            {
                cmd = new MySqlCommand("Select * from ventas where idventas =" + idventas + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public String eliminar(Int32 id)
        {
            string salida = "Se Elimino Cliente";
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("delete from ventas where idventas = {0}", id), cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Elimino al usuario" + ex.ToString();
            }
            return salida;
        }
        public void llenarTexBoxConsulta(int idventas, TextBox idCliente, TextBox telefono, TextBox nombre, DateTimePicker fecha, TextBox domicilio,
            TextBox a1, TextBox a2, TextBox a3, TextBox a4, TextBox a5, TextBox a6, TextBox a7, TextBox a8, TextBox a9, TextBox a10,
            TextBox b1, TextBox b2, TextBox b3, TextBox b4, TextBox b5, TextBox b6, TextBox b7, TextBox b8, TextBox opservaciones, TextBox precio,
            TextBox anticipo, TextBox d1, TextBox d2, TextBox d3, TextBox d4, TextBox d5, TextBox d6, TextBox d7, TextBox d8, TextBox d9, TextBox d10, TextBox d11, TextBox d12
            , TextBox d13, TextBox d14, TextBox d15, TextBox d16, TextBox d17, TextBox d18, TextBox d19, TextBox d20, TextBox d21, TextBox d22, TextBox d23, TextBox d24
            , TextBox d25, TextBox d26, TextBox d27, TextBox d28, TextBox d29, TextBox d30, TextBox d31, TextBox d32)
        {
            try
            {
                cmd = new MySqlCommand("Select * from ventas where idventas=" + idventas + "", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    idCliente.Text = dr["idCliente"].ToString();
                    telefono.Text = dr["telefono"].ToString();
                    nombre.Text = dr["nombre"].ToString();
                    fecha.Text = dr["fecha"].ToString();
                    domicilio.Text = dr["domicilio"].ToString();
                    a1.Text = dr["a1"].ToString();
                    a2.Text = dr["a2"].ToString();
                    a3.Text = dr["a3"].ToString();
                    a4.Text = dr["a4"].ToString();
                    a5.Text = dr["a5"].ToString();
                    a6.Text = dr["a6"].ToString();
                    a7.Text = dr["a7"].ToString();
                    a8.Text = dr["a8"].ToString();
                    a9.Text = dr["a9"].ToString();
                    a10.Text = dr["a10"].ToString();
                    b1.Text = dr["b1"].ToString();
                    b2.Text = dr["b2"].ToString();
                    b3.Text = dr["b3"].ToString();
                    b4.Text = dr["b4"].ToString();
                    b5.Text = dr["b5"].ToString();
                    b6.Text = dr["b6"].ToString();
                    b7.Text = dr["b7"].ToString();
                    b8.Text = dr["b8"].ToString();
                    opservaciones.Text = dr["opservaciones"].ToString();
                    precio.Text = dr["precio"].ToString();
                    anticipo.Text = dr["anticipo"].ToString();
                    d1.Text = dr["d1"].ToString();
                    d2.Text = dr["d2"].ToString();
                    d3.Text = dr["d3"].ToString();
                    d4.Text = dr["d4"].ToString();
                    d5.Text = dr["d5"].ToString();
                    d6.Text = dr["d6"].ToString();
                    d7.Text = dr["d7"].ToString();
                    d8.Text = dr["d8"].ToString();
                    d9.Text = dr["d9"].ToString();
                    d10.Text = dr["d10"].ToString();
                    d11.Text = dr["d11"].ToString();
                    d12.Text = dr["d12"].ToString();
                    d13.Text = dr["d13"].ToString();
                    d14.Text = dr["d14"].ToString();
                    d15.Text = dr["d15"].ToString();
                    d16.Text = dr["d16"].ToString();
                    d17.Text = dr["d17"].ToString();
                    d18.Text = dr["d18"].ToString();
                    d19.Text = dr["d19"].ToString();
                    d20.Text = dr["d20"].ToString();
                    d21.Text = dr["d21"].ToString();
                    d22.Text = dr["d22"].ToString();
                    d23.Text = dr["d23"].ToString();
                    d24.Text = dr["d24"].ToString();
                    d25.Text = dr["d25"].ToString();
                    d26.Text = dr["d26"].ToString();
                    d27.Text = dr["d27"].ToString();
                    d28.Text = dr["d28"].ToString();
                    d29.Text = dr["d29"].ToString();
                    d30.Text = dr["d30"].ToString();
                    d31.Text = dr["d31"].ToString();
                    d32.Text = dr["d32"].ToString();

                }
                dr.Close();
            }
            //Si se produce algun erro este lo cacha para despues mostrarlo
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public string actualizar(int idventas, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10,
            string b1, string b2, string b3, string b4, string b5, string b6, string b7, string b8, string opservaciones, string precio, string anticipo, string d1,
            string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10, string d11, string d12, string d13, 
            string d14, string d15, string d16, string d17, string d18, string d19, string d20, string d21, string d22, string d23, string d24, string d25,
            string d26, string d27, string d28, string d29, string d30, string d31, string d32)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new MySqlCommand("Update ventas set " + "" +
                    "a1 = '" + a1 + "'," +
                    "" + " a2 = '" + a2 + "'," +
                    "" + " a3 = '" + a3 + "'," +
                    "" + " a4 = '" + a4 + "'," +
                    "" + " a5 = '" + a5 + "'," +
                    "" + " a6 = '" + a6 + "'," +
                    "" + " a7 = '" + a7 + "'," +
                    "" + " a8 = '" + a8 + "'," +
                    "" + " a9 = '" + a9 + "'," +
                    "" + " a10 = '" + a10 + "'," +
                    "" + " b1 = '" + b1 + "'," +
                    "" + " b2 = '" + b2 + "'," +
                    "" + " b3 = '" + b3 + "'," +
                    "" + " b4 = '" + b4 + "'," +
                    "" + " b5 = '" + b5 + "'," +
                    "" + " b6 = '" + b6 + "'," +
                    "" + " b7 = '" + b7 + "'," +
                    "" + " b8 = '" + b8 + "'," +
                    "" + "opservaciones = '" + opservaciones + "'," +
                    "" + "precio = '" + precio + "'," +
                    "" + "anticipo = '" + anticipo + "'," +
                    "" + " d1 = '" + d1 + "'," +
                    "" + " d2 = '" + d2 + "'," +
                    "" + " d3 = '" +d3 + "'," +
                    "" + " d4 = '" + d4 + "'," +
                    "" + " d5 = '" + d5 + "'," +
                    "" + " d6 = '" + d6 + "'," +
                    "" + " d7 = '" + d7 + "'," +
                    "" + " d8 = '" + d8 + "'," +
                    "" + " d9 = '" + d9 + "'," +
                    "" + " d10 = '" + d10 + "'," +
                    "" + " d11 = '" + d11 + "'," +
                    "" + " d12 = '" + d12 + "'," +
                    "" + " d13 = '" + d13 + "'," +
                    "" + " d14 = '" + d14 + "'," +
                    "" + " d15 = '" + d15 + "'," +
                    "" + " d16 = '" + d16 + "'," +
                    "" + " d17 = '" + d17 + "'," +
                    "" + " d18 = '" + d18 + "'," +
                    "" + " d19 = '" + d19 + "'," +
                    "" + " d20 = '" + d20 + "'," +
                    "" + " d21 = '" + d21 + "'," +
                    "" + " d22 = '" + d22 + "'," +
                    "" + " d23 = '" + d23 + "'," +
                    "" + " d24 = '" + d24 + "'," +
                    "" + " d25 = '" + d25 + "'," +
                    "" + " d26 = '" + d26 + "'," +
                    "" + " d27 = '" + d27 + "'," +
                    "" + " d28 = '" + d28 + "'," +
                    "" + " d29 = '" + d29 + "'," +
                    "" + " d30 = '" + d30 + "'," +
                    "" + " d31 = '" + d31 + "'," +
                    "" + " d32 = '" + d32 + "'" +
                    " where idventas = " + idventas + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Actualizo: " + ex.ToString();
            }
            return salida;
        }
        public void cargarPersona(DataGridView dgv)
        {
            try
            {
                da = new MySqlDataAdapter("Select  idCliente, idventas, telefono, nombre, fecha, opservaciones, precio, anticipo  from ventas", cn);
                //antes de llenar el datatable se tiene que crear
                dt = new DataTable();
                // todo lo que se capture se mandara a dt = datatable
                da.Fill(dt);
                //y el dt llena a dgv con la consulta correspondiente
                dgv.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex, ToString());
            }
        }
        public DataTable MostrarVenta()
        {
            MySqlCommand cmd = new MySqlCommand("Select  idCliente, idventas, telefono, nombre, fecha, opservaciones, precio, anticipo  from ventas ", cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }
        public DataTable BuscarVenta(string nombre)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select idCliente, idventas, telefono, nombre, fecha, opservaciones, precio, anticipo from ventas where idCliente like '%{0}%'", nombre), cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }

        public DataTable BuscarVentaTel(string nombre)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select idCliente, idventas, telefono, nombre, fecha, opservaciones, precio, anticipo from ventas where telefono like '%{0}%'", nombre), cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }
        public DataTable BuscarVentaNom(string nombre)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select idCliente, idventas, telefono, nombre, fecha, opservaciones, precio, anticipo from ventas where nombre like '%{0}%'", nombre), cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }
        /// <summary>
        /// Buscar Clientes Registrados
        /// </summary>
        /// <returns></returns>

        public DataTable MostrarClien()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from cliente ", cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }
        public DataTable BuscarClien(string nombre2)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from cliente where idCliente like '%{0}%'", nombre2), cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }
        public DataTable BuscarClienTel(string nombre)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from cliente where telefono like '%{0}%'", nombre), cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }
        public DataTable BuscarClieNom(string nombre)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from cliente where nombre like '%{0}%'", nombre), cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }
    }
}
