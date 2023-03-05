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

        //Cuenta total de registros de la tabla empleado_proyecto
        public static int contarTotalRegistrosEmpleadosAsignados()
        {
            MySqlConnection contar = null;
            contar = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT count(*) FROM empleado_proyecto", contar);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        
        //Valida si se puede realizar la asignacion acorde a las reglas del negocio
        public static int isAssigned()
        {
            MySqlConnection conn = null;
            //Valida conexion con base de datos: base_test
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT asignado FROM empleado_proyecto WHERE idEmpleado = '" + frmAsignacionProyectos.noEmpleado + "'", conn);
            int result = (int)cmd.ExecuteScalar();
            return result;
        }


        //Valida si el id_proyecto de la tabla: tb_proyecto tiene o no fecha_final
        public static string fechaFinalExist()
        {
            MySqlConnection conn = null;
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT fecha_final FROM tb_proyecto WHERE nombre = '"+frmAsignacionProyectos.idProyecto+"'", conn);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                return reg["fecha_final"].ToString();
            } else
            {
                return null;
            }           
        }

    //Actualiza status del proyecto
    public static void actualizaInformaciónProyecto()
    {
        MySqlConnection connUpdate = null;
        connUpdate = conectarBase.conectarBaseDatos();
        MySqlCommand dataAdapter = new MySqlCommand();
        dataAdapter = new MySqlCommand("UPDATE empleado_proyecto SET asignado = '" + frmAsignacionProyectos.asignacionEmpleado + "', comentarios = '" + frmAsignacionProyectos.comentarios + "', idProyecto = '" + frmAsignacionProyectos.idProyecto + "' WHERE idEmpleado = '" + frmAsignacionProyectos.noEmpleado + "'", connUpdate);
        dataAdapter.ExecuteNonQuery();
    }


    //Consultar Departamentos   
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
            string consulta = "SELECT * FROM empleado_proyecto;";
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
    public static Boolean insertarDatosProyecto(String nombre, String descripcion, DateTime fechaI, DateTime fechaF, int status, int idDepto)
    {
        MySqlCommand comando = new MySqlCommand();
        try
        {
            String cadena = "INSERT INTO tb_proyecto SET nombre='" + nombre + "' , descripcion='" + descripcion + "', fecha_inicio='" + fechaI.ToString("yyyy-MM-dd HH:mm:ss") + "' , fecha_final='" + fechaF.ToString("yyyy-MM-dd HH:mm:ss") + "', estatus='" + status + "', id_departamento='" + idDepto + "'";
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
            String cadena = "INSERT INTO empleado_proyecto SET idEmpleado='" + idEmpleado + "' , idProyecto='" + idProyecto + "', asignado='" + asignado + "' , comentarios='" + comentarios + "'";
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
