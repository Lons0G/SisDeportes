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
    public partial class Torneo : Form
    {
        int id_deporte, id_usuario;
        public Torneo(int deporte_id, int usuario_id)
        {
            try
            {
                InitializeComponent();
                id_deporte = deporte_id;
                id_usuario = usuario_id;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Torneo", "Ha ocurrido un error en 'Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Torneo_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Categoria();
                Cargar_Tipos();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Torneo_Load", "Ha ocurrido un error en 'Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cargar_Categoria()
        {
            try
            {
                List<CLS_Categoria> lista_Categoria = new List<CLS_Categoria>();
                CLS_L_Categoria L_categoira = new CLS_L_Categoria();
                L_categoira.Obtener_Categoria(ref lista_Categoria, id_deporte);

                _cb_categoria.DisplayMember = "Nombre";
                _cb_categoria.ValueMember = "IdCategoria";
                _cb_categoria.DataSource = lista_Categoria;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Categoria", "Ha ocurrido un error en 'Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cargar_Tipos()
        {
            try
            {
                List<CLS_TipoActividad> lista_TiposDeportes = new List<CLS_TipoActividad>();
                CLS_L_Tipo L_tipo_deporte = new CLS_L_Tipo();
                L_tipo_deporte.ObtenerTipos(ref lista_TiposDeportes);

                _cb_tipo.DisplayMember = "Nombre";
                _cb_tipo.ValueMember = "IdTipo";
                _cb_tipo.DataSource = lista_TiposDeportes;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Tipos", "Ha ocurrido un error en 'Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btntorneocrear_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_Torneo obj_torneo = new CLS_Torneo();
                CLS_L_Torneo l_Torneo = new CLS_L_Torneo();

                obj_torneo.Fecha = Convert.ToDateTime(this.dtfechatorneo.Text);
                obj_torneo.IdCategoria = Convert.ToInt32(_cb_tipo.SelectedValue);
                obj_torneo.IdUsuario = id_usuario;
                obj_torneo.IdTipo = Convert.ToInt32(_cb_tipo.SelectedValue);
                obj_torneo.IdDeporte = id_deporte;
                obj_torneo.Nombre = txtnom.Text;

                bool resultado = l_Torneo.Insertar_Torneo(ref obj_torneo);

                if (resultado == true) { MessageBox.Show("Torneo Guardado Con Exito!"); }
                else { MessageBox.Show(obj_torneo.Error); }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btntorneocrear_Click", "Ha ocurrido un error en 'Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
