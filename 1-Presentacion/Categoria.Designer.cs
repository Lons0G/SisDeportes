﻿namespace _1_Presentacion
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
            this._gb_datos.Controls.Add(this.btnCatego);
            this._gb_datos.Controls.Add(this.cboidequipo);
            this._gb_datos.Controls.Add(this.label4);
            this._gb_datos.Controls.Add(this.txtcategoria);
            this._gb_datos.Controls.Add(this.label3);
            this._gb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gb_datos.Location = new System.Drawing.Point(51, 74);
            this._gb_datos.Margin = new System.Windows.Forms.Padding(4);
            this._gb_datos.Name = "_gb_datos";
            this._gb_datos.Padding = new System.Windows.Forms.Padding(4);
            this._gb_datos.Size = new System.Drawing.Size(441, 281);
            this._gb_datos.TabIndex = 2;
            this._gb_datos.TabStop = false;
            this._gb_datos.Text = "Datos";
            // 
            // btnCatego
            // 
            this.btnCatego.Location = new System.Drawing.Point(283, 203);
            this.btnCatego.Margin = new System.Windows.Forms.Padding(4);
            this.btnCatego.Name = "btnCatego";
            this.btnCatego.Size = new System.Drawing.Size(139, 38);
            this.btnCatego.TabIndex = 6;
            this.btnCatego.Text = "Registrar";
            this.btnCatego.UseVisualStyleBackColor = true;
            this.btnCatego.Click += new System.EventHandler(this.btnCatego_Click);
            // 
            // cboidequipo
            // 
            this.cboidequipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboidequipo.FormattingEnabled = true;
            this.cboidequipo.Location = new System.Drawing.Point(262, 76);
            this.cboidequipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboidequipo.Name = "cboidequipo";
            this.cboidequipo.Size = new System.Drawing.Size(160, 28);
            this.cboidequipo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Deporte:";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.Location = new System.Drawing.Point(262, 126);
            this.txtcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(160, 26);
            this.txtcategoria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de la Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1075, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._gb_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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