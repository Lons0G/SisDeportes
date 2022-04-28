namespace _1_Presentacion
{
    partial class Torneo
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
            this.fdd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtfechatorneo = new System.Windows.Forms.DateTimePicker();
            this.btntorneocrear = new System.Windows.Forms.Button();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 38);
            this.label6.TabIndex = 55;
            this.label6.Text = "Registro de Torneos";
            // 
            // fdd
            // 
            this.fdd.AutoSize = true;
            this.fdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdd.Location = new System.Drawing.Point(56, 173);
            this.fdd.Name = "fdd";
            this.fdd.Size = new System.Drawing.Size(114, 29);
            this.fdd.TabIndex = 53;
            this.fdd.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha:";
            // 
            // dtfechatorneo
            // 
            this.dtfechatorneo.Location = new System.Drawing.Point(230, 127);
            this.dtfechatorneo.Name = "dtfechatorneo";
            this.dtfechatorneo.Size = new System.Drawing.Size(301, 26);
            this.dtfechatorneo.TabIndex = 56;
            // 
            // btntorneocrear
            // 
            this.btntorneocrear.Location = new System.Drawing.Point(455, 241);
            this.btntorneocrear.Name = "btntorneocrear";
            this.btntorneocrear.Size = new System.Drawing.Size(76, 31);
            this.btntorneocrear.TabIndex = 57;
            this.btntorneocrear.Text = "Crear";
            this.btntorneocrear.UseVisualStyleBackColor = true;
            this.btntorneocrear.Click += new System.EventHandler(this.btntorneocrear_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(230, 175);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(301, 26);
            this.txtnom.TabIndex = 58;
            // 
            // Torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(617, 560);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.btntorneocrear);
            this.Controls.Add(this.dtfechatorneo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fdd);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Torneo";
            this.Text = "Torneo";
            this.Load += new System.EventHandler(this.Torneo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtfechatorneo;
        private System.Windows.Forms.Button btntorneocrear;
        private System.Windows.Forms.TextBox txtnom;
    }
}