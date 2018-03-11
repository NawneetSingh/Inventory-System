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
    public partial class Export : Form
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public Export()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text=="" || textBox2.Text=="")
                {
                    MessageBox.Show("Fields are Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlDataAdapter Da = new SqlDataAdapter(textBox1.Text, con);
                    DataTable Tab = new DataTable();
                    Da.Fill(Tab);
                    dataGridView1.DataSource = Tab;
                }
               
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Export_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="")
            {
                MessageBox.Show("Filename Field Empty", "warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string fileName;
                Spire.DataExport.XLS.CellExport cellExport = new Spire.DataExport.XLS.CellExport();
                Spire.DataExport.XLS.WorkSheet worksheet1 = new Spire.DataExport.XLS.WorkSheet();
                worksheet1.DataSource = Spire.DataExport.Common.ExportSource.DataTable;
                worksheet1.DataTable = this.dataGridView1.DataSource as DataTable;
                worksheet1.StartDataCol = ((System.Byte)(0));
                cellExport.Sheets.Add(worksheet1);
                cellExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView;
                fileName = textBox2.Text.ToString() + ".xls";
                cellExport.SaveToFile(fileName);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }
    }
}
