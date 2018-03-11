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
    public partial class Add_Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public Add_Product()
        {
            InitializeComponent();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
                con.Open();
            fillCombo();
            Disp();
            int i = 0;
            i = Convert.ToInt32(dataGridView1.Rows.Count);
            label9.Text = i.ToString();
            dataGridView1.ClearSelection();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into tblProductName values('" + textBox1.Text + "','" + comboBox1.SelectedItem.ToString() + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disp();
                int i = 0;
                i = Convert.ToInt32(dataGridView1.Rows.Count);
                label9.Text = i.ToString();


            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter the Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        public void fillCombo()
        {
           
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from units";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["unit"].ToString());
            }
        }
        public void Disp()
        {
            
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblProductName";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            comboBox2.Items.Clear();
           
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.Connection = con;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from units";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter dad1 = new SqlDataAdapter(cmd1);
            dad1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboBox2.Items.Add(dr1["unit"].ToString());
            }

            int i;
           
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblProductName where iID='"+i+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBox2.Text = dr["Product_Name"].ToString();
                comboBox2.SelectedItem=dr["Unit"].ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(textBox2.Text==""|| comboBox2.Text=="")
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());


                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update tblProductName set Product_Name='" + textBox2.Text + "',Unit='" + comboBox2.SelectedItem.ToString() + "' where iID='" + i + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disp();
                textBox2.Clear();
                comboBox2.SelectedIndex = -1;
                panel3.Visible = false;
            }
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            comboBox2.SelectedIndex = -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from tblProductName where iID='" + i + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disp();
                textBox2.Clear();
                panel3.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Data Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

