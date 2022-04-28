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

        /// LISTA PARA LA SELECCION DEL SWITCH
        /// 1- Usuario
        /// 2- Torneo
        /// 3- Tipo Deporte
        /// 4- Tipo
        /// 5- Roles
        /// 6- Integrante
        /// 7- Equipo 
        /// 8- Deporte
        /// 9- Categoria
        /// 10- Actividad
        /// 
        int v, ro; string n, ap, usu, pass, tel, corr;
        int dato_entidad;
        private void _lbl_nombre_entidad_Click(object sender, EventArgs e)
        {

        }

        decimal sue; //cree variables temporales
        Opciones_Usuario p;
        //CONSTRUCTOR PARA USUARIOS
        public UC_boton_entidad(int Id, string nombre, string apellido, string usuario, string password, string telefono, string correo, decimal sueldo, int rol , Opciones_Usuario op_user, int x, int dato)
        {
            InitializeComponent();
            dato_entidad = dato;
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
        //CONSTRUCTOR PARA EQUIPOS, TORNEOS
        public UC_boton_entidad(int id, string nombre, int x, int dato) {
            InitializeComponent();
            dato_entidad = dato;
            v = id;
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
            switch (dato_entidad) {
                //CASO PARA USUARIO
                case 1:
                    MessageBoxButtons btn_usuario = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_usuario = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_usuario, MessageBoxIcon.Question);

                    if (dr_usuario == DialogResult.Yes) {
                        CLS_Usuario obj_usuario = new CLS_Usuario();
                        CLS_L_Usuarios L_Usuario = new CLS_L_Usuarios();
                        obj_usuario.Id = v; //recibe el valor del id y lo elimina
                        bool resultado = L_Usuario.Eliminar_Usuario(ref obj_usuario);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    p.Cargar_Usuarios();
                    break;
                //CASO PARA TORNEO
                case 2:
                    MessageBoxButtons btn_torneo = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_torneo = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_torneo, MessageBoxIcon.Question);

                    if (dr_torneo == DialogResult.Yes)
                    {
                        CLS_Torneo obj_torneo = new CLS_Torneo();
                        CLS_L_Torneo L_torneo = new CLS_L_Torneo();
                        obj_torneo.IdTorneo = v; //recibe el valor del id y lo elimina
                        bool resultado = L_torneo.Eliminar_Torneo(ref obj_torneo);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA TIPO DEPORTE
                case 3:
                    MessageBoxButtons btn_tipodeporte = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_tipodeporte = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_tipodeporte, MessageBoxIcon.Question);

                    if (dr_tipodeporte == DialogResult.Yes)
                    {
                        CLS_TipoDeporte obj_tipodeporte = new CLS_TipoDeporte();
                        CLS_L_TipoDeporte L_tipodeporte = new CLS_L_TipoDeporte();
                        obj_tipodeporte.IdTipoDeporte = v; //recibe el valor del id y lo elimina
                        bool resultado = false;// = L_tipodeporte.(ref obj_tipodeporte);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA TIPO
                case 4:
                    MessageBoxButtons btn_tipo = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_tipo = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_tipo, MessageBoxIcon.Question);

                    if (dr_tipo == DialogResult.Yes)
                    {
                        CLS_TipoActividad obj_tipo = new CLS_TipoActividad();
                        CLS_L_Tipo L_tipo = new CLS_L_Tipo();
                        obj_tipo.IdTipo = v; //recibe el valor del id y lo elimina
                        bool resultado = false;// = L_tipodeporte.(ref obj_tipodeporte);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA ROLES
                case 5:
                    MessageBoxButtons btn_roles = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_roles = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_roles, MessageBoxIcon.Question);

                    if (dr_roles == DialogResult.Yes)
                    {
                        CLS_Rol obj_torneo = new CLS_Rol();
                        //CLS_L_Rol L_torneo = new CLS_L_Torneo(); <- REALIZAR LA LOGICA DEL ROL
                        //obj_torneo.IdTorneo = v; //recibe el valor del id y lo elimina
                        bool resultado = false; //L_torneo.Eliminar_Torneo(ref obj_torneo);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA INTEGRANTE
                case 6:
                    MessageBoxButtons btn_integrante = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_integrante = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_integrante, MessageBoxIcon.Question);

                    if (dr_integrante == DialogResult.Yes)
                    {
                        CLS_Integrantes obj_integrante = new CLS_Integrantes();
                        CLS_L_Integrante L_integrante = new CLS_L_Integrante();
                        obj_integrante.IdIntegrante = v; //recibe el valor del id y lo elimina
                        bool resultado = L_integrante.Eliminar_Integrante(ref obj_integrante);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA EQUIPO
                case 7:
                    MessageBoxButtons btn_equipo = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_equipo = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_equipo, MessageBoxIcon.Question);

                    if (dr_equipo == DialogResult.Yes)
                    {
                        CLS_Equipo obj_equipo = new CLS_Equipo();
                        CLS_L_Equipo L_equipo = new CLS_L_Equipo();
                        obj_equipo.IdEquipo = v; //recibe el valor del id y lo elimina
                        bool resultado = L_equipo.Eliminar_Equipo(ref obj_equipo);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA DEPORTE
                case 8:
                    MessageBoxButtons btn_deportes = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_deportes = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_deportes, MessageBoxIcon.Question);

                    if (dr_deportes == DialogResult.Yes)
                    {
                        CLS_Deporte obj_deporte = new CLS_Deporte();
                        CLS_L_Deporte L_deporte = new CLS_L_Deporte();
                        obj_deporte.IdDeporte = v; //recibe el valor del id y lo elimina
                        bool resultado = L_deporte.Eliminar_Deporte(ref obj_deporte);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA CATEGORIA
                case 9:
                    MessageBoxButtons btn_categoria = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_categoria = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_categoria, MessageBoxIcon.Question);

                    if (dr_categoria == DialogResult.Yes)
                    {
                        CLS_Categoria obj_categoria = new CLS_Categoria();
                        CLS_L_Categoria L_categoria = new CLS_L_Categoria();
                        obj_categoria.IdCategoria = v; //recibe el valor del id y lo elimina
                        bool resultado = L_categoria.Eliminar_Categoria(ref obj_categoria);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA ACTIVIDAD
                case 10:
                    MessageBoxButtons btn_actividad = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_actividad = MessageBox.Show("¿Deseas Eliminar este usuario?", "Eliminar", btn_actividad, MessageBoxIcon.Question);

                    if (dr_actividad == DialogResult.Yes)
                    {
                        CLS_Actividad obj_actividad = new CLS_Actividad();
                        CLS_L_Actividad L_actividad = new CLS_L_Actividad();
                        obj_actividad.IdActividad = v; //recibe el valor del id y lo elimina
                        bool resultado = L_actividad.Eliminar_Actividad(ref obj_actividad);

                        if (resultado == true) { MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("error"); }
                    }
                    //p.Cargar_Usuarios();
                    break;
            }
        }

        private void _btn_editar_Click(object sender, EventArgs e)
        {
            Actualizar_Usuario actualizar = new Actualizar_Usuario();
            actualizar.Show();

            actualizar.RecibeDatos(v, n, ap, usu, pass, tel, corr, sue, ro); //envia los datos al metodo que esta en actualizar usuario
        }
    }
}
