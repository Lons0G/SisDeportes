﻿using System;
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
    public partial class Menu_Encargado : Form
    {
        public Menu_Encargado()
        {
            ///NECESITO TENER EL USUARIO CON EL DEPORTE///
            ///
            InitializeComponent();
        }

        private void Menu_Encargado_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login vol = new Login();

            vol.Show();
        }
    }
}
