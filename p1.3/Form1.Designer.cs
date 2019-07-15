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
            this.lb_envoidfipayement = new System.Windows.Forms.Label();
            this.cb_envoi_dfi_paiement = new System.Windows.Forms.ComboBox();
            this.cb_direction = new System.Windows.Forms.ComboBox();
            this.tb_devise = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_sup_user = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_historik = new System.Windows.Forms.Button();
            this.bt_add_user = new System.Windows.Forms.Button();
            this.bt_supprim = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_recherch = new System.Windows.Forms.Button();
            this.bt_delet_fournisseur = new System.Windows.Forms.Button();
            this.bt_ajoutfournisseur = new System.Windows.Forms.Button();
            this.bt_ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // date_reception
            // 
            this.date_reception.CustomFormat = "dd/MM/yyyy";
            this.date_reception.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_reception.Location = new System.Drawing.Point(195, 185);
            this.date_reception.Name = "date_reception";
            this.date_reception.Size = new System.Drawing.Size(173, 31);
            this.date_reception.TabIndex = 0;
            this.date_reception.ValueChanged += new System.EventHandler(this.date_reception_ValueChanged);
            // 
            // date_envoi_fedosa
            // 
            this.date_envoi_fedosa.CustomFormat = "dd/MM/yyyy";
            this.date_envoi_fedosa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_envoi_fedosa.Location = new System.Drawing.Point(722, 314);
            this.date_envoi_fedosa.Name = "date_envoi_fedosa";
            this.date_envoi_fedosa.Size = new System.Drawing.Size(172, 31);
            this.date_envoi_fedosa.TabIndex = 1;
            // 
            // date_facture
            // 
            this.date_facture.CustomFormat = "dd/MM/yyyy";
            this.date_facture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_facture.Location = new System.Drawing.Point(1256, 185);
            this.date_facture.Name = "date_facture";
            this.date_facture.Size = new System.Drawing.Size(161, 31);
            this.date_facture.TabIndex = 2;
            // 
            // cb_fournisseur
            // 
            this.cb_fournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fournisseur.FormattingEnabled = true;
            this.cb_fournisseur.Location = new System.Drawing.Point(1037, 189);
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
            this.cb_restitution_fedosa.Location = new System.Drawing.Point(980, 308);
            this.cb_restitution_fedosa.Name = "cb_restitution_fedosa";
            this.cb_restitution_fedosa.Size = new System.Drawing.Size(94, 33);
            this.cb_restitution_fedosa.TabIndex = 5;
            // 
            // tb_pole
            // 
            this.tb_pole.Location = new System.Drawing.Point(1632, 310);
            this.tb_pole.Name = "tb_pole";
            this.tb_pole.Size = new System.Drawing.Size(100, 31);
            this.tb_pole.TabIndex = 7;
            // 
            // tb_nFacture
            // 
            this.tb_nFacture.Location = new System.Drawing.Point(201, 316);
            this.tb_nFacture.Name = "tb_nFacture";
            this.tb_nFacture.Size = new System.Drawing.Size(164, 31);
            this.tb_nFacture.TabIndex = 9;
            // 
            // tb_objetFacture
            // 
            this.tb_objetFacture.Location = new System.Drawing.Point(1768, 193);
            this.tb_objetFacture.Multiline = true;
            this.tb_objetFacture.Name = "tb_objetFacture";
            this.tb_objetFacture.Size = new System.Drawing.Size(162, 31);
            this.tb_objetFacture.TabIndex = 10;
            // 
            // tb_emeteur
            // 
            this.tb_emeteur.Location = new System.Drawing.Point(594, 191);
            this.tb_emeteur.Name = "tb_emeteur";
            this.tb_emeteur.Size = new System.Drawing.Size(149, 31);
            this.tb_emeteur.TabIndex = 12;
            // 
            // tb_remarque
            // 
            this.tb_remarque.Location = new System.Drawing.Point(1418, 308);
            this.tb_remarque.Multiline = true;
            this.tb_remarque.Name = "tb_remarque";
            this.tb_remarque.Size = new System.Drawing.Size(187, 31);
            this.tb_remarque.TabIndex = 13;
            // 
            // tb_montant
            // 
            this.tb_montant.Location = new System.Drawing.Point(1467, 189);
            this.tb_montant.Name = "tb_montant";
            this.tb_montant.Size = new System.Drawing.Size(100, 31);
            this.tb_montant.TabIndex = 14;
            this.tb_montant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_montant_KeyPress);
            // 
            // date_envoi_dfi
            // 
            this.date_envoi_dfi.CustomFormat = "dd/MM/yyyy";
            this.date_envoi_dfi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_envoi_dfi.Location = new System.Drawing.Point(1786, 306);
            this.date_envoi_dfi.Name = "date_envoi_dfi";
            this.date_envoi_dfi.Size = new System.Drawing.Size(153, 31);
            this.date_envoi_dfi.TabIndex = 16;
            // 
            // lb_dtReception
            // 
            this.lb_dtReception.AutoSize = true;
            this.lb_dtReception.Location = new System.Drawing.Point(217, 157);
            this.lb_dtReception.Name = "lb_dtReception";
            this.lb_dtReception.Size = new System.Drawing.Size(179, 25);
            this.lb_dtReception.TabIndex = 17;
            this.lb_dtReception.Text = "date de reception";
            // 
            // lb_direction
            // 
            this.lb_direction.AutoSize = true;
            this.lb_direction.Location = new System.Drawing.Point(458, 157);
            this.lb_direction.Name = "lb_direction";
            this.lb_direction.Size = new System.Drawing.Size(94, 25);
            this.lb_direction.TabIndex = 18;
            this.lb_direction.Text = "direction";
            // 
            // lb_emeteur
            // 
            this.lb_emeteur.AutoSize = true;
            this.lb_emeteur.Location = new System.Drawing.Point(631, 157);
            this.lb_emeteur.Name = "lb_emeteur";
            this.lb_emeteur.Size = new System.Drawing.Size(90, 25);
            this.lb_emeteur.TabIndex = 19;
            this.lb_emeteur.Text = "emeteur";
            // 
            // lb_destinataire
            // 
            this.lb_destinataire.AutoSize = true;
            this.lb_destinataire.Location = new System.Drawing.Point(809, 157);
            this.lb_destinataire.Name = "lb_destinataire";
            this.lb_destinataire.Size = new System.Drawing.Size(124, 25);
            this.lb_destinataire.TabIndex = 20;
            this.lb_destinataire.Text = "destinataire";
            // 
            // lb_fournisseur
            // 
            this.lb_fournisseur.AutoSize = true;
            this.lb_fournisseur.Location = new System.Drawing.Point(1043, 157);
            this.lb_fournisseur.Name = "lb_fournisseur";
            this.lb_fournisseur.Size = new System.Drawing.Size(119, 25);
            this.lb_fournisseur.TabIndex = 21;
            this.lb_fournisseur.Text = "fournisseur";
            // 
            // lb_dtFacture
            // 
            this.lb_dtFacture.AutoSize = true;
            this.lb_dtFacture.Location = new System.Drawing.Point(1251, 157);
            this.lb_dtFacture.Name = "lb_dtFacture";
            this.lb_dtFacture.Size = new System.Drawing.Size(156, 25);
            this.lb_dtFacture.TabIndex = 22;
            this.lb_dtFacture.Text = "date de facture";
            // 
            // lb_montant
            // 
            this.lb_montant.AutoSize = true;
            this.lb_montant.Location = new System.Drawing.Point(1472, 157);
            this.lb_montant.Name = "lb_montant";
            this.lb_montant.Size = new System.Drawing.Size(118, 25);
            this.lb_montant.TabIndex = 23;
            this.lb_montant.Text = "montant ttc";
            this.lb_montant.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_devise
            // 
            this.lb_devise.AutoSize = true;
            this.lb_devise.Location = new System.Drawing.Point(1627, 157);
            this.lb_devise.Name = "lb_devise";
            this.lb_devise.Size = new System.Drawing.Size(75, 25);
            this.lb_devise.TabIndex = 24;
            this.lb_devise.Text = "devise";
            // 
            // lb_objetFacture
            // 
            this.lb_objetFacture.AutoSize = true;
            this.lb_objetFacture.Location = new System.Drawing.Point(1778, 157);
            this.lb_objetFacture.Name = "lb_objetFacture";
            this.lb_objetFacture.Size = new System.Drawing.Size(161, 25);
            this.lb_objetFacture.TabIndex = 25;
            this.lb_objetFacture.Text = "objet de facture";
            // 
            // lb_nfacture
            // 
            this.lb_nfacture.AutoSize = true;
            this.lb_nfacture.Location = new System.Drawing.Point(229, 271);
            this.lb_nfacture.Name = "lb_nfacture";
            this.lb_nfacture.Size = new System.Drawing.Size(99, 25);
            this.lb_nfacture.TabIndex = 26;
            this.lb_nfacture.Text = "N facture";
            // 
            // lb_Ncomand
            // 
            this.lb_Ncomand.AutoSize = true;
            this.lb_Ncomand.Location = new System.Drawing.Point(472, 271);
            this.lb_Ncomand.Name = "lb_Ncomand";
            this.lb_Ncomand.Size = new System.Drawing.Size(138, 25);
            this.lb_Ncomand.TabIndex = 27;
            this.lb_Ncomand.Text = "N commande";
            // 
            // lb_dtenvoi
            // 
            this.lb_dtenvoi.AutoSize = true;
            this.lb_dtenvoi.Location = new System.Drawing.Point(714, 271);
            this.lb_dtenvoi.Name = "lb_dtenvoi";
            this.lb_dtenvoi.Size = new System.Drawing.Size(219, 25);
            this.lb_dtenvoi.TabIndex = 28;
            this.lb_dtenvoi.Text = "date d envoi a fedosa";
            // 
            // lb_restitution
            // 
            this.lb_restitution.AutoSize = true;
            this.lb_restitution.Location = new System.Drawing.Point(952, 271);
            this.lb_restitution.Name = "lb_restitution";
            this.lb_restitution.Size = new System.Drawing.Size(177, 25);
            this.lb_restitution.TabIndex = 29;
            this.lb_restitution.Text = "restitution fedosa";
            this.lb_restitution.Click += new System.EventHandler(this.label13_Click);
            // 
            // lb_remarke
            // 
            this.lb_remarke.AutoSize = true;
            this.lb_remarke.Location = new System.Drawing.Point(1477, 271);
            this.lb_remarke.Name = "lb_remarke";
            this.lb_remarke.Size = new System.Drawing.Size(90, 25);
            this.lb_remarke.TabIndex = 30;
            this.lb_remarke.Text = "remarke";
            // 
            // lb_pole
            // 
            this.lb_pole.AutoSize = true;
            this.lb_pole.Location = new System.Drawing.Point(1659, 271);
            this.lb_pole.Name = "lb_pole";
            this.lb_pole.Size = new System.Drawing.Size(53, 25);
            this.lb_pole.TabIndex = 31;
            this.lb_pole.Text = "pole";
            this.lb_pole.Click += new System.EventHandler(this.label15_Click);
            // 
            // lb_dtenvoidfi
            // 
            this.lb_dtenvoidfi.AutoSize = true;
            this.lb_dtenvoidfi.Location = new System.Drawing.Point(1778, 271);
            this.lb_dtenvoidfi.Name = "lb_dtenvoidfi";
            this.lb_dtenvoidfi.Size = new System.Drawing.Size(200, 25);
            this.lb_dtenvoidfi.TabIndex = 32;
            this.lb_dtenvoidfi.Text = "date d envoi a la dfi";
            // 
            // tb_nComande
            // 
            this.tb_nComande.Location = new System.Drawing.Point(450, 314);
            this.tb_nComande.Name = "tb_nComande";
            this.tb_nComande.Size = new System.Drawing.Size(174, 31);
            this.tb_nComande.TabIndex = 34;
            this.tb_nComande.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nComande_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(2071, 422);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lb_poboxp2p
            // 
            this.lb_poboxp2p.AutoSize = true;
            this.lb_poboxp2p.Location = new System.Drawing.Point(809, 201);
            this.lb_poboxp2p.Name = "lb_poboxp2p";
            this.lb_poboxp2p.Size = new System.Drawing.Size(138, 25);
            this.lb_poboxp2p.TabIndex = 36;
            this.lb_poboxp2p.Text = "PO BOX P2P";
            // 
            // lb_envoidfipayement
            // 
            this.lb_envoidfipayement.AutoSize = true;
            this.lb_envoidfipayement.Location = new System.Drawing.Point(1153, 271);
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
            this.cb_envoi_dfi_paiement.Location = new System.Drawing.Point(1221, 308);
            this.cb_envoi_dfi_paiement.Name = "cb_envoi_dfi_paiement";
            this.cb_envoi_dfi_paiement.Size = new System.Drawing.Size(91, 33);
            this.cb_envoi_dfi_paiement.TabIndex = 39;
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
            this.cb_direction.Location = new System.Drawing.Point(431, 193);
            this.cb_direction.Name = "cb_direction";
            this.cb_direction.Size = new System.Drawing.Size(121, 33);
            this.cb_direction.TabIndex = 41;
            // 
            // tb_devise
            // 
            this.tb_devise.Location = new System.Drawing.Point(1603, 189);
            this.tb_devise.Name = "tb_devise";
            this.tb_devise.Size = new System.Drawing.Size(100, 31);
            this.tb_devise.TabIndex = 42;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(222, 46);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(106, 37);
            this.lb_user.TabIndex = 50;
            this.lb_user.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projet1._1.Properties.Resources.Administrator_icon;
            this.pictureBox1.Location = new System.Drawing.Point(51, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // bt_sup_user
            // 
            this.bt_sup_user.Image = global::projet1._1.Properties.Resources.Delete_group_icon;
            this.bt_sup_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sup_user.Location = new System.Drawing.Point(1376, 846);
            this.bt_sup_user.Name = "bt_sup_user";
            this.bt_sup_user.Size = new System.Drawing.Size(202, 45);
            this.bt_sup_user.TabIndex = 52;
            this.bt_sup_user.Text = "suprime user";
            this.bt_sup_user.UseVisualStyleBackColor = true;
            this.bt_sup_user.Click += new System.EventHandler(this.bt_sup_user_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Image = global::projet1._1.Properties.Resources.Button_Close_icon;
            this.bt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_exit.Location = new System.Drawing.Point(1920, 846);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(202, 45);
            this.bt_exit.TabIndex = 51;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_historik
            // 
            this.bt_historik.Image = global::projet1._1.Properties.Resources.History_Folder_Ash_icon;
            this.bt_historik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_historik.Location = new System.Drawing.Point(1595, 846);
            this.bt_historik.Name = "bt_historik";
            this.bt_historik.Size = new System.Drawing.Size(202, 45);
            this.bt_historik.TabIndex = 49;
            this.bt_historik.Text = "historique";
            this.bt_historik.UseVisualStyleBackColor = true;
            this.bt_historik.Click += new System.EventHandler(this.bt_historik_Click);
            // 
            // bt_add_user
            // 
            this.bt_add_user.Image = global::projet1._1.Properties.Resources.Add_group_icon;
            this.bt_add_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add_user.Location = new System.Drawing.Point(1149, 846);
            this.bt_add_user.Name = "bt_add_user";
            this.bt_add_user.Size = new System.Drawing.Size(202, 45);
            this.bt_add_user.TabIndex = 48;
            this.bt_add_user.Text = "ajout user";
            this.bt_add_user.UseVisualStyleBackColor = true;
            this.bt_add_user.Click += new System.EventHandler(this.bt_add_user_Click);
            // 
            // bt_supprim
            // 
            this.bt_supprim.Image = global::projet1._1.Properties.Resources.Close_2_icon;
            this.bt_supprim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_supprim.Location = new System.Drawing.Point(711, 846);
            this.bt_supprim.Name = "bt_supprim";
            this.bt_supprim.Size = new System.Drawing.Size(202, 45);
            this.bt_supprim.TabIndex = 47;
            this.bt_supprim.Text = "supprimer";
            this.bt_supprim.UseVisualStyleBackColor = true;
            this.bt_supprim.Click += new System.EventHandler(this.bt_supprim_Click);
            // 
            // bt_export
            // 
            this.bt_export.Image = global::projet1._1.Properties.Resources.Microsoft_Excel_2013_icon;
            this.bt_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_export.Location = new System.Drawing.Point(927, 846);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(202, 45);
            this.bt_export.TabIndex = 46;
            this.bt_export.Text = "exporter";
            this.bt_export.UseVisualStyleBackColor = true;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.Image = global::projet1._1.Properties.Resources.Actions_edit_redo_icon;
            this.bt_modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_modifier.Location = new System.Drawing.Point(491, 846);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(202, 45);
            this.bt_modifier.TabIndex = 45;
            this.bt_modifier.Text = "modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_recherch
            // 
            this.bt_recherch.Image = global::projet1._1.Properties.Resources.Start_Menu_Search_icon;
            this.bt_recherch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_recherch.Location = new System.Drawing.Point(51, 846);
            this.bt_recherch.Name = "bt_recherch";
            this.bt_recherch.Size = new System.Drawing.Size(202, 45);
            this.bt_recherch.TabIndex = 44;
            this.bt_recherch.Text = "recherche";
            this.bt_recherch.UseVisualStyleBackColor = true;
            this.bt_recherch.Click += new System.EventHandler(this.bt_recherch_Click);
            // 
            // bt_delet_fournisseur
            // 
            this.bt_delet_fournisseur.Image = global::projet1._1.Properties.Resources.Close_2_icon;
            this.bt_delet_fournisseur.Location = new System.Drawing.Point(975, 189);
            this.bt_delet_fournisseur.Name = "bt_delet_fournisseur";
            this.bt_delet_fournisseur.Size = new System.Drawing.Size(56, 42);
            this.bt_delet_fournisseur.TabIndex = 43;
            this.bt_delet_fournisseur.UseVisualStyleBackColor = true;
            this.bt_delet_fournisseur.Click += new System.EventHandler(this.bt_delet_fournisseur_Click);
            // 
            // bt_ajoutfournisseur
            // 
            this.bt_ajoutfournisseur.Image = global::projet1._1.Properties.Resources.add_icon;
            this.bt_ajoutfournisseur.Location = new System.Drawing.Point(1164, 189);
            this.bt_ajoutfournisseur.Name = "bt_ajoutfournisseur";
            this.bt_ajoutfournisseur.Size = new System.Drawing.Size(56, 42);
            this.bt_ajoutfournisseur.TabIndex = 40;
            this.bt_ajoutfournisseur.UseVisualStyleBackColor = true;
            this.bt_ajoutfournisseur.Click += new System.EventHandler(this.bt_ajoutfournisseur_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Image = global::projet1._1.Properties.Resources.add_icon;
            this.bt_ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ajouter.Location = new System.Drawing.Point(271, 846);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(202, 45);
            this.bt_ajouter.TabIndex = 37;
            this.bt_ajouter.Text = "ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2160, 1129);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_sup_user);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.bt_historik);
            this.Controls.Add(this.bt_add_user);
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
            this.MinimumSize = new System.Drawing.Size(2186, 1200);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(40, 10, 40, 40);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button bt_add_user;
        private System.Windows.Forms.Button bt_historik;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_sup_user;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

