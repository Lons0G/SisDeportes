﻿using System;

namespace _1_Presentacion
{
    partial class UC_boton_entidad
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._btn_eliminar = new System.Windows.Forms.Button();
            this._btn_editar = new System.Windows.Forms.Button();
            this._lbl_nombre_entidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btn_eliminar
            // 
            this._btn_eliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this._btn_eliminar.Location = new System.Drawing.Point(348, 0);
            this._btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this._btn_eliminar.Name = "_btn_eliminar";
            this._btn_eliminar.Size = new System.Drawing.Size(79, 62);
            this._btn_eliminar.TabIndex = 0;
            this._btn_eliminar.Text = "Eliminar";
            this._btn_eliminar.UseVisualStyleBackColor = true;
            this._btn_eliminar.Click += new System.EventHandler(this._btn_eliminar_Click);
            // 
            // _btn_editar
            // 
            this._btn_editar.Dock = System.Windows.Forms.DockStyle.Right;
            this._btn_editar.Location = new System.Drawing.Point(261, 0);
            this._btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this._btn_editar.Name = "_btn_editar";
            this._btn_editar.Size = new System.Drawing.Size(87, 62);
            this._btn_editar.TabIndex = 1;
            this._btn_editar.Text = "Editar";
            this._btn_editar.UseVisualStyleBackColor = true;
            // 
            // _lbl_nombre_entidad
            // 
            this._lbl_nombre_entidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbl_nombre_entidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_nombre_entidad.Location = new System.Drawing.Point(0, 0);
            this._lbl_nombre_entidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lbl_nombre_entidad.Name = "_lbl_nombre_entidad";
            this._lbl_nombre_entidad.Size = new System.Drawing.Size(261, 62);
            this._lbl_nombre_entidad.TabIndex = 2;
            this._lbl_nombre_entidad.Text = "Nombre";
            this._lbl_nombre_entidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lbl_nombre_entidad.Click += new System.EventHandler(this._lbl_nombre_entidad_Click);
            // 
            // UC_boton_entidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lbl_nombre_entidad);
            this.Controls.Add(this._btn_editar);
            this.Controls.Add(this._btn_eliminar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_boton_entidad";
            this.Size = new System.Drawing.Size(427, 62);
            this.ResumeLayout(false);

        }

        private void _lbl_nombre_entidad_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button _btn_eliminar;
        private System.Windows.Forms.Button _btn_editar;
        private System.Windows.Forms.Label _lbl_nombre_entidad;
    }
}
