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
            this._btn_eliminar.Location = new System.Drawing.Point(255, 0);
            this._btn_eliminar.Name = "_btn_eliminar";
            this._btn_eliminar.Size = new System.Drawing.Size(65, 50);
            this._btn_eliminar.TabIndex = 0;
            this._btn_eliminar.Text = "Eliminar";
            this._btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // _btn_editar
            // 
            this._btn_editar.Dock = System.Windows.Forms.DockStyle.Right;
            this._btn_editar.Location = new System.Drawing.Point(190, 0);
            this._btn_editar.Name = "_btn_editar";
            this._btn_editar.Size = new System.Drawing.Size(65, 50);
            this._btn_editar.TabIndex = 1;
            this._btn_editar.Text = "Editar";
            this._btn_editar.UseVisualStyleBackColor = true;
            // 
            // _lbl_nombre_entidad
            // 
            this._lbl_nombre_entidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbl_nombre_entidad.Location = new System.Drawing.Point(0, 0);
            this._lbl_nombre_entidad.Name = "_lbl_nombre_entidad";
            this._lbl_nombre_entidad.Size = new System.Drawing.Size(190, 50);
            this._lbl_nombre_entidad.TabIndex = 2;
            this._lbl_nombre_entidad.Text = "Nombre";
            this._lbl_nombre_entidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_boton_entidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lbl_nombre_entidad);
            this.Controls.Add(this._btn_editar);
            this.Controls.Add(this._btn_eliminar);
            this.Name = "UC_boton_entidad";
            this.Size = new System.Drawing.Size(320, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btn_eliminar;
        private System.Windows.Forms.Button _btn_editar;
        private System.Windows.Forms.Label _lbl_nombre_entidad;
    }
}
