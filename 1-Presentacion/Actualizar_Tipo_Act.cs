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
    public partial class Actualizar_Tipo_Act : Form
    {
        public Actualizar_Tipo_Act()
        {
            InitializeComponent();
        }
        
        int id;
        string nombre, descripcion;
        public void recibe(int id_, string nom, string descrip)
        {
            id = id_;
            nombre = nom;
            descripcion = descrip;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CLS_TipoActividad obj_tipoActividad = new CLS_TipoActividad();
            CLS_L_Tipo l_Tipo = new CLS_L_Tipo();

            obj_tipoActividad.IdTipo = id;
            obj_tipoActividad.Nombre = txtnombreAct.Text;
            obj_tipoActividad.Descripcion = txtDescrip.Text;

            bool resultado = l_Tipo.Editar_Tipo(ref obj_tipoActividad);

            if (resultado == true)
            {
                MessageBox.Show("Tipo de Actividad Actualizada con Exito!");
            }
            else
            {
                MessageBox.Show(obj_tipoActividad.Error);
            }

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            lbl_id.Text = id.ToString();
            txtnombreAct.Text = nombre;
            txtDescrip.Text = descripcion;
        }
        private void Actualizar_Tipo_Act_Load(object sender, EventArgs e)
        {
           
        }
    }
}
