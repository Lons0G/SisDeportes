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
        public Menu_Administrador(int rol)
        {
            InitializeComponent();
            if (rol == 1) { _lbl_usuario.Text = "Administrador"; }
            else { _lbl_usuario.Text = "Encargado"; }
            _p_forms.Visible = false;
            ///MODIFICAR LOS CONTROLES QUE APARECEN///
            ///REALIZAR UN METODO PARA DETERMINAR QUE BOTONES MOSTRAR EN CASO 
            ///DE QUE SEA UN ENCARGADO O UN ADMINISTRADOR///
        }

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void _btn_usuarios_Click(object sender, EventArgs e) {
            AbrirForms(new Opciones_Usuario());
        }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
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
            //SE CREA UN NUEVO EVENTO QUE DETECTA CUANDO SE CERRO EL FORMS SECUNDARIO//
            secundario.FormClosing += new FormClosingEventHandler(Agregar_Usuario_Close);
        }
        //ESTE METODO SE EJECUTA CUANDO SE OPRIME EL BOTON VOLVER EN EL FORMS DE REGISTRAR USUARIO//
        private void Agregar_Usuario_Close(object sender, FormClosingEventArgs e)
        {
            _p_forms.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
