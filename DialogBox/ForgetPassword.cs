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
    public partial class ForgetPassword : Form
    {
        SqlConnection con = new SqlConnection("Data Source =DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from tblLogin where vLoginId='" + textBox3.Text + "' AND vName='" + textBox1.Text + "' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter dad = new SqlDataAdapter(cmd);
                    dad.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        SqlCommand cmd1 = con.CreateCommand();
                        cmd.Connection = con;
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "Update tblLogin set vPassword='" + textBox4.Text + "' where vLoginId='" + textBox3.Text + "' ";
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Password Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                       

                      
                    }
                    else
                    {
                        MessageBox.Show("LoginId Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Internal Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }
    }
}
