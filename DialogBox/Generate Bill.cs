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
using System.Configuration;

namespace DialogBox
{
    public partial class Generate_Bill : Form
    {
        int j;
        int tot=0;
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public Generate_Bill()
        {
            InitializeComponent();
        }

        public void Get_value(int i)
        {
            j = i;
        }
        private void Generate_Bill_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            DataSet1 ds = new DataSet1();

            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblOderUser where iID='"+j+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(ds.DataTable1);


            SqlCommand cmd1 = con.CreateCommand();
            cmd1.Connection = con;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from tblOrderItem where OrderID='" + j + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter dad1 = new SqlDataAdapter(cmd1);
            dad1.Fill(ds.DataTable2);
            dad1.Fill(dt1);

            tot = 0;
            foreach(DataRow dr1 in dt1.Rows)
            {
                tot = tot + Convert.ToInt32(dr1["Total"].ToString());
            }

            CrystalReport1 CR = new CrystalReport1();
            CR.SetDataSource(ds);
            CR.SetParameterValue("Total", tot.ToString());
            crystalReportViewer1.ReportSource = CR;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
