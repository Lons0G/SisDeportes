﻿namespace _1_Presentacion
{
    partial class Menu_Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Administrador));
            this.lbladmi = new System.Windows.Forms.Label();
            this._p_lateral = new System.Windows.Forms.Panel();
            this._btn_usuarios = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._p_salir = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this._p_usuario = new System.Windows.Forms.Panel();
            this._pb_imagen_usuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._p_forms = new System.Windows.Forms.Panel();
            this._p_lateral.SuspendLayout();
            this._p_salir.SuspendLayout();
            this._p_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pb_imagen_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbladmi
            // 
            this.lbladmi.AutoSize = true;
            this.lbladmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmi.ForeColor = System.Drawing.Color.White;
            this.lbladmi.Location = new System.Drawing.Point(9, 80);
            this.lbladmi.Margin = new System.Windows.Forms.Padding(0);
            this.lbladmi.Name = "lbladmi";
            this.lbladmi.Size = new System.Drawing.Size(107, 20);
            this.lbladmi.TabIndex = 3;
            this.lbladmi.Text = "Administrador";
            // 
            // _p_lateral
            // 
            this._p_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(33)))), ((int)(((byte)(24)))));
            this._p_lateral.Controls.Add(this._btn_usuarios);
            this._p_lateral.Controls.Add(this.lbladmi);
            this._p_lateral.Controls.Add(this.button3);
            this._p_lateral.Controls.Add(this.button2);
            this._p_lateral.Controls.Add(this._p_salir);
            this._p_lateral.Controls.Add(this._p_usuario);
            this._p_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this._p_lateral.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._p_lateral.Location = new System.Drawing.Point(0, 0);
            this._p_lateral.Name = "_p_lateral";
            this._p_lateral.Size = new System.Drawing.Size(120, 761);
            this._p_lateral.TabIndex = 4;
            // 
            // _btn_usuarios
            // 
            this._btn_usuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this._btn_usuarios.Location = new System.Drawing.Point(0, 115);
            this._btn_usuarios.Name = "_btn_usuarios";
            this._btn_usuarios.Size = new System.Drawing.Size(120, 50);
            this._btn_usuarios.TabIndex = 0;
            this._btn_usuarios.Text = "Usuarios";
            this._btn_usuarios.UseVisualStyleBackColor = false;
            this._btn_usuarios.Click += new System.EventHandler(this._btn_usuarios_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(0, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reportes";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(0, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Deportes";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // _p_salir
            // 
            this._p_salir.Controls.Add(this.button4);
            this._p_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._p_salir.Location = new System.Drawing.Point(0, 726);
            this._p_salir.Name = "_p_salir";
            this._p_salir.Size = new System.Drawing.Size(120, 35);
            this._p_salir.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // _p_usuario
            // 
            this._p_usuario.Controls.Add(this._pb_imagen_usuario);
            this._p_usuario.Location = new System.Drawing.Point(0, 0);
            this._p_usuario.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this._p_usuario.Name = "_p_usuario";
            this._p_usuario.Size = new System.Drawing.Size(120, 77);
            this._p_usuario.TabIndex = 5;
            // 
            // _pb_imagen_usuario
            // 
            this._pb_imagen_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pb_imagen_usuario.Image = global::_1_Presentacion.Properties.Resources.usuario_de_perfil;
            this._pb_imagen_usuario.Location = new System.Drawing.Point(0, 0);
            this._pb_imagen_usuario.Name = "_pb_imagen_usuario";
            this._pb_imagen_usuario.Size = new System.Drawing.Size(120, 77);
            this._pb_imagen_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pb_imagen_usuario.TabIndex = 5;
            this._pb_imagen_usuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 761);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // _p_forms
            // 
            this._p_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this._p_forms.Location = new System.Drawing.Point(120, 0);
            this._p_forms.Name = "_p_forms";
            this._p_forms.Size = new System.Drawing.Size(1104, 761);
            this._p_forms.TabIndex = 6;
            // 
            // Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1224, 761);
            this.Controls.Add(this._p_forms);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._p_lateral);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_Administrador";
            this.Text = "Menu_Administrador";
            this.Load += new System.EventHandler(this.Menu_Administrador_Load);
            this._p_lateral.ResumeLayout(false);
            this._p_lateral.PerformLayout();
            this._p_salir.ResumeLayout(false);
            this._p_usuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pb_imagen_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbladmi;
        private System.Windows.Forms.Panel _p_lateral;
        private System.Windows.Forms.Button _btn_usuarios;
        private System.Windows.Forms.Panel _p_usuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel _p_salir;
        private System.Windows.Forms.PictureBox _pb_imagen_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel _p_forms;
    }
}