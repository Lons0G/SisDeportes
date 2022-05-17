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
        public Actualizar_Equipo(int idequipo, string nombre, int usuario, int categoria, int deporte, int entreandor, bool visitante)
        {
            try
            {
                InitializeComponent();
                id_ = idequipo;
                nom = nombre;
                visita = visitante;
                id_u = usuario;
                id_c = categoria;
                id_d = deporte;
                id_entre = entreandor;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Actualizar_Equipo", "Ha ocurrido un error en 'Actualizar Equipos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombreEquipo_TextChanged(object sender, EventArgs e)
        {

        }
        int id_,id_u,id_c,id_d,id_entre;string nom;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool visita;
        public void recibe(int id, string nombre, bool visitante,int id_usu,int id_cate,int id_depo,int id_entrena)
        {
            try
            {
                id_ = id;
                nom = nombre;
                visita = visitante;
                id_u = id_usu;
                id_c = id_cate;
                id_d = id_depo;
                id_entre = id_entrena;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo recibe", "Ha ocurrido un error en 'Actualizar Equipos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_Equipo obj_equipo = new CLS_Equipo();
                CLS_L_Equipo l_Equipo = new CLS_L_Equipo();

                obj_equipo.IdEquipo = id_;
                obj_equipo.IdUsuario = id_u;
                obj_equipo.IdDeporte = id_d;
                obj_equipo.IdCategoria = 1;
                obj_equipo.IdEntrenador = 0;
                obj_equipo.Nombre = TxtNombreEquipo.Text;
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
            catch
            {
                MessageBox.Show("Error en el Metodo BtnActualizar_Click", "Ha ocurrido un error en 'Actualizar Equipos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbIdEquipo.Text = id_.ToString();
                this.TxtNombreEquipo.Text = nom;
                this.txtvisita.Text = visita.ToString();
                this.txtentrenador.Text = id_entre.ToString();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnCargar_Click", "Ha ocurrido un error en 'Actualizar Equipos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
