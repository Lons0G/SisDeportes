namespace _1_Presentacion
{
    partial class Menu_Administrador
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
            this.lbladmi = new System.Windows.Forms.Label();
            this.lblmensajeadmi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladmi
            // 
            this.lbladmi.AutoSize = true;
            this.lbladmi.Location = new System.Drawing.Point(616, 215);
            this.lbladmi.Name = "lbladmi";
            this.lbladmi.Size = new System.Drawing.Size(90, 16);
            this.lbladmi.TabIndex = 3;
            this.lbladmi.Text = "Administrador";
            // 
            // lblmensajeadmi
            // 
            this.lblmensajeadmi.AutoSize = true;
            this.lblmensajeadmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensajeadmi.Location = new System.Drawing.Point(94, 215);
            this.lblmensajeadmi.Name = "lblmensajeadmi";
            this.lblmensajeadmi.Size = new System.Drawing.Size(0, 20);
            this.lblmensajeadmi.TabIndex = 2;
            // 
            // Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbladmi);
            this.Controls.Add(this.lblmensajeadmi);
            this.Name = "Menu_Administrador";
            this.Text = "Menu_Administrador";
            this.Load += new System.EventHandler(this.Menu_Administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladmi;
        private System.Windows.Forms.Label lblmensajeadmi;
    }
}