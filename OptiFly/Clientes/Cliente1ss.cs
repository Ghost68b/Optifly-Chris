using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OptiFly
{
    internal class Cliente1ss
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

        //se agrega un nuevo usuario a la base de datos
        public string insertar(string telefono, string nombre, string fecha, string domicilio)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new MySqlCommand("Insert into cliente ( telefono, nombre, fecha , domicilio) values('" + telefono + "','" + nombre + "','" + fecha + "','" + domicilio + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public int personaRegistrada(int idcliente)
        {
            int contador = 0;
            try
            {
                cmd = new MySqlCommand("Select * from cliente where idcliente =" + idcliente + "", cn);
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
        //Aqui empieza el codigo de la tabla que da la informacion de la bd

        public DataTable BuscarBodegaSAMS(string fecha)
        {
            MySqlCommand cmd = new MySqlCommand(string.Format("select * from cliente where fecha like '%{0}%'", fecha), cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }
        public DataTable MostrarBodegaUS()
        {
            MySqlCommand cmd = new MySqlCommand("select * from cliente ", cn);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cn.Close();
            return ds.Tables["tabla"];
        }

        public void cargarPersona(DataGridView dgv)
        {
            try
            {
                da = new MySqlDataAdapter("Select * from cliente", cn);
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
        }//aqui termina la consula de los datos para mostrar la info

        //Aqui empieza para actualizar los datos de la base de datos
        public void llenarTexBoxConsulta(int idcliente, TextBox telefono, TextBox txtnombre, DateTimePicker fecha, TextBox domicilio)
        {
            try
            {
                cmd = new MySqlCommand("Select * from cliente where idcliente=" + idcliente + "", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    telefono.Text = dr["telefono"].ToString();
                    txtnombre.Text = dr["nombre"].ToString();
                    fecha.Text = dr["fecha"].ToString();
                    domicilio.Text = dr["domicilio"].ToString();

                }
                dr.Close();
            }
            //Si se produce algun erro este lo cacha para despues mostrarlo
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public string actualizar(int idcliente, string telefono, string nombre, string fecha, string domicilio)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new MySqlCommand("Update cliente set " + "telefono = '" + telefono + "'," + "nombre = '" + nombre + "'," + " fecha = '" + fecha + "'," + " domicilio = '" + domicilio + "' where idcliente = " + idcliente + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Actualizo: " + ex.ToString();
            }
            return salida;
        }
        public String eliminar(Int32 id)
        {
            string salida = "Se Elimino Cliente";
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("delete from cliente where  idcliente = {0}", id), cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Elimino al usuario" + ex.ToString();
            }
            return salida;
        }

        public void llenarTexBoxConsulta2(int idcliente, TextBox telefono, TextBox txtnombre, TextBox domicilio)
        {
            try
            {
                cmd = new MySqlCommand("Select * from cliente where idcliente=" + idcliente + "", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    telefono.Text = dr["telefono"].ToString();
                    txtnombre.Text = dr["nombre"].ToString();
                    domicilio.Text = dr["domicilio"].ToString();

                }
                dr.Close();
            }
            //Si se produce algun erro este lo cacha para despues mostrarlo
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
    }
}