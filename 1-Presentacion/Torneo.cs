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
    public partial class Torneo : Form
    {
        int id_depo, id_usu;
        public Torneo(int d1,int d2)
        {
           
            InitializeComponent();
            id_depo = d1;
            id_usu = d2;
        }

        private void Torneo_Load(object sender, EventArgs e)
        {

        }

        private void btntorneocrear_Click(object sender, EventArgs e)
        {
            CLS_Torneo obj_torneo = new CLS_Torneo();
            CLS_L_Torneo l_Torneo = new CLS_L_Torneo();

            obj_torneo.Fecha = Convert.ToDateTime(this.dtfechatorneo.Text);
            obj_torneo.IdCategoria = 1;
            obj_torneo.IdUsuario = id_usu;
            obj_torneo.IdTipo = 1;
            obj_torneo.IdDeporte = id_depo;
            obj_torneo.Nombre = txtnom.Text;
           

            bool resultado = l_Torneo.Insertar_Torneo(ref obj_torneo);

            if(resultado == true)
            {
                MessageBox.Show("Torneo Guardado Con Exito!");
            }
            else
            {
                MessageBox.Show(obj_torneo.Error);
            }



            
            
        }
    }
}
