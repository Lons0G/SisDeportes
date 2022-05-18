namespace _1_Presentacion
{
    partial class FRM_Deportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Deportes));
            this.label1 = new System.Windows.Forms.Label();
            this._gb_datos = new System.Windows.Forms.GroupBox();
            this._btn_registrar = new System.Windows.Forms.Button();
            this._cb_tipo_deporte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txt_nombre_deporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._lbl_nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._gb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Usuario: ";
            // 
            // _gb_datos
            // 
            this._gb_datos.Controls.Add(this._btn_registrar);
            this._gb_datos.Controls.Add(this._cb_tipo_deporte);
            this._gb_datos.Controls.Add(this.label4);
            this._gb_datos.Controls.Add(this._txt_nombre_deporte);
            this._gb_datos.Controls.Add(this.label3);
            this._gb_datos.Controls.Add(this._lbl_nombre);
            this._gb_datos.Controls.Add(this.label1);
            this._gb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gb_datos.Location = new System.Drawing.Point(63, 127);
            this._gb_datos.Name = "_gb_datos";
            this._gb_datos.Size = new System.Drawing.Size(303, 272);
            this._gb_datos.TabIndex = 1;
            this._gb_datos.TabStop = false;
            // 
            // _btn_registrar
            // 
            this._btn_registrar.BackColor = System.Drawing.Color.LightCoral;
            this._btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this._btn_registrar.FlatAppearance.BorderSize = 2;
            this._btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this._btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_registrar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btn_registrar.Location = new System.Drawing.Point(80, 202);
            this._btn_registrar.Name = "_btn_registrar";
            this._btn_registrar.Size = new System.Drawing.Size(132, 50);
            this._btn_registrar.TabIndex = 6;
            this._btn_registrar.Text = "REGISTRAR";
            this._btn_registrar.UseVisualStyleBackColor = false;
            this._btn_registrar.Click += new System.EventHandler(this._btn_registrar_Click);
            // 
            // _cb_tipo_deporte
            // 
            this._cb_tipo_deporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cb_tipo_deporte.FormattingEnabled = true;
            this._cb_tipo_deporte.Location = new System.Drawing.Point(173, 126);
            this._cb_tipo_deporte.Name = "_cb_tipo_deporte";
            this._cb_tipo_deporte.Size = new System.Drawing.Size(121, 24);
            this._cb_tipo_deporte.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo del Deporte:";
            // 
            // _txt_nombre_deporte
            // 
            this._txt_nombre_deporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txt_nombre_deporte.Location = new System.Drawing.Point(176, 78);
            this._txt_nombre_deporte.Name = "_txt_nombre_deporte";
            this._txt_nombre_deporte.Size = new System.Drawing.Size(121, 22);
            this._txt_nombre_deporte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Deporte:";
            // 
            // _lbl_nombre
            // 
            this._lbl_nombre.AutoSize = true;
            this._lbl_nombre.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_nombre.Location = new System.Drawing.Point(169, 28);
            this._lbl_nombre.Name = "_lbl_nombre";
            this._lbl_nombre.Size = new System.Drawing.Size(19, 21);
            this._lbl_nombre.TabIndex = 1;
            this._lbl_nombre.Text = "...";
            this._lbl_nombre.Click += new System.EventHandler(this._lbl_nombre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(375, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 418);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(-1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 418);
            this.panel2.TabIndex = 8;
            // 
            // FRM_Deportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(432, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._gb_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Deportes";
            this.Text = "FRM_Deportes";
            this.Load += new System.EventHandler(this.FRM_Deportes_Load);
            this._gb_datos.ResumeLayout(false);
            this._gb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _gb_datos;
        private System.Windows.Forms.ComboBox _cb_tipo_deporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txt_nombre_deporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lbl_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _btn_registrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}