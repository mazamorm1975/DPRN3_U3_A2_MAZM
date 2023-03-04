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
    public partial class AsignacionEmpleadosAProyecto : Form
    {
        public AsignacionEmpleadosAProyecto()
        {
            InitializeComponent();
                      
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosEmpleados frmEmpleado = new frmDatosEmpleados();
            frmEmpleado.ShowDialog();
        }

        private void altaNuevaAsignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignacionProyectos frmAltaProyectos = new frmAsignacionProyectos();
            frmAltaProyectos.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoProyecto proyecto_1 = new IngresoProyecto();
            proyecto_1.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignacionEmpleadosAProyecto_Load(object sender, EventArgs e)
        {

        }
    }
}
