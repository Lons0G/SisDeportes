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
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 26);
            this.label6.TabIndex = 55;
            this.label6.Text = "Registro de Torneos";
            // 
            // fdd
            // 
            this.fdd.AutoSize = true;
            this.fdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdd.Location = new System.Drawing.Point(37, 114);
            this.fdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fdd.Name = "fdd";
            this.fdd.Size = new System.Drawing.Size(76, 20);
            this.fdd.TabIndex = 53;
            this.fdd.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha:";
            // 
            // dtfechatorneo
            // 
            this.dtfechatorneo.Location = new System.Drawing.Point(153, 83);
            this.dtfechatorneo.Margin = new System.Windows.Forms.Padding(2);
            this.dtfechatorneo.Name = "dtfechatorneo";
            this.dtfechatorneo.Size = new System.Drawing.Size(202, 20);
            this.dtfechatorneo.TabIndex = 56;
            // 
            // btntorneocrear
            // 
            this.btntorneocrear.Location = new System.Drawing.Point(304, 206);
            this.btntorneocrear.Margin = new System.Windows.Forms.Padding(2);
            this.btntorneocrear.Name = "btntorneocrear";
            this.btntorneocrear.Size = new System.Drawing.Size(51, 20);
            this.btntorneocrear.TabIndex = 57;
            this.btntorneocrear.Text = "Crear";
            this.btntorneocrear.UseVisualStyleBackColor = true;
            this.btntorneocrear.Click += new System.EventHandler(this.btntorneocrear_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(153, 114);
            this.txtnom.Margin = new System.Windows.Forms.Padding(2);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(202, 20);
            this.txtnom.TabIndex = 58;
            // 
            // _cb_categoria
            // 
            this._cb_categoria.FormattingEnabled = true;
            this._cb_categoria.Location = new System.Drawing.Point(153, 148);
            this._cb_categoria.Name = "_cb_categoria";
            this._cb_categoria.Size = new System.Drawing.Size(202, 21);
            this._cb_categoria.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tipo:";
            // 
            // _cb_tipo
            // 
            this._cb_tipo.FormattingEnabled = true;
            this._cb_tipo.Location = new System.Drawing.Point(153, 180);
            this._cb_tipo.Name = "_cb_tipo";
            this._cb_tipo.Size = new System.Drawing.Size(202, 21);
            this._cb_tipo.TabIndex = 62;
            // 
            // Torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(411, 364);
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
    }
}