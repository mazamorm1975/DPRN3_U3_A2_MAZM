using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U2_A1_MAZM.com.dprn3.model
{
    class NotificacionFalloAnalistas : Mensaje
    {
        MensajePersonalizado_4 limiteAnalistas = null;

        public void MensajePersonalizado()
        {
            limiteAnalistas = new MensajePersonalizado_4();
            limiteAnalistas.Show();
        }
    }
}
