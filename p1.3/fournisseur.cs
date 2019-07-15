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
{
    public partial class fournisseur : Form
    {
        private string myval;
        public string Myval
        {
            get { return myval; }
            set { myval = value; }
        }

        public fournisseur()
        {
            InitializeComponent();
        }

        private void fournisseur_Load(object sender, EventArgs e)
        {
            Myval = tb_nomfourni.Text;
        }
        public string getvalue()
        {
            return tb_nomfourni.Text;
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            Connect cc = new Connect();
            cc.ajouterfournisseur(tb_nomfourni.Text);
        }
    }
}

