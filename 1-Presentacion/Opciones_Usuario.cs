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
    public partial class Opciones_Usuario : Form
    {
        public Opciones_Usuario()
        {
            InitializeComponent();
            _p_forms.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e) {
            AbrirForms(new Agregar_Usuario());    
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
             
        }
        private void AbrirForms(object FRM_secundario)
        {
            _p_forms.Visible = true;
            if (this._p_forms.Controls.Count > 0)
            {
                this._p_forms.Controls.RemoveAt(0);
            }
            Form secundario = FRM_secundario as Form;
            secundario.TopLevel = false;
            secundario.Dock = DockStyle.Fill;
            this._p_forms.Controls.Add(secundario);
            this._p_forms.Tag = secundario;
            secundario.Show();
        }
    }
}
