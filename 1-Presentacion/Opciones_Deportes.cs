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
    public partial class Opciones_Deportes : Form
    {
        private int _id;
        private string _name;
        public Opciones_Deportes(int id,string name )
        {
            try
            {
                _id = id;
                _name = name;
                InitializeComponent();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Deportes", "Ha ocurrido un error en 'Opciones Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirForms(object FRM_secundario)
        {
            try
            {
                _p_forms2.Visible = true;
                if (this._p_forms2.Controls.Count > 0) { this._p_forms2.Controls.Clear(); }

                Form secundario = FRM_secundario as Form;
                secundario.TopLevel = false;
                secundario.Dock = DockStyle.Fill;
                this._p_forms2.Controls.Add(secundario);
                this._p_forms2.Tag = secundario;

                secundario.Show();

                ////SE CREA UN NUEVO EVENTO QUE DETECTA CUANDO SE CERRO EL FORMS SECUNDARIO//
                //secundario.FormClosing += new FormClosingEventHandler(Agregar_Usuario_Close);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo AbrirForms", "Ha ocurrido un error en 'Opciones Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public void Cargar_Deportes()
        {
            try
            {
                List<CLS_Deporte> lista_deportes = new List<CLS_Deporte>();
                CLS_L_Deporte L_deportes = new CLS_L_Deporte();
                L_deportes.Obtener_Deportes(lista_deportes);

                int i = 0;
                int x = _p_equipos.Width;

                foreach (var deportes in lista_deportes)
                {
                    UC_boton_entidad btn = new UC_boton_entidad(deportes.IdDeporte, deportes.Nombre,deportes.IdTipoDeporte,deportes.IdUsuario, x, 8);
                    btn.Top = 52 * i;
                    _p_equipos.Controls.Add(btn);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Deportes", "Ha ocurrido un error en 'Opciones Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInsertarDeporte_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForms(new FRM_Deportes(_id, _name));
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnInsertarDeporte_Click", "Ha ocurrido un error en 'Opciones Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Opciones_Deportes_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Deportes();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Deportes_Load", "Ha ocurrido un error en 'Opciones Deportes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
