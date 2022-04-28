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
            this.panel1 = new System.Windows.Forms.Panel();
            this._p_forms = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(11, 77);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(138, 49);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertar Integrante";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Location = new System.Drawing.Point(7, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 434);
            this.panel1.TabIndex = 14;
            // 
            // _p_forms
            // 
            this._p_forms.Dock = System.Windows.Forms.DockStyle.Right;
            this._p_forms.Location = new System.Drawing.Point(527, 0);
            this._p_forms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._p_forms.Name = "_p_forms";
            this._p_forms.Size = new System.Drawing.Size(675, 581);
            this._p_forms.TabIndex = 13;
            this._p_forms.Paint += new System.Windows.Forms.PaintEventHandler(this._p_forms_Paint);
            // 
            // Opciones_Integrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 581);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._p_forms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opciones_Integrantes";
            this.Text = "Opciones_Integrantes";
            this.Load += new System.EventHandler(this.Opciones_Integrantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel _p_forms;
    }
}