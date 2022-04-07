using System;
using System.Windows.Forms;
using _3_Entidades;
using _2_Logica;

namespace _1_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void logear(string usuario, string contrasena) //este metodo sirve para comprobar si mi usuario existe en el servidor
        {

            CLS_Usuario obj_usuario = new CLS_Usuario();
            CLS_L_Usuarios L_usuario = new CLS_L_Usuarios();

            obj_usuario.Usuario = usuario;
            obj_usuario.Password = contrasena;

            L_usuario.Login(ref obj_usuario);


            if (obj_usuario.Id != 0) //VERIFICA si mi rol de usuario existe, si es asi entra y muestra el menu de administrador
            {
                this.Hide();
                if (obj_usuario.Rol == 1) //si mi rol es igual da 1 es administrador
                {
                    Menu_Administrador MenuAdmi = new Menu_Administrador(); //cree el objeto 
                    MenuAdmi.Show();//si se cumple me abre la ventana de menu
                }
                else if (obj_usuario.Rol == 2)//si mi rol es 2 es usuario y muestra el menu de usuario
                {
                    Menu_Encargado MenuEncar = new Menu_Encargado();
                    MenuEncar.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña no existe"); //si no es ninguno, entonces no existe
            }
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
