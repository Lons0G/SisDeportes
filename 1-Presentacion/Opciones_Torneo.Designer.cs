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
            this._p_torneos = new System.Windows.Forms.Panel();
            this._p_forms2 = new System.Windows.Forms.Panel();
            this.btnInsertarTorneo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _p_torneos
            // 
            this._p_torneos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._p_torneos.BackColor = System.Drawing.Color.LightCoral;
            this._p_torneos.Location = new System.Drawing.Point(11, 110);
            this._p_torneos.Name = "_p_torneos";
            this._p_torneos.Size = new System.Drawing.Size(330, 280);
            this._p_torneos.TabIndex = 13;
            // 
            // _p_forms2
            // 
            this._p_forms2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._p_forms2.Dock = System.Windows.Forms.DockStyle.Right;
            this._p_forms2.Location = new System.Drawing.Point(350, 0);
            this._p_forms2.Name = "_p_forms2";
            this._p_forms2.Size = new System.Drawing.Size(450, 400);
            this._p_forms2.TabIndex = 12;
            this._p_forms2.Paint += new System.Windows.Forms.PaintEventHandler(this._p_forms2_Paint);
            // 
            // btnInsertarTorneo
            // 
            this.btnInsertarTorneo.BackColor = System.Drawing.Color.IndianRed;
            this.btnInsertarTorneo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnInsertarTorneo.FlatAppearance.BorderSize = 2;
            this.btnInsertarTorneo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnInsertarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarTorneo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarTorneo.ForeColor = System.Drawing.Color.White;
            this.btnInsertarTorneo.Location = new System.Drawing.Point(11, 55);
            this.btnInsertarTorneo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarTorneo.Name = "btnInsertarTorneo";
            this.btnInsertarTorneo.Size = new System.Drawing.Size(124, 36);
            this.btnInsertarTorneo.TabIndex = 10;
            this.btnInsertarTorneo.Text = "INSERTAR TORNEO";
            this.btnInsertarTorneo.UseVisualStyleBackColor = false;
            this.btnInsertarTorneo.Click += new System.EventHandler(this.btnInsertarTorneo_Click);
            // 
            // Opciones_Torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this._p_torneos);
            this.Controls.Add(this._p_forms2);
            this.Controls.Add(this.btnInsertarTorneo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Opciones_Torneo";
            this.Text = "Opciones_Torneo";
            this.Load += new System.EventHandler(this.Opciones_Torneo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _p_torneos;
        private System.Windows.Forms.Panel _p_forms2;
        private System.Windows.Forms.Button btnInsertarTorneo;
    }
}