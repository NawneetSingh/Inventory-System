using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Spire.Xls;
using Spire.CompoundFile;
using Spire.Spreadsheet;


namespace DialogBox
{
    public partial class Import : Form
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public Import()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName;
            fileName = textBox3.Text.ToString();
            Workbook wb = new Workbook();
            wb.LoadFromFile(fileName);
            Worksheet sheet = wb.Worksheets[0];
            this.dataGridView2.DataSource = sheet.ExportDataTable();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Field are Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int i = 0;
                SqlCommand cmd;
                string str;
                for (i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    str = "Insert into tblDealerInfo Values('" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "', '" + dataGridView2.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[5].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[6].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[7].Value.ToString() + "')";
                    cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void Import_Load(object sender, EventArgs e)
        {

        }
    }
}
