using _2_Logica;
using _3_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Presentacion
{
    public partial class Opciones_Torneo : Form
    {
        int usu, _id;
        public Opciones_Torneo(int id,int id_usu)
        {
            try
            {
                InitializeComponent();
                //cate = categoria;
                _id = id;
                usu = id_usu;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Torneo", "Ha ocurrido un error en 'Opciones Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error en el Metodo AbrirForms", "Ha ocurrido un error en 'Opciones Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar_Torneos()
        {
            try
            {
                Limpiar_Torneos();

                List<CLS_Torneo> lista_torneos = new List<CLS_Torneo>();
                CLS_L_Torneo L_torneo = new CLS_L_Torneo();
                L_torneo.ObtenerTorneos(ref lista_torneos);

                int i = 0;
                int x = _p_torneos.Width;

                foreach (var torneo in lista_torneos)
                {
                    UC_boton_entidad btn = new UC_boton_entidad(torneo.IdTorneo, torneo.Fecha, torneo.IdCategoria, torneo.IdUsuario, torneo.IdTipo, torneo.Nombre, torneo.IdDeporte, x, 2);
                    btn.Top = 52 * i;
                    _p_torneos.Controls.Add(btn);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Torneos", "Ha ocurrido un error en 'Opciones Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void Limpiar_Torneos()
        {
            try
            {
                if (_p_torneos.Controls.Count > 0) { _p_torneos.Controls.Clear(); }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Limpiar_Torneos", "Ha ocurrido un error en 'Opciones Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _p_forms2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Opciones_Torneo_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Torneos();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Torneo_Load", "Ha ocurrido un error en 'Opciones Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertarTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForms(new Torneo(usu, _id));
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnInsertarTorneo_Click", "Ha ocurrido un error en 'Opciones Torneo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
