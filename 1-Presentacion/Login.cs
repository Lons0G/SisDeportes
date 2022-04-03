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

namespace _1_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VE4H6KBS; Initial Catalog=DB_DEPORTES; Integrated Security=True");

        public void logear(string usuario, string contrasena) //este metodo sirve para comprobar si mi usuario existe en el servidor
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT nombre, IdRol from TBL_Usuario WHERE Usuario=@usuario AND Contrasena=@contrasena", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();//oculta el formulario de login

                    if (dt.Rows[0][1].ToString() == "1")//adminsitrador
                    {
                        new Menu_Administrador(dt.Rows[0][0].ToString()).Show();
                    }
                    //else if (dt.Rows[0][1].ToString() == "2")//usuario
                    //{
                    //    new Menu_Usuario(dt.Rows[0][0].ToString()).Show();
                    //}

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña invalidos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
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
