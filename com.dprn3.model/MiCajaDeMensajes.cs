using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U2_A1_MAZM
{
    public static class MiCajaDeMensajes
    {

        //Metodo para guardar en base de datos
        public static System.Windows.Forms.DialogResult GuardadoEnBaseDeDatos(string mensaje, string visualizacion)
        {
            System.Windows.Forms.DialogResult mostrarDialogo = System.Windows.Forms.DialogResult.None;

            //Si se usa el frame MensajePersonalizado
            using (MensajePersonalizado myMensaje = new MensajePersonalizado())
            {
                myMensaje.Text = visualizacion;
                myMensaje.Text = mensaje;
                myMensaje.MensajeIcono = DPRNIII_U2_A1_MAZM.Properties.Resources.database_saved;
                mostrarDialogo = myMensaje.ShowDialog();

            }

            return mostrarDialogo;
        }

        //Mensaje Desplegado cuando no se puede guardar en la base de datos
        public static System.Windows.Forms.DialogResult ErrorParaGuardarDatos(string mensaje, string visualizacion)
        {
            System.Windows.Forms.DialogResult mostrarDialogo = System.Windows.Forms.DialogResult.None;

            //Si se usa el frame MensajePersonalizado
            using (MensajePersonalizado_2 myMensaje = new MensajePersonalizado_2())
            {
                myMensaje.Text = visualizacion;
                myMensaje.Text = mensaje;
                myMensaje.MensajeIcono = DPRNIII_U2_A1_MAZM.Properties.Resources.candado_color;
                mostrarDialogo = myMensaje.ShowDialog();
            }

            return mostrarDialogo;
        }
    }
}
