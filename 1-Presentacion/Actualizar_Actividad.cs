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
    public partial class Actualizar_Actividad : Form
    {
        int id_act,id_con1,id_con2,id_categoria,id_usuario,id_deporte,id_tipoo,id_torneo; DateTime fecha, hora;string nom;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_Actividad obj_actividad = new CLS_Actividad();
                CLS_L_Actividad L_actividad = new CLS_L_Actividad();

                obj_actividad.IdActividad = id_act;
                obj_actividad.IdUsuario = id_usuario;
                obj_actividad.Nombre = txtActividad.Text;
                obj_actividad.IdDeporte = id_deporte;/*cmbDeporte.SelectedIndex;*/
                obj_actividad.IdTipo = cboAct.SelectedIndex + 1;
                obj_actividad.IdTorneo = cboTorneo.SelectedIndex;
                obj_actividad.IdCategoria = cmbCategoria.SelectedIndex; //el indice por defecto marca 0 y por eso le sume 1
                obj_actividad.Fecha = Convert.ToDateTime(this.dtpFecha.Text);
                obj_actividad.Hora = Convert.ToDateTime(this.dtpHora.Text);
                obj_actividad.IdContricante_1 = cmbContri1.SelectedIndex + 1; //el indice por defecto marca 0 y por eso le sume 1
                obj_actividad.IdContricante_2 = cmbContri2.SelectedIndex + 1;//el indice por defecto marca 0 y por eso le sume 1

                bool resultado = L_actividad.Editar_Actividad(ref obj_actividad);

                if (resultado == true)
                {
                    MessageBox.Show("Actividad Guardada con Exito");
                }
                else
                {
                    MessageBox.Show(obj_actividad.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnAceptar_Click", "Ha ocurrido un error en 'Actualizar Actividad'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Actualizar_Actividad(int id, DateTime fech, DateTime hor, int id_c1, int id_c2, int id_catego, int id_usu, int id_depo, int id_tip, int id_torn, string nombre)
        {
            try
            {
                InitializeComponent();
                id_act = id;
                fecha = fech;
                hora = hor;
                id_con1 = id_c1;
                id_con2 = id_c2;
                id_categoria = id_catego;
                id_usuario = id_usu;
                id_deporte = id_depo;
                id_tipoo = id_tip;
                id_torneo = id_torn;
                nom = nombre;
                Cargar_Categoria();
                Cargar_Torneos();
                Cargar_Tipo_Actividad();
                Cargar_Equipos(id_usuario);
                Cargar_Equipos2(id_usuario);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Actualizar_Actividad", "Ha ocurrido un error en 'Actualizar Actividad'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                txtActividad.Text = nom;
                cboAct.Text = id_act.ToString();
                cmbCategoria.Text = id_categoria.ToString();
                dtpFecha.Text = fecha.ToString();
                dtpHora.Text = hora.ToString();
                cmbContri1.Text = id_con1.ToString();
                cmbContri2.Text = id_con2.ToString();
                cboTorneo.Text = id_torneo.ToString();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnCargar_Click", "Ha ocurrido un error en 'Actualizar Actividad'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar_Categoria()
        {
            try
            {
                //LISTA DE LAS CATEGORIAS QUE SE TIENEN EN ESTE DEPORTE//
                List<CLS_Categoria> list_categoria = new List<CLS_Categoria>();
                CLS_L_Categoria L_categoria = new CLS_L_Categoria();

                //SE EJECTUA EL METODO PARA OBTENER LAS CATEGORAIS//
                L_categoria.Obtener_Categoria(ref list_categoria, id_deporte);

                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.DataSource = list_categoria;


                if (cmbCategoria.SelectedValue.ToString() != null)
                {
                    string idDeporte = cmbCategoria.SelectedValue.ToString();
                    //Cargar_Categoria(idDeporte);
                    //Cargar_Categoria(int idDeporte);
                    //Cargar_Categoria();
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Categoria", "Ha ocurrido un error en 'Actualizar Actividad'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo que carga los equipos
        public void Cargar_Equipos(int id)
        {
            try
            {
                List<CLS_Equipo> lista_equipos = new List<CLS_Equipo>();
                CLS_L_Equipo L_equipo = new CLS_L_Equipo();
                L_equipo.ObtenerEquipos(ref lista_equipos, id);
                cmbContri1.DisplayMember = "Nombre";
                cmbContri1.ValueMember = "IdEquipo";
                cmbContri1.DataSource = lista_equipos;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Equipos", "Ha ocurrido un error en 'Actualizar Actividad'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo que carga los tipos de actividad
        public void Cargar_Tipo_Actividad()
        {
            try
            {
                List<CLS_TipoActividad> lista_act = new List<CLS_TipoActividad>();
                CLS_L_Tipo l_Tipo = new CLS_L_Tipo();
                l_Tipo.ObtenerTipos(ref lista_act);
                cboAct.DisplayMember = "Nombre";
                cboAct.ValueMember = "IdTipo";
                cboAct.DataSource = lista_act;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Actualizar_Torneos", "Ha ocurrido un error en 'Actualizar Actividad'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo que carga los equipos
        public void Cargar_Equipos2(int id)
        {
            try
            {
                List<CLS_Equipo> lista_equipos = new List<CLS_Equipo>();
                CLS_L_Equipo L_equipo = new CLS_L_Equipo();
                L_equipo.ObtenerEquipos(ref lista_equipos, id);

                cmbContri2.DisplayMember = "Nombre";
                cmbContri2.ValueMember = "IdEquipo";
                cmbContri2.DataSource = lista_equipos;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Equipos2", "Ha ocurrido un error en 'Actualizar Actividad'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo que carga los torneos
        public void Cargar_Torneos()
        {
            try
            {
                List<CLS_Torneo> lista_torneo = new List<CLS_Torneo>();
                CLS_L_Torneo L_Torneo = new CLS_L_Torneo();
                L_Torneo.ObtenerTorneos(ref lista_torneo);

                cboTorneo.DisplayMember = "Nombre";
                cboTorneo.ValueMember = "IdTorneo";
                cboTorneo.DataSource = lista_torneo;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Torneos", "Ha ocurrido un error en 'Actualizar Actividad'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Actualizar_Actividad_Load(object sender, EventArgs e)
        {

        }
    }
}