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
            InitializeComponent();
            id_equipo = idequipo;
            id_usuario = usuario;
            id_categoria = categoria;
            id_deporte = deporte;
            id_entrenador = entreandor;
            visita = visitante;
            nombre_equipo = nombre;
        }

        private void AbrirForms(object FRM_secundario)
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
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            AbrirForms(new FRM_Integrantes());
        }
        private void Cargar_Integrantes() {
            List<CLS_Integrantes> lista_integrantes = new List<CLS_Integrantes>();
            CLS_L_Integrante L_integrante = new CLS_L_Integrante();
            L_integrante.ObtenerIntegrantes(ref lista_integrantes, id_equipo);

            int i = 0;
            int x = _p_integrantes.Width;

            foreach (var integrante in lista_integrantes)
            {
                UC_boton_entidad btn = new UC_boton_entidad(integrante.IdIntegrante, integrante.Nombre, x, 2);
                btn.Top = 52 * i;
                _p_integrantes.Controls.Add(btn);
                i++;
            }

        }
        private void Opciones_Integrantes_Load(object sender, EventArgs e) {
            Cargar_Integrantes();
        }

        private void Opciones_Integrantes_Resize(object sender, EventArgs e)
        {
            foreach (UC_boton_entidad integrante in _p_integrantes.Controls) {
                integrante.Width = _p_integrantes.Width - 20;
            }
        }

        private void _btn_editar_equipo_Click(object sender, EventArgs e)
        {
            AbrirForms(new Actualizar_Equipo(id_equipo, nombre_equipo, id_usuario, id_categoria, id_deporte, id_entrenador, visita));
        }
    }
}
