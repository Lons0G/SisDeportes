using _2_Logica;
using _3_Entidades;
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
            Cargar_Usuarios();
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
            if (this._p_forms.Controls.Count > 0) { this._p_forms.Controls.RemoveAt(0); }
            
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
        private void Agregar_Usuario_Close(object sender, FormClosingEventArgs e) {
            _p_forms.Visible = false;
            pictureBox1.Visible = true;
        }
        private void Cargar_Usuarios() {
            List<CLS_Usuario> lista_usuarios = new List<CLS_Usuario>();
            CLS_L_Usuarios L_usuario = new CLS_L_Usuarios();
            L_usuario.ObtenerUsuarios(ref lista_usuarios);
            
            int i = 0;
            foreach (var usuario in lista_usuarios) {
                UC_boton_entidad btn = new UC_boton_entidad(usuario.Id, usuario.Nombre, usuario.Apellido);
                btn.Top = 52 * i;
                _p_usuarios.Controls.Add(btn);
                i++;
            }

        }
    }
}
