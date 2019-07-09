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
    public partial class fournisseur_delet : Form
    {
        private string myval;
        public string Myval
        {
            get { return myval; }
            set { myval = value; }
        }

        public fournisseur_delet()
        {
            InitializeComponent();
        }

        private void fournisseur_delet_Load(object sender, EventArgs e)
        {
            Myval = tb_nomfourni.Text;
        }
        public string getvalue()
        {
            return tb_nomfourni.Text;
        }
        private void bt_delet_Click(object sender, EventArgs e)
        {
            Connect cc = new Connect();
            cc.deletefournisseur(tb_nomfourni.Text);
        }
    }
}
