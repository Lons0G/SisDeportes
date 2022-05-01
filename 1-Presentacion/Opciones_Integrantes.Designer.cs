namespace _1_Presentacion
{
    partial class Opciones_Integrantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones_Integrantes));
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this._p_integrantes = new System.Windows.Forms.Panel();
            this._p_forms = new System.Windows.Forms.Panel();
            this._btn_editar_equipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(7, 50);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(115, 32);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertar Integrante";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // _p_integrantes
            // 
            this._p_integrantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._p_integrantes.AutoScroll = true;
            this._p_integrantes.BackColor = System.Drawing.Color.Salmon;
            this._p_integrantes.Location = new System.Drawing.Point(14, 108);
            this._p_integrantes.Name = "_p_integrantes";
            this._p_integrantes.Size = new System.Drawing.Size(330, 280);
            this._p_integrantes.TabIndex = 14;
            // 
            // _p_forms
            // 
            this._p_forms.Dock = System.Windows.Forms.DockStyle.Right;
            this._p_forms.Location = new System.Drawing.Point(350, 0);
            this._p_forms.Name = "_p_forms";
            this._p_forms.Size = new System.Drawing.Size(450, 400);
            this._p_forms.TabIndex = 13;
            // 
            // _btn_editar_equipo
            // 
            this._btn_editar_equipo.BackColor = System.Drawing.Color.OrangeRed;
            this._btn_editar_equipo.ForeColor = System.Drawing.Color.White;
            this._btn_editar_equipo.Location = new System.Drawing.Point(126, 50);
            this._btn_editar_equipo.Margin = new System.Windows.Forms.Padding(2);
            this._btn_editar_equipo.Name = "_btn_editar_equipo";
            this._btn_editar_equipo.Size = new System.Drawing.Size(92, 32);
            this._btn_editar_equipo.TabIndex = 17;
            this._btn_editar_equipo.Text = "Editar Equipo";
            this._btn_editar_equipo.UseVisualStyleBackColor = false;
            this._btn_editar_equipo.Click += new System.EventHandler(this._btn_editar_equipo_Click);
            // 
            // Opciones_Integrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this._btn_editar_equipo);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this._p_integrantes);
            this.Controls.Add(this._p_forms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Opciones_Integrantes";
            this.Text = "Opciones_Integrantes";
            this.Load += new System.EventHandler(this.Opciones_Integrantes_Load);
            this.Resize += new System.EventHandler(this.Opciones_Integrantes_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel _p_integrantes;
        private System.Windows.Forms.Panel _p_forms;
        private System.Windows.Forms.Button _btn_editar_equipo;
    }
}