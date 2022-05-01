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

        private void TxtNombreEquipo_TextChanged(object sender, EventArgs e)
        {

        }
        int id_,id_u,id_c,id_d,id_entre;string nom;bool visita;
        public void recibe(int id, string nombre, bool visitante,int id_usu,int id_cate,int id_depo,int id_entrena)
        {
            id_ = id;
            nom = nombre;
            visita = visitante;
            id_u = id_usu;
            id_c = id_cate;
            id_d = id_depo;
            id_entre = id_entrena;
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
           //marca error de asignacion de tipo de objeto _3_entidades
            CLS_Equipo obj_equipo = new CLS_Equipo();
            CLS_L_Equipo l_Equipo = new CLS_L_Equipo();

            obj_equipo.IdUsuario = id_u;
            obj_equipo.IdDeporte = id_d;
            obj_equipo.IdCategoria = id_c;
            obj_equipo.IdEntrenador = id_entre;
            obj_equipo.Nombre = this.TxtNombreEquipo.Text;
            obj_equipo.Visitante = Convert.ToBoolean(txtvisita.Text);

            bool resultado = l_Equipo.Editar_Equipo(ref obj_equipo);

            if (resultado == true)
            {
                MessageBox.Show("Equipo Guardado con Exito!");
            }
            else
            {
                MessageBox.Show(obj_equipo.Error);
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.lbIdEquipo.Text = id_.ToString();
            this.TxtNombreEquipo.Text = nom;
            this.txtvisita.Text = visita.ToString();
            this.txtentrenador.Text = id_entre.ToString();

        }
    }
}
