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
    public partial class frmWithDrawal: Form
    {
        public frmWithDrawal()
        {
            InitializeComponent();
        }

        private void frmWithDrawal_Load(object sender, EventArgs e)
        {
            txtATMId.Text = frmMain._atm.ToString();
            txtAccNo.Text = frmMain._accountNo;
            cmbAcType.Items.Clear();
            cmbAcType.Items.Add(txtAccNo.Text + "-0");
            cmbAcType.Items.Add(txtAccNo.Text + "-1");
        }

        private void cmdAcType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cDailyBalances bal = new cDailyBalances(txtAccNo.Text, cmbAcType.Text, "0");
            GlobalConfig.Connection.GetAccBal(bal);
            lblAcBal.Text = bal.Balance.ToString();
        }
        private Boolean validateForm(double wdAmt)
        {
            bool output = true;

            double bal = 0;
            double.TryParse(lblAcBal.Text, out bal);

            if (wdAmt > bal)
            {
                output = false;
            }

            if (wdAmt > 5000)
            {
                output = false;
            }

            return output;
        }

        private void saveTransaction(double wdAmount)
        {
            DateTime curDate = DateTime.Now;

            cTransaction tran = new cTransaction("0", curDate.ToShortDateString(), txtATMId.Text, txtAccNo.Text, cmbAcType.Text, "WD", "-"+wdAmount.ToString(), "ATM - WithDrawal");
            GlobalConfig.Connection.InsertTran(tran);
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            if (validateForm(10))
            {
                saveTransaction(10);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }
        }

        private void lbl20_Click(object sender, EventArgs e)
        {
            if (validateForm(20))
            {
                saveTransaction(20);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }

        }

        private void lbl40_Click(object sender, EventArgs e)
        {
            if (validateForm(40))
            {
                saveTransaction(40);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }

        }

        private void lbl60_Click(object sender, EventArgs e)
        {
            if (validateForm(60))
            {
                saveTransaction(60);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }

        }

        private void lbl80_Click(object sender, EventArgs e)
        {
            if (validateForm(80))
            {
                saveTransaction(80);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }

        }

        private void lbl100_Click(object sender, EventArgs e)
        {
            if (validateForm(100))
            {
                saveTransaction(100);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }

        }

        private void lbl200_Click(object sender, EventArgs e)
        {
            if (validateForm(200))
            {
                saveTransaction(200);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }

        }

        private void lbl400_Click(object sender, EventArgs e)
        {
            if (validateForm(400))
            {
                saveTransaction(400);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            btnWithDraw.Text = txtAmount.Text;
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            double otherAmt = 0;
            double.TryParse(txtAmount.Text, out otherAmt);

            if (validateForm(otherAmt))
            {
                saveTransaction(otherAmt);
                MessageBox.Show("Successfully WithDrawal.....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance OR WithDrawal is greater then 5000");
            }

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain._accountNo = txtAccNo.Text;
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }
    }
}
