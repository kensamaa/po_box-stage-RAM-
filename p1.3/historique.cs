using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;

namespace projet1._1
{
    public partial class historique : Form
    {
        private Connect cc = new Connect();
        private DataTable table = new DataTable();

        public historique()
        {
            InitializeComponent();
        }

        private void historique_Load(object sender, EventArgs e)
        {
            cb_users.DataSource = cc.get_users();

            table.Columns.Add("date action", typeof(string));
            table.Columns.Add("utilisateur", typeof(string));
            table.Columns.Add("action", typeof(string));
            table.Columns.Add("change ip", typeof(string));
            table.Columns.Add("fournisseur", typeof(string));
            table.Columns.Add("N facture", typeof(string));
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_users_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_users_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bt_fetch_Click(object sender, EventArgs e)
        {
            cb_users.Text = cb_users.SelectedText.ToString();
            //MessageBox.Show(cb_users.Text);
            table.Clear();
            List<C_historik> h = new List<C_historik>();
            h = cc.Get_historik(cb_users.Text);
            for(int i = 0; i < h.Count(); i++)
            {
                table.Rows.Add(h[i].date_action, h[i].username, h[i].action, h[i].change_ip, h[i].fournisseur, h[i].Nfacture);
            }
            dataGridView1.DataSource = table;
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            cb_users.Text = cb_users.SelectedText.ToString();
            string name= cb_users.Text.ToString() ;
            string file = "../../../exported/historique_"+name+".xlsx";//le chemina + le nom en ajoutant le nom de user
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("Sheet");
            int i = 0, j = 0;

            for (i = 0; i < dataGridView1.Columns.Count ; i++)//for the headers
            {
                worksheet.Cells[0, i] = new Cell(dataGridView1.Columns[i ].HeaderText);
            }
            for (i = 1; i < dataGridView1.Rows.Count + 1; i++)//for the rows
            {
                for (j = 0; j < dataGridView1.Columns.Count ; j++)//for the columns
                {
                    worksheet.Cells[i, j] = new Cell(dataGridView1[j , i - 1].Value.ToString());
                }
            }
            
            worksheet.Cells.ColumnWidth[0, 1] = 3000;
            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);
           /* var safefiledialog = new SaveFileDialog();
            safefiledialog.FileName = "output";
            safefiledialog.DefaultExt = ".xlsx";
            */
            MessageBox.Show("exporter");
        }
    }
}
