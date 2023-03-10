using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class NotificacionFueraDeProyecto : Mensaje
    {
        MensajePersonalizado_5 fueraProyecto = null;

        public void MensajePersonalizado()
        {
            fueraProyecto = new MensajePersonalizado_5();
            fueraProyecto.Show();
        }
    }
}
