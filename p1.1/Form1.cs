using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet1._1
    //double is , not .
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        int tt_rows=0;//nombre de ligne
        List<string> Lfournisseur = new List<string>();
        Connect cc = new Connect();
        CpoBox pb = new CpoBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("acc", typeof(string));//pour le test d acceptation de dfi 
            table.Columns.Add("date de reception", typeof(string));
            table.Columns.Add("direction", typeof(string));
            table.Columns.Add("emeteur", typeof(string));
            table.Columns.Add("destinataire", typeof(string));
            table.Columns.Add("fournisseur", typeof(string));
            table.Columns.Add("date de facture", typeof(string));
            table.Columns.Add("montant", typeof(double));
            table.Columns.Add("devise", typeof(string));
            table.Columns.Add("objet de facture", typeof(string));
            table.Columns.Add("N facture", typeof(string));
            table.Columns.Add("N commande", typeof(long));
            table.Columns.Add("date d envoi fedosa", typeof(string));
            table.Columns.Add("restitution", typeof(string));
            table.Columns.Add("envoi dfi", typeof(string));
            table.Columns.Add("remarke", typeof(string));
            table.Columns.Add("pole", typeof(string));
            table.Columns.Add("date d envoi a la dfi", typeof(string));

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;//disable user to add row to datagrid
            cb_fournisseur.DataSource = cc.getfournisseur();//get fournisseur from database
            //cb_fournisseur.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {/*obligatoire : Fournisseur, n facture, n commande ,date facture, date recepetion, montant, devise */
            string datereception = date_reception.Text.ToString();
            cb_direction.Text = cb_direction.SelectedText.ToString();
            string direction = cb_direction.Text;
            string emeteur = tb_emeteur.Text;
            string poboxpp = lb_poboxp2p.Text;

            cb_fournisseur.Text= cb_fournisseur.SelectedText.ToString();
            string fourniseur = cb_fournisseur.Text;
            string datefacture = date_facture.Text.ToString();
            double montant;
            //if (tb_montant.Text == "") {  montant = 0; }else {  montant = Convert.ToDouble(tb_montant.Text); }//si il la laisse vide
            long ncomande;
            
            string devise = tb_devise.Text.ToString();

            string objectfact = tb_objetFacture.Text.ToString();
            string nfacture = tb_nFacture.Text.ToString();
            //if (tb_nComande.Text == "") {  ncomande = 0; } else { ncomande = Convert.ToInt32(tb_nComande.Text); }//si il la laisse vide
            string dateenvoifedosa = date_envoi_fedosa.Text.ToString();

            cb_restitution_fedosa.Text= cb_restitution_fedosa.SelectedText.ToString();
            string restitution = cb_restitution_fedosa.Text;

            cb_envoi_dfi_paiement.Text= cb_envoi_dfi_paiement.SelectedText.ToString();
            string envoidfi = cb_envoi_dfi_paiement.Text;
            string remarque = tb_remarque.Text.ToString();
            string pole = tb_pole.Text.ToString();
            string dateenvoidfi = date_envoi_dfi.Text.ToString();

            if (datereception == "") {
                lb_dtReception.ForeColor = Color.Red;
                
                if (fourniseur == "") { lb_fournisseur.ForeColor = Color.Red; }
                if (datefacture == "") { lb_dtFacture.ForeColor = Color.Red; }
                if (tb_montant.Text == "") { lb_montant.ForeColor = Color.Red; }
                if (devise == "") { lb_devise.ForeColor = Color.Red; }
                if (nfacture == "") { lb_nfacture.ForeColor = Color.Red; }
                if (tb_nComande.Text == "") { lb_Ncomand.ForeColor = Color.Red; }
                MessageBox.Show("certain case essentielle sont vide", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//date reception vide
            else {
                if (fourniseur == "") {
                    lb_fournisseur.ForeColor = Color.Red;
                    
                    if (datefacture == "") { lb_dtFacture.ForeColor = Color.Red; }
                    if (tb_montant.Text == "") { lb_montant.ForeColor = Color.Red; }
                    if (devise == "") { lb_devise.ForeColor = Color.Red; }
                    if (nfacture == "") { lb_nfacture.ForeColor = Color.Red; }
                    if (tb_nComande.Text == "") { lb_Ncomand.ForeColor = Color.Red; }
                    MessageBox.Show("certain case essentielle sont vide", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//fournisseur vide
                else
                {
                    if (datefacture == "") {
                        lb_dtFacture.ForeColor = Color.Red;
                        
                        if (tb_montant.Text == "") { lb_montant.ForeColor = Color.Red; }
                        if (devise == "") { lb_devise.ForeColor = Color.Red; }
                        if (nfacture == "") { lb_nfacture.ForeColor = Color.Red; }
                        if (tb_nComande.Text == "") { lb_Ncomand.ForeColor = Color.Red; }
                        MessageBox.Show("certain case essentielle sont vide", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }//date facture vide
                    else
                    {
                        if (tb_montant.Text == "") {
                            lb_montant.ForeColor = Color.Red;
                            
                            if (devise == "") { lb_devise.ForeColor = Color.Red; }
                            if (nfacture == "") { lb_nfacture.ForeColor = Color.Red; }
                            if (tb_nComande.Text == "") { lb_Ncomand.ForeColor = Color.Red; }
                            MessageBox.Show("certain case essentielle sont vide", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }//montant vide
                        else
                        {
                            montant = Convert.ToDouble(tb_montant.Text);
                            if (devise == "") {
                                lb_devise.ForeColor = Color.Red;
                                
                                if (nfacture == "") { lb_nfacture.ForeColor = Color.Red; }
                                if (tb_nComande.Text == "") { lb_Ncomand.BackColor = Color.Red; }
                                MessageBox.Show("certain case essentielle sont vide", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }//devise vide
                            else
                            {
                                if (nfacture == ""){
                                    lb_nfacture.BackColor = Color.Red;
                                    
                                    if (tb_nComande.Text == "") { lb_Ncomand.ForeColor = Color.Red; }
                                    MessageBox.Show("certain case essentielle sont vide", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }//nfacture vide
                                else
                                {
                                    if (tb_nComande.Text == "") { lb_Ncomand.ForeColor = Color.Red; MessageBox.Show("certain case essentielle sont vide", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }//ncomande vide
                                    else
                                    {               
                                        ncomande = Convert.ToInt64(tb_nComande.Text); 
                                        table.Rows.Add("", datereception, direction, emeteur, poboxpp, fourniseur, datefacture, montant, devise, objectfact, nfacture, ncomande, dateenvoifedosa,restitution,envoidfi, remarque, pole, dateenvoidfi);
                                        dataGridView1.DataSource = table;
                                        if (string.Equals(envoidfi,"OUI"))
                                        {
                                            dataGridView1.Rows[tt_rows].Cells[0].Style.BackColor = Color.Green;//set column to green if envoie dfi est oui
                                        }
                                        dataGridView1.Columns[0].Width = 30;//size of acc dfi
                                        clear_textbox();clearColor();//clear all textbox and back to normal colors
                                        //sett objet po box
                                        pb.SetPobox(datereception, direction, emeteur, poboxpp, fourniseur, datefacture, montant, devise, objectfact, nfacture, ncomande, dateenvoifedosa, restitution, envoidfi, remarque, pole, dateenvoidfi);
                                 
                                        cc.ajout_pobox(pb);//stokage dans bas donne
                                        tt_rows++;
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }



            clearColor();
        }
        public void clear_textbox()//clean up text boxs after ajout
        {
            
            tb_emeteur.Text = "";
            tb_montant.Text = "";
            tb_nComande.Text = "";
            tb_nFacture.Text = "";
            tb_objetFacture.Text = "";
            tb_pole.Text = "";
            tb_remarque.Text = "";
            tb_devise.Text = "";
            cb_envoi_dfi_paiement.Text = "";
            cb_fournisseur.Text = "";
            cb_restitution_fedosa.Text = "";
            cb_direction.Text = "";
            
        }
        public void clearColor()//set colors of labels back to normal
        {
            lb_dtReception.ForeColor = SystemColors.ControlText;
            lb_fournisseur.ForeColor = SystemColors.ControlText;
            lb_dtFacture.ForeColor = SystemColors.ControlText;
            lb_montant.ForeColor = SystemColors.ControlText;
            lb_devise.ForeColor = SystemColors.ControlText;
            lb_nfacture.ForeColor = SystemColors.ControlText;
            lb_Ncomand.ForeColor = SystemColors.ControlText;
        }

        private void tb_montant_KeyPress(object sender, KeyPressEventArgs e)//input just numeric and one ,
        {
            char ch = e.KeyChar;

            if (!char.IsControl(ch) && !char.IsDigit(ch) && (ch != ','))
            {
                //input only numeric
                e.Handled = true;

            }
            if ((ch == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                //alow only one , 
                e.Handled = true;
            }
        }

        private void tb_nComande_KeyPress(object sender, KeyPressEventArgs e)//input only numeric
        {
            char ch = e.KeyChar;

            if (!char.IsControl(ch) && !char.IsDigit(ch) && (ch != ','))
            {
                //to only input numeric values
                e.Handled = true;

            }
            if ((ch == ',') && ((sender as TextBox).Text.IndexOf(',') > -2))
            {
                //prevent from inputing , cause its a qte
                e.Handled = true;
            }
        }

        private void bt_ajoutfournisseur_Click(object sender, EventArgs e)
        {
            fournisseur f = new fournisseur();
            if (f.ShowDialog() == DialogResult.OK)//reception du nouveau fournisseur
            {
                string fournisseur = f.getvalue();
                //cb_fournisseur.Items.Add(fournisseur);
                cb_fournisseur.DataSource = cc.getfournisseur();
                Lfournisseur.Add(fournisseur);
            }
        }

        private void bt_delet_fournisseur_Click(object sender, EventArgs e)
        {
            fournisseur_delet f = new fournisseur_delet();
            if (f.ShowDialog() == DialogResult.OK)//reception du nouveau fournisseur
            {
                string fournisseur = f.getvalue();
                //cb_fournisseur.Items.Add(fournisseur);
                cb_fournisseur.DataSource = cc.getfournisseur();
                Lfournisseur.Remove(fournisseur);
            }
        }

        

        private void bt_recherch_Click(object sender, EventArgs e)
        {

        }
    }
}
