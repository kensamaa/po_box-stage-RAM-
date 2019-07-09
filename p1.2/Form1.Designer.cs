namespace projet1._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.date_reception = new System.Windows.Forms.DateTimePicker();
            this.date_envoi_fedosa = new System.Windows.Forms.DateTimePicker();
            this.date_facture = new System.Windows.Forms.DateTimePicker();
            this.cb_fournisseur = new System.Windows.Forms.ComboBox();
            this.cb_restitution_fedosa = new System.Windows.Forms.ComboBox();
            this.tb_pole = new System.Windows.Forms.TextBox();
            this.tb_nFacture = new System.Windows.Forms.TextBox();
            this.tb_objetFacture = new System.Windows.Forms.TextBox();
            this.tb_emeteur = new System.Windows.Forms.TextBox();
            this.tb_remarque = new System.Windows.Forms.TextBox();
            this.tb_montant = new System.Windows.Forms.TextBox();
            this.date_envoi_dfi = new System.Windows.Forms.DateTimePicker();
            this.lb_dtReception = new System.Windows.Forms.Label();
            this.lb_direction = new System.Windows.Forms.Label();
            this.lb_emeteur = new System.Windows.Forms.Label();
            this.lb_destinataire = new System.Windows.Forms.Label();
            this.lb_fournisseur = new System.Windows.Forms.Label();
            this.lb_dtFacture = new System.Windows.Forms.Label();
            this.lb_montant = new System.Windows.Forms.Label();
            this.lb_devise = new System.Windows.Forms.Label();
            this.lb_objetFacture = new System.Windows.Forms.Label();
            this.lb_nfacture = new System.Windows.Forms.Label();
            this.lb_Ncomand = new System.Windows.Forms.Label();
            this.lb_dtenvoi = new System.Windows.Forms.Label();
            this.lb_restitution = new System.Windows.Forms.Label();
            this.lb_remarke = new System.Windows.Forms.Label();
            this.lb_pole = new System.Windows.Forms.Label();
            this.lb_dtenvoidfi = new System.Windows.Forms.Label();
            this.tb_nComande = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_poboxp2p = new System.Windows.Forms.Label();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.lb_envoidfipayement = new System.Windows.Forms.Label();
            this.cb_envoi_dfi_paiement = new System.Windows.Forms.ComboBox();
            this.bt_ajoutfournisseur = new System.Windows.Forms.Button();
            this.cb_direction = new System.Windows.Forms.ComboBox();
            this.tb_devise = new System.Windows.Forms.TextBox();
            this.bt_delet_fournisseur = new System.Windows.Forms.Button();
            this.bt_recherch = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            this.bt_supprim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // date_reception
            // 
            this.date_reception.CustomFormat = "dd/MM/yyyy";
            this.date_reception.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_reception.Location = new System.Drawing.Point(78, 102);
            this.date_reception.Name = "date_reception";
            this.date_reception.Size = new System.Drawing.Size(173, 31);
            this.date_reception.TabIndex = 0;
            this.date_reception.ValueChanged += new System.EventHandler(this.date_reception_ValueChanged);
            // 
            // date_envoi_fedosa
            // 
            this.date_envoi_fedosa.CustomFormat = "dd/MM/yyyy";
            this.date_envoi_fedosa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_envoi_fedosa.Location = new System.Drawing.Point(572, 274);
            this.date_envoi_fedosa.Name = "date_envoi_fedosa";
            this.date_envoi_fedosa.Size = new System.Drawing.Size(172, 31);
            this.date_envoi_fedosa.TabIndex = 1;
            // 
            // date_facture
            // 
            this.date_facture.CustomFormat = "dd/MM/yyyy";
            this.date_facture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_facture.Location = new System.Drawing.Point(1139, 102);
            this.date_facture.Name = "date_facture";
            this.date_facture.Size = new System.Drawing.Size(161, 31);
            this.date_facture.TabIndex = 2;
            // 
            // cb_fournisseur
            // 
            this.cb_fournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fournisseur.FormattingEnabled = true;
            this.cb_fournisseur.Location = new System.Drawing.Point(920, 106);
            this.cb_fournisseur.Name = "cb_fournisseur";
            this.cb_fournisseur.Size = new System.Drawing.Size(121, 33);
            this.cb_fournisseur.TabIndex = 3;
            // 
            // cb_restitution_fedosa
            // 
            this.cb_restitution_fedosa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_restitution_fedosa.FormattingEnabled = true;
            this.cb_restitution_fedosa.Items.AddRange(new object[] {
            "OUI",
            "NON"});
            this.cb_restitution_fedosa.Location = new System.Drawing.Point(830, 268);
            this.cb_restitution_fedosa.Name = "cb_restitution_fedosa";
            this.cb_restitution_fedosa.Size = new System.Drawing.Size(94, 33);
            this.cb_restitution_fedosa.TabIndex = 5;
            // 
            // tb_pole
            // 
            this.tb_pole.Location = new System.Drawing.Point(1482, 270);
            this.tb_pole.Name = "tb_pole";
            this.tb_pole.Size = new System.Drawing.Size(100, 31);
            this.tb_pole.TabIndex = 7;
            // 
            // tb_nFacture
            // 
            this.tb_nFacture.Location = new System.Drawing.Point(51, 276);
            this.tb_nFacture.Name = "tb_nFacture";
            this.tb_nFacture.Size = new System.Drawing.Size(164, 31);
            this.tb_nFacture.TabIndex = 9;
            // 
            // tb_objetFacture
            // 
            this.tb_objetFacture.Location = new System.Drawing.Point(1651, 110);
            this.tb_objetFacture.Multiline = true;
            this.tb_objetFacture.Name = "tb_objetFacture";
            this.tb_objetFacture.Size = new System.Drawing.Size(162, 31);
            this.tb_objetFacture.TabIndex = 10;
            // 
            // tb_emeteur
            // 
            this.tb_emeteur.Location = new System.Drawing.Point(477, 108);
            this.tb_emeteur.Name = "tb_emeteur";
            this.tb_emeteur.Size = new System.Drawing.Size(149, 31);
            this.tb_emeteur.TabIndex = 12;
            // 
            // tb_remarque
            // 
            this.tb_remarque.Location = new System.Drawing.Point(1268, 268);
            this.tb_remarque.Multiline = true;
            this.tb_remarque.Name = "tb_remarque";
            this.tb_remarque.Size = new System.Drawing.Size(187, 31);
            this.tb_remarque.TabIndex = 13;
            // 
            // tb_montant
            // 
            this.tb_montant.Location = new System.Drawing.Point(1350, 106);
            this.tb_montant.Name = "tb_montant";
            this.tb_montant.Size = new System.Drawing.Size(100, 31);
            this.tb_montant.TabIndex = 14;
            this.tb_montant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_montant_KeyPress);
            // 
            // date_envoi_dfi
            // 
            this.date_envoi_dfi.CustomFormat = "dd/MM/yyyy";
            this.date_envoi_dfi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_envoi_dfi.Location = new System.Drawing.Point(1636, 266);
            this.date_envoi_dfi.Name = "date_envoi_dfi";
            this.date_envoi_dfi.Size = new System.Drawing.Size(153, 31);
            this.date_envoi_dfi.TabIndex = 16;
            // 
            // lb_dtReception
            // 
            this.lb_dtReception.AutoSize = true;
            this.lb_dtReception.Location = new System.Drawing.Point(60, 64);
            this.lb_dtReception.Name = "lb_dtReception";
            this.lb_dtReception.Size = new System.Drawing.Size(179, 25);
            this.lb_dtReception.TabIndex = 17;
            this.lb_dtReception.Text = "date de reception";
            // 
            // lb_direction
            // 
            this.lb_direction.AutoSize = true;
            this.lb_direction.Location = new System.Drawing.Point(327, 64);
            this.lb_direction.Name = "lb_direction";
            this.lb_direction.Size = new System.Drawing.Size(94, 25);
            this.lb_direction.TabIndex = 18;
            this.lb_direction.Text = "direction";
            // 
            // lb_emeteur
            // 
            this.lb_emeteur.AutoSize = true;
            this.lb_emeteur.Location = new System.Drawing.Point(502, 64);
            this.lb_emeteur.Name = "lb_emeteur";
            this.lb_emeteur.Size = new System.Drawing.Size(90, 25);
            this.lb_emeteur.TabIndex = 19;
            this.lb_emeteur.Text = "emeteur";
            // 
            // lb_destinataire
            // 
            this.lb_destinataire.AutoSize = true;
            this.lb_destinataire.Location = new System.Drawing.Point(695, 64);
            this.lb_destinataire.Name = "lb_destinataire";
            this.lb_destinataire.Size = new System.Drawing.Size(124, 25);
            this.lb_destinataire.TabIndex = 20;
            this.lb_destinataire.Text = "destinataire";
            // 
            // lb_fournisseur
            // 
            this.lb_fournisseur.AutoSize = true;
            this.lb_fournisseur.Location = new System.Drawing.Point(922, 64);
            this.lb_fournisseur.Name = "lb_fournisseur";
            this.lb_fournisseur.Size = new System.Drawing.Size(119, 25);
            this.lb_fournisseur.TabIndex = 21;
            this.lb_fournisseur.Text = "fournisseur";
            // 
            // lb_dtFacture
            // 
            this.lb_dtFacture.AutoSize = true;
            this.lb_dtFacture.Location = new System.Drawing.Point(1134, 64);
            this.lb_dtFacture.Name = "lb_dtFacture";
            this.lb_dtFacture.Size = new System.Drawing.Size(156, 25);
            this.lb_dtFacture.TabIndex = 22;
            this.lb_dtFacture.Text = "date de facture";
            // 
            // lb_montant
            // 
            this.lb_montant.AutoSize = true;
            this.lb_montant.Location = new System.Drawing.Point(1341, 64);
            this.lb_montant.Name = "lb_montant";
            this.lb_montant.Size = new System.Drawing.Size(118, 25);
            this.lb_montant.TabIndex = 23;
            this.lb_montant.Text = "montant ttc";
            this.lb_montant.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_devise
            // 
            this.lb_devise.AutoSize = true;
            this.lb_devise.Location = new System.Drawing.Point(1498, 74);
            this.lb_devise.Name = "lb_devise";
            this.lb_devise.Size = new System.Drawing.Size(75, 25);
            this.lb_devise.TabIndex = 24;
            this.lb_devise.Text = "devise";
            // 
            // lb_objetFacture
            // 
            this.lb_objetFacture.AutoSize = true;
            this.lb_objetFacture.Location = new System.Drawing.Point(1646, 74);
            this.lb_objetFacture.Name = "lb_objetFacture";
            this.lb_objetFacture.Size = new System.Drawing.Size(161, 25);
            this.lb_objetFacture.TabIndex = 25;
            this.lb_objetFacture.Text = "objet de facture";
            // 
            // lb_nfacture
            // 
            this.lb_nfacture.AutoSize = true;
            this.lb_nfacture.Location = new System.Drawing.Point(69, 221);
            this.lb_nfacture.Name = "lb_nfacture";
            this.lb_nfacture.Size = new System.Drawing.Size(99, 25);
            this.lb_nfacture.TabIndex = 26;
            this.lb_nfacture.Text = "N facture";
            // 
            // lb_Ncomand
            // 
            this.lb_Ncomand.AutoSize = true;
            this.lb_Ncomand.Location = new System.Drawing.Point(327, 221);
            this.lb_Ncomand.Name = "lb_Ncomand";
            this.lb_Ncomand.Size = new System.Drawing.Size(138, 25);
            this.lb_Ncomand.TabIndex = 27;
            this.lb_Ncomand.Text = "N commande";
            // 
            // lb_dtenvoi
            // 
            this.lb_dtenvoi.AutoSize = true;
            this.lb_dtenvoi.Location = new System.Drawing.Point(544, 221);
            this.lb_dtenvoi.Name = "lb_dtenvoi";
            this.lb_dtenvoi.Size = new System.Drawing.Size(219, 25);
            this.lb_dtenvoi.TabIndex = 28;
            this.lb_dtenvoi.Text = "date d envoi a fedosa";
            // 
            // lb_restitution
            // 
            this.lb_restitution.AutoSize = true;
            this.lb_restitution.Location = new System.Drawing.Point(795, 221);
            this.lb_restitution.Name = "lb_restitution";
            this.lb_restitution.Size = new System.Drawing.Size(177, 25);
            this.lb_restitution.TabIndex = 29;
            this.lb_restitution.Text = "restitution fedosa";
            this.lb_restitution.Click += new System.EventHandler(this.label13_Click);
            // 
            // lb_remarke
            // 
            this.lb_remarke.AutoSize = true;
            this.lb_remarke.Location = new System.Drawing.Point(1310, 221);
            this.lb_remarke.Name = "lb_remarke";
            this.lb_remarke.Size = new System.Drawing.Size(90, 25);
            this.lb_remarke.TabIndex = 30;
            this.lb_remarke.Text = "remarke";
            // 
            // lb_pole
            // 
            this.lb_pole.AutoSize = true;
            this.lb_pole.Location = new System.Drawing.Point(1504, 221);
            this.lb_pole.Name = "lb_pole";
            this.lb_pole.Size = new System.Drawing.Size(53, 25);
            this.lb_pole.TabIndex = 31;
            this.lb_pole.Text = "pole";
            this.lb_pole.Click += new System.EventHandler(this.label15_Click);
            // 
            // lb_dtenvoidfi
            // 
            this.lb_dtenvoidfi.AutoSize = true;
            this.lb_dtenvoidfi.Location = new System.Drawing.Point(1603, 221);
            this.lb_dtenvoidfi.Name = "lb_dtenvoidfi";
            this.lb_dtenvoidfi.Size = new System.Drawing.Size(200, 25);
            this.lb_dtenvoidfi.TabIndex = 32;
            this.lb_dtenvoidfi.Text = "date d envoi a la dfi";
            // 
            // tb_nComande
            // 
            this.tb_nComande.Location = new System.Drawing.Point(300, 274);
            this.tb_nComande.Name = "tb_nComande";
            this.tb_nComande.Size = new System.Drawing.Size(174, 31);
            this.tb_nComande.TabIndex = 34;
            this.tb_nComande.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nComande_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1733, 422);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lb_poboxp2p
            // 
            this.lb_poboxp2p.AutoSize = true;
            this.lb_poboxp2p.Location = new System.Drawing.Point(695, 108);
            this.lb_poboxp2p.Name = "lb_poboxp2p";
            this.lb_poboxp2p.Size = new System.Drawing.Size(138, 25);
            this.lb_poboxp2p.TabIndex = 36;
            this.lb_poboxp2p.Text = "PO BOX P2P";
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(1815, 432);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(202, 45);
            this.bt_ajouter.TabIndex = 37;
            this.bt_ajouter.Text = "ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // lb_envoidfipayement
            // 
            this.lb_envoidfipayement.AutoSize = true;
            this.lb_envoidfipayement.Location = new System.Drawing.Point(978, 221);
            this.lb_envoidfipayement.Name = "lb_envoidfipayement";
            this.lb_envoidfipayement.Size = new System.Drawing.Size(254, 25);
            this.lb_envoidfipayement.TabIndex = 38;
            this.lb_envoidfipayement.Text = "envoi a dfi pour paiement";
            // 
            // cb_envoi_dfi_paiement
            // 
            this.cb_envoi_dfi_paiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_envoi_dfi_paiement.FormattingEnabled = true;
            this.cb_envoi_dfi_paiement.Items.AddRange(new object[] {
            "NON",
            "OUI"});
            this.cb_envoi_dfi_paiement.Location = new System.Drawing.Point(1071, 268);
            this.cb_envoi_dfi_paiement.Name = "cb_envoi_dfi_paiement";
            this.cb_envoi_dfi_paiement.Size = new System.Drawing.Size(91, 33);
            this.cb_envoi_dfi_paiement.TabIndex = 39;
            // 
            // bt_ajoutfournisseur
            // 
            this.bt_ajoutfournisseur.Location = new System.Drawing.Point(1047, 106);
            this.bt_ajoutfournisseur.Name = "bt_ajoutfournisseur";
            this.bt_ajoutfournisseur.Size = new System.Drawing.Size(56, 37);
            this.bt_ajoutfournisseur.TabIndex = 40;
            this.bt_ajoutfournisseur.Text = "+";
            this.bt_ajoutfournisseur.UseVisualStyleBackColor = true;
            this.bt_ajoutfournisseur.Click += new System.EventHandler(this.bt_ajoutfournisseur_Click);
            // 
            // cb_direction
            // 
            this.cb_direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_direction.FormattingEnabled = true;
            this.cb_direction.Items.AddRange(new object[] {
            "DAAG",
            "DFI",
            "DGA",
            "DM",
            "DOA",
            "DOSI",
            "DQSS",
            "DRH",
            "DRRM",
            "DV"});
            this.cb_direction.Location = new System.Drawing.Point(314, 110);
            this.cb_direction.Name = "cb_direction";
            this.cb_direction.Size = new System.Drawing.Size(121, 33);
            this.cb_direction.TabIndex = 41;
            // 
            // tb_devise
            // 
            this.tb_devise.Location = new System.Drawing.Point(1486, 106);
            this.tb_devise.Name = "tb_devise";
            this.tb_devise.Size = new System.Drawing.Size(100, 31);
            this.tb_devise.TabIndex = 42;
            // 
            // bt_delet_fournisseur
            // 
            this.bt_delet_fournisseur.Location = new System.Drawing.Point(858, 106);
            this.bt_delet_fournisseur.Name = "bt_delet_fournisseur";
            this.bt_delet_fournisseur.Size = new System.Drawing.Size(56, 37);
            this.bt_delet_fournisseur.TabIndex = 43;
            this.bt_delet_fournisseur.Text = "-";
            this.bt_delet_fournisseur.UseVisualStyleBackColor = true;
            this.bt_delet_fournisseur.Click += new System.EventHandler(this.bt_delet_fournisseur_Click);
            // 
            // bt_recherch
            // 
            this.bt_recherch.Location = new System.Drawing.Point(1815, 505);
            this.bt_recherch.Name = "bt_recherch";
            this.bt_recherch.Size = new System.Drawing.Size(202, 37);
            this.bt_recherch.TabIndex = 44;
            this.bt_recherch.Text = "recherche";
            this.bt_recherch.UseVisualStyleBackColor = true;
            this.bt_recherch.Click += new System.EventHandler(this.bt_recherch_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(1815, 564);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(202, 38);
            this.bt_modifier.TabIndex = 45;
            this.bt_modifier.Text = "modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_export
            // 
            this.bt_export.Location = new System.Drawing.Point(1815, 690);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(202, 40);
            this.bt_export.TabIndex = 46;
            this.bt_export.Text = "exporter";
            this.bt_export.UseVisualStyleBackColor = true;
            // 
            // bt_supprim
            // 
            this.bt_supprim.Location = new System.Drawing.Point(1815, 630);
            this.bt_supprim.Name = "bt_supprim";
            this.bt_supprim.Size = new System.Drawing.Size(202, 42);
            this.bt_supprim.TabIndex = 47;
            this.bt_supprim.Text = "supprimer";
            this.bt_supprim.UseVisualStyleBackColor = true;
            this.bt_supprim.Click += new System.EventHandler(this.bt_supprim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2067, 929);
            this.Controls.Add(this.bt_supprim);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_recherch);
            this.Controls.Add(this.bt_delet_fournisseur);
            this.Controls.Add(this.tb_devise);
            this.Controls.Add(this.cb_direction);
            this.Controls.Add(this.bt_ajoutfournisseur);
            this.Controls.Add(this.cb_envoi_dfi_paiement);
            this.Controls.Add(this.lb_envoidfipayement);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.lb_poboxp2p);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_nComande);
            this.Controls.Add(this.lb_dtenvoidfi);
            this.Controls.Add(this.lb_pole);
            this.Controls.Add(this.lb_remarke);
            this.Controls.Add(this.lb_restitution);
            this.Controls.Add(this.lb_dtenvoi);
            this.Controls.Add(this.lb_Ncomand);
            this.Controls.Add(this.lb_nfacture);
            this.Controls.Add(this.lb_objetFacture);
            this.Controls.Add(this.lb_devise);
            this.Controls.Add(this.lb_montant);
            this.Controls.Add(this.lb_dtFacture);
            this.Controls.Add(this.lb_fournisseur);
            this.Controls.Add(this.lb_destinataire);
            this.Controls.Add(this.lb_emeteur);
            this.Controls.Add(this.lb_direction);
            this.Controls.Add(this.lb_dtReception);
            this.Controls.Add(this.date_envoi_dfi);
            this.Controls.Add(this.tb_montant);
            this.Controls.Add(this.tb_remarque);
            this.Controls.Add(this.tb_emeteur);
            this.Controls.Add(this.tb_objetFacture);
            this.Controls.Add(this.tb_nFacture);
            this.Controls.Add(this.tb_pole);
            this.Controls.Add(this.cb_restitution_fedosa);
            this.Controls.Add(this.cb_fournisseur);
            this.Controls.Add(this.date_facture);
            this.Controls.Add(this.date_envoi_fedosa);
            this.Controls.Add(this.date_reception);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_reception;
        private System.Windows.Forms.DateTimePicker date_envoi_fedosa;
        private System.Windows.Forms.DateTimePicker date_facture;
        private System.Windows.Forms.ComboBox cb_fournisseur;
        private System.Windows.Forms.ComboBox cb_restitution_fedosa;
        private System.Windows.Forms.TextBox tb_pole;
        private System.Windows.Forms.TextBox tb_nFacture;
        private System.Windows.Forms.TextBox tb_objetFacture;
        private System.Windows.Forms.TextBox tb_emeteur;
        private System.Windows.Forms.TextBox tb_remarque;
        private System.Windows.Forms.TextBox tb_montant;
        private System.Windows.Forms.DateTimePicker date_envoi_dfi;
        private System.Windows.Forms.Label lb_dtReception;
        private System.Windows.Forms.Label lb_direction;
        private System.Windows.Forms.Label lb_emeteur;
        private System.Windows.Forms.Label lb_destinataire;
        private System.Windows.Forms.Label lb_fournisseur;
        private System.Windows.Forms.Label lb_dtFacture;
        private System.Windows.Forms.Label lb_montant;
        private System.Windows.Forms.Label lb_devise;
        private System.Windows.Forms.Label lb_objetFacture;
        private System.Windows.Forms.Label lb_nfacture;
        private System.Windows.Forms.Label lb_Ncomand;
        private System.Windows.Forms.Label lb_dtenvoi;
        private System.Windows.Forms.Label lb_restitution;
        private System.Windows.Forms.Label lb_remarke;
        private System.Windows.Forms.Label lb_pole;
        private System.Windows.Forms.Label lb_dtenvoidfi;
        private System.Windows.Forms.TextBox tb_nComande;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_poboxp2p;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Label lb_envoidfipayement;
        private System.Windows.Forms.ComboBox cb_envoi_dfi_paiement;
        private System.Windows.Forms.Button bt_ajoutfournisseur;
        private System.Windows.Forms.ComboBox cb_direction;
        private System.Windows.Forms.TextBox tb_devise;
        private System.Windows.Forms.Button bt_delet_fournisseur;
        private System.Windows.Forms.Button bt_recherch;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.Button bt_supprim;
    }
}

