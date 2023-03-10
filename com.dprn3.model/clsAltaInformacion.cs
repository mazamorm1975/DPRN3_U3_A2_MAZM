using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;
using DPRNIII_U2_A1_MAZM.com.dprn3.model;

namespace DPRNIII_U2_A1_MAZM
{
    class clsAltaInformacion
    {
        protected internal DataTable Tabla;
        protected MySqlDataAdapter buscar;
        public static int result;
        public static int noRows;

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

        
        //Consultar cantidad de desarrolladores   
        public  int MatrixToFilterProgrammersOnly()
        {
            Tabla = new DataTable();

            //Ingresar informacion a base de datos

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT idEmpleado FROM empleado_proyecto INNER JOIN tb_empleado ON empleado_proyecto.idEmpleado = tb_empleado.ldap_empleado WHERE tb_empleado.tb_perfil_id_perfil > 4 AND tb_empleado.tb_perfil_id_perfil < 9 AND empleado_proyecto.idProyecto = '" + frmAsignacionProyectos.idProyecto + "';";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
                noRows = Tabla.Rows.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return noRows;
        }

        //Consultar cantidad de Lideres de proyecto   
        public int MatrixToFilterProjectLeadersOnly()
        {
            Tabla = new DataTable();

            //Ingresar informacion a base de datos

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT idEmpleado FROM empleado_proyecto INNER JOIN tb_empleado ON empleado_proyecto.idEmpleado = tb_empleado.ldap_empleado WHERE tb_empleado.tb_perfil_id_perfil > 8 AND tb_empleado.tb_perfil_id_perfil < 13 AND empleado_proyecto.idProyecto = '" + frmAsignacionProyectos.idProyecto + "';";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
                noRows = Tabla.Rows.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return noRows;
        }

        //Consultar cantidad de analistas en un proyecto   
        public int MatrixToFilterAnalystOnly()
        {
            Tabla = new DataTable();

            //Ingresar informacion a base de datos

            string perfil = frmDatosEmpleados.dato;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_test; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                String consulta = "SELECT idEmpleado FROM empleado_proyecto INNER JOIN tb_empleado ON empleado_proyecto.idEmpleado = tb_empleado.ldap_empleado WHERE tb_empleado.tb_perfil_id_perfil > 0 AND tb_empleado.tb_perfil_id_perfil < 5 AND empleado_proyecto.idProyecto = '" + frmAsignacionProyectos.idProyecto + "';";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);
                noRows = Tabla.Rows.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return noRows;
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

        public static void actualizaStatus(string noEmp)
        {
            //Se valida si se sacara a este empleado del proyecto actual
            if (clsAltaInformacion.isAssigned() == 1 && frmAsignacionProyectos.isAsignacion == 0)
            {
                clsAltaInformacion.actualizaInformaciónProyecto();
                               
            }
        }


        //Ubica si el empleado existe en la tabla:tb_empleado_proyecto
        public static Boolean ubicaEmpleado()
        {
            MySqlConnection conn = null;
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT idEmpleado FROM empleado_proyecto WHERE idEmpleado = '"+frmAsignacionProyectos.noEmpleado+"'", conn);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
               reg["idEmpleado"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }


        //Valida si el id_proyecto de la tabla: tb_proyecto tiene o no fecha_final
        public static string fechaFinalExist()
        {
            MySqlConnection conn = null;
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand cmd = new MySqlCommand("SELECT fecha_final FROM tb_proyecto WHERE nombre = '" + frmAsignacionProyectos.idProyecto + "'", conn);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                return reg["fecha_final"].ToString();
            }
            else
            {
                return null;
            }
        }

        //Verifica si el perfil del empleado es de programador y arroja true o false
        public static Boolean ValidaSiesRolDeProgramador()
        {
            MySqlConnection connection = null;
            connection = conectarBase.conectarBaseDatos();
            MySqlCommand command = new MySqlCommand("SELECT tb_perfil_id_perfil FROM tb_empleado WHERE tb_perfil_id_perfil > 4 AND tb_perfil_id_perfil < 9 AND ldap_empleado ='" + frmAsignacionProyectos.noEmpleado + "' ", connection);
            MySqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                /*En caso de requerir que se devuelva el perfil del empleado se tendra que poner
                (int)lector["tb_perfil_id_perfil"];*/
                return true; 
            }

            return false;
        }


        //Verifica si el perfil del empleado es de lider de proyecto y arroja true o false
        public static Boolean ValidaSiesRolDeLiderDeProyecto()
        {
            MySqlConnection connection = null;
            connection = conectarBase.conectarBaseDatos();
            MySqlCommand command = new MySqlCommand("SELECT tb_perfil_id_perfil FROM tb_empleado WHERE tb_perfil_id_perfil > 8 AND tb_perfil_id_perfil < 13 AND ldap_empleado ='" + frmAsignacionProyectos.noEmpleado + "' ", connection);
            MySqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                /*En caso de requerir que se devuelva el perfil del empleado se tendra que poner
                (int)lector["tb_perfil_id_perfil"];*/
                return true;
            }

            return false;
        }


        //Verifica si el perfil del empleado es Analista y arroja true o false
        public static Boolean ValidaSiesRolDeAnalista()
        {
            MySqlConnection connection = null;
            connection = conectarBase.conectarBaseDatos();
            MySqlCommand command = new MySqlCommand("SELECT tb_perfil_id_perfil FROM tb_empleado WHERE tb_perfil_id_perfil > 0 AND tb_perfil_id_perfil < 5 AND ldap_empleado ='" + frmAsignacionProyectos.noEmpleado + "' ", connection);
            MySqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                /*En caso de requerir que se devuelva el perfil del empleado se tendra que poner
                (int)lector["tb_perfil_id_perfil"];*/
                return true;
            }

            return false;
        }


        //Verifica si el numero de empleado esta tomando parte activa en el proyecto
        public static string isIncludedIntoProject()
        {
            MySqlConnection conn = null;
            conn = conectarBase.conectarBaseDatos();
            MySqlCommand comando = new MySqlCommand("SELECT idEmpleado FROM empleado_proyecto WHERE idProyecto='" + frmAsignacionProyectos.idProyecto + "'", conn);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                return reader["idEmpleado"].ToString();
            }

            return " ";
        }


        //Actualiza status del proyecto
        public static void actualizaInformaciónProyecto()
        {
            MySqlConnection connUpdate = null;
            connUpdate = conectarBase.conectarBaseDatos();
            MySqlCommand dataAdapter = new MySqlCommand();
            dataAdapter = new MySqlCommand("UPDATE empleado_proyecto SET asignado = '" + frmAsignacionProyectos.asignacionEmpleado + "', Comentarios = '" + frmAsignacionProyectos.comentarios + "', idProyecto = '" + frmAsignacionProyectos.idProyecto + "' WHERE idEmpleado = '" + frmAsignacionProyectos.noEmpleado + "'", connUpdate);
            dataAdapter.ExecuteNonQuery();
            Notificacion mensajeOffProject = new Notificacion(new NotificacionGuardar());
            mensajeOffProject.MostrarMensaje();
        }

        //Actualiza status del proyecto
        public static void remueveEmpleadoDeProyecto(String noEmpleado)
        {
            MySqlConnection connUpdate = null;
            connUpdate = conectarBase.conectarBaseDatos();
            MySqlCommand dataAdapter = new MySqlCommand();
            dataAdapter = new MySqlCommand("DELETE FROM empleado_proyecto WHERE idEmpleado = '" + frmAsignacionProyectos.noEmpleado + "'" , connUpdate);
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
            //Se crea objeto de tipo DataTable
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
