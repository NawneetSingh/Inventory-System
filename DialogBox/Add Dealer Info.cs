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
    public partial class Add_Dealer_Info : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");

        public Add_Dealer_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           if(textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""|| textBox5.Text == ""|| textBox6.Text == ""|| textBox7.Text == "")
            {
                MessageBox.Show("Please Enter Mandatory Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else
            {
               
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into tblDealerInfo values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                FillGrid();

                int j = 0;
                j = Convert.ToInt32(dataGridView1.RowCount.ToString());
                label17.Text = j.ToString();
            }
        }
        public void FillGrid()
        {
            
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblDealerInfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Add_Dealer_Info_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            FillGrid();
            int j = 0;
            j = Convert.ToInt32(dataGridView1.RowCount.ToString());
            label17.Text = j.ToString();
            dataGridView1.ClearSelection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From tblDealerInfo where iID='" + i + "'";
                MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.ExecuteNonQuery();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                FillGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Data Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int j = 0;
            j = Convert.ToInt32(dataGridView1.RowCount.ToString());
            label17.Text = j.ToString();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
            
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblDealerInfo where iID='"+i+"'";
            cmd.ExecuteNonQuery();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "")
            {
                MessageBox.Show("Please Select Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tblDealerInfo set DealerName='" + textBox8.Text + "',DealerCompanyName='" + textBox9.Text + "',Contact='" + textBox10.Text + "',Address='" + textBox11.Text + "',City='" + textBox12.Text + "',State='" + textBox13.Text + "',Country='" + textBox14.Text + "' Where iID='" + i + "' ";
                cmd.ExecuteNonQuery();
                FillGrid();
            }
            

        }
        public void FillTextBox()
        {
            
            int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblDealerInfo where iID='"+i+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBox8.Text = dr["DealerName"].ToString();
                textBox9.Text = dr["DealerCompanyName"].ToString();
                textBox10.Text = dr["Contact"].ToString();
                textBox11.Text = dr["Address"].ToString();
                textBox12.Text = dr["City"].ToString();
                textBox13.Text = dr["State"].ToString();
                textBox14.Text = dr["Country"].ToString();
               
            }
           

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FillTextBox();
        }

        private void endUpdationPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Dealer_Info_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel3_Click(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
