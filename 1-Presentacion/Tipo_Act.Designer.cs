namespace _1_Presentacion
{
    partial class Tipo_Act
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.fdd = new System.Windows.Forms.Label();
            this.txtnombreAct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarTipoAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 38);
            this.label6.TabIndex = 51;
            this.label6.Text = "Registro de Actividad";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Location = new System.Drawing.Point(301, 157);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(181, 35);
            this.txtDescrip.TabIndex = 50;
            // 
            // fdd
            // 
            this.fdd.AutoSize = true;
            this.fdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdd.Location = new System.Drawing.Point(52, 157);
            this.fdd.Name = "fdd";
            this.fdd.Size = new System.Drawing.Size(159, 29);
            this.fdd.TabIndex = 49;
            this.fdd.Text = "Descripcion:";
            // 
            // txtnombreAct
            // 
            this.txtnombreAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreAct.Location = new System.Drawing.Point(301, 111);
            this.txtnombreAct.Name = "txtnombreAct";
            this.txtnombreAct.Size = new System.Drawing.Size(181, 35);
            this.txtnombreAct.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nombre:";
            // 
            // btnRegistrarTipoAct
            // 
            this.btnRegistrarTipoAct.Location = new System.Drawing.Point(392, 221);
            this.btnRegistrarTipoAct.Name = "btnRegistrarTipoAct";
            this.btnRegistrarTipoAct.Size = new System.Drawing.Size(90, 32);
            this.btnRegistrarTipoAct.TabIndex = 52;
            this.btnRegistrarTipoAct.Text = "Registrar";
            this.btnRegistrarTipoAct.UseVisualStyleBackColor = true;
            this.btnRegistrarTipoAct.Click += new System.EventHandler(this.btnRegistrarTipoAct_Click);
            // 
            // Tipo_Act
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(592, 560);
            this.Controls.Add(this.btnRegistrarTipoAct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.fdd);
            this.Controls.Add(this.txtnombreAct);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tipo_Act";
            this.Text = "Tipo_Act";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label fdd;
        private System.Windows.Forms.TextBox txtnombreAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarTipoAct;
    }
}