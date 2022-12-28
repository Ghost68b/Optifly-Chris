using MySql.Data.MySqlClient;


namespace OptiFly
{
    class BdComun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; Port=3306; database=optifly; uid=root; pwd=telmex22; SslMode = none");
            conectar.Open();
            return conectar;
            //SslMode = none;*/
            /*   MySqlConnection conectar = new MySqlConnection("server=69.49.241.61; Port=3306; database=setboxco_login; uid=setboxco_christian; pwd=telmex22; SslMode = none");
              conectar.Open();
              return conectar;
              //SslMode = none;*/
        }
    }
}
