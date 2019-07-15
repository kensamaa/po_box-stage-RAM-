namespace projet1._1
{
    partial class fournisseur
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
            this.tb_nomfourni = new System.Windows.Forms.TextBox();
            this.lb_ajoutfourni = new System.Windows.Forms.Label();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nomfourni
            // 
            this.tb_nomfourni.Location = new System.Drawing.Point(259, 234);
            this.tb_nomfourni.Name = "tb_nomfourni";
            this.tb_nomfourni.Size = new System.Drawing.Size(216, 31);
            this.tb_nomfourni.TabIndex = 1;
            // 
            // lb_ajoutfourni
            // 
            this.lb_ajoutfourni.AutoSize = true;
            this.lb_ajoutfourni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ajoutfourni.Location = new System.Drawing.Point(237, 115);
            this.lb_ajoutfourni.Name = "lb_ajoutfourni";
            this.lb_ajoutfourni.Size = new System.Drawing.Size(350, 37);
            this.lb_ajoutfourni.TabIndex = 2;
            this.lb_ajoutfourni.Text = "ajouter un fournisseur";
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ajouter.Location = new System.Drawing.Point(517, 233);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(115, 40);
            this.bt_ajouter.TabIndex = 3;
            this.bt_ajouter.Text = "ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projet1._1.Properties.Resources.Actions_list_add_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(26, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.lb_ajoutfourni);
            this.Controls.Add(this.tb_nomfourni);
            this.Name = "fournisseur";
            this.Load += new System.EventHandler(this.fournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nomfourni;
        private System.Windows.Forms.Label lb_ajoutfourni;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}