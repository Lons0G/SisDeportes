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
    public partial class Equipos : Form
    {
        private int _id, id_depo;
        private string _name;
        public Equipos(int Id,string Nombre,int iddepo)
        {
            InitializeComponent();
            _id = Id;
            _name = Nombre;
            //id_depo = iddepo;
        }
        public void CargarDeporte()
        {
            List<CLS_Deporte> lista_deportes = new List<CLS_Deporte>();
            CLS_L_Deporte L_deportes = new CLS_L_Deporte();

            L_deportes.Obtener_Deportes(lista_deportes);

            cboidequipo.DisplayMember = "Nombre";
            cboidequipo.ValueMember = "IdTipoDeporte";
            cboidequipo.DataSource = lista_deportes;
  

        }
        private void Cargar_TiposCategoria()
        {
            List<CLS_TipoDeporte> lista_TiposDeportes = new List<CLS_TipoDeporte>();
            CLS_L_TipoDeporte L_tipo_deporte = new CLS_L_TipoDeporte();
            L_tipo_deporte.Obtener_TipoDeportes(ref lista_TiposDeportes);

            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "IdTipoDeporte";
            cboCategoria.DataSource = lista_TiposDeportes;

        }
        //private void Cargar_TiposCategoria()
        //{
        //    List<CLS_Categoria> lista_categoria = new List<CLS_Categoria>();
        //    CLS_L_Categoria L_Categoria = new CLS_L_Categoria();
        //    L_Categoria.Obtener_Categoria(lista_categoria, 1);

        //    cboCategoria.DisplayMember = "Nombre";
        //    cboCategoria.ValueMember = "IdTipoDeporte";
        //    cboCategoria.DataSource = lista_categoria;

        //}
        private void btnRegEquipo_Click(object sender, EventArgs e)
        {
            CLS_Equipo obj_equipo = new CLS_Equipo();
            CLS_L_Equipo l_Equipo = new CLS_L_Equipo();

            obj_equipo.IdUsuario = _id;
            obj_equipo.IdDeporte = Convert.ToInt32(cboidequipo.SelectedValue);
            obj_equipo.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
            obj_equipo.IdEntrenador = 2;
            obj_equipo.Nombre = this.txtNameEquipo.Text;
            obj_equipo.Visitante = true;

            bool resultado = l_Equipo.Insertar_Equipo(ref obj_equipo);
            
            if(resultado == true)
            {
                MessageBox.Show("Equipo Guardado con Exito!");
            }
            else
            {
                MessageBox.Show(obj_equipo.Error);
            }



        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            CargarDeporte();
            Cargar_TiposCategoria();
            lblusuario.Text = _name;
        }
    }
}
