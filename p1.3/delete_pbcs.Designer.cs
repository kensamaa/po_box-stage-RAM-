namespace projet1._1
{
    partial class delete_pbcs
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
            this.tb_nfact = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fourni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_delet
            // 
            this.bt_delet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_delet.Location = new System.Drawing.Point(577, 177);
            this.bt_delet.Name = "bt_delet";
            this.bt_delet.Size = new System.Drawing.Size(115, 40);
            this.bt_delet.TabIndex = 9;
            this.bt_delet.Text = "supprimer";
            this.bt_delet.UseVisualStyleBackColor = true;
            this.bt_delet.Click += new System.EventHandler(this.bt_delet_Click);
            // 
            // lb_ajoutfourni
            // 
            this.lb_ajoutfourni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ajoutfourni.AutoSize = true;
            this.lb_ajoutfourni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ajoutfourni.Location = new System.Drawing.Point(249, 23);
            this.lb_ajoutfourni.Name = "lb_ajoutfourni";
            this.lb_ajoutfourni.Size = new System.Drawing.Size(284, 37);
            this.lb_ajoutfourni.TabIndex = 8;
            this.lb_ajoutfourni.Text = "supprimer facture";
            // 
            // tb_nfact
            // 
            this.tb_nfact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_nfact.Location = new System.Drawing.Point(283, 129);
            this.tb_nfact.Name = "tb_nfact";
            this.tb_nfact.Size = new System.Drawing.Size(216, 31);
            this.tb_nfact.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.01299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.53247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.32467F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_fourni, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_nfact, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_ajoutfourni, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_delet, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.67521F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 234);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nfacture :";
            // 
            // tb_fourni
            // 
            this.tb_fourni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_fourni.Location = new System.Drawing.Point(283, 87);
            this.tb_fourni.Name = "tb_fourni";
            this.tb_fourni.Size = new System.Drawing.Size(216, 31);
            this.tb_fourni.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "fournisseur :";
            // 
            // delete_pbcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "delete_pbcs";
            this.Load += new System.EventHandler(this.delete_pbcs_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_delet;
        private System.Windows.Forms.Label lb_ajoutfourni;
        private System.Windows.Forms.TextBox tb_nfact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_fourni;
        private System.Windows.Forms.Label label1;
    }
}