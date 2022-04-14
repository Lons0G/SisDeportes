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
    public partial class UC_boton_entidad : UserControl
    {
        /// <summary>
        /// 1- REALIZAR QUE OBTENGA LOS ATRIBUTOS DE LAS ENTIDADES
        /// ID, NOMBRE
        /// 2- REALIZAR LOS METODOS CORRESPONDIENTES A SUS BOTONES
        /// ACTUALIZAR Y ELIMINAR
        /// </summary>
        public UC_boton_entidad(int Id, string nombre, string apellido)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            this.Name = Id.ToString();
            _lbl_nombre_entidad.Text = nombre + " " + apellido;
            //this.Location = new Point(20, 20);
        }

        private void _btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
