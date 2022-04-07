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
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Agregar_Usuario agrega =  new Agregar_Usuario();

            agrega.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
             
        }
    }
}
