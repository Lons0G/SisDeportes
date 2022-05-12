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
        int id_torneo, id_categoria, id_usuario, id_tipo,id_deporte;
        string nombre;
        public Actualizar_Torneos(int id_tor, DateTime fech, int id_catego, int id_usuari, int id_tipoo, string noma,int id_depo)
        {
            try
            {
                InitializeComponent();
                id_torneo = id_tor;
                fecha = fech;
                id_categoria = id_catego;
                id_usuario = id_usuari;
                id_tipo = id_tipoo;
                nombre = noma;
                id_deporte = id_depo;
                Cargar_Categoria();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Actualizar_Torneos", "Ha ocurrido un error en 'Actualizar Torneos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                lblid_torneo.Text = id_torneo.ToString();
                txtnom.Text = nombre;
                dtfechatorneo.Text = fecha.ToString();
                _cb_categoria.Text = id_categoria.ToString();
                Cargar_Tipo_Actividad();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnCargar_Click", "Ha ocurrido un error en 'Actualizar Torneos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_Torneo obj_Torneo = new CLS_Torneo();
                CLS_L_Torneo L_Torneo = new CLS_L_Torneo();

                obj_Torneo.IdTorneo = id_torneo;
                obj_Torneo.Fecha = Convert.ToDateTime(this.dtfechatorneo.Text);
                obj_Torneo.IdCategoria = _cb_categoria.SelectedIndex + 1;
                obj_Torneo.IdUsuario = id_usuario;
                obj_Torneo.IdTipo = _cb_tipo.SelectedIndex + 1;
                obj_Torneo.Nombre = txtnom.Text;

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
            catch
            {
                MessageBox.Show("Error en el Metodo BtnActualizar_Click", "Ha ocurrido un error en 'Actualizar Torneos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Categoria", "Ha ocurrido un error en 'Actualizar Torneos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _cb_tipo.DisplayMember = "Nombre";
                _cb_tipo.ValueMember = "IdTipoDeporte";
                _cb_tipo.DataSource = lista_act;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Tipo_Actividad", "Ha ocurrido un error en 'Actualizar Torneos'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar_Torneos_Load(object sender, EventArgs e)
        {

        }
    }
}
