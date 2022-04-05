using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Presentacion
{
    public partial class FRM_Integrantes : Form
    {
        public FRM_Integrantes()
        {
            InitializeComponent();
        }

        private void CbEntrenador_CheckedChanged(object sender, EventArgs e)
        {
            if (CbEntrenador.Checked== true)
            {
               CbJugador.Checked = false;
                txtPosicion.Enabled = false;
                txtDorsal.Enabled = false;
            }
            
        }

        private void CbJugador_CheckedChanged(object sender, EventArgs e)
        {
            if (CbJugador.Checked==true)
            {
               CbEntrenador.Checked = false;
                txtDorsal.Enabled = true;
                txtPosicion.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
