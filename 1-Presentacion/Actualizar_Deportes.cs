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
    public partial class Actualizar_Deportes : Form
    {
        int id_depo, id_tipo_deporte, id_usuario;string nombre;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lblusuario.Text = id_usuario.ToString();
            _txt_nombre_deporte.Text = nombre;
            _cb_tipo_deporte.Text = id_tipo_deporte.ToString();
        }

        public Actualizar_Deportes(int id, string nom, int id_tipod, int id_usu)
        {
            InitializeComponent();
            id_depo = id;
            nombre = nom;
            id_tipo_deporte = id_tipod;
            id_usuario = id_usu;
            Cargar_TiposDeporte();
        }
        private void Cargar_TiposDeporte()
        {
            try
            {
                List<CLS_TipoDeporte> lista_TiposDeportes = new List<CLS_TipoDeporte>();
                CLS_L_TipoDeporte L_tipo_deporte = new CLS_L_TipoDeporte();
                L_tipo_deporte.Obtener_TipoDeportes(ref lista_TiposDeportes);

                _cb_tipo_deporte.DisplayMember = "Nombre";
                _cb_tipo_deporte.ValueMember = "IdTipoDeporte";
                _cb_tipo_deporte.DataSource = lista_TiposDeportes;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_TiposDeporte", "Ha ocurrido un error en 'FRM Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar_Deportes_Load(object sender, EventArgs e)
        {

        }
    }
}
