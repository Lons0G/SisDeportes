using System;
using System.Windows.Forms;
using _3_Entidades;
using _2_Logica;
using System.Threading;

namespace _1_Presentacion
{
    public partial class Login : Form
    {
        Thread th;
        CLS_Usuario obj_usuario = new CLS_Usuario();
        public Login()
        {
            InitializeComponent();
        }

        public void logear(string usuario, string contrasena) //este metodo sirve para comprobar si mi usuario existe en el servidor
        {
            try
            {
                CLS_L_Usuarios L_usuario = new CLS_L_Usuarios();

                obj_usuario.Usuario = usuario;
                obj_usuario.Password = contrasena;

                //SE EJECUTA EL METODO DEL LOGIN//
                L_usuario.Login(ref obj_usuario);

                ////DESPUES DEL LOGIN, SE EJECUTA EL METODO DE OBTENER DEPORTE//
                //L_usuario.ObtenerDeporte(ref obj_usuario); // <-- SE REQUIERE DE SOLUCIONAR BUGS

                if (obj_usuario.Id != 0) //VERIFICA si mi rol de usuario existe, si es asi entra y muestra el menu de administrador
                {
                    L_usuario.ObtenerDeporte(ref obj_usuario);
                    this.Close();
                    this.Dispose();
                    th = new Thread(AbrirMenu);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else { MessageBox.Show("Usuario y/o Contraseña no existe"); }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo logear", "Ha ocurrido un error en 'Login'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirMenu() 
        {
            try
            {
                Application.Run(new Menu_Administrador(ref obj_usuario));
            }
            catch
            {
                MessageBox.Show("Error en el Metodo AbrirMenu", "Ha ocurrido un error en 'Login'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                logear(this.txtUsuLog.Text, this.txtContraLog.Text);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnIniciar_Click", "Ha ocurrido un error en 'Login'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pbmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                //imagen ocultar la mandamos hacia enfrente
                pbocultar.BringToFront();
                //oculatamos la contraseña
                txtContraLog.PasswordChar = '\0';
            }
            catch
            {
                MessageBox.Show("Error en el Metodo pbmostrar_Click", "Ha ocurrido un error en 'Login'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbocultar_Click(object sender, EventArgs e)
        {
            try
            {
                //imagen mostrar la madamos hacia enfrente
                pbmostrar.BringToFront();
                //mostramos la contraseña
                txtContraLog.PasswordChar = '*';
            }
            catch
            {
                MessageBox.Show("Error en el Metodo pbocultar_Click", "Ha ocurrido un error en 'Login'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
