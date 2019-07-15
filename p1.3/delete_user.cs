using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet1._1
{
    public partial class delete_user : Form
    {
        private Connect cc = new Connect();
        public delete_user()
        {
            InitializeComponent();
        }

        private void bt_delet_user_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                MessageBox.Show("remplisser les champs ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cc.delete_user(tb_username.Text);
                
            }
        }
    }
}
