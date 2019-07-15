namespace projet1._1
{
    partial class fournisseur_delet
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
            this.bt_delet = new System.Windows.Forms.Button();
            this.lb_ajoutfourni = new System.Windows.Forms.Label();
            this.tb_nomfourni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_delet
            // 
            this.bt_delet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_delet.Location = new System.Drawing.Point(501, 251);
            this.bt_delet.Name = "bt_delet";
            this.bt_delet.Size = new System.Drawing.Size(115, 40);
            this.bt_delet.TabIndex = 6;
            this.bt_delet.Text = "supprimer";
            this.bt_delet.UseVisualStyleBackColor = true;
            this.bt_delet.Click += new System.EventHandler(this.bt_delet_Click);
            // 
            // lb_ajoutfourni
            // 
            this.lb_ajoutfourni.AutoSize = true;
            this.lb_ajoutfourni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ajoutfourni.Location = new System.Drawing.Point(183, 90);
            this.lb_ajoutfourni.Name = "lb_ajoutfourni";
            this.lb_ajoutfourni.Size = new System.Drawing.Size(397, 37);
            this.lb_ajoutfourni.TabIndex = 5;
            this.lb_ajoutfourni.Text = "supprimer un fournisseur";
            // 
            // tb_nomfourni
            // 
            this.tb_nomfourni.Location = new System.Drawing.Point(243, 252);
            this.tb_nomfourni.Name = "tb_nomfourni";
            this.tb_nomfourni.Size = new System.Drawing.Size(216, 31);
            this.tb_nomfourni.TabIndex = 4;
            // 
            // fournisseur_delet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_delet);
            this.Controls.Add(this.lb_ajoutfourni);
            this.Controls.Add(this.tb_nomfourni);
            this.Name = "fournisseur_delet";
            this.Load += new System.EventHandler(this.fournisseur_delet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_delet;
        private System.Windows.Forms.Label lb_ajoutfourni;
        private System.Windows.Forms.TextBox tb_nomfourni;
    }
}