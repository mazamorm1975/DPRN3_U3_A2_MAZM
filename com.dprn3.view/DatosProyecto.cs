using DPRNIII_U2_A1_MAZM.com.dprn3.interfaces;
using DPRNIII_U2_A1_MAZM.com.dprn3.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM
{
    public partial class frmAsignacionProyectos : Form
    {

        public static string noEmpleado = "";
        public static int asignacionEmpleado;
        public static string comentarios;
        public static string idProyecto = "";

        clsAltaInformacion consultaProyecto = new clsAltaInformacion();
        public static int isAsignacion = 0;

        public frmAsignacionProyectos()
        {
            InitializeComponent();
        }

        private void frmAsignacionProyectos_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarAsignacion_Click(object sender, EventArgs e)
        {
            //Variables que reciben la información de los componentes
            noEmpleado = cboNumeroEmpleado.Text;
            idProyecto = cboFolio.Text;
            comentarios = txtComentarios.Text;

            //Validacion de los radiobuttons, si es que esta o no asignado el proyecto
            if (rdbAsignado.Checked.Equals(true))
            {
                isAsignacion = 1;
                asignacionEmpleado = isAsignacion;
            }
            else
            {
                isAsignacion = 0;
                asignacionEmpleado = isAsignacion;
            }

            //Se inicia validación de reglas de negocio
            reglasDeNegocio.ValidacionAsignacionEmpleadoProyecto();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FillGridView();
        }

        public void FillGridView()
        {
            dgvConsultaProyectos.DataSource = consultaProyecto.ConsultarProyecto_Empleado();
        }

        private void contenedorAsignacionProyecto_Enter(object sender, EventArgs e)
        {

        }

        private void icbRemover_Click(object sender, EventArgs e)
        {
            noEmpleado = cboNumeroEmpleado.Text;
            clsAltaInformacion.remueveEmpleadoDeProyecto(noEmpleado);
            Notificacion remueveEmpleadoProyecto = new Notificacion(new NotificacionFueraDeProyecto());
            remueveEmpleadoProyecto.MostrarMensaje();

        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            idProyecto = cboFolio.Text;
            noEmpleado = cboNumeroEmpleado.Text;
            comentarios = txtComentarios.Text;
            clsAltaInformacion.actualizaStatus(noEmpleado);
            
        }
    }
}
