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
    public partial class IngresoProyecto : Form
    {
        public static string datoProyecto;
        public static DateTime fecha;
        public static string nombreProyecto;

        clsAltaInformacion nuevoIngreso = new clsAltaInformacion();

        public IngresoProyecto()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            datoProyecto = cboDepto.Text;

            if (cboDepto.SelectedItem.Equals(datoProyecto))
            {
                FillGridView();
            }
            else
            {
                MessageBox.Show("Ese perfil no es existente en la base de datos");
            }
        }

        private void FillGridView()
        {
            dgvProyecto.DataSource = nuevoIngreso.ConsultarDatosDepartamento();

            //dgvRolEmpleado.Columns[0].Visible = false;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            nombreProyecto = cboProyecto.Text;
            String descripcion = txtDescripcionProyecto.Text;
            DateTime fechaInicial = dtFechaInicio.Value;
            DateTime fechaFinal = dtFechaFinal.Value;
            int estatus = Convert.ToInt32(txtStatus.Text);
            int idDepto = Convert.ToInt32(cboDepto.Text);
            


            clsAltaInformacion.insertarDatosProyecto(nombreProyecto, descripcion, fechaInicial, fechaFinal, estatus, idDepto);
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
