using System;
using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet1._1
{
    class Connect
    {
        string connetionString = @"Data Source=DESKTOP-GJ747SQ;Initial Catalog=PO_BOX;Integrated Security=True;Password=";//this might be changed depends on ip or smtg
        private SqlConnection cnn;
        private SqlCommand commande;
        private SqlDataReader dr;
        private SqlDataAdapter adapter;

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
            if (check_double_fournisseur(fname) == false)
            {
                sql = "insert into fournisseur(name) values('" + fname + "')";//if we dont fiind the name in the database the n we add it

                cnn.Open();
                commande = new SqlCommand(sql, cnn);
                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                commande.Dispose();
                cnn.Close();
                MessageBox.Show("ajouter");
            }
            else
            {  
                MessageBox.Show("fournisseur déjà existant", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void deletefournisseur(string fname)
        {
            string sql = "";
            if (check_double_fournisseur(fname) == true)//if we found the name in the database then we delete 
            {
                sql = "delete from fournisseur where name= '" + fname + "' ";
                cnn.Open();
                commande = new SqlCommand(sql, cnn);
                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                commande.Dispose();
                MessageBox.Show("supprimer");
                cnn.Close();
            }
            else
            {
                MessageBox.Show("fournisseur n existe pas ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool ajout_pobox(CpoBox pb,string user)
        {//(date_reception,direction,emetteur,destinataire,fournisseur,date_facture,montant_ttc,devise,objet_facture,Nfacture,Ncommande,date_envoi_fedaso,restitution_fedosa,envoie_dfi,remarque,pole,date_envoi_dfi   )
            string sql = "";
            if (check_for_double(pb.fournisseur, pb.Nfacture) == false) {
                
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
                archiv(user, 1, pb.fournisseur, pb.Nfacture);//archiv
                return true;
            }
            else {
                MessageBox.Show("facture déjà existant ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            
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

        public List<CpoBox> get_pobox_by_nfact_or_fourniss(string nfacture,string fournisseur)
        {
            List<CpoBox> llpb = new List<CpoBox>();//declaration de la list pour stockage des pobox,puis return de liste
            
            string sql="";
            if (nfacture == "" && fournisseur!="") { sql = "select * from Tpo_box where fournisseur ='" + fournisseur + "' "; }//sinfacture est vide
            if (fournisseur == ""&& nfacture!="") { sql = "select * from Tpo_box where Nfacture='" + nfacture + "' "; }//si fournisseur est vide
            if(fournisseur != "" && nfacture != "") { sql = "select * from Tpo_box where fournisseur ='" + fournisseur + "' and Nfacture='" + nfacture + "'  ";/*recherche par nfacture ou fournisseur*/}
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            //string bb="";
            dr = commande.ExecuteReader();
            while (dr.Read())
            {
                //int i = 0;
                CpoBox pb = new CpoBox();
                //stock what we got from database to the class pobox

                long l = Convert.ToInt64(dr.GetValue(10).ToString());//get as string then turn it to long
                double mt = Convert.ToDouble(dr.GetValue(6).ToString());//get as string then turn it to double
                

                pb.SetPobox(dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), mt, dr.GetValue(7).ToString(), dr.GetValue(8).ToString(), dr.GetValue(9).ToString(), l, dr.GetValue(11).ToString(), dr.GetValue(12).ToString(), dr.GetValue(13).ToString(), dr.GetValue(14).ToString(), dr.GetValue(15).ToString(), dr.GetValue(16).ToString());
                
                llpb.Add(pb);//add the pobox to the list
                //bb += llpb[i].direction.ToString() + "#";
            }
             //MessageBox.Show(output);

            cnn.Close();
            //MessageBox.Show(bb);

            return llpb;//return the list

        }
        
        public void modif_pobox(CpoBox pb,string old_nfacture,string old_fourni,string user)
        {
            string sql = "";
            //@dt_recp,@direc,@emet,@desti,@fourn,@dt_fac,@ttc,@dev,@objfac,@nfac,@ncom,@dt_env_fed,@restit,@env_dfi,@remar,@pole,@dt_env_dfi
            if (check_for_double(pb.fournisseur, pb.Nfacture) == true)
            {
                sql = "update Tpo_box set date_reception=@dt_recp,direction=@direc,emetteur=@emet,destinataire=@desti,fournisseur=@fourn,date_facture=@dt_fac,montant_ttc=@ttc,devise=@dev,objet_facture=@objfac,Nfacture=@nfac,Ncommande=@ncom ,date_envoi_fedaso=@dt_env_fed,restitution_fedosa=@restit,envoie_dfi=@env_dfi,remarque=@remar,pole=@pole,date_envoi_dfi=@dt_env_dfi where Nfacture= @old_nfact and fournisseur = @old_fourni  ";
                cnn.Open();
                commande = new SqlCommand(sql, cnn);

                //set the pb
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
                //old values
                commande.Parameters.AddWithValue("@old_nfact", old_nfacture);
                commande.Parameters.AddWithValue("@old_fourni", old_fourni);
                commande.ExecuteNonQuery();


                commande.Dispose();
                cnn.Close();
                archiv(user, 0, pb.fournisseur, pb.Nfacture);//archiv
                MessageBox.Show("updated");
            }
            else {
                MessageBox.Show("facture n existe pas ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public bool check_for_double(string fourni, string nfact)
        {
            string sql = "";
            
                sql = "select count(montant_ttc) from Tpo_box where  Nfacture= '" + nfact + "'and fournisseur = '" + fourni + "'  ";
            
            
           
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            dr = commande.ExecuteReader();
            int test = 0;
            while (dr.Read())
            {
                test = Convert.ToInt32(dr.GetValue(0).ToString());//test fro result of the count in the sql
                
            }
            cnn.Close();
            if (test > 0)
            {
                return true;//double facture
            }
            else
            {

                return false;//pas de double facture
            }

        }

        public bool check_double_fournisseur(string fourni)
        {
            string sql = "";
            sql = "select count(name) from fournisseur where name= '" + fourni + "'   ";
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            dr = commande.ExecuteReader();
            int test = 0;

            while (dr.Read())
            {
                test = Convert.ToInt32(dr.GetValue(0).ToString());//test fro result of the count in the sql

            }
            cnn.Close();
            if (test > 0)
            {
                return true;//double facture
               
            }
            else
            {

                return false;//pas de double facture
               
            }
            
        }

        public bool check_to_delete_pb(string nfact,string fourni)
        {

            string sql = "select count(montant_ttc) from Tpo_box where  Nfacture= '" + nfact + "' and fournisseur = '" + fourni + "' ";
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            dr = commande.ExecuteReader();
            int test = 0;
            while (dr.Read())
            {
                test = Convert.ToInt32(dr.GetValue(0).ToString());//test fro result of the count in the sql

            }
            commande.Dispose();
            cnn.Close();
            if (test > 0)
            {
                return true;//double facture
            }
            else
            {

                return false;//pas de double facture
            }
        }

        public void deletepb(string nfact,string fourni,string user)
        {
            string sql = "";
            if (check_to_delete_pb(nfact,fourni) == true) {
                sql = "delete from Tpo_box where Nfacture= '" + nfact + "' ";
                cnn.Open();
                commande = new SqlCommand(sql, cnn);
                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                commande.Dispose();
                MessageBox.Show(" facture supprimer");
                cnn.Close();
                archiv(user, 2, fourni,nfact);//archiv
            }
            else {
                MessageBox.Show(" facture n existe pas");
            }
        }
        public int LookForUser(string username,string password)//using it in log in
        {
            string sql = "select  * from users where username = '" + username + "' and passwordd ='" + password + "' ";
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            string user="";
            dr = commande.ExecuteReader();
            int test = 0;
            while (dr.Read())
            {
                test = Convert.ToInt32(dr.GetValue(0).ToString());
                user = dr.GetValue(1).ToString();
            }
            cnn.Close();
            bool testt = string.Equals(user, "admin");
           // MessageBox.Show(test.ToString() + testt);

            if (testt==true && test > 0)
            {
                
                return 2;//found and admin
            }
            else if (testt==false && test>0)
            {
                return 1;//not admin
            }
            else
            {
                return 0;//not found
            }
        }
        public string get_name(string username, string password)
        {
            string sql = "select  * from users where username = '" + username + "' and passwordd ='" + password + "' ";
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            string user = "";
            dr = commande.ExecuteReader();
            
            while (dr.Read())
            {
                user = dr.GetValue(1).ToString();
            }
            commande.Dispose();
            cnn.Close();
            return user;
        }
        public int get_last_id_username()
        {
            string sql = "";
            int last = 0;
            sql = "SELECT MAX(id) from users";

            cnn.Open();
            commande = new SqlCommand(sql, cnn);

            dr = commande.ExecuteReader();//get the last id

            while (dr.Read())
            {
                last = Convert.ToInt32(dr.GetValue(0).ToString());
            }
            commande.Dispose();
            cnn.Close();
            return last;
        }
        public void add_user(string user,string pass)
        {
            if (check_user(user) == false && string.Equals(user, "admin") == false)//must be new user and must not add another admin
            {
                string sql = "";
                int last = 0;

                last = get_last_id_username();//returns the last id
                last += 1;
                sql = "insert into users values (@last,@user,@pass)";

                cnn.Open();
                commande = new SqlCommand(sql, cnn);

                commande.Parameters.AddWithValue("@last", last);
                commande.Parameters.AddWithValue("@user", user);
                commande.Parameters.AddWithValue("@pass", pass);

                commande.ExecuteNonQuery();

                commande.Dispose();
                cnn.Close();
                MessageBox.Show("utilisateur ajoute");
            }
            else
            {
                MessageBox.Show("user exicte deja ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void delete_user(string username)
        {
            if (check_user(username) == true && string.Equals(username,"admin")==false)//si user exicte est n est pas admin
            {
                string sql = "";
                //int last = 0;
                sql = "delete from users where username = '" + username + "' ";
                cnn.Open();
                commande = new SqlCommand(sql, cnn);
                commande.ExecuteNonQuery();
                //adapter = new SqlDataAdapter();
                //adapter.InsertCommand = new SqlCommand(sql, cnn);
                // adapter.InsertCommand.ExecuteNonQuery();
                commande.Dispose();
                cnn.Close();
                MessageBox.Show("utilisateur supprime");
            }
            else //sinon
            {
                MessageBox.Show("user n'exicte pas ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public bool check_user(string n)
        {
            string sql = "";
            sql = "select count(id) from users where username= '" + n + "'   ";
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            dr = commande.ExecuteReader();
            int test = 0;

            while (dr.Read())
            {
                test = Convert.ToInt32(dr.GetValue(0).ToString());//test fro result of the count in the sql

            }
            cnn.Close();
            if (test > 0)
            {
                return true;//user exicte
            }
            else
            {
                return false;//user n exicte pas
            }
        }

        public List<string> get_users()
        {
            List<String> user_names = new List<string>();
            string sql = "select * from users ";
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            string user = "";
            dr = commande.ExecuteReader();

            while (dr.Read())
            {
                user = dr.GetValue(1).ToString();//store the name in temp var 
                user_names.Add(user);//store it in list
            }
            commande.Dispose();
            cnn.Close();
            return user_names;
        }

        public void archiv(string username,int action,string fournisseur,string Nfact)
        {
            // CONNECTIONPROPERTY('client_net_address');       --ip adresse of SQL client was connected from when this change was performed
            // CONVERT(VARCHAR(50), getDATE(), 120)            --date and time of the change
            string sql = "";
            
            sql = "insert into historic(date_action,username,actionn,change_ip,Nfacture,fournisseur) values (CONVERT(VARCHAR(50), getDATE(), 120) ,@user,@action,convert(varchar(50),CONNECTIONPROPERTY('client_net_address')),@nfac,@fourni)";

            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            //to know wich action he did
            //2 is supprime
            //1 is add
            //0 is update
            if (action == 2)
            {
                commande.Parameters.AddWithValue("@action", "supprimer");
            }
            else if (action == 1)
            {
                commande.Parameters.AddWithValue("@action", "ajouter");
            }
            else
            {
                commande.Parameters.AddWithValue("@action", "modifier");
            }

            commande.Parameters.AddWithValue("@user", username);
            commande.Parameters.AddWithValue("@nfac", Nfact);
            commande.Parameters.AddWithValue("@fourni", fournisseur);

            commande.ExecuteNonQuery();
            commande.Dispose();
            cnn.Close();
        }

        public List<C_historik> Get_historik(string user)
        { 
            List<C_historik> lh = new List<C_historik>();
            string sql = "";
            sql = "select * from historic where username= '" + user + "' ";
            cnn.Open();
            commande = new SqlCommand(sql, cnn);
            
            dr = commande.ExecuteReader();

            while (dr.Read())
            {
                C_historik h = new C_historik();
                /*
                h.date_action = dr.GetValue(1).ToString();
                h.username = dr.GetValue(2).ToString();
                h.action = dr.GetValue(3).ToString();
                h.change_ip = dr.GetValue(4).ToString();
                h.Nfacture = dr.GetValue(5).ToString();
                h.fournisseur = dr.GetValue(6).ToString();
                */
                h.set_historik(dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(6).ToString(), dr.GetValue(5).ToString());
                lh.Add(h);//store it in list
            }
            
            commande.Dispose();
            cnn.Close();



            return lh;
        }
    }
}
