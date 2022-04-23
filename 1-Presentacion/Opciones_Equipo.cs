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
            if (this._p_forms2.Controls.Count > 0) { this._p_forms2.Controls.RemoveAt(0); }

            Form secundario = FRM_secundario as Form;
            secundario.TopLevel = false;
            secundario.Dock = DockStyle.Fill;
            this._p_forms2.Controls.Add(secundario);
            this._p_forms2.Tag = secundario;

            secundario.Show();

            ////SE CREA UN NUEVO EVENTO QUE DETECTA CUANDO SE CERRO EL FORMS SECUNDARIO//
            //secundario.FormClosing += new FormClosingEventHandler(Agregar_Usuario_Close);

        }


        private void Opciones_Equipo_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            AbrirForms(new Equipos(_id,_nome));
        }
    }
}
