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
    public partial class Actualizar_Torneos : Form
    {
        DateTime fecha;
        int id_torneo, id_categoria, id_usuario, id_tipo;
        string nombre;
        public Actualizar_Torneos(int id_tor, DateTime fech, int id_catego, int id_usuari, int id_tipoo, string noma)
        {
            InitializeComponent();
            id_torneo = id_tor;
            fecha = fech;
            id_categoria = id_catego;
            id_usuario = id_usuari;
            id_tipo = id_tipoo;
            nombre = noma;

        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CLS_Torneo obj_Torneo = new CLS_Torneo();
            CLS_L_Torneo L_Torneo = new CLS_L_Torneo();

            obj_Torneo.IdTorneo = id_torneo;
            obj_Torneo.Fecha = fecha;
            obj_Torneo.IdCategoria = id_categoria;
            obj_Torneo.IdUsuario = id_usuario;
            obj_Torneo.IdTipo = id_tipo;
            obj_Torneo.Nombre = nombre;

            bool resultado = L_Torneo.Editar_Torneo(ref obj_Torneo);

            if (resultado == true)
            {
                MessageBox.Show("Torneo Actualizado con Exito!");
            }
            else
            {
                MessageBox.Show(obj_Torneo.Error);

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
                L_categoria.Obtener_Categoria(ref list_categoria, 1);

                _cb_categoria.DisplayMember = "Nombre";
                _cb_categoria.ValueMember = "IdCategoria";
                _cb_categoria.DataSource = list_categoria;


                if (_cb_categoria.SelectedValue.ToString() != null)
                {
                    string idDeporte = _cb_categoria.SelectedValue.ToString();
                    //Cargar_Categoria(idDeporte);
                    //Cargar_Categoria(int idDeporte);
                    //Cargar_Categoria();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        //metodo que carga los tipos de actividad
        public void Cargar_Tipo_Actividad()
        {
            List<CLS_TipoActividad> lista_act = new List<CLS_TipoActividad>();
            CLS_L_Tipo l_Tipo = new CLS_L_Tipo();
            l_Tipo.ObtenerTipos(ref lista_act);
            _cb_tipo.DisplayMember = "Nombre";
            _cb_tipo.ValueMember = "IdTipoDeporte";
            _cb_tipo.DataSource = lista_act;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lblid_torneo.Text = id_torneo.ToString();
            txtnom.Text = nombre;
            lblcategoria.Text = id_categoria.ToString();
            lbltipo.Text = id_tipo.ToString();
            lblusu.Text = id_usuario.ToString();
            Cargar_Categoria();
            Cargar_Tipo_Actividad();
        }

        private void Actualizar_Torneos_Load(object sender, EventArgs e)
        {

        }
    }
}
