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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public Login()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 
                 SqlCommand cmd = con.CreateCommand();
                 cmd.Connection = con;
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "Select * from tblLogin where vLoginId='" + textBox1.Text + "' and vPassword='" + textBox2.Text + "'";
                 cmd.ExecuteNonQuery();
                 DataTable dt = new DataTable();
                 SqlDataAdapter dad = new SqlDataAdapter(cmd);
                 dad.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                User us = new User(textBox1.Text);
                us.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Enter Correct Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2_Click(sender, e);
            }

           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
           
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
           
            ForgetPassword FP = new ForgetPassword();
            FP.ShowDialog();
           
        }
    }

}
