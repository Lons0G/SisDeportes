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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        public void CargarDeporte()
        {
            try
            {
                List<CLS_Deporte> lista_deportes = new List<CLS_Deporte>();
                CLS_L_Deporte L_deportes = new CLS_L_Deporte();

                L_deportes.Obtener_Deportes(lista_deportes);

                cboidequipo.DisplayMember = "Nombre";
                cboidequipo.ValueMember = "IdTipoDeporte";
                cboidequipo.DataSource = lista_deportes;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo CargarDeporte", "Ha ocurrido un error en 'Categoria'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCatego_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_Categoria obj_categoria = new CLS_Categoria();

                CLS_L_Categoria L_categoria = new CLS_L_Categoria();

                obj_categoria.IdDeporte = Convert.ToInt32(cboidequipo.SelectedValue);
                obj_categoria.Nombre = this.txtcategoria.Text;

                bool resultado = L_categoria.Insertar_Categoria(ref obj_categoria);

                if (resultado == true)
                {
                    MessageBox.Show("Guadado Con Exito!");
                }
                else
                {
                    MessageBox.Show(obj_categoria.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnCatego_Click", "Ha ocurrido un error en 'Categoria'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDeporte();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Categoria_Load", "Ha ocurrido un error en 'Categoria'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
