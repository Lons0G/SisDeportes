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
    public partial class Opciones_Integrantes : Form
    {

        int id_equipo;
        int id_usuario;
        int id_categoria;
        int id_deporte;
        int id_entrenador;
        string nombre_equipo;
        bool visita;

        public Opciones_Integrantes(int idequipo, string nombre, int usuario, int categoria, int deporte, int entreandor, bool visitante)
        {
            try
            {
                InitializeComponent();
                id_equipo = idequipo;
                id_usuario = usuario;
                id_categoria = categoria;
                id_deporte = deporte;
                id_entrenador = entreandor;
                visita = visitante;
                nombre_equipo = nombre;
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Integrantes", "Ha ocurrido un error en 'Opciones Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                ////SE CREA UN NUEVO EVENTO QUE DETECTA CUANDO SE CERRO EL FORMS SECUNDARIO//
                //secundario.FormClosing += new FormClosingEventHandler(Agregar_Usuario_Close);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo AbrirForms", "Ha ocurrido un error en 'Opciones Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForms(new FRM_Integrantes(id_equipo, id_usuario, id_entrenador));
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnInsertar_Click", "Ha ocurrido un error en 'Opciones Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cargar_Integrantes()
        {
            try
            {
                List<CLS_Integrantes> lista_integrantes = new List<CLS_Integrantes>();
                CLS_L_Integrante L_integrante = new CLS_L_Integrante();
                L_integrante.ObtenerIntegrantes(ref lista_integrantes, id_equipo);

                int i = 0;
                int x = _p_integrantes.Width;

                foreach (var integrante in lista_integrantes)
                {
                    UC_boton_entidad btn = new UC_boton_entidad(integrante.IdIntegrante, integrante.IdEquipo, integrante.IdUsuario, integrante.IdEntrenador, integrante.Nombre, integrante.Apellido, integrante.Edad, integrante.Nacionalidad, integrante.Posicion, integrante.Dorsal, integrante.Rol, x, 6);
                    btn.Top = 52 * i;
                    _p_integrantes.Controls.Add(btn);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Integrantes", "Ha ocurrido un error en 'Opciones Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Opciones_Integrantes_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Integrantes();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Integrantes_Load", "Ha ocurrido un error en 'Opciones Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Opciones_Integrantes_Resize(object sender, EventArgs e)
        {
            try
            {
                foreach (UC_boton_entidad integrante in _p_integrantes.Controls)
                {
                    integrante.Width = _p_integrantes.Width - 20;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Opciones_Integrantes_Resize", "Ha ocurrido un error en 'Opciones Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _btn_editar_equipo_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForms(new Actualizar_Equipo(id_equipo, nombre_equipo, id_usuario, id_categoria, id_deporte, id_entrenador, visita));
            }
            catch
            {
                MessageBox.Show("Error en el Metodo _btn_editar_equipo_Click", "Ha ocurrido un error en 'Opciones Integrantes'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
