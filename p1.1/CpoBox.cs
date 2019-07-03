using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet1._1
{
    class CpoBox
    {
        public string date_reception;
        public string direction;
        public string emetteur;
        public string destinataire;
        public string fournisseur;
        public string date_facture;
        public double montant;
        public string devise;
        public string objet_facture;
        public string Nfacture;
        public long Ncommande;
        public string date_envoi_fedosa;
        public string restitution_fedosa;
        public string envoi_dfi;
        public string remarque;
        public string pole;
        public string date_envoi_dfi;
        /*date_reception;
         direction;
         emetteur;
         destinataire;
         fournisseur;
         date_facture;
         montant;
         devise;
         objet_facture;
         Nfacture;
         Ncommande;
         date_envoi_fedosa;
         restitution_fedosa;
         envoi_dfi;
         remarque;
         pole;
         date_envoi_dfi;*/
        public CpoBox()
        {
            this.date_reception = "";
            this.direction = "";
            this.emetteur = "";
            this.destinataire = "";
            this.fournisseur = "";
            this.date_facture = "";
            this.montant = 0;
            this.devise = "";
            this.objet_facture = "";
            this.Nfacture = "";
            this.Ncommande = 0;
            this.date_envoi_fedosa = "";
            this.restitution_fedosa = "";
            this.envoi_dfi = "";
            this.remarque = "";
            this.pole = "";
            this.date_envoi_dfi = "";
        }
        public void SetPobox(string dt_recp, string dir, string emet, string desti, string fourni, string dt_fac, double mtt, string dev, string objfa, string nfac, long ncom, string dt_env_fedo, string restuti, string env_dfi, string rema, string pole, string dt_env_dfi)
        {
            this.date_reception = dt_recp;
            this.direction = dir;
            this.emetteur = emet;
            this.destinataire = desti;
            this.fournisseur = fourni;
            this.date_facture = dt_fac;
            this.montant = mtt;
            this.devise = dev;
            this.objet_facture = objfa;
            this.Nfacture = nfac;
            this.Ncommande = ncom;
            this.date_envoi_fedosa = dt_env_fedo;
            this.restitution_fedosa = restuti;
            this.envoi_dfi = env_dfi;
            this.remarque = rema;
            this.pole = pole;
            this.date_envoi_dfi = dt_env_dfi;
        }
        public CpoBox getpobox()
        {
            return this;
        }
    }
}
