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
    public partial class Opciones_Actividades : Form
    {
        int id_u,id_deporte;
        public Opciones_Actividades(int id,int u)
        {
            try
            {
                InitializeComponent();
                id_u = u;
                id_deporte = id;
                Cargar_Actividad();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnVolver_Click", "Ha ocurrido un error en 'Opciones Actividades'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirForms(object FRM_secundario) 
        {
            try
            {
                _p_forms.Visible = true;
                if (this._p_forms.Controls.Count > 0) { this._p_forms.Controls.RemoveAt(0); }

                Form secundario = FRM_secundario as Form;
                secundario.TopLevel = false;
                secundario.Dock = DockStyle.Fill;
                this._p_forms.Controls.Add(secundario);
                this._p_forms.Tag = secundario;

                secundario.Show();

                //SE CREA UN NUEVO EVENTO QUE DETECTA CUANDO SE CERRO EL FORMS SECUNDARIO//
                //secundario.FormClosing += new FormClosingEventHandler(Creacion_Actividad_Close);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo AbrirForms", "Ha ocurrido un error en 'Opciones Actividades'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar_Actividad()
        {
            try
            {
                //Limpiar_Equipos();

                List<CLS_Actividad> lista_actividad = new List<CLS_Actividad>();
                CLS_L_Actividad L_actividad = new CLS_L_Actividad();
                L_actividad.ObtenerActividades(ref lista_actividad, id_deporte);

                int i = 0;
                int x = panelact.Width;

                foreach (var actividad in lista_actividad)
                {
                    UC_boton_entidad btn = new UC_boton_entidad(actividad.IdActividad, actividad.Fecha, actividad.Hora, actividad.IdContricante_1, actividad.IdContricante_2, actividad.IdCategoria, actividad.IdUsuario, actividad.IdDeporte, actividad.IdTipo, actividad.IdTorneo, actividad.Nombre, x, 10);
                    btn.Top = 52 * i;
                    panelact.Controls.Add(btn);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Actividad", "Ha ocurrido un error en 'Opciones Actividades'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForms(new Creación_Actividades(id_deporte, id_u));
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnInsertar_Click", "Ha ocurrido un error en 'Opciones Actividades'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _p_forms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
