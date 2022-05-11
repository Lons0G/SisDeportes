﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using _3_Entidades;
using _2_Logica;

namespace _1_Presentacion
{
    public partial class FRM_Integrantes : Form
    {
        int id_equipo, id_usuario, id_entrenador;
        public FRM_Integrantes(int id_equi,int id_usu, int id_entre)
        {
            InitializeComponent();
            id_equipo = id_equi;
            id_usuario = id_usu;
            id_entrenador = id_entre;   
        }
        public void GuardarDatosJu(string Nombre,string Apellido,string Edad,string Nacionalidad,string Posicion,string Dorsal)//Guardar Datos Jugador
        {
            //CLS_Integrantes obj_Integrante = new CLS_Integrantes();
            //CLS_L_Integrante L_Integrante = new CLS_L_Integrante ();
            
            
        }
        private void CbEntrenador_CheckedChanged(object sender, EventArgs e)
        {
            if (CbEntrenador.Checked== true)
            {
               CbJugador.Checked = false;
                txtPosicion.Enabled = false;
                txtDorsal.Enabled = false;
            }
            
        }

        private void CbJugador_CheckedChanged(object sender, EventArgs e)
        {
            if (CbJugador.Checked==true)
            {
               CbEntrenador.Checked = false;
                txtDorsal.Enabled = true;
                txtPosicion.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (CbJugador.Checked == true)
            {
                string rola = "Jugador";
                CLS_Integrantes obj_Integrante = new CLS_Integrantes();
                CLS_L_Integrante l_Integrante = new CLS_L_Integrante();

                obj_Integrante.IdEquipo = id_equipo;
                obj_Integrante.IdUsuario = id_usuario;
                obj_Integrante.IdEntrenador = id_entrenador;
                obj_Integrante.Nombre = txtNombre.Text;
                obj_Integrante.Apellido = txtApellido.Text;
                obj_Integrante.Edad = Convert.ToByte(txtEdad.Text);
                obj_Integrante.Nacionalidad = txtNacionalidad.Text;
                obj_Integrante.Posicion = this.txtPosicion.Text;
                obj_Integrante.Dorsal = Convert.ToInt32(txtDorsal.Text);
                obj_Integrante.Rol = rola;

               bool resultado = l_Integrante.Insertar_Integrante(ref obj_Integrante);

                if(resultado == true)
                {
                    MessageBox.Show("Integrante Guardado con Exito!");
                }
                else
                {
                    MessageBox.Show(obj_Integrante.Error);
                }
               
            }
            else
            {
                CLS_Integrantes obj_Integrante = new CLS_Integrantes();
                CLS_L_Integrante l_Integrante = new CLS_L_Integrante();

                obj_Integrante.IdEquipo = id_equipo;
                obj_Integrante.IdUsuario = id_usuario;
                obj_Integrante.Nombre = txtNombre.Text;
                obj_Integrante.Apellido = txtApellido.Text;
                obj_Integrante.Edad = Convert.ToByte(txtEdad.Text);
                obj_Integrante.Nacionalidad = txtNacionalidad.Text;
                obj_Integrante.Posicion = "Null";
                obj_Integrante.Dorsal = 0;
                obj_Integrante.Rol = "Entrenador";

                bool resultado = l_Integrante.Insertar_Integrante(ref obj_Integrante);

                if (resultado == true)
                {
                    MessageBox.Show("Integrante Guardado con Exito!");
                }
                else
                {
                    MessageBox.Show(obj_Integrante.Error);
                }

            }
        }
    }
}
