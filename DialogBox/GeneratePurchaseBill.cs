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
namespace DialogBox
{
    public partial class GeneratePurchaseBill : Form
    {
        string j;
        int tot=0;
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        
        public void getvalue(string i)
        {
            j=i;
        }
        public GeneratePurchaseBill()
        {
            InitializeComponent();
        }

        private void GeneratePurchaseBill_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            DataSet2 ds2 = new DataSet2();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = j;
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(ds2.DataTable1);
            

            tot = 0;

            foreach(DataRow dr in dt1.Rows)
            {
                tot=tot+Convert.ToInt32(dr["total"].ToString());
            }

            CrystalReport2 report = new CrystalReport2();
            report.SetDataSource(ds2);
            report.SetParameterValue("total", tot.ToString());
            crystalReportViewer1.ReportSource = report;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
