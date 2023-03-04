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
    public partial class MensajePersonalizado_2 : Form
    {
        public MensajePersonalizado_2()
        {
            InitializeComponent();
        }

        public Image MensajeIcono
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public String Mensaje
        {
            get { return lblMessage.Text;}
            set { lblMessage.Text = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MensajePersonalizado_2_Load(object sender, EventArgs e)
        {

        }
    }
}
