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
    public partial class Units : Form
    {
        SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public Units()
        {
            InitializeComponent();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            if(con1.State==ConnectionState.Open)
            {
                con1.Close();
            }
            con1.Open();
            Disp_data();
            int i=0;
            i = Convert.ToInt32(dataGridView1.Rows.Count);
            label6.Text = i.ToString();
            dataGridView1.ClearSelection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                SqlCommand cmd1 = con1.CreateCommand();
                cmd1.Connection = con1;
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from Units where unit='" + textBox2.Text + "' ";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter dad = new SqlDataAdapter(cmd1);
                dad.Fill(dt1);
                count = Convert.ToInt32(dt1.Rows.Count.ToString());
                if (count == 0)
                {
                    if(textBox2.Text=="")
                    {
                        MessageBox.Show("Please Enter Unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = con1.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into Units values('" + textBox2.Text + "')";
                        cmd.ExecuteNonQuery();
                        textBox2.Clear();
                        MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disp_data();
                        int i = 0;
                        i = Convert.ToInt32(dataGridView1.Rows.Count);
                        label6.Text = i.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void Disp_data()
        {
           
            
            SqlCommand cmd = con1.CreateCommand();
            cmd.Connection = con1;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Units ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con1.CreateCommand();
                cmd.Connection = con1;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Units where iID='" + id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disp_data();
                int i = 0;
                i = Convert.ToInt32(dataGridView1.Rows.Count);
                label6.Text = i.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Select Row To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

           
           
            SqlCommand cmd = con1.CreateCommand();
            cmd.Connection = con1;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Units set Unit='" + textBox1.Text + "' where iID='"+i+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Disp_data();
            textBox1.Clear();
            panel2.Visible = false;


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            int i;

            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con1.CreateCommand();
            cmd.Connection = con1;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Units where iID='" + i + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["unit"].ToString();
            }
        }

        private void endUpdatePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Units_Click(object sender, EventArgs e)
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

        private void panel3_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
