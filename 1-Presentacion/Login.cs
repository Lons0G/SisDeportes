using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _3_Entidades;
using _2_Logica.Logica;
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
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            logear(this.txtUsuLog.Text, this.txtContraLog.Text);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
