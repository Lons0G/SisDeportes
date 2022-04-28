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
    public partial class Actualizar_Equipo : Form
    {
        public Actualizar_Equipo()
        {
            InitializeComponent();
        }
        int id; string nom, ciu;

        private void TxtNombreEquipo_TextChanged(object sender, EventArgs e)
        {
            this.lbIdEquipo.Text = id.ToString();
            this.LbNomEqu.Text = nom;
            this.LbCiudad.Text= ciu;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CLS_Equipo obj_Equipo = new CLS_Equipo();
            CLS_L_Equipo log_Equipo = new CLS_L_Equipo();

            obj_Equipo.IdEquipo = id;
            obj_Equipo.Nombre=this.TxtNombreEquipo.Text;
            
        }
    }
}
