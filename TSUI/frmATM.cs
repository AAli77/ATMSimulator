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
    public partial class frmATM: Form
    {
        public frmATM()
        {
            InitializeComponent();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void lblAcType_Click(object sender, EventArgs e)
        {

        }

        private void cmbFAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            //MessageBox.Show(curDate.ToShortDateString());
            txtAmount.Text = "";
            txtBal.Text = "";

            cATM atm = new cATM(cmbATMId.Text, curDate.ToShortDateString(), "", "", "");
            GlobalConfig.Connection.GetBalance(atm);

            if (atm.fndRec == "1")
            {
                //TO DO: Setup Initialization
                initializeForm("1", atm.DepoAmount, atm.DepoBalance);
                
            }
            else
            {
                //TO DO: Allow add ATM Deposit
                initializeForm("0", 0,0);
            }

        }
        private void initializeForm(string _a, double _depoAmt, double _atmBal)
        {
            if (_a == "1")
            {
                txtAmount.Enabled = false;
                txtAmount.Text = _depoAmt.ToString();
                txtBal.Text = _atmBal.ToString();
                btnDeposit.Enabled = false;

            }
            else
            {
                txtAmount.Enabled = true;
                txtAmount.Text = _depoAmt.ToString(); ;
                txtBal.Text = _atmBal.ToString();
                btnDeposit.Enabled = true;
            }
        }
        private Boolean validateForm()
        {
            bool output = true;

            int atmid = 0;
            bool atm_valid = int.TryParse(cmbATMId.Text, out atmid);
            if (!atm_valid)
            {
                output = false;
            }

            if (atmid < 1)
            {
                output = false;
            }

            double atmDepo = 0;
            bool depo_valid = double.TryParse(txtAmount.Text, out atmDepo);
            if (!depo_valid)
            {
                output = false;
            }
            if (atmDepo < 50000)
            {
                output = false;
            }
            if (txtAmount.Text.Length == 0)
            {
                output = false;
            }

            txtBal.Text = "0.00";

            return output;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                DateTime curDate = DateTime.Now;

                cATM atm = new cATM(cmbATMId.Text, curDate.ToShortDateString(), txtAmount.Text, txtBal.Text, "");
                GlobalConfig.Connection.AddBalance(atm);

                MessageBox.Show("Record Successfully saved.....!");
                btnDeposit.Enabled = false;
                txtAmount.Enabled = false;
                btnDeposit.Focus();


            }
            else
            {
                MessageBox.Show("Invalid Enteries ......!");
            }
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSupervisor fSuper = new frmSupervisor();
            fSuper.Show();
            this.Hide();
        }
    }
}
