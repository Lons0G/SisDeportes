using System;
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
using System.Globalization;

namespace _1_Presentacion
{
    public partial class FRM_Integrantes : Form
    {
        int id_equipo, id_usuario, id_entrenador;
        public FRM_Integrantes(int id_equi,int id_usu, int id_entre)
        {
            try
            {
                InitializeComponent();
                id_equipo = id_equi;
                id_usuario = id_usu;
                id_entrenador = id_entre;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnVolver_Click", "Ha ocurrido un error en 'FRM Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        public void GuardarDatosJu(string Nombre,string Apellido,string Edad,string Nacionalidad,string Posicion,string Dorsal)//Guardar Datos Jugador
        {

            //CLS_Integrantes obj_Integrante = new CLS_Integrantes();
            //CLS_L_Integrante L_Integrante = new CLS_L_Integrante ();
            
            
        }
        private void CbEntrenador_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbEntrenador.Checked == true)
                {
                    CbJugador.Checked = false;
                    txtPosicion.Enabled = false;
                    txtDorsal.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo CbEntrenador_CheckedChanged", "Ha ocurrido un error en 'FRM Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void CbJugador_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbJugador.Checked == true)
                {
                    CbEntrenador.Checked = false;
                    txtDorsal.Enabled = true;
                    txtPosicion.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo CbJugador_CheckedChanged", "Ha ocurrido un error en 'FRM Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            e.Handled = !(char.IsDigit(e.KeyChar)
            || e.KeyChar == (char)Keys.Back);
        }

        private void txtDorsal_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            e.Handled = !(char.IsDigit(e.KeyChar)
            || e.KeyChar == (char)Keys.Back);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
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

                    if (txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtNacionalidad.Text != "" && txtPosicion.Text != "" && txtDorsal.Text != "" && CbJugador.Checked == true)
                    {
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
                    else
                    {
                        MessageBox.Show("Verifique que todos los campos esten llenados y correctos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (txtNombre.Text != "" && txtApellido.Text != "" && txtEdad.Text != "" && txtNacionalidad.Text != "" && CbEntrenador.Checked == true)
                    {
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
                    else
                    {
                        MessageBox.Show("Verifique que todos los campos esten llenados y correctos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique que todos los campos esten llenados y correctos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
