using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBox
{
    public partial class ProductActivationWindow : Form
    {
        public ProductActivationWindow()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) == 100000)
                {
                    MessageBox.Show("Product Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid Serial Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
                {
                    label7.Text = "Your Product is not Registered";
                }
                else
                {
                    label7.Text = "Your Product is Registered";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()=="Standard")
            {
                textBox2.Text = "100";
            }
            else if(comboBox1.SelectedItem.ToString()=="Professional")
            {
                textBox2.Clear();
                textBox2.Text = "300";
            }
            else
            {
                textBox2.Clear();
                textBox2.Text = "200";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem.ToString()=="TRIAL")
            {
                panel4.Hide();
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void ProductActivationWindow_Load(object sender, EventArgs e)
        {
            label7.Text = "";
        }
    }
}
