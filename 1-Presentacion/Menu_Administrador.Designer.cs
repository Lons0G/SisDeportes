namespace _1_Presentacion
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
            this._lbl_usuario = new System.Windows.Forms.Label();
            this._p_controles = new System.Windows.Forms.Panel();
            this._p_salir = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this._p_usuario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._p_forms = new System.Windows.Forms.Panel();
            this._p_lateral = new System.Windows.Forms.Panel();
            this._p_controles.SuspendLayout();
            this._p_salir.SuspendLayout();
            this._p_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._p_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lbl_usuario
            // 
            this._lbl_usuario.AutoSize = true;
            this._lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_usuario.ForeColor = System.Drawing.Color.White;
            this._lbl_usuario.Location = new System.Drawing.Point(0, 34);
            this._lbl_usuario.Margin = new System.Windows.Forms.Padding(0);
            this._lbl_usuario.Name = "_lbl_usuario";
            this._lbl_usuario.Size = new System.Drawing.Size(120, 20);
            this._lbl_usuario.TabIndex = 3;
            this._lbl_usuario.Text = "Administrador";
            // 
            // _p_controles
            // 
            this._p_controles.BackColor = System.Drawing.Color.LightCoral;
            this._p_controles.Controls.Add(this._p_salir);
            this._p_controles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._p_controles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._p_controles.Location = new System.Drawing.Point(0, 77);
            this._p_controles.Name = "_p_controles";
            this._p_controles.Size = new System.Drawing.Size(120, 605);
            this._p_controles.TabIndex = 4;
            this._p_controles.Paint += new System.Windows.Forms.PaintEventHandler(this._p_controles_Paint);
            // 
            // _p_salir
            // 
            this._p_salir.Controls.Add(this.button4);
            this._p_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._p_salir.Location = new System.Drawing.Point(0, 570);
            this._p_salir.Name = "_p_salir";
            this._p_salir.Size = new System.Drawing.Size(120, 35);
            this._p_salir.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "SALIR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // _p_usuario
            // 
            this._p_usuario.BackColor = System.Drawing.Color.IndianRed;
            this._p_usuario.Controls.Add(this._lbl_usuario);
            this._p_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this._p_usuario.Location = new System.Drawing.Point(0, 0);
            this._p_usuario.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this._p_usuario.Name = "_p_usuario";
            this._p_usuario.Size = new System.Drawing.Size(120, 77);
            this._p_usuario.TabIndex = 5;
            this._p_usuario.Paint += new System.Windows.Forms.PaintEventHandler(this._p_usuario_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1224, 682);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // _p_forms
            // 
            this._p_forms.BackColor = System.Drawing.Color.White;
            this._p_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this._p_forms.Location = new System.Drawing.Point(120, 0);
            this._p_forms.Name = "_p_forms";
            this._p_forms.Size = new System.Drawing.Size(1104, 682);
            this._p_forms.TabIndex = 6;
            // 
            // _p_lateral
            // 
            this._p_lateral.BackColor = System.Drawing.Color.White;
            this._p_lateral.Controls.Add(this._p_controles);
            this._p_lateral.Controls.Add(this._p_usuario);
            this._p_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this._p_lateral.Location = new System.Drawing.Point(0, 0);
            this._p_lateral.Name = "_p_lateral";
            this._p_lateral.Size = new System.Drawing.Size(120, 682);
            this._p_lateral.TabIndex = 6;
            // 
            // Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1224, 682);
            this.Controls.Add(this._p_forms);
            this.Controls.Add(this._p_lateral);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Administrador";
            this.Load += new System.EventHandler(this.Menu_Administrador_Load);
            this._p_controles.ResumeLayout(false);
            this._p_salir.ResumeLayout(false);
            this._p_usuario.ResumeLayout(false);
            this._p_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._p_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lbl_usuario;
        private System.Windows.Forms.Panel _p_controles;
        private System.Windows.Forms.Panel _p_usuario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel _p_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel _p_forms;
        private System.Windows.Forms.Panel _p_lateral;
    }
}