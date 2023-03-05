using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class reglasDeNegocio
    {
        //Se valida si el empleado puede ser asignado a un proyecto
        public static void ValidacionAsignacionEmpleadoProyecto()
        {
          for (int i = 0; i < clsAltaInformacion.contarTotalRegistrosEmpleadosAsignados(); i++)
            {
                //Se valida el proyecto
                if (ValidaciónIngresoNuevoProyecto() == true)
                {
                    //Si el status del empleado es 0
                    if (clsAltaInformacion.isAssigned() != 1)
                    {
                        clsAltaInformacion.actualizaInformaciónProyecto();
                        //clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(idEmpleado, idProyecto, isAsignacion, comentarios);

                        MessageBox.Show("Empleado Asignado exitosamente al nuevo proyecto. Felicitaciones :) ");
                        break;
                    }

                    //Se valida si se sacara a este empleado del proyecto actual
                    if (clsAltaInformacion.isAssigned() == 1 && frmAsignacionProyectos.isAsignacion == 0)
                    {
                        clsAltaInformacion.actualizaInformaciónProyecto();
                        MessageBox.Show("Empleado ha dejado el proyecto. ");
                        break;
                    }

                    if (clsAltaInformacion.isAssigned() == 1)
                    {
                        MessageBox.Show("El empleado no puede estar Activo en más de 1 proyecto. ");
                        break;
                    }


                } else
                {
                    break;
                } 
                

            }
        }

        //Se valida si el proyecto esta disponible o no esta disponible
        public static Boolean ValidaciónIngresoNuevoProyecto()
        {
            string fechaFinalProyecto = clsAltaInformacion.fechaFinalExist();
            
            if(!fechaFinalProyecto.Equals(""))
            {
                MessageBox.Show("El proyecto ya ha sido concluido, puesto que hay fecha de terminación.");
                return false;
            }
         
            return true;
        }
    }
}
