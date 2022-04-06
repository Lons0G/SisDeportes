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
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador(/*string nombre*/)
        {
            InitializeComponent();
            //lblmensajeadmi.Text = nombre;
        }

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpcionesUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            Opciones_Usuario opciones = new Opciones_Usuario();

            opciones.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login mostrar = new Login();

            mostrar.Show();
        }
    }
}
