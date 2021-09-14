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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            txtATM.Text = frmMain._atm.ToString();
            txtAccNo.Text = frmMain._accountNo;
            cmbAcType.Items.Clear();
            cmbAcType.Items.Add(txtAccNo.Text + "-0");
            cmbAcType.Items.Add(txtAccNo.Text + "-1");
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain._accountNo = txtAccNo.Text;
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
            
        }

        private void cmbAcType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cDailyBalances bal = new cDailyBalances(txtAccNo.Text, cmbAcType.Text, "0");
            GlobalConfig.Connection.GetAccBal(bal);
            lblAcBal.Text = bal.Balance.ToString();
            //txtAmount.Text = this.cmbAcType.SelectedItem.ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                DateTime curDate = DateTime.Now;

                cTransaction tran = new cTransaction("0", curDate.ToShortDateString(), txtATM.Text, txtAccNo.Text, cmbAcType.Text, "DP", txtAmount.Text, "ATM - Deposit");
                GlobalConfig.Connection.InsertTran(tran);

                MessageBox.Show("Deposited successfully.....!");
                cmbAcType.Text = "";
                lblAcBal.Text = "";
                txtAmount.Text = "";

                cmbAcType.Focus();
            }
            else
            {
                MessageBox.Show("Invalid OR Blank Entry(s).....!");

                cmbAcType.Focus();
            }

        }

        private Boolean validateForm()
        {
            bool output = true;

            double amount = 0;
            bool depo_valid = double.TryParse(txtAmount.Text, out amount);
            if (!depo_valid)
            {
                output = false;
            }
            if (amount < 1)
            {
                output = false;
            }
            if (txtAmount.Text.Length == 0)
            {
                output = false;
            }

            if (txtATM.Text.Length == 0)
            {
                output = false;
            }

            if (cmbAcType.Text.Length == 0)
            {
                output = false;
            }

            if (txtAccNo.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
