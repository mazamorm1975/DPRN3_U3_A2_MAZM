using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class NotificacionExcedeNumeroEmpleados : Mensaje
    {
        MensajePersonalizado_6 excedePosicion = null;

        public void MensajePersonalizado()
        {
            excedePosicion = new MensajePersonalizado_6();
            excedePosicion.Show();
        }
    }
}
