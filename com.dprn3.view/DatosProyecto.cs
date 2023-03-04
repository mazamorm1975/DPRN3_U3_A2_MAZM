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
        
        clsAltaInformacion consultaProyecto = new clsAltaInformacion();
        int isAsignacion = 0;

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
            String idEmpleado = cboNumeroEmpleado.Text;
            String idProyecto = cboFolio.Text;
            String comentarios = txtComentarios.Text;

            //Validacion de los radiobuttons, si es que esta o no asignado el proyecto
            if (rdbAsignado.Checked.Equals(true))
            {
                isAsignacion = 1;
            }
            else
            {
                isAsignacion = 0;
            }           

            clsAltaInformacion.insertarDatosNuevaAsignacionAProyecto(idEmpleado, idProyecto, isAsignacion, comentarios);
            //MiCajaDeMensajes.ErrorParaGuardarDatos("Información Guardada Exitosamente", "Ingreso A Base De Datos");

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

    }
}
