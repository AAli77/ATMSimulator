using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSLibary;
using TSLibary.Models;

namespace TSUI
{
    public partial class frmMain: Form
    {

        public static string _accountNo = "";
        public static int _atm = 1;
        public static int _acc = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void lblMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cAccounts acc = new cAccounts(_accountNo);
            GlobalConfig.Connection.getAccInfo(acc);

            DateTime curDate = DateTime.Now;
            lblMessage.Text = "Welcome Account No." + _accountNo + " - " + acc.FullName;
            lblDate.Text = curDate.ToShortDateString();



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();
            flogin.Show();
            this.Hide();
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            
            frmDeposit fdeposit = new frmDeposit();
            fdeposit.Show();
            this.Hide();
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            frmBillPayee frmBP = new frmBillPayee();
            frmBP.Show();
            this.Hide();
        }

        private void btnWD_Click(object sender, EventArgs e)
        {
            frmWithDrawal frmWD = new frmWithDrawal();
            frmWD.Show();
            this.Hide();

        }

        private void btnTF_Click(object sender, EventArgs e)
        {
            frmTransfer fTrans = new frmTransfer();
            fTrans.Show();
            this.Hide();
        }

        private void btnAccBal_Click(object sender, EventArgs e)
        {
            frmAccBalances frmAccBal = new frmAccBalances();
            frmAccBal.Show();
            this.Hide();
        }

        private void btnChPIN_Click(object sender, EventArgs e)
        {
            frmChangPin frmChPin = new frmChangPin();
            frmChPin.Show();
            this.Hide();
        }
    }
}
