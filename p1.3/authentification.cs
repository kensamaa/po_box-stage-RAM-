using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projet1._1
{
    public partial class authentification : Form
    {
        Connect cc = new Connect();
        string user = "";
        Thread th;
        public authentification()
        {
            InitializeComponent();
        }

        private void bt_signIn_Click(object sender, EventArgs e)
        {
            if(tb_username.Text=="" && tb_password.Text == "")
            {
                MessageBox.Show("remplisser les champs ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int result = cc.LookForUser(tb_username.Text, tb_password.Text);
                if (result>0)
                {
                    /*string user = cc.get_name(tb_username.Text, tb_password.Text);
                    Form1 f = new Form1(user);
                    f.Show();
                    Visible = false;*/
                    user = cc.get_name(tb_username.Text, tb_password.Text);
                    this.Close();//close this form
                    th = new Thread(openform);//to open the other form
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("utilisateur n'existe pas ou mot de pass faux ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void openform()
        {
            Application.Run(new Form1(user));
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authentification_Load(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
