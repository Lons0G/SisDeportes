namespace _1_Presentacion
{
    partial class Opciones_Deportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones_Deportes));
            this._p_equipos = new System.Windows.Forms.Panel();
            this._p_forms2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInsertarDeporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _p_equipos
            // 
            this._p_equipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._p_equipos.BackColor = System.Drawing.Color.MistyRose;
            this._p_equipos.Location = new System.Drawing.Point(9, 142);
            this._p_equipos.Name = "_p_equipos";
            this._p_equipos.Size = new System.Drawing.Size(343, 258);
            this._p_equipos.TabIndex = 21;
            // 
            // _p_forms2
            // 
            this._p_forms2.BackColor = System.Drawing.Color.LightCoral;
            this._p_forms2.Dock = System.Windows.Forms.DockStyle.Right;
            this._p_forms2.Location = new System.Drawing.Point(357, 0);
            this._p_forms2.Name = "_p_forms2";
            this._p_forms2.Size = new System.Drawing.Size(414, 409);
            this._p_forms2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnInsertarDeporte
            // 
            this.btnInsertarDeporte.BackColor = System.Drawing.Color.IndianRed;
            this.btnInsertarDeporte.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnInsertarDeporte.FlatAppearance.BorderSize = 2;
            this.btnInsertarDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnInsertarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarDeporte.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarDeporte.ForeColor = System.Drawing.Color.White;
            this.btnInsertarDeporte.Location = new System.Drawing.Point(11, 96);
            this.btnInsertarDeporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertarDeporte.Name = "btnInsertarDeporte";
            this.btnInsertarDeporte.Size = new System.Drawing.Size(148, 41);
            this.btnInsertarDeporte.TabIndex = 18;
            this.btnInsertarDeporte.Text = "INSERTAR DEPORTE";
            this.btnInsertarDeporte.UseVisualStyleBackColor = false;
            this.btnInsertarDeporte.Click += new System.EventHandler(this.btnInsertarDeporte_Click);
            // 
            // Opciones_Deportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(771, 409);
            this.Controls.Add(this._p_equipos);
            this.Controls.Add(this._p_forms2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnInsertarDeporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Opciones_Deportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opciones_Deportes";
            this.Load += new System.EventHandler(this.Opciones_Deportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _p_equipos;
        private System.Windows.Forms.Panel _p_forms2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInsertarDeporte;
    }
}