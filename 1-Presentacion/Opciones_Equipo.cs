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
        private int _id;
        private string _nome;
        public Opciones_Equipo(int Id, string Nombre)
        {
            _id = Id;
            _nome = Nombre;
            InitializeComponent();
        }
        private void AbrirForms(object FRM_secundario)
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
        public void Cargar_Equipos(int id)
        {
            Limpiar_Equipos();

            List<CLS_Equipo> lista_equipos = new List<CLS_Equipo>();
            CLS_L_Equipo L_equipo = new CLS_L_Equipo();
            L_equipo.ObtenerEquipos(ref lista_equipos, id);

            int i = 0;
            int x = _p_equipos.Width;

            foreach (var equipo in lista_equipos) {
                UC_boton_entidad btn = new UC_boton_entidad(equipo.IdEquipo, equipo.Nombre, x, 7);
                btn.Top = 52 * i;
                _p_equipos.Controls.Add(btn);
                i++;
            }

        }

        private void Limpiar_Equipos()
        {
            if (_p_equipos.Controls.Count > 0) { _p_equipos.Controls.Clear(); }
        }

        private void Opciones_Equipo_Load(object sender, EventArgs e)
        {
            Cargar_Equipos(_id);
        }

        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            AbrirForms(new Equipos(_id,_nome));
        }
    }
}
