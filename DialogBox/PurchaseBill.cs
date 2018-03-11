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
    public partial class PurchaseBill : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        string query;
        public PurchaseBill()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tblPurchaseInfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;
            foreach(DataRow dr in dt.Rows)
            {
                i = i +Convert.ToInt32 (dr["ProductTotal"].ToString());
            }
            label5.Text = i.ToString();

            query = "Select * from tblPurchaseInfo";
            int j = 0;
            j = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            label8.Text = j.ToString();
        }

        private void PurchaseBill_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
                con.Open();
            int j = 0;
            j =Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            label8.Text = j.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StartDate;
            string LastDate;
            int i = 0;
            StartDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            LastDate = dateTimePicker2.Value.ToString("dd-MM-yyyy");

            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblPurchaseInfo where ProductPurchaseDate >='" + StartDate.ToString()+ "' AND ProductPurchaseDate <='" + LastDate.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;
            foreach (DataRow dr in dt.Rows)
            {
                i = i + Convert.ToInt32(dr["ProductTotal"].ToString());
            }
            label5.Text = i.ToString();


            query = "select * from tblPurchaseInfo where ProductPurchaseDate >='" + StartDate.ToString() + "' AND ProductPurchaseDate <='" + LastDate.ToString() + "'";
            int j = 0;
            j = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            label8.Text = j.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneratePurchaseBill GPB = new GeneratePurchaseBill();
            GPB.getvalue(query.ToString());
            GPB.Show();
        }

        private void PurchaseBill_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
