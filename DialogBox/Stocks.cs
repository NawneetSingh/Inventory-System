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
    public partial class Stocks : Form
    {
       
        private int childFormNumber = 0;
      
        public Stocks()
        {
            InitializeComponent();
           
        }

        private void Stocks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

            Login login = new Login();
            login.ShowDialog();
          

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup sp = new Signup();
            sp.ShowDialog();
            
        }

        private void stockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void addNewUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Units unit = new Units();
            unit.ShowDialog();
           
        }
        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product AP = new Add_Product();
            AP.ShowDialog();
        }
        private void addDealerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Dealer_Info ADI = new Add_Dealer_Info();
            ADI.ShowDialog();
        }
        private void productPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPurchase PR = new ProductPurchase();
            PR.ShowDialog();  
        }
        private void sellProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Selling_Dialog_Box SDB = new Selling_Dialog_Box();
            SDB.ShowDialog();    
        }
        private void purchaseBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseBill PB = new PurchaseBill();
            PB.ShowDialog();   
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void filterDealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterDealer FD = new FilterDealer();  
            FD.ShowDialog();
            
        }

        private void productRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductActivationWindow PRW = new ProductActivationWindow();
            PRW.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void wareHouseDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WareHouse_Data WD = new WareHouse_Data();
            WD.ShowDialog();  
        }
        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "User";
        }

        private void stockToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Units";
        }

        private void reportToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Product";
        }

        private void dealerInfoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dealer Info";
        }

        private void reportToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Report";
        }

        private void registrationToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Registration";
        }

        private void Stocks_DragOver(object sender, DragEventArgs e)
        {

        }

        private void Stocks_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text="Easy Record";
        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Easy Record";
        }

        private void saleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterBox FB = new FilterBox();
            FB.ShowDialog();
        }

        private void dealerAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealerAudit DA = new DealerAudit();
            DA.ShowDialog();
        }

        private void purchaseInfoAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseAudit PA = new PurchaseAudit();
            PA.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export EX = new Export();
            EX.ShowDialog();
        }

        private void importDealerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import Im = new Import();
            Im.ShowDialog();
        }

        private void loginAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginAudit LA = new LoginAudit();
            LA.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Exit";
           Application.Exit();
        }

        private void importExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Import/Export";
        }

        private void auditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Audit";
        }
    }
   
}
   
