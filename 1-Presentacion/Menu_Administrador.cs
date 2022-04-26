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
    public partial class Menu_Administrador : Form
    {
        CLS_Usuario obj_usuario = new CLS_Usuario();
        public Menu_Administrador(ref CLS_Usuario usuario)
        {
            InitializeComponent();
            //VERIFICA SI EL ROL SE TRATA DE ADMINISTRADOR O DE USUARIO
            obj_usuario = usuario;
            if (usuario.Rol == 1) { 
                _lbl_usuario.Text = "Administrador";
                Agregar_BTN_Administrador();
            }
            else { 
                _lbl_usuario.Text = "Encargado";
                Agregar_BTN_Usuario();
            }
            _p_forms.Visible = false;
        }

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
            this.Dispose();
        }

        private void AbrirForms(object FRM_secundario) {
            //HACE INVISIBLE AL PICTURE BOX Y HACE VISIBLE AL PANEL DEL FORMS//
            pictureBox1.Visible = false;
            _p_forms.Visible = true;
            
            //SI EXISTE UN FORMS LO ELIMINA//
            if (this._p_forms.Controls.Count > 0) { this._p_forms.Controls.RemoveAt(0); }

            //INSTANCIA UN NUEVO FORMS Y LE COLOCA LAS PROPIEDADES//
            Form secundario = FRM_secundario as Form;
            secundario.TopLevel = false;
            secundario.Dock = DockStyle.Fill;

            //AGREGA EL FORMS AL PANEL DEL FORMS//
            this._p_forms.Controls.Add(secundario);
            this._p_forms.Tag = secundario;
            
            //MUESTRA EL FORMS//
            secundario.Show();
            
            //SE CREA UN NUEVO EVENTO QUE DETECTA CUANDO SE CERRO EL FORMS SECUNDARIO//
            secundario.FormClosing += new FormClosingEventHandler(Agregar_Usuario_Close);
        }
        //ESTE METODO SE EJECUTA CUANDO SE OPRIME EL BOTON VOLVER EN EL FORMS DE REGISTRAR USUARIO//
        private void Agregar_Usuario_Close(object sender, FormClosingEventArgs e)
        {
            _p_forms.Visible = false;
            pictureBox1.Visible = true;
        }
        //NETODO PARA GENERAR BOTONES DINAMICAMENTE//
        private void Agregar_BTN_Administrador() {
            //INSTANCIA UN NUEVO BOTON USUARIO Y LE COLOCA LAS PROPIEDADES//
            Button btn_usuarios = new Button();
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Text = "Usuarios";
            btn_usuarios.Width = 120;
            btn_usuarios.Height = 50;
            btn_usuarios.Top = (50 + 12) * 1;

            //INSTANCIA UN NUEVO BOTON DEPORTES Y LE COLOCA LAS PROPIEDADES
            Button btn_deportes = new Button();
            btn_deportes.Name = "btn_deportes";
            btn_deportes.Text = "Deportes";
            btn_deportes.Width = 120;
            btn_deportes.Height = 50;
            btn_deportes.Top = (50 + 12) * 2;


            //INSTANCIA UN NUEVO BOTON CATEGORIAS Y LE COLOCA LAS PROPIEDADES
            Button btn_categoria = new Button();
            btn_categoria.Name = "btn_categoria";
            btn_categoria.Text = "Categoria";
            btn_categoria.Width = 120;
            btn_categoria.Height = 50;
            btn_categoria.Top = (50 + 12) * 3;


            //GENERA UN NUEVO METEDO CUANDO SE DE CLICK AL BOTON USUARIO//
            btn_usuarios.Click += Btn_Usuarios_Click;
            btn_deportes.Click += Btn_Deportes_Click;
            btn_categoria.Click += Btn_Categoria_Click;

            //SE AGREGA EL BOTON USUARIO AL PANEL DE CONTROLES//
            _p_controles.Controls.Add(btn_usuarios);
            _p_controles.Controls.Add(btn_deportes);
            _p_controles.Controls.Add(btn_categoria);
        }

        //METODO GENERADO PARA LLAMARSE CADA VEZ QUE SE DE CLICK AL BOTON//
        private void Btn_Usuarios_Click(object sender, EventArgs e) {
            //ABRE EL FORMS DE OPCIONES_USUARIO//
            AbrirForms(new Opciones_Usuario());
        }
        private void Btn_Deportes_Click(object sender, EventArgs e) {
            //REALIZAR EL FORMS QUE PERMITIRA VISUALIZAR LOS DEPORTES//
            AbrirForms(new FRM_Deportes(obj_usuario.Id, obj_usuario.Usuario));
        }
        private void Btn_Equipos_Click(object sender, EventArgs e)
        {
            //ABRE EL FORMS DE OPCIONES_Equipo//
            AbrirForms(new Opciones_Equipo(obj_usuario.Id, obj_usuario.Usuario));
           
        }
        private void Btn_Categoria_Click(object sender, EventArgs e)
        {
            //ABRE EL FORMS DE OPCIONES_USUARIO//
            AbrirForms(new Categoria());
        }


        private void Btn_Integrantes_Click(object sender, EventArgs e)
        {
            //ABRE EL FORMS DE OPCIONES_Integrante//
            AbrirForms(new FRM_Integrantes());

        }
        private void Agregar_BTN_Usuario() {
            //REALIZAR LOS BOTONES FALTANTES PARA EL MENU DEL USUARIO//

            //INSTANCIA UN NUEVO BOTON EQUIPO Y LE COLOCA LAS PROPIEDADES//
            Button btn_Equipos = new Button();
            btn_Equipos.Name = "btn_Equipos";
            btn_Equipos.Text = "Equipos";
            btn_Equipos.Width = 120;
            btn_Equipos.Height = 50;
            btn_Equipos.Top = (50 + 12) * 1;

            //INSTANCIA UN NUEVO BOTON INTEGRANTES Y LE COLOCA LAS PROPIEDADES
            Button btn_integrantes = new Button();
            btn_integrantes.Name = "btn_Integrantes";
            btn_integrantes.Text = "Integrantes";
            btn_integrantes.Width = 120;
            btn_integrantes.Height = 50;
            btn_integrantes.Top = (50 + 12) * 2;

            //INSTANCIA UN NUEVO BOTON ACTIVIDAD Y LE COLOCA LAS PROPIEDADES
            Button btn_actividad = new Button();
            btn_actividad.Name = "btn_Actividad"; 
            btn_actividad.Text = "Actividad";
            btn_actividad.Width = 120;
            btn_actividad.Height = 50;
            btn_actividad.Top = (50 + 12) * 3;


            //GENERA UN NUEVO METEDO CUANDO SE DE CLICK AL BOTON USUARIO//
            btn_Equipos.Click += Btn_Equipos_Click;
            btn_integrantes.Click += Btn_Integrantes_Click;
            btn_actividad.Click += Btn_Actividad_Click;

            //SE AGREGA EL BOTON USUARIO AL PANEL DE CONTROLES//
            _p_controles.Controls.Add(btn_Equipos);
            _p_controles.Controls.Add(btn_integrantes);
            _p_controles.Controls.Add(btn_actividad);
        }

        private void Btn_Actividad_Click(object sender, EventArgs e)
        {
            //FALTA EL FORMS DE OPCIONES DE ACTVIDAD//
            AbrirForms(new Opciones_Actividades(obj_usuario.Deporte)); //AL FORMS SE LE PASA EL ID DEPORTE DEL USUARIO//
        }

        private void _p_controles_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
