//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace projet1._1
{
    class C_historik
    {
        public string date_action;
        public string username;
        public string action;
        public string change_ip;
        public string fournisseur;
        public string Nfacture;

        public C_historik()
        {
            this.date_action = null;
            this.username = null;
            this.action = null;
            this.change_ip = null;
            this.fournisseur = null;
            this.Nfacture = null;
        }
        public void set_historik( 
             string date_action,
             string username,
             string action,
             string change_ip,
             string fournisseur,
             string Nfacture)
        {
            this.date_action=date_action;
            this.username=username;
            this.action=action;
            this.change_ip=change_ip;
            this.fournisseur=fournisseur;
            this.Nfacture=Nfacture;
         }
        





    }
}
