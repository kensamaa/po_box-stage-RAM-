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
    public partial class add_user : Form
    {
        Connect cc = new Connect();
        public add_user()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" && tb_password.Text == "")
            {
                MessageBox.Show("remplisser les champs ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cc.add_user(tb_username.Text, tb_password.Text);
                
            }
        }
    }
}
