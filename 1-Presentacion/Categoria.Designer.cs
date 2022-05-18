namespace _1_Presentacion
{
    partial class Categoria
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
            this._gb_datos = new System.Windows.Forms.GroupBox();
            this.btnCatego = new System.Windows.Forms.Button();
            this.cboidequipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._gb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gb_datos
            // 
            this._gb_datos.BackColor = System.Drawing.Color.MistyRose;
            this._gb_datos.Controls.Add(this.cboidequipo);
            this._gb_datos.Controls.Add(this.label4);
            this._gb_datos.Controls.Add(this.txtcategoria);
            this._gb_datos.Controls.Add(this.label3);
            this._gb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gb_datos.Location = new System.Drawing.Point(38, 95);
            this._gb_datos.Name = "_gb_datos";
            this._gb_datos.Size = new System.Drawing.Size(331, 152);
            this._gb_datos.TabIndex = 2;
            this._gb_datos.TabStop = false;
            this._gb_datos.Text = "Datos";
            // 
            // btnCatego
            // 
            this.btnCatego.BackColor = System.Drawing.Color.Firebrick;
            this.btnCatego.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCatego.FlatAppearance.BorderSize = 2;
            this.btnCatego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnCatego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatego.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatego.ForeColor = System.Drawing.Color.White;
            this.btnCatego.Location = new System.Drawing.Point(147, 273);
            this.btnCatego.Name = "btnCatego";
            this.btnCatego.Size = new System.Drawing.Size(112, 52);
            this.btnCatego.TabIndex = 6;
            this.btnCatego.Text = "REGISTRAR";
            this.btnCatego.UseVisualStyleBackColor = false;
            this.btnCatego.Click += new System.EventHandler(this.btnCatego_Click);
            // 
            // cboidequipo
            // 
            this.cboidequipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboidequipo.FormattingEnabled = true;
            this.cboidequipo.Location = new System.Drawing.Point(196, 62);
            this.cboidequipo.Name = "cboidequipo";
            this.cboidequipo.Size = new System.Drawing.Size(121, 24);
            this.cboidequipo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Deporte:";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.Location = new System.Drawing.Point(196, 102);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(121, 22);
            this.txtcategoria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de la Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "CATEGORÍA";
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(413, 344);
            this.Controls.Add(this.btnCatego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._gb_datos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this._gb_datos.ResumeLayout(false);
            this._gb_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _gb_datos;
        private System.Windows.Forms.Button btnCatego;
        private System.Windows.Forms.ComboBox cboidequipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}