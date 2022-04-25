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
    public partial class UC_boton_entidad : UserControl
    {
        /// <summary>
        /// 1- REALIZAR QUE OBTENGA LOS ATRIBUTOS DE LAS ENTIDADES
        /// ID, NOMBRE
        /// 2- REALIZAR LOS METODOS CORRESPONDIENTES A SUS BOTONES
        /// ACTUALIZAR Y ELIMINAR
        /// </summary>
        /// 
        int v, ro; string n, ap, usu, pass, tel, corr;

        private void _lbl_nombre_entidad_Click(object sender, EventArgs e)
        {

        }

        decimal sue; //cree variables temporales
        Opciones_Usuario p;
        public UC_boton_entidad(int Id, string nombre, string apellido, string usuario, string password, string telefono, string correo, decimal sueldo, int rol , Opciones_Usuario op_user, int x)
        {
            InitializeComponent();
            this.Width = x - 10;
            this.Height = 50;
            this.Anchor = AnchorStyles.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            this.Name = Id.ToString();
            _lbl_nombre_entidad.Text = nombre + " " + apellido;
            p = op_user;
            v = Id; //envia el id y lo guarda en una variable temporal
            n = nombre;
            ap = apellido;
            usu = usuario; //almacema todos los valores y se los asigna
            pass = password;
            tel = telefono;
            corr = correo;
            sue = sueldo;
            ro = rol;
            //this.Location = new Point(20, 20);
        }

        public UC_boton_entidad(int id, string nombre, int x) {
            InitializeComponent();
            this.Width = x - 10;
            this.Height = 50;
            this.Anchor = AnchorStyles.None;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            this.Name = id.ToString();
            _lbl_nombre_entidad.Text = nombre;
        }
        //SOLUCIONAR BUG SOBRE LAS DIFERENTES ENTIDADES
        private void _btn_eliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;

            DialogResult dr = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", botones, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                CLS_Usuario obj_usuario = new CLS_Usuario();

                CLS_L_Usuarios L_Usuario = new CLS_L_Usuarios();

                obj_usuario.Id = v; //recibe el valor del id y lo elimina

                bool resultado = L_Usuario.Eliminar_Usuario(ref obj_usuario);

                if (resultado == true)
                {

                    MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            p.Cargar_Usuarios();
        }

        private void _btn_editar_Click(object sender, EventArgs e)
        {
            Actualizar_Usuario actualizar = new Actualizar_Usuario();
            actualizar.Show();

            actualizar.RecibeDatos(v, n, ap, usu, pass, tel, corr, sue, ro); //envia los datos al metodo que esta en actualizar usuario
        }
    }
}
