namespace _1_Presentacion
{
    partial class OpcionesTipo_Act
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
            this._p_tipo_act = new System.Windows.Forms.Panel();
            this._p_forms2 = new System.Windows.Forms.Panel();
            this.btnInsertartpAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _p_tipo_act
            // 
            this._p_tipo_act.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._p_tipo_act.BackColor = System.Drawing.Color.IndianRed;
            this._p_tipo_act.Location = new System.Drawing.Point(9, 92);
            this._p_tipo_act.Name = "_p_tipo_act";
            this._p_tipo_act.Size = new System.Drawing.Size(327, 343);
            this._p_tipo_act.TabIndex = 17;
            this._p_tipo_act.Paint += new System.Windows.Forms.PaintEventHandler(this._p_equipos_Paint);
            // 
            // _p_forms2
            // 
            this._p_forms2.BackColor = System.Drawing.Color.LightCoral;
            this._p_forms2.Dock = System.Windows.Forms.DockStyle.Right;
            this._p_forms2.Location = new System.Drawing.Point(341, 0);
            this._p_forms2.Name = "_p_forms2";
            this._p_forms2.Size = new System.Drawing.Size(414, 444);
            this._p_forms2.TabIndex = 16;
            // 
            // btnInsertartpAct
            // 
            this.btnInsertartpAct.BackColor = System.Drawing.Color.Brown;
            this.btnInsertartpAct.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnInsertartpAct.FlatAppearance.BorderSize = 2;
            this.btnInsertartpAct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnInsertartpAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertartpAct.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertartpAct.ForeColor = System.Drawing.Color.White;
            this.btnInsertartpAct.Location = new System.Drawing.Point(11, 27);
            this.btnInsertartpAct.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertartpAct.Name = "btnInsertartpAct";
            this.btnInsertartpAct.Size = new System.Drawing.Size(117, 47);
            this.btnInsertartpAct.TabIndex = 14;
            this.btnInsertartpAct.Text = "INSERTAR TIPO ACT.";
            this.btnInsertartpAct.UseVisualStyleBackColor = false;
            this.btnInsertartpAct.Click += new System.EventHandler(this.btnInsertartpAct_Click);
            // 
            // OpcionesTipo_Act
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(755, 444);
            this.Controls.Add(this._p_tipo_act);
            this.Controls.Add(this._p_forms2);
            this.Controls.Add(this.btnInsertartpAct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OpcionesTipo_Act";
            this.Text = "OpcionesTipo_Act";
            this.Load += new System.EventHandler(this.OpcionesTipo_Act_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _p_tipo_act;
        private System.Windows.Forms.Panel _p_forms2;
        private System.Windows.Forms.Button btnInsertartpAct;
    }
}