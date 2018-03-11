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
    public partial class FilterDealer : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public FilterDealer()
        {
            InitializeComponent();
        }

        private void FilterDealer_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from vtblDealerInfo where DealerName like('"+textBox1.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["DealerName"].ToString());
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up)
            {
                this.listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
            if(e.KeyCode==Keys.Down)
            {
                this.listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            if(e.KeyCode==Keys.Enter)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from vtblDealerInfo where DealerName='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;



            SqlCommand cmd1 = con.CreateCommand();
            cmd1.Connection = con;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from vtblPurchaseInfo where PurchaseCustomerName='"+textBox1.Text+"'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter dad1 = new SqlDataAdapter(cmd1);
            dad1.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void FilterDealer_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
