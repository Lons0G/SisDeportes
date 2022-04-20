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
        
        public Creación_Actividades(int deporte)
        {
            InitializeComponent();
            Cargar_Categoria(deporte);
        }

        private void Creación_Actividades_Load(object sender, EventArgs e)
        {

        }

        public void Cargar_Categoria(int idDeporte)
        {
            try
            {
                //LISTA DE LAS CATEGORIAS QUE SE TIENEN EN ESTE DEPORTE//
                List<CLS_Categoria> list_categoria = new List<CLS_Categoria>();
                CLS_L_Categoria L_categoria = new CLS_L_Categoria();
                
                //SE EJECTUA EL METODO PARA OBTENER LAS CATEGORAIS//
                L_categoria.Obtener_Categoria(list_categoria, idDeporte);
                
                //SE AGREGAN LAS CATEGORIAS AL COMBOBOX
                foreach (var categoria in list_categoria) {
                    cmbCategoria.Items.Add(categoria.Nombre); //PENDIENTE: AGREGAR TAMBIEN EL ID DE LA CATEGORIA
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //PENDIENTE, REALIZAR LA FUNCION PARA GENERAR UNA ACTIVIDAD//
        }
    }
}
