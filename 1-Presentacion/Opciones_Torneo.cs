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
            InitializeComponent();
            //cate = categoria;
            _id = id;
            usu = id_usu;
            
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
        public void Cargar_Torneos()
        {
            Limpiar_Torneos();

            List<CLS_Torneo> lista_torneos = new List<CLS_Torneo>();
            CLS_L_Torneo L_torneo = new CLS_L_Torneo();
            L_torneo.ObtenerTorneos(ref lista_torneos);

            int i = 0;
            int x = _p_torneos.Width;

            foreach (var torneo in lista_torneos)
            {
                UC_boton_entidad btn = new UC_boton_entidad(torneo.IdTorneo, torneo.Fecha, torneo.IdCategoria, torneo.IdUsuario, torneo.IdTipo, torneo.Nombre,torneo.IdDeporte, x, 2);
                btn.Top = 52 * i;
                _p_torneos.Controls.Add(btn);
                i++;
            }

        }
        //public void Cargar()
        //{
        //    Limpiar_Torneos();

        //    List<CLS_Torneo> lista_torneos = new List<CLS_Torneo>();
        //    CLS_L_Torneo L_torneo = new CLS_L_Torneo();
        //    L_torneo.ObtenerTorneos(ref lista_torneos);

        //    int i = 0;
        //    int x = _p_torneos.Width;

        //    foreach (var torneo in lista_torneos)
        //    {
        //        UC_boton_entidad btn = new UC_boton_entidad(torneo.IdTorneo,torneo.Fecha,torneo.IdCategoria,torneo.IdUsuario,torneo.IdTipo, torneo.Nombre, x, 2);
        //        btn.Top = 52 * i;
        //        _p_torneos.Controls.Add(btn);
        //        i++;
        //    }

        //}
        private void Limpiar_Torneos()
        {
            if (_p_torneos.Controls.Count > 0) { _p_torneos.Controls.Clear(); }
        }
        private void _p_forms2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Opciones_Torneo_Load(object sender, EventArgs e)
        {
            Cargar_Torneos();
        }

        private void btnInsertarTorneo_Click(object sender, EventArgs e)
        {
            AbrirForms(new Torneo(usu, _id)) ;
        }
    }
}
