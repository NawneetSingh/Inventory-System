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
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public Signup()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please Enter Mandatory Feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text == textBox8.Text)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from tblLogin where vLoginId='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter dad = new SqlDataAdapter(cmd);
                    dad.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    if (i == 0)
                    {
                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.Connection = con;
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "Insert into tblLogin (vLoginId,vPassword,vName,vEmailId,vContactNo,vAddress,vGender) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.SelectedItem.ToString() + "')";
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Signed Up Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox8.Clear();
                        comboBox1.SelectedIndex = 0;
                        display();
                        int j = 0;
                        j = Convert.ToInt32(dataGridView1.RowCount.ToString());
                        label12.Text = j.ToString();
                    }
                    else
                    {
                        MessageBox.Show("LoginId Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            comboBox1.SelectedIndex = 0;
            display();
            int j = 0;
            j= Convert.ToInt32(dataGridView1.RowCount.ToString());
            label12.Text = j.ToString();
            dataGridView1.ClearSelection();

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from vtblLogin";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tblLogin where iId='" + id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                int j = 0;
                j = Convert.ToInt32(dataGridView1.RowCount.ToString());
                label12.Text = j.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString();
        }

        private void Signup_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
    
}
