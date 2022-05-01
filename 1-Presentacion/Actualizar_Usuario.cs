using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_Logica;
using _3_Entidades;

namespace _1_Presentacion
{
    public partial class Actualizar_Usuario : Form
    {
        public Actualizar_Usuario()
        {
            InitializeComponent();
        }
        int r, rol; string no, ap, usu, pass, tel, corr;

        private void Actualizar_Usuario_Load(object sender, EventArgs e)
        {
            cbotipo2.Items.Add("Administrador");
            cbotipo2.Items.Add("Usuario");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.lblid.Text = r.ToString(); //cuando escribamos una palabra en txtnombre se mostrara los datos actuales
            this.txtnombre2.Text = no;
            this.txtApellido2.Text = ap;
            this.lblusu.Text = usu;
            this.txtpassword2.Text = pass;
            this.txtTelefono2.Text = corr;
            this.txtCorreo2.Text = tel;
            this.txtSueldo2.Text = suel.ToString();

            if (rol == 1)
            {
                cbotipo2.Text = "Administrador";
            }
            else
            {
                cbotipo2.Text = "Usuario";
            }
        }

        private void txtnombre2_TextChanged(object sender, EventArgs e)
        {
           
        }

        decimal suel;

        //metodo que recibe datos opara proyectarlos
        public void RecibeDatos(int i, string j, string k, string l, string m, string n, string o, decimal p, int q)
        {
            r = i;
            no = j;
            ap = k;
            usu = l;
            pass = m;
            tel = n;
            corr = o;
            suel = p;
            rol = q;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CLS_Usuario obj_usuario = new CLS_Usuario();

            CLS_L_Usuarios L_Usuario = new CLS_L_Usuarios();

            obj_usuario.Id = Convert.ToInt32(this.lblid.Text);
            obj_usuario.Nombre = this.txtnombre2.Text;
            obj_usuario.Apellido = this.txtApellido2.Text;
            obj_usuario.Usuario = obj_usuario.Nombre[0] + "" + obj_usuario.Nombre[1] + "" + obj_usuario.Apellido[0] + "" + obj_usuario.Apellido[1] + "" + obj_usuario.Apellido[2];
            obj_usuario.Password = this.txtpassword2.Text; /*en la parte de usuario, se toma 2 letras inicales y 3 inciales del apellido*/
            obj_usuario.Telefono = this.txtTelefono2.Text;
            obj_usuario.Correo = this.txtCorreo2.Text;
            obj_usuario.Sueldo = Convert.ToDecimal(this.txtSueldo2.Text);
            obj_usuario.Rol = indice2;

            bool resultado = L_Usuario.Editar_Usuario(ref obj_usuario);

            //MessageBox.Show(obj_usuario.Error);

            if (resultado == true)
            {
                MessageBox.Show("Datos Actualizados Correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Tu Usuario Actualizado es: " + obj_usuario.Usuario); //cuando se guarda, muestra esta ventana con el usurio generado
            }
            else
            {
                MessageBox.Show(obj_usuario.Error);
            }
        }

        int indice2;
        private void cbotipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice2 = cbotipo2.SelectedIndex;
            indice2 = indice2 + 1;
        }
    }
}
