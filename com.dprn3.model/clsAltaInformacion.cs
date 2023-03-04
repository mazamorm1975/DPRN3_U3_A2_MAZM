using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace DPRNIII_U2_A1_MAZM
{
    class clsAltaInformacion
    {
        protected internal DataTable Tabla;
        protected MySqlDataAdapter buscar;
        public string perfil;

        //Consultar Vehiculos   
        public DataTable ConsultarDatosEmpleado()
        {

            Tabla = new DataTable();

            //Ingresar informacion a base de datos

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT tipo, rol FROM tb_perfil WHERE id_perfil =" + Convert.ToInt32(perfil) + ";";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Tabla;
        }

        //Consultar Vehiculos   
        public DataTable ConsultarDatosDepartamento()
        {

            Tabla = new DataTable();


            //Ingresar informacion a base de datos

            string depto = IngresoProyecto.datoProyecto;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password =Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT nombre_depto, sede FROM tb_departamento WHERE id_departamento =" + Convert.ToInt32(depto) + ";";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Tabla;
        }

        //Consulta proyectos asignados a los empleados   
        public DataTable ConsultarProyecto_Empleado()
        {

            Tabla = new DataTable();


            //Ingresar informacion a base de datos

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password =Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT * FROM empleado_proyecto;";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return Tabla;
        }


        //Metodo que ingresa la información a una base de datos
        public static Boolean insertarDatosEmpleado(String idEmpleado, String nombreEmpleado, String apellidoPaterno, String apellidoMaterno, Char status, int perfil)
        {
            MySqlCommand comando = new MySqlCommand();
            try
            {
                String cadena = "INSERT INTO tb_empleado SET ldap_empleado='" + idEmpleado + "' ,nombre='" + nombreEmpleado + "' , apellido_paterno='" + apellidoPaterno + "', apellido_materno='" + apellidoMaterno + "', estatus='" + status + "', tb_perfil_id_perfil='" + perfil + "'";
                comando = new MySqlCommand(cadena, conectarBase.conectarBaseDatos());
                comando.ExecuteNonQuery();
                MessageBox.Show("Información Ingresada exitosamente");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
            return true;
        }

        //Metodo que ingresa la información a una base de datos
        public static Boolean insertarDatosProyecto(String nombre, String descripcion, DateTime fechaI, DateTime fechaF, int status,  int idDepto)
        {
            MySqlCommand comando = new MySqlCommand();
            try
            {
                String cadena = "INSERT INTO tb_proyecto SET nombre='" + nombre + "' , descripcion='"+descripcion+"', fecha_inicio='" + fechaI.ToString("yyyy-MM-dd HH:mm:ss") + "' , fecha_final='"+fechaF.ToString("yyyy-MM-dd HH:mm:ss") +"', estatus='" +status+ "', id_departamento='"+idDepto+"'";
                comando = new MySqlCommand(cadena, conectarBase.conectarBaseDatos());
                comando.ExecuteNonQuery();
                MessageBox.Show("Información Ingresada exitosamente");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        //Metodo que ingresa la información sobre una nueva asignacion a proyecto de un empleado a una base de datos
        public static Boolean insertarDatosNuevaAsignacionAProyecto(String idEmpleado, String idProyecto, int asignado, String comentarios)
        {
            MySqlCommand comando = new MySqlCommand();
            try
            {
                String cadena = "INSERT INTO empleado_proyecto SET idEmpleado='" + idEmpleado + "' , idProyecto='" + idProyecto + "', asignado='" + asignado+ "' , comentarios='" +comentarios+ "'";
                comando = new MySqlCommand(cadena, conectarBase.conectarBaseDatos());
                comando.ExecuteNonQuery();
                
                MiCajaDeMensajes.GuardadoEnBaseDeDatos("Información Guardada Exitosamente", "Ingreso A Base De Datos");
                //MessageBox.Show("El empleado "+idEmpleado+" ha sido exitosamente asignado al proyecto"+idProyecto+"'");
               return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }


        //Inserta datos en departamento
        //Metodo que ingresa la información a una base de datos
        public static Boolean insertarDatosProyecto(String idEmpleado, String nombreEmpleado, String apellidoPaterno, String apellidoMaterno, Char status, int perfil)
        {
            MySqlCommand comando = new MySqlCommand();
            try
            {
                String cadena = "INSERT INTO tb_empleado SET ldap_empleado='" + idEmpleado + "' ,nombre='" + nombreEmpleado + "' , apellido_paterno='" + apellidoPaterno + "', apellido_materno='" + apellidoMaterno + "', estatus='" + status + "', tb_perfil_id_perfil='" + perfil + "'";
                comando = new MySqlCommand(cadena, conectarBase.conectarBaseDatos());
                comando.ExecuteNonQuery();
                MessageBox.Show("Información Ingresada exitosamente");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

    }
}
