namespace _1_Presentacion
{
    partial class Opciones_Torneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones_Torneo));
            this._p_torneos = new System.Windows.Forms.Panel();
            this._p_forms2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInsertarTorneo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _p_torneos
            // 
            this._p_torneos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._p_torneos.BackColor = System.Drawing.Color.RosyBrown;
            this._p_torneos.Location = new System.Drawing.Point(14, 108);
            this._p_torneos.Name = "_p_torneos";
            this._p_torneos.Size = new System.Drawing.Size(330, 280);
            this._p_torneos.TabIndex = 13;
            // 
            // _p_forms2
            // 
            this._p_forms2.BackColor = System.Drawing.SystemColors.Control;
            this._p_forms2.Dock = System.Windows.Forms.DockStyle.Right;
            this._p_forms2.Location = new System.Drawing.Point(350, 0);
            this._p_forms2.Name = "_p_forms2";
            this._p_forms2.Size = new System.Drawing.Size(450, 400);
            this._p_forms2.TabIndex = 12;
            this._p_forms2.Paint += new System.Windows.Forms.PaintEventHandler(this._p_forms2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnInsertarTorneo
            // 
            this.btnInsertarTorneo.BackColor = System.Drawing.Color.Maroon;
            this.btnInsertarTorneo.ForeColor = System.Drawing.Color.White;
            this.btnInsertarTorneo.Location = new System.Drawing.Point(20, 51);
            this.btnInsertarTorneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertarTorneo.Name = "btnInsertarTorneo";
            this.btnInsertarTorneo.Size = new System.Drawing.Size(92, 32);
            this.btnInsertarTorneo.TabIndex = 10;
            this.btnInsertarTorneo.Text = "Insertar Torneo";
            this.btnInsertarTorneo.UseVisualStyleBackColor = false;
            this.btnInsertarTorneo.Click += new System.EventHandler(this.btnInsertarTorneo_Click);
            // 
            // Opciones_Torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this._p_torneos);
            this.Controls.Add(this._p_forms2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnInsertarTorneo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Opciones_Torneo";
            this.Text = "Opciones_Torneo";
            this.Load += new System.EventHandler(this.Opciones_Torneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _p_torneos;
        private System.Windows.Forms.Panel _p_forms2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInsertarTorneo;
    }
}