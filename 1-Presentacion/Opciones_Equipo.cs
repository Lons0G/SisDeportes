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
    public partial class Opciones_Equipo : Form
    {
        private int _id,id_de;
        private string _nome;
        Menu_Administrador m_a;
        public Opciones_Equipo(int Id, string Nombre,int iddepor, Menu_Administrador form)
        {
            try
            {
                InitializeComponent();
                _id = Id;
                _nome = Nombre;
                id_de = iddepor;
                m_a = form;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Equipo", "Ha ocurrido un error en 'Opciones Equipo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error en el Metodo AbrirForms", "Ha ocurrido un error en 'Opciones Equipo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar_Equipos(int id)
        {
            try
            {
                Limpiar_Equipos();

                List<CLS_Equipo> lista_equipos = new List<CLS_Equipo>();
                CLS_L_Equipo L_equipo = new CLS_L_Equipo();
                L_equipo.ObtenerEquipos(ref lista_equipos, id);

                int i = 0;
                int x = _p_equipos.Width;

                foreach (var equipo in lista_equipos)
                {
                    UC_boton_entidad btn = new UC_boton_entidad(equipo.IdEquipo, equipo.Nombre, equipo.Visitante, equipo.IdUsuario, equipo.IdCategoria, equipo.IdDeporte, equipo.IdEntrenador, x, 7, m_a);
                    btn.Top = 52 * i;
                    _p_equipos.Controls.Add(btn);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Equipos", "Ha ocurrido un error en 'Opciones Equipo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar_Equipos()
        {
            try
            {
                if (_p_equipos.Controls.Count > 0) { _p_equipos.Controls.Clear(); }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Limpiar_Equipos", "Ha ocurrido un error en 'Opciones Equipo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Opciones_Equipo_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Equipos(_id);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Equipo_Load", "Ha ocurrido un error en 'Opciones Equipo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _p_equipos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForms(new Equipos(_id, _nome, id_de));
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnInsertarEquipo_Click", "Ha ocurrido un error en 'Opciones Equipo'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
