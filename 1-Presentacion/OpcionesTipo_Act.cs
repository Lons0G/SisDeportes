﻿using System;
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
    public partial class OpcionesTipo_Act : Form
    {
        public OpcionesTipo_Act()
        {
            InitializeComponent();
        }

        private void _p_equipos_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirForms(object FRM_secundario)
        {
            try
            {
                _p_forms2.Visible = true;
                if (this._p_forms2.Controls.Count > 0) { this._p_forms2.Controls.Clear(); }

                Form secundario = FRM_secundario as Form;
                secundario.TopLevel = false;
                secundario.Dock = DockStyle.Fill;
                this._p_forms2.Controls.Add(secundario);
                this._p_forms2.Tag = secundario;

                secundario.Show();

                ////SE CREA UN NUEVO EVENTO QUE DETECTA CUANDO SE CERRO EL FORMS SECUNDARIO//
                //secundario.FormClosing += new FormClosingEventHandler(Agregar_Usuario_Close);
            }
            catch
            {
                MessageBox.Show("Error en el Metodo AbrirForms", "Ha ocurrido un error en 'Opciones Tipo Actividades'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Cargar_Tipo_Act()
        {
            try
            {
                //Limpiar_Equipos();

                List<CLS_TipoActividad> lista_act = new List<CLS_TipoActividad>();
                CLS_L_Tipo l_Tipo = new CLS_L_Tipo();
                l_Tipo.ObtenerTipos(ref lista_act);

                int i = 0;
                int x = _p_tipo_act.Width;

                foreach (var tipo_act in lista_act)
                {
                    UC_boton_entidad btn = new UC_boton_entidad(tipo_act.IdTipo, tipo_act.Nombre, tipo_act.Descripcion, x, 4);
                    btn.Top = 52 * i;
                    _p_tipo_act.Controls.Add(btn);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Error en el Metodo Cargar_Tipo_Act", "Ha ocurrido un error en 'Opciones Tipo Actividades'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInsertartpAct_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForms(new Tipo_Act());
            }
            catch
            {
                MessageBox.Show("Error en el Metodo btnInsertartpAct_Click", "Ha ocurrido un error en 'Opciones Tipo Actividades'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpcionesTipo_Act_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Tipo_Act();
            }
            catch
            {
                MessageBox.Show("Error en el Metodo OpcionesTipo_Act_Load", "Ha ocurrido un error en 'Opciones Tipo Actividades'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
