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
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador(/*string nombre*/)
        {
            InitializeComponent();
            //lblmensajeadmi.Text = nombre;
            _p_forms.Visible = false;
        }

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOpcionesUsuario_Click(object sender, EventArgs e)
        {
            AbrirForms(new Opciones_Usuario());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login mostrar = new Login();

            mostrar.Show();
        }

        private void AbrirForms(object FRM_secundario) {
            pictureBox1.Visible = false;
            _p_forms.Visible = true;
            if (this._p_forms.Controls.Count > 0) {
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
