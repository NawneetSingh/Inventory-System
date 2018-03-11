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
using System.Collections;

namespace DialogBox
{
   
    public partial class FilterBox : Form
    {
     SqlConnection con = new SqlConnection("Data Source = DESKTOP-JR9VG22\\SQLEXPRESS1; Initial Catalog = Stock; User ID = sa; Password=123");
        public FilterBox()
        {
            InitializeComponent();
        }
        private void FilterBox_Load(object sender, EventArgs e)
        {
            int j = 0;
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            j = dataGridView1.Rows.Count;
            label7.Text = j.ToString();


        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int j = 0;
            int i = 0;
            string StartDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string EndDate = dateTimePicker2.Value.ToString("dd-MM-yyyy");


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select OrderID, Product_Name, Product_Price, Product_Quantity, Total, FirstName, BillDate, Contact From[tblOrderItem] join tblOderUser on[tblOrderItem].OrderID=tblOderUser.iID where BillDate>='"+StartDate.ToString()+"' And BillDate<='"+EndDate.ToString()+"' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           foreach(DataRow dr in dt.Rows)
            {
                i = i+Convert.ToInt32(dr["Total"].ToString());
            }
              label6.Text = i.ToString();

              j=dataGridView1.Rows.Count;
              label7.Text = j.ToString();
            
        }
           

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString();
        }
    }  

        
   
}
