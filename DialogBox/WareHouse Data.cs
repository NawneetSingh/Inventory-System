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
    public partial class WareHouse_Data : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public WareHouse_Data()
        {
            InitializeComponent();
        }

        private void WareHouse_Data_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dataGridView1.ClearSelection();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                listBox1.Visible = true;
                listBox1.Items.Clear();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from tblStock where ProductName like('" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listBox1.Items.Add(dr["ProductName"].ToString());
                }
           
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                }
                if (e.KeyCode == Keys.Up)
                {
                    this.listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    textBox1.Text = listBox1.SelectedItem.ToString();
                    listBox1.Visible = false;
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblStock where ProductName='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;
            int i = 0;
            i = Convert.ToInt32(dataGridView1.RowCount.ToString());
            label5.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblStock";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;
            int i = 0;
            i = Convert.ToInt32(dataGridView1.RowCount.ToString());
            label5.Text = i.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
