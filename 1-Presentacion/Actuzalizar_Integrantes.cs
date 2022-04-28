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
    public partial class Actuzalizar_Integrantes : Form
    {
        public Actuzalizar_Integrantes()
        {
            InitializeComponent();
        }
        int id, ed; string nom, ape, nac, pos,dor;

        public void Recibir_Da(int i,string no,string ap,int e,string na,string po,string d)
        {
            id= i;
            nom= no; 
            ape= ap; 
            nac= na; 
            dor= d;
            ed= e;
            pos= po;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.lbID.Text=id.ToString();
            this.LbNombre.Text = nom;
            this.LbApellido.Text = ape;
            this.LbEdad.Text=ed.ToString();
            this.LbNacionalidad.Text=nac;
            this.LbPosicion.Text=pos;
            this.LbDorsal.Text=dor;

            if (this.LbPosicion.Text=="")
            {
                this.TxtDorsal.Enabled = false;
                this.TxtPosicion.Enabled=false;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CLS_Integrantes obj_Integrante = new CLS_Integrantes();
            CLS_L_Integrante log_Integrante = new CLS_L_Integrante();

            obj_Integrante.IdIntegrante = Convert.ToInt32(this.lbID.Text);
            obj_Integrante.Nombre = this.TxtNombre.Text;
            obj_Integrante.Apellido = this.TxtApell.Text;
            obj_Integrante.Edad = Convert.ToByte(this.TxtEdad.Text);
            obj_Integrante.Nacionalidad = this.TxtNacionalidad.Text;
            obj_Integrante.Posicion = this.TxtPosicion.Text;
            obj_Integrante.Dorsal= this.TxtDorsal.Text;

            bool resultado = log_Integrante.Editar_Integrante(ref obj_Integrante);

            if (resultado == true)
            {
                MessageBox.Show("Se a actualizado correctamente el integrante del equipo", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos No Actualizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
