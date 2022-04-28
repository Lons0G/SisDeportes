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
    public partial class Tipo_Act : Form
    {
        public Tipo_Act()
        {
            InitializeComponent();
        }

        private void btnRegistrarTipoAct_Click(object sender, EventArgs e)
        {
            CLS_TipoActividad obj_tipoActividad = new CLS_TipoActividad();

            CLS_L_Tipo l_Tipo = new CLS_L_Tipo();

            obj_tipoActividad.Nombre = txtnombreAct.Text;
            obj_tipoActividad.Descripcion = txtDescrip.Text;

            bool resultado = l_Tipo.Insertar_Tipo(ref obj_tipoActividad);

            if(resultado == true)
            {
                MessageBox.Show("Actividad Con Exito");
            }
            else
            {
                MessageBox.Show(obj_tipoActividad.Error);
            }




        }
    }
}
