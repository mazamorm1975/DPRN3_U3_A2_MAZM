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
        public static void ValidacionAsignacionEmpleadoProyecto()
        {
            int cont = 0;
            for (int i = 0; i < clsAltaInformacion.contarTotalRegistros(); i++)
            {
                //Si el status del empleado es 0
                if (clsAltaInformacion.isAssigned() != 1)
                {
                    clsAltaInformacion.actualizaInformaciónProyecto();
                    //clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(idEmpleado, idProyecto, isAsignacion, comentarios);
                    MessageBox.Show("Empleado Asignado exitosamente al nuevo proyecto. Felicitaciones :) ");
                    break;
                }

                if (clsAltaInformacion.isAssigned() == 1)
                {
                    MessageBox.Show("El empleado no puede estar Activo en más de 1 proyecto. ");
                    break;
                }
            }
        }
    }
}
