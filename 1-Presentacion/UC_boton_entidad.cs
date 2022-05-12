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
        int v, ro; string n, ap, usu, pass, tel, corr,des;
        int dato_entidad;
        private void _lbl_nombre_entidad_Click(object sender, EventArgs e)
        {

        }

        decimal sue; //cree variables temporales
        Opciones_Usuario p;
        Menu_Administrador m_a;
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
        //CONSTRUCTOR PARA EQUIPOS
        bool visita;int id_usuario, id_categoria, id_deporte,id_entrenador;
        public UC_boton_entidad(int id, string nombre,bool visitante,int id_usu,int id_cate,int id_depo,int id_entre, int x, int dato, Menu_Administrador form) {
            InitializeComponent();
            dato_entidad = dato;
            m_a = form;
            v = id;
            n = nombre;
            id_usuario = id_usu;
            id_categoria = id_cate;
            id_deporte = id_depo;
            id_entrenador = id_entre;
            visita = visitante;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            this.Width = x - 10;
            this.Height = 50;
            this.Name = id.ToString();
            _lbl_nombre_entidad.Text = nombre;
        }
        //CONSTRUCTOR PARA LAS DEMAS ENTIDADES
        int id_2;string nom;
        public UC_boton_entidad(int id, string nombre, int x, int dato)
        {
            InitializeComponent();
            dato_entidad = dato;
            v = id;
            nom = nombre;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            this.Width = x - 10;
            this.Height = 50;
            this.Name = id.ToString();
            _lbl_nombre_entidad.Text = nombre;
        }
        //constructor para tipos de actividades
        public UC_boton_entidad(int id, string nombre, string descripcion, int x, int dato)
        {
            InitializeComponent();
            dato_entidad = dato;
            v = id;
            nom = nombre;
            des = descripcion;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.Width = x - 10;
            this.Height = 50;
            this.Name = id.ToString();
            _lbl_nombre_entidad.Text = nombre;
        }
        //constructor para integrantes
        byte eda;int equi,dor;string nacional,pos,rol3;
        public UC_boton_entidad(int id,int idequi,int idusu,int identre, string nombre,string apellido,byte edad, string naciona, string posi,int dorsal,string rol, int x, int dato)
        {
            InitializeComponent();
            dato_entidad = dato;
            v = id;
            equi = idequi;
            id_usua = idusu;
            id_entrenador = identre;
            nom = nombre;
            ap = apellido;
            eda = edad;
            nacional = naciona;
            pos = posi;
            dor = dorsal;
            rol3 = rol;
            
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.Width = x - 10;
            this.Height = 50;
            this.Name = id.ToString();
            _lbl_nombre_entidad.Text = nombre;
        }
        //constructor para actualizar torneos
        DateTime fecha;
        int id_categ, id_usua, id_tipo,id_depo;
        public UC_boton_entidad(int id,DateTime fech, int id_cate,int idusu, int id_tip,string nombre,int id_d, int x, int dato)
        {
            InitializeComponent();
            dato_entidad = dato;
            v = id;
            fecha = fech;
            id_categ = id_cate;
            id_usua=idusu;
            id_tipo = id_tip;
            nom = nombre;
            id_depo = id_d;

            this.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.Width = x - 10;
            this.Height = 50;
            this.Name = id.ToString();
            _lbl_nombre_entidad.Text = nombre;
        }
        //constructor para Actividad
        DateTime hora;int id_con1, id_con2,id_torneo;string nombreTipo;
        public UC_boton_entidad(int id,DateTime fech,DateTime hor,int id_c1,int id_c2,int id_catego,int id_usu,int id_depo,int id_tip,int id_torn,string nombre, int x, int dato)
        {
            InitializeComponent();
            dato_entidad = dato;
            v = id;
            fecha = fech;
            hora = hor;
            id_con1 = id_c1;
            id_con2 = id_c2;
            id_categ = id_catego;
            id_usuario = id_usu;
            id_deporte = id_depo;
            id_tipo = id_tip;
            id_torneo = id_torn;
            nom = nombre;

            this.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.Width = x - 10;
            this.Height = 50;
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
                        else { MessageBox.Show(obj_usuario.Error); }
                    }
                    p.Cargar_Usuarios();
                    break;
                //CASO PARA TORNEO
                case 2:
                    MessageBoxButtons btn_torneo = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_torneo = MessageBox.Show("¿Deseas Eliminar este Torneo?", "Eliminar", btn_torneo, MessageBoxIcon.Question);

                    if (dr_torneo == DialogResult.Yes)
                    {
                        CLS_Torneo obj_torneo = new CLS_Torneo();
                        CLS_L_Torneo L_torneo = new CLS_L_Torneo();
                        obj_torneo.IdTorneo = v; //recibe el valor del id y lo elimina
                        bool resultado = L_torneo.Eliminar_Torneo(ref obj_torneo);

                        if (resultado == true) { MessageBox.Show("Torneo Eliminado Correctamente", "Torneo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show(obj_torneo.Error); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA TIPO DEPORTE
                case 3:
                    MessageBoxButtons btn_tipodeporte = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_tipodeporte = MessageBox.Show("¿Deseas Eliminar este Tipo de Deporte?", "Eliminar", btn_tipodeporte, MessageBoxIcon.Question);

                    if (dr_tipodeporte == DialogResult.Yes)
                    {
                        CLS_TipoDeporte obj_tipodeporte = new CLS_TipoDeporte();
                        CLS_L_TipoDeporte L_tipodeporte = new CLS_L_TipoDeporte();
                        obj_tipodeporte.IdTipoDeporte = v; //recibe el valor del id y lo elimina
                        bool resultado = false;// = L_tipodeporte.(ref obj_tipodeporte);

                        if (resultado == true) { MessageBox.Show("Tipo de deporte Eliminado Correctamente", "Tipo Deporte Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show(obj_tipodeporte.Error); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA TIPO
                case 4:
                    MessageBoxButtons btn_tipo = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_tipo = MessageBox.Show("¿Deseas Eliminar este Tipo de Actividad?", "Eliminar", btn_tipo, MessageBoxIcon.Question);

                    if (dr_tipo == DialogResult.Yes)
                    {
                        CLS_TipoActividad obj_tipoActividad = new CLS_TipoActividad();
                        CLS_L_Tipo l_Tipo = new CLS_L_Tipo();
                        obj_tipoActividad.IdTipo = v; //recibe el valor del id y lo elimina
                        bool resultado = l_Tipo.Eliminar_Tipo(ref obj_tipoActividad);// = L_tipodeporte.(ref obj_tipodeporte);

                        if (resultado == true) 
                        { 
                            MessageBox.Show("Tipo de Actividad Eliminado Correctamente", "Tipo Act Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        }
                        else 
                        {
                            MessageBox.Show(obj_tipoActividad.Error);
                        }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA ROLES
                case 5:
                    MessageBoxButtons btn_roles = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_roles = MessageBox.Show("¿Deseas Eliminar este Rol?", "Eliminar", btn_roles, MessageBoxIcon.Question);

                    if (dr_roles == DialogResult.Yes)
                    {
                        CLS_Rol obj_torneo = new CLS_Rol();
                        //CLS_L_Rol L_torneo = new CLS_L_Torneo(); <- REALIZAR LA LOGICA DEL ROL
                        //obj_torneo.IdTorneo = v; //recibe el valor del id y lo elimina
                        bool resultado = false; //L_torneo.Eliminar_Torneo(ref obj_torneo);

                        if (resultado == true) { MessageBox.Show("Rol Eliminado Correctamente", "Rol Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show(obj_torneo.Error); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA INTEGRANTE
                case 6:
                    MessageBoxButtons btn_integrante = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_integrante = MessageBox.Show("¿Deseas Eliminar este Intregrante?", "Eliminar", btn_integrante, MessageBoxIcon.Question);

                    if (dr_integrante == DialogResult.Yes)
                    {
                        CLS_Integrantes obj_integrante = new CLS_Integrantes();
                        CLS_L_Integrante L_integrante = new CLS_L_Integrante();
                        obj_integrante.IdIntegrante = v; //recibe el valor del id y lo elimina
                        bool resultado = L_integrante.Eliminar_Integrante(ref obj_integrante);

                        if (resultado == true) { MessageBox.Show("Integrante Eliminado Correctamente", "Integrante Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show(obj_integrante.Error); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA EQUIPO
                case 7:
                    MessageBoxButtons btn_equipo = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_equipo = MessageBox.Show("¿Deseas Eliminar este Equipo?", "Eliminar", btn_equipo, MessageBoxIcon.Question);

                    if (dr_equipo == DialogResult.Yes)
                    {
                        CLS_Equipo obj_equipo = new CLS_Equipo();
                        CLS_L_Equipo L_equipo = new CLS_L_Equipo();
                        obj_equipo.IdEquipo = v; //recibe el valor del id y lo elimina
                        bool resultado = L_equipo.Eliminar_Equipo(ref obj_equipo);

                        if (resultado == true) { MessageBox.Show("Equipo Eliminado Correctamente", "Equipo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show(obj_equipo.Error); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA DEPORTE
                case 8:
                    MessageBoxButtons btn_deportes = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_deportes = MessageBox.Show("¿Deseas Eliminar este Deporte?", "Eliminar", btn_deportes, MessageBoxIcon.Question);

                    if (dr_deportes == DialogResult.Yes)
                    {
                        CLS_Deporte obj_deporte = new CLS_Deporte();
                        CLS_L_Deporte L_deporte = new CLS_L_Deporte();
                        obj_deporte.IdDeporte = v; //recibe el valor del id y lo elimina
                        bool resultado = L_deporte.Eliminar_Deporte(ref obj_deporte);

                        if (resultado == true) { MessageBox.Show("Deporte Eliminado Correctamente", "Deporte Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show(obj_deporte.Error); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA CATEGORIA
                case 9:
                    MessageBoxButtons btn_categoria = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_categoria = MessageBox.Show("¿Deseas Eliminar esta Categoria?", "Eliminar", btn_categoria, MessageBoxIcon.Question);

                    if (dr_categoria == DialogResult.Yes)
                    {
                        CLS_Categoria obj_categoria = new CLS_Categoria();
                        CLS_L_Categoria L_categoria = new CLS_L_Categoria();
                        obj_categoria.IdCategoria = v; //recibe el valor del id y lo elimina
                        bool resultado = L_categoria.Eliminar_Categoria(ref obj_categoria);

                        if (resultado == true) { MessageBox.Show("Categoria Eliminado Correctamente", "Categoria Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show(obj_categoria.Error); }
                    }
                    //p.Cargar_Usuarios();
                    break;
                //CASO PARA ACTIVIDAD
                case 10:
                    MessageBoxButtons btn_actividad = MessageBoxButtons.YesNoCancel;
                    DialogResult dr_actividad = MessageBox.Show("¿Deseas Eliminar este Actividad?", "Eliminar", btn_actividad, MessageBoxIcon.Question);

                    if (dr_actividad == DialogResult.Yes)
                    {
                        CLS_Actividad obj_actividad = new CLS_Actividad();
                        CLS_L_Actividad L_actividad = new CLS_L_Actividad();
                        obj_actividad.IdActividad = v; //recibe el valor del id y lo elimina
                        bool resultado = L_actividad.Eliminar_Actividad(ref obj_actividad);

                        if (resultado == true) { MessageBox.Show("Actividad Eliminado Correctamente", "Actividad Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show(obj_actividad.Error); }
                    }
                    //p.Cargar_Usuarios();
                    break;
            }
        }

        private void _btn_editar_Click(object sender, EventArgs e)
        {
            switch(dato_entidad)
            {
                case 1:
                    Actualizar_Usuario actualizar = new Actualizar_Usuario();
                    actualizar.Show();

                    actualizar.RecibeDatos(v, n, ap, usu, pass, tel, corr, sue, ro); //envia los datos al metodo que esta en actualizar usuario
                    break;
                case 2:
                    Actualizar_Torneos torneos = new Actualizar_Torneos(v,fecha,id_categ,id_usua,id_tipo,nom,id_depo);
                    torneos.Show();
                    break;
                case 3:
                    MessageBox.Show(dato_entidad.ToString());
                    break;
                case 4:
                    Actualizar_Tipo_Act tipo = new Actualizar_Tipo_Act();
                    tipo.Show();
                    tipo.recibe(v, nom, des);
                    break;
                case 5:
                    MessageBox.Show(dato_entidad.ToString());
                    break;
                case 6:
                    Actuzalizar_Integrantes integrantes = new Actuzalizar_Integrantes();
                    integrantes.Show();
                    integrantes.Recibir_Da(v,equi,id_usua,id_entrenador,nom,ap,eda,nacional,pos,dor,rol3);
                    break;
                case 7:
                    /*Actualizar_Equipo actualizarEquipo = new Actualizar_Equipo();
                    actualizarEquipo.Show();
                    actualizarEquipo.recibe(v, n, visita,id_usu,id_depo,id_cate,id_entre);*/

                    //ABRE EL FORMS DE OPCIONES_Integrante//
                    m_a.AbrirForms(new Opciones_Integrantes(v, n, id_usuario, id_categoria, id_deporte, id_entrenador, visita));
                    break;
                case 8:
                    MessageBox.Show(dato_entidad.ToString());
                    break;
                case 9:
                    MessageBox.Show(dato_entidad.ToString());
                    break;
                case 10:
                    Actualizar_Actividad actualizarAct = new Actualizar_Actividad(v,fecha,hora,id_con1,id_con2,id_categ,id_usuario,id_deporte,id_tipo,id_torneo,nom);
                    actualizarAct.Show();
                    break;
            }
           
        }
    }
}
