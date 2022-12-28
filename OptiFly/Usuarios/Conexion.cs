using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OptiFly
{
    internal class Conexion
    {
        //variable para conectar a la base de datos
        MySqlConnection cn = BdComun.ObtenerConexion();
        //variable para insertar datos a la bd
        MySqlCommand cmd;
        MySqlDataReader dr;
        //creamos una instancia para mostrar los datos
        MySqlDataAdapter da;
        DataTable dt;

        //se agrega un nuevo usuario a la base de datos
        public string insertar(string TipoUsuario, string nombre, string usuario, string password, string Fecha_que_se_agrego)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new MySqlCommand("Insert into usuarios (TipoUsuario, Nombre, Usuario, Password, Fecha_que_se_agrego) values('" + TipoUsuario + "','" + nombre + "','" + usuario + "','" + password + "','" + Fecha_que_se_agrego + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new MySqlCommand("Select * from usuarios where Num_Control =" + id + "", cn);
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
        public void cargarPersona(DataGridView dgv)
        {
            try
            {
                da = new MySqlDataAdapter("Select  Num_Control AS Num_Control, TipoUsuario AS TipoUsuario, Nombre As Nombre, Usuario AS Usuario, Password AS Password, Fecha_que_se_agrego AS Fecha_que_se_agrego from usuarios", cn);
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
        public void llenarTexBoxConsulta(int id, ComboBox TipoUsuario, TextBox txtNombre, TextBox txtUsuario, TextBox txtPassword, DateTimePicker dtpFecha)
        {
            try
            {
                cmd = new MySqlCommand("Select * from usuarios where Num_Control=" + id + "", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TipoUsuario.Text = dr["TipoUsuario"].ToString();
                    txtNombre.Text = dr["nombre"].ToString();
                    txtUsuario.Text = dr["usuario"].ToString();
                    txtPassword.Text = dr["password"].ToString();
                    dtpFecha.Text = dr["Fecha_que_se_agrego"].ToString();
                }
                dr.Close();
            }
            //Si se produce algun erro este lo cacha para despues mostrarlo
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
        }
        public string actualizar(int id, string TipoUsuario, string nombre, string usuario, string password, string Fecha_que_se_agrego)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new MySqlCommand("Update usuarios set TipoUsuario = '" + TipoUsuario + "',Nombre = '" + nombre + "', Usuario = '" + usuario + "', Password = '" + password + "', Fecha_que_se_agrego = '" + Fecha_que_se_agrego + "' where Num_Control = " + id + "", cn);
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
            string salida = "Se Elimino al usuario";
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("delete from usuarios where  Num_Control = {0}", id), cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Elimino al usuario" + ex.ToString();
            }
            return salida;
        }
    }
}
