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
    public partial class LoginAudit : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public LoginAudit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Proc_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;
            int i = 0;
            i = dataGridView1.Rows.Count;
            label3.Text = i.ToString();

        }

        private void LoginAudit_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            int i = 0;
            i = dataGridView1.Rows.Count;
            label3.Text = i.ToString();
            dataGridView1.ClearSelection(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
