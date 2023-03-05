using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace DPRNIII_U2_A1_MAZM
{
    class conectarBase
    {
        public static MySqlConnection conectarBaseDatos()
        {
            MySqlConnection connection = null;
            MySqlDataAdapter buscar;
            try
            {
                string connectionString = "server=localhost; database=base_test; user id=root; password=Cu213lona1973; Allow Zero Datetime=true";
                //string cadenaConsulta = "SELECT * FROM tb_perfil";

                connection = new MySqlConnection(connectionString);
                
                    connection.Open();
                    //Console.WriteLine("State: {0}", connection.State);
                    //Console.WriteLine("connectionString: {0}", connection.ConnectionString);
                    //buscar = new MySqlDataAdapter(cadenaConsulta, connection);
                    
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return connection;
        }

        public static MySqlConnection desconectarBaseDeDatos()
        {
            MySqlConnection connection = null;
            MySqlDataAdapter buscar;
            try
            {
                string connectionString = "server=localhost; database=base_test; user id=root; password=Cu213lona1973;";
                //string cadenaConsulta = "SELECT * FROM tb_perfil";

                connection = new MySqlConnection(connectionString);

                connection.Close();
                //Console.WriteLine("State: {0}", connection.State);
                //Console.WriteLine("connectionString: {0}", connection.ConnectionString);
                //buscar = new MySqlDataAdapter(cadenaConsulta, connection);

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return connection;
        }

    }
}
