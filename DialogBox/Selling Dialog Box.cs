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
    public partial class Selling_Dialog_Box : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        DataTable dt1 = new DataTable();
        int tot = 0;
        string OrderId = "";
        public Selling_Dialog_Box()
        {
            InitializeComponent();
        }

        private void Selling_Dialog_Box_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
                con.Open();
            dt1.Clear();
            dt1.Columns.Add("Product_Name");
            dt1.Columns.Add("Product_Price");
            dt1.Columns.Add("Product_Quantity");
            dt1.Columns.Add("Total");

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tblStock where ProductName like('"+textBox1.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["ProductName"].ToString());
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
                if(e.KeyCode==Keys.Down)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;
                }
                if(e.KeyCode==Keys.Up)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;
                }
                if(e.KeyCode==Keys.Enter)
                {
                    textBox1.Text = listBox1.SelectedItem.ToString();
                    listBox1.Visible = false;
                    textBox2.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from tblPurchaseInfo where ProductName='"+textBox1.Text+"' order by iID desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBox2.Text = dr["ProductPrice"].ToString();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""||textBox5.Text==""||textBox6.Text=="")
                {
                    MessageBox.Show("Please Enter Mandatory Fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    int stock = 0;
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from tblStock where ProductName='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter dad = new SqlDataAdapter(cmd);
                    dad.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        stock = Convert.ToInt32(dr["ProductQuantity"].ToString());
                    }
                    if (stock < Convert.ToInt32(textBox3.Text))
                    {
                        MessageBox.Show("Stock Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataRow dr = dt1.NewRow();
                        dr["Product_Name"] = textBox1.Text;
                        dr["Product_Price"] = textBox2.Text;
                        dr["Product_Quantity"] = textBox3.Text;
                        dr["Total"] = textBox4.Text;
                        dt1.Rows.Add(dr);
                        dataGridView1.DataSource = dt1;

                        tot = tot + Convert.ToInt32(dr["Total"].ToString());

                        label10.Text = tot.ToString();
                    }
                   
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex+"Message");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                    tot = 0;
                    dt1.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString()));
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        tot = tot + Convert.ToInt32(dr1["Total"].ToString());
                        label10.Text = tot.ToString();
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Please Enter Mandatory Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into tblOderUser values('" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "')";
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.Connection = con;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "Select Top 1 * from tblOderUser Order by iID desc";
                    cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter dad = new SqlDataAdapter(cmd2);
                    dad.Fill(dt2);
                    foreach (DataRow dr2 in dt2.Rows)
                    {
                        OrderId = dr2["iID"].ToString();
                    }

                    foreach (DataRow dr in dt1.Rows)
                    {
                        int Quantity = 0;
                        string ProductName = "";

                        SqlCommand cmd3 = con.CreateCommand();
                        cmd3.Connection = con;
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "insert into tblOrderItem values('" + OrderId.ToString() + "','" + dr["Product_Name"].ToString() + "','" + dr["Product_Price"].ToString() + "','" + dr["Product_Quantity"].ToString() + "','" + dr["Total"].ToString() + "')";
                        cmd3.ExecuteNonQuery();


                        Quantity = Convert.ToInt32(dr["Product_Quantity"].ToString());
                        ProductName = dr["Product_Name"].ToString();

                        SqlCommand cmd4 = con.CreateCommand();
                        cmd4.Connection = con;
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "update tblStock set ProductQuantity=ProductQuantity-" + Quantity + " where ProductName='" + ProductName.ToString() + "'";
                        cmd4.ExecuteNonQuery();



                    }

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    label10.Text = "";
                    dt1.Clear();
                    dataGridView1.DataSource = dt1;
                    Generate_Bill Gb = new Generate_Bill();
                    Gb.Get_value(Convert.ToInt32(OrderId.ToString()));
                    Gb.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToString();
        }

        private void Selling_Dialog_Box_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
