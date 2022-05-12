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
            try
            {

            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnVolver_Click", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            this.Dispose();
        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                cbotipo.Items.Add("Administrador");
                cbotipo.Items.Add("Usuario");
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Agregar_Usuario_Load", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int indice;
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //NOTA PARA ANGEL (de Angel) 
                //REALIZAR LA OBTENCION DE LOS ROLES EN SQL Y MOSTRARLO EN EL CBO
                //
                indice = cbotipo.SelectedIndex;
                indice = indice + 1;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnVolver_Click", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_Usuario obj_usuario = new CLS_Usuario();

                CLS_L_Usuarios L_Usuario = new CLS_L_Usuarios();

                obj_usuario.Nombre = this.txtnombre.Text;
                obj_usuario.Apellido = this.txtApellido.Text;
                obj_usuario.Usuario = obj_usuario.Nombre[0] + "" + obj_usuario.Nombre[1] + "" + obj_usuario.Apellido[0] + "" + obj_usuario.Apellido[1] + "" + obj_usuario.Apellido[2];
                obj_usuario.Password = this.txtpassword.Text; /*en la parte de usuario, se toma 2 letras inicales y 3 inciales del apellido*/
                obj_usuario.Telefono = this.txtTelefono.Text;
                obj_usuario.Correo = this.txtCorreo.Text;
                obj_usuario.Sueldo = Convert.ToDecimal(this.txtSueldo.Text);
                obj_usuario.Rol = indice;

                bool resultado = L_Usuario.Insertar_Usuario(ref obj_usuario);

                //MessageBox.Show(obj_usuario.Error);

                if (resultado == true)
                {
                    MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Tu Usuario es: " + obj_usuario.Usuario); //cuando se guarda, muestra esta ventana con el usurio generado
                }
                else
                {
                    MessageBox.Show(obj_usuario.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnregistrar_Click", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                //imagen ocultar la mandamos hacia enfrente
                pbocultar.BringToFront();
                //oculatamos la contraseña
                txtpassword.PasswordChar = '\0';
            }
            catch
            {
                MessageBox.Show("Error en el Metodo pbmostrar_Click", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbocultar_Click(object sender, EventArgs e)
        {
            try
            {
                //imagen mostrar la madamos hacia enfrente
                pbmostrar.BringToFront();
                //mostramos la contraseña
                txtpassword.PasswordChar = '*';
            }
            catch
            {
                MessageBox.Show("Error en el Metodo pbocultar_Click", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones.SoloLetras(e);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo txtnombre_KeyPress", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones.SoloLetras(e);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo txtApellido_KeyPress", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones.SoloEnteros(e);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo txtTelefono_KeyPress", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones.SoloConDecimal(e);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo txtSueldo_KeyPress", "Ha ocurrido un error en 'Agregar Usuario'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
