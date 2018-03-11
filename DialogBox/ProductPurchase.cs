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
    public partial class ProductPurchase : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public ProductPurchase()
        {
            InitializeComponent();
        }

      
        public void FillCombo()
        {
           
           
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tblDealerInfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["DealerName"].ToString());
            }
        }

        public void FillCombo2()
        {
           
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tblProductName";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Product_Name"].ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductPurchase_Load_1(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            FillCombo();
            FillCombo2();
            FillData();
            int j=0;
            j = Convert.ToInt32((dataGridView1.Rows.Count));
            label16.Text = j.ToString();
            dataGridView1.ClearSelection();
            total();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from tblProductName where Product_Name='" + comboBox1.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    label3.Text = dr["Unit"].ToString();
                }
            }
            catch(Exception ex)
            {
                
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox5.Text = (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox4.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                int i;

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.Connection = con;
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select * from tblStock where ProductName='" + comboBox1.SelectedItem.ToString() + "'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter dad1 = new SqlDataAdapter(cmd1);
                dad1.Fill(dt1);
                i = Convert.ToInt32(dt1.Rows.Count.ToString());
                if (i == 0)
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into tblPurchaseInfo values('" + comboBox1.Text + "','" + textBox2.Text + "','" + label3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + comboBox2.Text + "','" + comboBox3.SelectedItem.ToString() + "','" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "','" + textBox9.Text + "')";
                    cmd.ExecuteNonQuery();
                    FillData();
                    int j=0;
                    j = Convert.ToInt32((dataGridView1.Rows.Count));
                    label16.Text = j.ToString();


                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.Connection = con;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "insert into tblStock values('" + comboBox1.Text + "','" + textBox2.Text + "','" + label3.Text + "')";
                    cmd2.ExecuteNonQuery();


                }
                else
                {

                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.Connection = con;
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "insert into tblPurchaseInfo values('" + comboBox1.Text + "','" + textBox2.Text + "','" + label3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "','" + comboBox2.Text + "','" + comboBox3.SelectedItem.ToString() + "','" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "','" + textBox9.Text + "')";
                    cmd3.ExecuteNonQuery();
                    FillData();
                    total();
                    int j=0;
                    j = Convert.ToInt32((dataGridView1.Rows.Count));
                    label16.Text = j.ToString();
                    total();





                    SqlCommand cmd4 = con.CreateCommand();
                    cmd4.Connection = con;
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "update tblStock set ProductQuantity=ProductQuantity+" + textBox2.Text + " where ProductName='" + comboBox1.Text + "'";
                    cmd4.ExecuteNonQuery();


                }
                MessageBox.Show("Item Purchased", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
               
            }


        }
        public void FillData()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from tblPurchaseInfo";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
              
            }
        }
        public void total()
        {
            try
            {
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from tblPurchaseInfo";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dad = new SqlDataAdapter(cmd);
                dad.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    i = i + Convert.ToInt32(dr["ProductTotal"].ToString());
                }
                label17.Text = i.ToString();
            }
            catch(Exception ex)
            {
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox9.Clear();
            label12.Text = "";
            label13.Text = "";  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());


            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tblPurchaseInfo where iID='"+i+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBox2.Text = dr["ProductQuantity"].ToString();
                comboBox1.SelectedItem = dr["ProductName"].ToString();
                comboBox2.SelectedItem = dr["PurchaseCustomerName"].ToString();
                comboBox3.SelectedItem = dr["PurchaseType"].ToString();
                textBox4.Text = dr["ProductPrice"].ToString();
                textBox5.Text = dr["ProductTotal"].ToString();
                textBox9.Text = dr["Profit"].ToString();
                label12.Text = (dr["ProductPurchaseDate"].ToString());
                label13.Text = dr["DateOfExpiry"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text==""||textBox4.Text==""||textBox5.Text=="")
                {
                    MessageBox.Show("Please Fill Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i;
                    i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update tblPurchaseInfo set ProductName='" + comboBox1.Text + "',ProductQuantity='" + textBox2.Text + "',ProductPrice='" + textBox4.Text + "',ProductUnit='" + label3.Text + "',ProductTotal='" + textBox5.Text + "',ProductPurchaseDate='" + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "',PurchaseCustomerName='" + comboBox2.Text + "',PurchaseType='" + comboBox3.Text + "',DateOfExpiry='" + dateTimePicker2.Value.ToString("dd-MM-yyyy") + "',Profit='" + textBox9.Text + "' where iID='" + i + "'";
                    cmd.ExecuteNonQuery();
                    FillData();
                    total();
                    
                }
               

                

            }
            catch (Exception ex)
            {

            }


            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ProductPurchase_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from tblPurchaseInfo where iID='"+i+"'";
            cmd.ExecuteNonQuery();
            FillData();
            total();
            int j = 0;
            j = Convert.ToInt32((dataGridView1.Rows.Count));
            label16.Text = j.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
