namespace _1_Presentacion
{
    partial class Opciones_Equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones_Equipo));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInsertarEquipo = new System.Windows.Forms.Button();
            this._p_forms2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnInsertarEquipo
            // 
            this.btnInsertarEquipo.BackColor = System.Drawing.Color.Maroon;
            this.btnInsertarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnInsertarEquipo.Location = new System.Drawing.Point(41, 86);
            this.btnInsertarEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertarEquipo.Name = "btnInsertarEquipo";
            this.btnInsertarEquipo.Size = new System.Drawing.Size(123, 39);
            this.btnInsertarEquipo.TabIndex = 3;
            this.btnInsertarEquipo.Text = "Insertar Equipo";
            this.btnInsertarEquipo.UseVisualStyleBackColor = false;
            this.btnInsertarEquipo.Click += new System.EventHandler(this.btnInsertarEquipo_Click);
            // 
            // _p_forms2
            // 
            this._p_forms2.Dock = System.Windows.Forms.DockStyle.Right;
            this._p_forms2.Location = new System.Drawing.Point(513, 0);
            this._p_forms2.Margin = new System.Windows.Forms.Padding(4);
            this._p_forms2.Name = "_p_forms2";
            this._p_forms2.Size = new System.Drawing.Size(600, 607);
            this._p_forms2.TabIndex = 8;
            // 
            // Opciones_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1113, 607);
            this.Controls.Add(this._p_forms2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnInsertarEquipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opciones_Equipo";
            this.Text = "Opciones_Equipo";
            this.Load += new System.EventHandler(this.Opciones_Equipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInsertarEquipo;
        private System.Windows.Forms.Panel _p_forms2;
    }
}