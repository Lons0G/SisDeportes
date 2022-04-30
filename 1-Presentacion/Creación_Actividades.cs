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
        int id__;
        
        public Creación_Actividades(int deporte, int _id)
        {
            id__ = _id;
            InitializeComponent();
          //Cargar_Categoria(deporte);
            Cargar_Categoria();
         // Cargar_Deporte();
            Cargar_Equipos(id__);
            Cargar_Equipos2(id__);
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

        public void Cargar_Equipos(int id)
        {

            List<CLS_Equipo> lista_equipos = new List<CLS_Equipo>();
            CLS_L_Equipo L_equipo = new CLS_L_Equipo();
            L_equipo.ObtenerEquipos(ref lista_equipos, id);
            cmbContri1.DisplayMember = "Nombre";
            cmbContri1.ValueMember = "IdTipoDeporte";
            cmbContri1.DataSource = lista_equipos;
        }
        public void Cargar_Equipos2(int id)
        {

            List<CLS_Equipo> lista_equipos = new List<CLS_Equipo>();
            CLS_L_Equipo L_equipo = new CLS_L_Equipo();
            L_equipo.ObtenerEquipos(ref lista_equipos, id);
   
            cmbContri2.DisplayMember = "Nombre";
            cmbContri2.ValueMember = "IdTipoDeporte";
            cmbContri2.DataSource = lista_equipos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //PENDIENTE, REALIZAR LA FUNCION PARA GENERAR UNA ACTIVIDAD//
            CLS_Actividad obj_actividad = new CLS_Actividad();
            CLS_L_Actividad L_actividad = new CLS_L_Actividad();

            obj_actividad.Nombre = txtActividad.Text;
          //obj_actividad.IdDeporte = cmbDeporte.SelectedIndex;
            obj_actividad.IdCategoria = 1; /*cmbCategoria.SelectedIndex;*/
            obj_actividad.Fecha = dtpFecha.Value;
            obj_actividad.Hora = dtpHora.Value;
            obj_actividad.IdContricante_1 = cmbContri1.SelectedIndex;
            obj_actividad.IdContricante_2 = cmbContri2.SelectedIndex;

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


    }
}
