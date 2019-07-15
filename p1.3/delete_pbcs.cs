using System;
using System.Windows.Forms;

namespace projet1._1
{
    public partial class delete_pbcs : Form
    {
        private string myval;
        private string user;
        public string Myval
        {
            get { return myval; }
            set { myval = value; }
        }
        public delete_pbcs(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        public string getvalue()
        {
            return tb_nfact.Text;
        }
        private void bt_delet_Click(object sender, EventArgs e)
        {
            if(tb_fourni.Text=="" && tb_nfact.Text == "")
            {
                MessageBox.Show("certaine case sont vide ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connect cc = new Connect();
                cc.deletepb(tb_nfact.Text, tb_fourni.Text, this.user);
                
            }
            
        }

        private void delete_pbcs_Load(object sender, EventArgs e)
        {
            
            Myval = tb_nfact.Text;
        }
    }
}
