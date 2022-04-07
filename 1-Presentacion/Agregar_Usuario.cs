using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_Entidades;
using _2_Logica;

namespace _1_Presentacion
{
    public partial class Agregar_Usuario : Form
    {
        public Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Administrador volver = new Menu_Administrador();

            volver.Show();
        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
            cbotipo.Items.Add("Administrador");
            cbotipo.Items.Add("Usuario");
        }

        int indice;
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = cbotipo.SelectedIndex;
            indice = indice + 1;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            CLS_Usuario obj_usuario = new CLS_Usuario();

            CLS_L_Usuarios L_Usuario = new CLS_L_Usuarios();

            obj_usuario.Nombre = this.txtnombre.Text;
            obj_usuario.Apellido = this.txtApellido.Text;
            obj_usuario.Usuario = this.txtusuario.Text;
            obj_usuario.Password = this.txtpassword.Text;
            obj_usuario.Telefono = this.txtTelefono.Text;
            obj_usuario.Correo = this.txtCorreo.Text;
            obj_usuario.Sueldo = Convert.ToDecimal(this.txtSueldo.Text);
            obj_usuario.Rol = indice;

            bool resultado = L_Usuario.Insertar_Usuario(ref obj_usuario);

            MessageBox.Show(obj_usuario.Error);

            if (resultado == true)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
