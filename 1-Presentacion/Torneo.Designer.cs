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
            this._cb_categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._cb_tipo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 31);
            this.label6.TabIndex = 55;
            this.label6.Text = "Registro de Torneos";
            // 
            // fdd
            // 
            this.fdd.AutoSize = true;
            this.fdd.BackColor = System.Drawing.Color.Firebrick;
            this.fdd.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdd.ForeColor = System.Drawing.Color.White;
            this.fdd.Location = new System.Drawing.Point(31, 144);
            this.fdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fdd.Name = "fdd";
            this.fdd.Size = new System.Drawing.Size(75, 21);
            this.fdd.TabIndex = 53;
            this.fdd.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha:";
            // 
            // dtfechatorneo
            // 
            this.dtfechatorneo.Location = new System.Drawing.Point(147, 113);
            this.dtfechatorneo.Margin = new System.Windows.Forms.Padding(2);
            this.dtfechatorneo.Name = "dtfechatorneo";
            this.dtfechatorneo.Size = new System.Drawing.Size(202, 20);
            this.dtfechatorneo.TabIndex = 56;
            // 
            // btntorneocrear
            // 
            this.btntorneocrear.BackColor = System.Drawing.Color.LightCoral;
            this.btntorneocrear.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btntorneocrear.FlatAppearance.BorderSize = 2;
            this.btntorneocrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btntorneocrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntorneocrear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntorneocrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntorneocrear.Location = new System.Drawing.Point(136, 291);
            this.btntorneocrear.Margin = new System.Windows.Forms.Padding(2);
            this.btntorneocrear.Name = "btntorneocrear";
            this.btntorneocrear.Size = new System.Drawing.Size(104, 48);
            this.btntorneocrear.TabIndex = 57;
            this.btntorneocrear.Text = "CREAR";
            this.btntorneocrear.UseVisualStyleBackColor = false;
            this.btntorneocrear.Click += new System.EventHandler(this.btntorneocrear_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(147, 144);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(202, 20);
            this.txtnom.TabIndex = 58;
            // 
            // _cb_categoria
            // 
            this._cb_categoria.FormattingEnabled = true;
            this._cb_categoria.Location = new System.Drawing.Point(147, 178);
            this._cb_categoria.Name = "_cb_categoria";
            this._cb_categoria.Size = new System.Drawing.Size(202, 21);
            this._cb_categoria.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tipo:";
            // 
            // _cb_tipo
            // 
            this._cb_tipo.FormattingEnabled = true;
            this._cb_tipo.Location = new System.Drawing.Point(147, 210);
            this._cb_tipo.Name = "_cb_tipo";
            this._cb_tipo.Size = new System.Drawing.Size(202, 21);
            this._cb_tipo.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(-5, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 180);
            this.panel1.TabIndex = 63;
            // 
            // Torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(389, 364);
            this.Controls.Add(this._cb_tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cb_categoria);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.btntorneocrear);
            this.Controls.Add(this.dtfechatorneo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox _cb_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cb_tipo;
        private System.Windows.Forms.Panel panel1;
    }
}