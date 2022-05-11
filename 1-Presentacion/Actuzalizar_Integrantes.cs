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
    public partial class Actuzalizar_Integrantes : Form
    {
        public Actuzalizar_Integrantes()
        {
            InitializeComponent();
        }
        int id_inte,id_equi,id_usu,id_entrena, dorsal; string nom, ape, nac, pos,rol;

        private void lbNombreEquipo_Click(object sender, EventArgs e)
        {

        }

        private void CbEntrenador_CheckedChanged(object sender, EventArgs e)
        {

            if (CbEntrenador.Checked == true)
            {
                CbJugador.Checked = false;
                TxtPosicion.Enabled = false;
                TxtDorsal.Enabled = false;
                TxtPosicion.Text = "Null";
                TxtDorsal.Text = "0";
            }
        }

        private void CbJugador_CheckedChanged(object sender, EventArgs e)
        {
            if (CbJugador.Checked == true)
            {
                CbEntrenador.Checked = false;
                TxtDorsal.Enabled = true;
                TxtPosicion.Enabled = true;
            }
        }

        byte edad;

        private void btncargar_Click(object sender, EventArgs e)
        {
            this.lbID.Text = id_inte.ToString();
            this.TxtNombre.Text = nom;
            this.TxtApell.Text = ape;
            this.TxtEdad.Text = edad.ToString();
            this.TxtNacionalidad.Text = nac;
            this.TxtPosicion.Text = pos;
            this.TxtDorsal.Text = dorsal.ToString();

            if (CbJugador.Checked == true)
            {
                CbEntrenador.Checked = false;
                TxtDorsal.Enabled = true;
                TxtPosicion.Enabled = true;
            }
            else if (CbEntrenador.Checked == false)
            {
                CbJugador.Checked = false;
                TxtPosicion.Enabled = false;
                TxtDorsal.Enabled = false;
            }


            //if (this.TxtPosicion.Text == "Entrenador")
            //{
            //    this.TxtDorsal.Enabled = false;
            //    this.TxtPosicion.Enabled = false;
            //}
        }

        private void Actuzalizar_Integrantes_Load(object sender, EventArgs e)
        {

        }

        public void Recibir_Da(int id,int id_eq,int id_usua,int id_entrenador,string no, string ap, byte eda, string na, string po, int dor,string ro)
        {
            id_inte = id;
            id_equi = id_eq;
            id_usu = id_usua;
            id_entrena = id_entrenador;
            nom = no;
            ape = ap;
            edad = eda;
            nac = na;
            pos = po;
            dorsal = dor;
            rol = ro;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (CbJugador.Checked == true)
            {
                CLS_Integrantes obj_Integrante = new CLS_Integrantes();
                CLS_L_Integrante log_Integrante = new CLS_L_Integrante();

                obj_Integrante.IdIntegrante = Convert.ToInt32(this.lbID.Text);
                obj_Integrante.IdEquipo = id_equi;
                obj_Integrante.IdUsuario = id_usu;
                obj_Integrante.IdEntrenador = id_entrena;
                obj_Integrante.Nombre = this.TxtNombre.Text;
                obj_Integrante.Apellido = this.TxtApell.Text;
                obj_Integrante.Edad = Convert.ToByte(this.TxtEdad.Text);
                obj_Integrante.Nacionalidad = this.TxtNacionalidad.Text;
                obj_Integrante.Posicion = this.TxtPosicion.Text;
                obj_Integrante.Dorsal = Convert.ToInt32(this.TxtDorsal.Text);
                obj_Integrante.Rol = "Jugador";

                bool resultado = log_Integrante.Editar_Integrante(ref obj_Integrante);

                if (resultado == true)
                {
                    MessageBox.Show("Se a actualizado correctamente el integrante del equipo");
                }
                else
                {
                    MessageBox.Show(obj_Integrante.Error);
                }
            }
            else
            {
                CLS_Integrantes obj_Integrante = new CLS_Integrantes();
                CLS_L_Integrante log_Integrante = new CLS_L_Integrante();

                obj_Integrante.IdIntegrante = Convert.ToInt32(this.lbID.Text);
                obj_Integrante.IdEquipo = id_equi;
                obj_Integrante.IdUsuario = id_usu;
                obj_Integrante.IdEntrenador = id_entrena;
                obj_Integrante.Nombre = this.TxtNombre.Text;
                obj_Integrante.Apellido = this.TxtApell.Text;
                obj_Integrante.Edad = Convert.ToByte(this.TxtEdad.Text);
                obj_Integrante.Nacionalidad = this.TxtNacionalidad.Text;
                obj_Integrante.Posicion = "Null";
                obj_Integrante.Dorsal = 0;
                obj_Integrante.Rol = "Entrenador";

                bool resultado = log_Integrante.Editar_Integrante(ref obj_Integrante);

                if (resultado == true)
                {
                    MessageBox.Show("Se a actualizado correctamente el integrante del equipo");
                }
                else
                {
                    MessageBox.Show(obj_Integrante.Error);
                }
            }

           

        }

    }
}
