﻿namespace _1_Presentacion
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
            this.label6.Location = new System.Drawing.Point(116, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 32);
            this.label6.TabIndex = 51;
            this.label6.Text = "Registro de Actividad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Location = new System.Drawing.Point(268, 126);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(161, 30);
            this.txtDescrip.TabIndex = 50;
            this.txtDescrip.TextChanged += new System.EventHandler(this.txtDescrip_TextChanged);
            // 
            // fdd
            // 
            this.fdd.AutoSize = true;
            this.fdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdd.Location = new System.Drawing.Point(46, 126);
            this.fdd.Name = "fdd";
            this.fdd.Size = new System.Drawing.Size(132, 25);
            this.fdd.TabIndex = 49;
            this.fdd.Text = "Descripcion:";
            this.fdd.Click += new System.EventHandler(this.fdd_Click);
            // 
            // txtnombreAct
            // 
            this.txtnombreAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreAct.Location = new System.Drawing.Point(268, 89);
            this.txtnombreAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombreAct.Name = "txtnombreAct";
            this.txtnombreAct.Size = new System.Drawing.Size(161, 30);
            this.txtnombreAct.TabIndex = 48;
            this.txtnombreAct.TextChanged += new System.EventHandler(this.txtnombreAct_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Nombre:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnRegistrarTipoAct
            // 
            this.btnRegistrarTipoAct.Location = new System.Drawing.Point(348, 177);
            this.btnRegistrarTipoAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarTipoAct.Name = "btnRegistrarTipoAct";
            this.btnRegistrarTipoAct.Size = new System.Drawing.Size(80, 26);
            this.btnRegistrarTipoAct.TabIndex = 52;
            this.btnRegistrarTipoAct.Text = "Registrar";
            this.btnRegistrarTipoAct.UseVisualStyleBackColor = true;
            this.btnRegistrarTipoAct.Click += new System.EventHandler(this.btnRegistrarTipoAct_Click);
            // 
            // Tipo_Act
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(526, 448);
            this.Controls.Add(this.btnRegistrarTipoAct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.fdd);
            this.Controls.Add(this.txtnombreAct);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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