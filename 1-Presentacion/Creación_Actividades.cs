using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _3_Entidades;
using _2_Logica;

namespace _1_Presentacion
{
    public partial class Creación_Actividades : Form
    {
        int id__,id_depo;
        
        public Creación_Actividades(int deporte, int _id)
        {
            id__ = _id;
            id_depo = deporte;
            InitializeComponent();
            Cargar_Categoria();
            Cargar_Equipos(id__);
            Cargar_Equipos2(id__);
            Cargar_Tipo_Actividad();
            Cargar_Torneos();
        }

        private void Creación_Actividades_Load(object sender, EventArgs e)
        {

        }

        public void Cargar_Categoria()
        {
            try
            {
                //LISTA DE LAS CATEGORIAS QUE SE TIENEN EN ESTE DEPORTE//
                List<CLS_Categoria> list_categoria = new List<CLS_Categoria>();
                CLS_L_Categoria L_categoria = new CLS_L_Categoria();

                //SE EJECTUA EL METODO PARA OBTENER LAS CATEGORAIS//
                L_categoria.Obtener_Categoria(ref list_categoria,id__);

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
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        int id_usu;
        //metodo que carga los equipos
        public void Cargar_Equipos(int id)
        {
            try
            {
                List<CLS_Equipo> lista_equipos = new List<CLS_Equipo>();
                CLS_L_Equipo L_equipo = new CLS_L_Equipo();
                L_equipo.ObtenerEquipos(ref lista_equipos, id);
                id_usu = id;
                cmbContri1.DisplayMember = "Nombre";
                cmbContri1.ValueMember = "IdTipoDeporte";
                cmbContri1.DataSource = lista_equipos;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

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
                cboAct.ValueMember = "IdTipoDeporte";
                cboAct.DataSource = lista_act;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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
                cmbContri2.ValueMember = "IdTipoDeporte";
                cmbContri2.DataSource = lista_equipos;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
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
                cboTorneo.ValueMember = "IdTipoDeporte";
                cboTorneo.DataSource = lista_torneo;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_Actividad obj_actividad = new CLS_Actividad();
                CLS_L_Actividad L_actividad = new CLS_L_Actividad();

                obj_actividad.IdUsuario = id__;
                obj_actividad.Nombre = txtActividad.Text;
                obj_actividad.IdDeporte = id_depo;/*cmbDeporte.SelectedIndex;*/
                obj_actividad.IdTipo = cboAct.SelectedIndex + 1;
                obj_actividad.IdTorneo = cboTorneo.SelectedIndex;
                obj_actividad.IdCategoria = cmbCategoria.SelectedIndex + 1; //el indice por defecto marca 0 y por eso le sume 1
                obj_actividad.Fecha = dtpFecha.Value;
                obj_actividad.Hora = dtpHora.Value;
                obj_actividad.IdContricante_1 = cmbContri1.SelectedIndex + 1; //el indice por defecto marca 0 y por eso le sume 1
                obj_actividad.IdContricante_2 = cmbContri2.SelectedIndex + 1;//el indice por defecto marca 0 y por eso le sume 1

                bool resultado = L_actividad.Insertar_Actividad(ref obj_actividad);

                if (resultado == true)
                {
                    MessageBox.Show("Actividad Guardada con Exito");
                }
                else
                {
                    MessageBox.Show(obj_actividad.Error);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbContri1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
