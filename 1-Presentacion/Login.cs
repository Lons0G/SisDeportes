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
            CLS_L_Usuarios L_usuario = new CLS_L_Usuarios();

            obj_usuario.Usuario = usuario;
            obj_usuario.Password = contrasena;

            L_usuario.Login(ref obj_usuario);


            if (obj_usuario.Id != 0) //VERIFICA si mi rol de usuario existe, si es asi entra y muestra el menu de administrador
            {
                this.Close();
                this.Dispose();
                th = new Thread(AbrirMenu);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            else { MessageBox.Show("Usuario y/o Contraseña no existe"); }
        }
        private void AbrirMenu() {
            Application.Run(new Menu_Administrador(obj_usuario.Rol));
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            logear(this.txtUsuLog.Text, this.txtContraLog.Text);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pbmostrar_Click(object sender, EventArgs e)
        {
            //imagen ocultar la mandamos hacia enfrente
            pbocultar.BringToFront();
            //oculatamos la contraseña
            txtContraLog.PasswordChar = '\0';
        }

        private void pbocultar_Click(object sender, EventArgs e)
        {
            //imagen mostrar la madamos hacia enfrente
            pbmostrar.BringToFront();
            //mostramos la contraseña
            txtContraLog.PasswordChar = '*';
        }

    }
}
