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
        public Menu_Administrador(int rol)
        {
            InitializeComponent();
            //VERIFICA SI EL ROL SE TRATA DE ADMINISTRADOR O DE USUARIO
            if (rol == 1) { 
                _lbl_usuario.Text = "Administrador";
                Agregar_BTN_Administrador();
            }
            else { 
                _lbl_usuario.Text = "Encargado"; 
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

            //GENERA UN NUEVO METEDO CUANDO SE DE CLICK AL BOTON USUARIO//
            btn_usuarios.Click += Btn_Usuarios_Click;
            btn_deportes.Click += Btn_Deportes_Click;

            //SE AGREGA EL BOTON USUARIO AL PANEL DE CONTROLES//
            _p_controles.Controls.Add(btn_usuarios);
            _p_controles.Controls.Add(btn_deportes);
        }

        //METODO GENERADO PARA LLAMARSE CADA VEZ QUE SE DE CLICK AL BOTON//
        private void Btn_Usuarios_Click(object sender, EventArgs e) {
            //ABRE EL FORMS DE OPCIONES_USUARIO//
            AbrirForms(new Opciones_Usuario());
        }
        private void Btn_Deportes_Click(object sender, EventArgs e) {
            //REALIZAR EL FORMS QUE PERMITIRA VISUALIZAR LOS DEPORTES//

        }
        private void Agregar_BTN_Usuario() {
            //REALIZAR LOS BOTONES FALTANTES PARA EL MENU DEL USUARIO//
        }
    }
}
