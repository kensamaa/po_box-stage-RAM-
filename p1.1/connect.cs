using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet1._1
{
    class Connect
    {
        string connetionString = @"Data Source=DESKTOP-GJ747SQ;Initial Catalog=PO_BOX;Integrated Security=True;Password=";
        SqlConnection cnn;
        SqlCommand commande;
        SqlDataReader dr;
        SqlDataAdapter adapter;

        //connetionString = @"Data Source=DESKTOP-GJ747SQ;Initial Catalog=PO_BOX;Integrated Security=True;Password=";
        public Connect()
        {
            cnn = new SqlConnection(this.connetionString);
        }
        public void connecting()
        {
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
        public void ajouterfournisseur(string fname)
        {

            string sql = "";
            sql = "insert into fournisseur(name) values('" + fname + "')";

            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            commande.Dispose();
            cnn.Close();
            //MessageBox.Show(fname);

        }
        public void deletefournisseur(string fname)
        {
            string sql = "";
            sql = "delete from fournisseur where name= '" + fname + "' ";
            try
            {
                cnn.Open();
                commande = new SqlCommand(sql, cnn);
                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                commande.Dispose();
                MessageBox.Show("deleted");
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("nom invalide ou n'existe pas ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ajout_pobox(CpoBox pb)
        {//(date_reception,direction,emetteur,destinataire,fournisseur,date_facture,montant_ttc,devise,objet_facture,Nfacture,Ncommande,date_envoi_fedaso,restitution_fedosa,envoie_dfi,remarque,pole,date_envoi_dfi   )
            
            string sql = "";
            // sql = "insert into Tpo_box  values('" +pb.date_reception + "','" + pb.date_reception + "','" + pb.emetteur + "','" + pb.destinataire + "','" + pb.fournisseur + "','" + pb.date_facture + "','" + pb.montant + "','" + pb.devise + "','" + pb.objet_facture + "','" + pb.Nfacture + "','" + pb.Ncommande + "','" + pb.date_envoi_fedosa + "','" + pb.restitution_fedosa + "','" + pb.envoi_dfi + "','" + pb.remarque + "','" + pb.pole + "','" + pb.date_envoi_dfi + "')";
            sql = "insert into Tpo_box (date_reception,direction,emetteur,destinataire,fournisseur,date_facture,montant_ttc,devise,objet_facture,Nfacture,Ncommande,date_envoi_fedaso,restitution_fedosa,envoie_dfi,remarque,pole,date_envoi_dfi) values (@dt_recp,@direc,@emet,@desti,@fourn,@dt_fac,@ttc,@dev,@objfac,@nfac,@ncom,@dt_env_fed,@restit,@env_dfi,@remar,@pole,@dt_env_dfi)";
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            //@dt_recp,@direc,@emet,@desti,@fourn,@dt_fac,@ttc,@dev,@objfac,@nfac,@ncom,@dt_env_fed,@restit,@env_dfi,@remar,@pole,@dt_env_dfi
            commande.Parameters.AddWithValue("@dt_recp", pb.date_reception);
            commande.Parameters.AddWithValue("@direc", pb.direction);
            commande.Parameters.AddWithValue("@emet", pb.emetteur);
            commande.Parameters.AddWithValue("@desti", pb.destinataire);
            commande.Parameters.AddWithValue("@fourn", pb.fournisseur);
            commande.Parameters.AddWithValue("@dt_fac", pb.date_facture);
            commande.Parameters.AddWithValue("@ttc", pb.montant);
            commande.Parameters.AddWithValue("@dev", pb.devise);
            commande.Parameters.AddWithValue("@objfac", pb.objet_facture);
            commande.Parameters.AddWithValue("@nfac", pb.Nfacture);
            commande.Parameters.AddWithValue("@ncom", pb.Ncommande);
            commande.Parameters.AddWithValue("@dt_env_fed", pb.date_envoi_fedosa);
            commande.Parameters.AddWithValue("@restit", pb.restitution_fedosa);
            commande.Parameters.AddWithValue("@env_dfi", pb.envoi_dfi);
            commande.Parameters.AddWithValue("@remar", pb.remarque);
            commande.Parameters.AddWithValue("@pole", pb.pole);
            commande.Parameters.AddWithValue("@dt_env_dfi", pb.date_envoi_dfi);

            commande.ExecuteNonQuery();

            /*
            adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();*/
            commande.Dispose();
            cnn.Close();
            //MessageBox.Show(fname);
        }
        public List<string> getfournisseur()
        {
            List<string> fourniseur = new List<string>();
            cnn.Open();
            
            string sql;
            sql = "select name from fournisseur";
            commande = new SqlCommand(sql, cnn);
            dr = commande.ExecuteReader();
            while (dr.Read())
            {
                //output = output + dr.GetValue(0) + "-" + dr.GetValue(1) + "\n";
                fourniseur.Add(dr.GetValue(0).ToString());//stoker les nom
            }
            // MessageBox.Show(output);
            cnn.Close();
            return fourniseur;//envoie de la liste
        }

    }
}
