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
    public partial class delete_pbcs : Form
    {
        private string myval;
        public string Myval
        {
            get { return myval; }
            set { myval = value; }
        }
        public delete_pbcs()
        {
            InitializeComponent();
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
                cc.deletepb(tb_nfact.Text, tb_fourni.Text);
            }
            
        }

        private void delete_pbcs_Load(object sender, EventArgs e)
        {
            
            Myval = tb_nfact.Text;
        }
    }
}
