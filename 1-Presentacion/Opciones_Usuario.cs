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
            try
            {
                InitializeComponent();
                _p_forms.Visible = false;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Usuario", "Ha ocurrido un error en 'Opciones Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForms(new Agregar_Usuario());
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnInsertar_Click", "Ha ocurrido un error en 'Opciones Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
             
        }
        private void AbrirForms(object FRM_secundario)
        {
            try
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
            catch
            {
                MessageBox.Show("Error en el Metodo AbrirForms", "Ha ocurrido un error en 'Opciones Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        //ESTE METODO SE EJECUTA CUANDO SE OPRIME EL BOTON VOLVER EN EL FORMS DE REGISTRAR USUARIO//
        private void Agregar_Usuario_Close(object sender, FormClosingEventArgs e)
        {
            try
            {
                _p_forms.Visible = false;
                pictureBox1.Visible = true;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Agregar_Usuario_Close", "Ha ocurrido un error en 'Opciones Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar_Usuarios()
        {
            try
            {
                Limpiar_Usuarios();

                List<CLS_Usuario> lista_usuarios = new List<CLS_Usuario>();
                CLS_L_Usuarios L_usuario = new CLS_L_Usuarios();
                L_usuario.ObtenerUsuarios(ref lista_usuarios);

                int i = 0;
                int x = _p_usuarios.Width;

                foreach (var usuario in lista_usuarios)
                {
                    UC_boton_entidad btn = new UC_boton_entidad(usuario.Id, usuario.Nombre, usuario.Apellido, usuario.Usuario, usuario.Password, usuario.Correo, usuario.Telefono, usuario.Sueldo, usuario.Rol, this, x, 1);
                    btn.Top = 52 * i;
                    _p_usuarios.Controls.Add(btn);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Usuarios", "Ha ocurrido un error en 'Opciones Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar_Usuarios()
        {
            try
            {
                if (_p_usuarios.Controls.Count > 0) { _p_usuarios.Controls.Clear(); }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Limpiar_Usuarios", "Ha ocurrido un error en 'Opciones Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Opciones_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Usuarios();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnVolver_Click", "Ha ocurrido un error en 'Opciones Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _p_usuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
