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
        public Opciones_Integrantes()
        {
            InitializeComponent();
        }

        private void _p_forms_Paint(object sender, PaintEventArgs e)
        {

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
        //public void Cargar_Integrantes()
        //{

        //    List<CLS_Torneo> lista_torneos = new List<CLS_Torneo>();
        //    CLS_L_Torneo L_torneo = new CLS_L_Torneo();
        //    L_torneo.ObtenerTorneos(ref lista_torneos);

        //    int i = 0;
        //    int x = _p_torneos.Width;

        //    foreach (var torneo in lista_torneos)
        //    {
        //        UC_boton_entidad btn = new UC_boton_entidad(torneo.IdTorneo, torneo.Nombre, x, 2);
        //        btn.Top = 52 * i;
        //        _p_torneos.Controls.Add(btn);
        //        i++;
        //    }

        //}
        private void Opciones_Integrantes_Load(object sender, EventArgs e)
        {

        }
    }
}
