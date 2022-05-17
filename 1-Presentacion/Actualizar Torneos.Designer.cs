namespace _1_Presentacion
{
    partial class Actualizar_Torneos
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this._cb_tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cb_categoria = new System.Windows.Forms.ComboBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.dtfechatorneo = new System.Windows.Forms.DateTimePicker();
            this.fdd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblid_torneo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 30);
            this.label1.TabIndex = 128;
            this.label1.Text = "Actualizar datos de Torneo";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 2;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActualizar.Location = new System.Drawing.Point(133, 304);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(103, 50);
            this.BtnActualizar.TabIndex = 143;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // _cb_tipo
            // 
            this._cb_tipo.FormattingEnabled = true;
            this._cb_tipo.Location = new System.Drawing.Point(127, 172);
            this._cb_tipo.Name = "_cb_tipo";
            this._cb_tipo.Size = new System.Drawing.Size(202, 21);
            this._cb_tipo.TabIndex = 151;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 150;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 149;
            this.label3.Text = "Categoria:";
            // 
            // _cb_categoria
            // 
            this._cb_categoria.FormattingEnabled = true;
            this._cb_categoria.Location = new System.Drawing.Point(127, 139);
            this._cb_categoria.Name = "_cb_categoria";
            this._cb_categoria.Size = new System.Drawing.Size(202, 21);
            this._cb_categoria.TabIndex = 148;
            this._cb_categoria.SelectedIndexChanged += new System.EventHandler(this._cb_categoria_SelectedIndexChanged);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(127, 105);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(202, 20);
            this.txtnom.TabIndex = 147;
            // 
            // dtfechatorneo
            // 
            this.dtfechatorneo.Location = new System.Drawing.Point(127, 74);
            this.dtfechatorneo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtfechatorneo.Name = "dtfechatorneo";
            this.dtfechatorneo.Size = new System.Drawing.Size(202, 20);
            this.dtfechatorneo.TabIndex = 146;
            // 
            // fdd
            // 
            this.fdd.AutoSize = true;
            this.fdd.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.fdd.ForeColor = System.Drawing.Color.White;
            this.fdd.Location = new System.Drawing.Point(10, 105);
            this.fdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fdd.Name = "fdd";
            this.fdd.Size = new System.Drawing.Size(75, 21);
            this.fdd.TabIndex = 145;
            this.fdd.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 144;
            this.label4.Text = "Fecha:";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargar.Location = new System.Drawing.Point(247, 15);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(81, 38);
            this.btnCargar.TabIndex = 152;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 21);
            this.label5.TabIndex = 153;
            this.label5.Text = "id:";
            // 
            // lblid_torneo
            // 
            this.lblid_torneo.AutoSize = true;
            this.lblid_torneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid_torneo.Location = new System.Drawing.Point(54, 14);
            this.lblid_torneo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid_torneo.Name = "lblid_torneo";
            this.lblid_torneo.Size = new System.Drawing.Size(0, 20);
            this.lblid_torneo.TabIndex = 154;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lblid_torneo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this._cb_tipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._cb_categoria);
            this.panel1.Controls.Add(this.txtnom);
            this.panel1.Controls.Add(this.dtfechatorneo);
            this.panel1.Controls.Add(this.fdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 233);
            this.panel1.TabIndex = 155;
            // 
            // Actualizar_Torneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(377, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnActualizar);
            this.Name = "Actualizar_Torneos";
            this.Text = "Actualizar_Torneos";
            this.Load += new System.EventHandler(this.Actualizar_Torneos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.ComboBox _cb_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cb_categoria;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.DateTimePicker dtfechatorneo;
        private System.Windows.Forms.Label fdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblid_torneo;
        private System.Windows.Forms.Panel panel1;
    }
}