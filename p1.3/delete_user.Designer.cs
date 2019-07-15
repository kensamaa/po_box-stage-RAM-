namespace projet1._1
{
    partial class delete_user
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ajoutfourni = new System.Windows.Forms.Label();
            this.bt_delet_user = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.4734F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.28192F));
            this.tableLayoutPanel1.Controls.Add(this.tb_username, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_ajoutfourni, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_delet_user, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.90598F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 234);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tb_username
            // 
            this.tb_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_username.Location = new System.Drawing.Point(253, 81);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(216, 31);
            this.tb_username.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "username :";
            // 
            // lb_ajoutfourni
            // 
            this.lb_ajoutfourni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ajoutfourni.AutoSize = true;
            this.lb_ajoutfourni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ajoutfourni.Location = new System.Drawing.Point(305, 20);
            this.lb_ajoutfourni.Name = "lb_ajoutfourni";
            this.lb_ajoutfourni.Size = new System.Drawing.Size(245, 37);
            this.lb_ajoutfourni.TabIndex = 8;
            this.lb_ajoutfourni.Text = "supprimer user";
            // 
            // bt_delet_user
            // 
            this.bt_delet_user.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_delet_user.Location = new System.Drawing.Point(609, 177);
            this.bt_delet_user.Name = "bt_delet_user";
            this.bt_delet_user.Size = new System.Drawing.Size(115, 40);
            this.bt_delet_user.TabIndex = 9;
            this.bt_delet_user.Text = "supprimer";
            this.bt_delet_user.UseVisualStyleBackColor = true;
            this.bt_delet_user.Click += new System.EventHandler(this.bt_delet_user_Click);
            // 
            // delete_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "delete_user";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ajoutfourni;
        private System.Windows.Forms.Button bt_delet_user;
    }
}