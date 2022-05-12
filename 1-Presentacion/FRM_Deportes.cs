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
    /*CODIGO Y DISEÑO REALIZADO POR MIGUEL Y PUESTO EN PROYECTO POR ANGEL*/
    public partial class FRM_Deportes : Form
    {
        private int _id;
        private string _name;
        public FRM_Deportes(int id, string nombre)
        {
            try
            {
                InitializeComponent();
                _id = id;
                _name = nombre;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo FRM_Deportes", "Ha ocurrido un error en 'FRM Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void _btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(_cb_tipo_deporte.SelectedValue.ToString());
                //bool Estado;
                if (_txt_nombre_deporte.Text != "")
                {
                    CLS_Deporte obj_deporte = new CLS_Deporte();
                    CLS_L_Deporte L_Deporte = new CLS_L_Deporte();

                    obj_deporte.IdUsuario = _id;
                    obj_deporte.Nombre = _txt_nombre_deporte.Text;
                    obj_deporte.IdTipoDeporte = Convert.ToInt32(_cb_tipo_deporte.SelectedValue);

                    bool resultado = L_Deporte.Insertar_Deporte(ref obj_deporte);

                    if (resultado == true)
                    {
                        MessageBox.Show("Deporte Guardado con Exito!");
                    }
                    else
                    {
                        MessageBox.Show(obj_deporte.Error);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo _btn_registrar_Click", "Ha ocurrido un error en 'FRM Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_Deportes_Load(object sender, EventArgs e)
        {
            try
            {
                _lbl_nombre.Text = _name;
                Cargar_TiposDeporte();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo FRM_Deportes_Load", "Ha ocurrido un error en 'FRM Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
