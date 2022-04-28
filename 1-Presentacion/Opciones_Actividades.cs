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
    public partial class Opciones_Actividades : Form
    {
        int id_deporte;
        public Opciones_Actividades(int id)
        {
            InitializeComponent();
            id_deporte = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirForms(object FRM_secundario) {
            _p_forms.Visible = true;
            if (this._p_forms.Controls.Count > 0) { this._p_forms.Controls.RemoveAt(0); }

            Form secundario = FRM_secundario as Form;
            secundario.TopLevel = false;
            secundario.Dock = DockStyle.Fill;
            this._p_forms.Controls.Add(secundario);
            this._p_forms.Tag = secundario;

            secundario.Show();

            //SE CREA UN NUEVO EVENTO QUE DETECTA CUANDO SE CERRO EL FORMS SECUNDARIO//
            //secundario.FormClosing += new FormClosingEventHandler(Creacion_Actividad_Close);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //AbrirForms(new Creación_Actividades(id_deporte));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
