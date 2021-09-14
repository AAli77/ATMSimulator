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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain._accountNo = txtAccNo.Text;
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            txtAccNo.Text = frmMain._accountNo;
            cmbFAccount.Items.Clear();
            cmbFAccount.Items.Add(txtAccNo.Text + "-0");
            cmbFAccount.Items.Add(txtAccNo.Text + "-1");
        }

        private void cmbFAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            cDailyBalances bal = new cDailyBalances(txtAccNo.Text, cmbFAccount.Text, "0");
            GlobalConfig.Connection.GetAccBal(bal);
            lblFAcBal.Text = bal.Balance.ToString();
            if (cmbFAccount.Text == txtAccNo.Text + "-0")
            {
                cmbTAccount.Items.Clear();
                cmbTAccount.Items.Add(txtAccNo.Text + "-1");
            }
            else
            {
                cmbTAccount.Items.Clear();
                cmbTAccount.Items.Add(txtAccNo.Text + "-0");
            }
        }

        private void cmbTAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            cDailyBalances bal = new cDailyBalances(txtAccNo.Text, cmbTAccount.Text, "0");
            GlobalConfig.Connection.GetAccBal(bal);
            lblTAcBal.Text = bal.Balance.ToString();
        }

        private Boolean validateForm()
        {
            bool output = true;

            double _fBal = 0;
            double.TryParse(lblFAcBal.Text, out _fBal);

            double _tBal = 0;
            double.TryParse(lblTAcBal.Text, out _tBal);

            double _amnt = 0;
            bool amnt_valid = double.TryParse(txtAmount.Text, out _amnt);
            //double.TryParse(txtAmount.Text, out _amnt);
            if (!amnt_valid)
            {
                return false;
            }

            if (_amnt > _fBal)
            {
                return false;
            }

            if (cmbFAccount.Text == cmbTAccount.Text)
            {
                return false;
            }

            if (_amnt < 1)
            {
                return false;
            }

            if (txtAmount.Text.Length == 0)
            {
                return false;
            }

            if (txtAccNo.Text.Length == 0)
            {
                return false;
            }

            if (cmbFAccount.Text.Length == 0)
            {
                return false;
            }

            if(cmbTAccount.Text.Length == 0)
            {
                return false;
            }
            return output;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            float _trAmnt = 0;
            float.TryParse(txtAmount.Text, out _trAmnt);

            DateTime curDate = DateTime.Now;
            string _tranDesc = "";
            string _tranType = "TO";
            string _amnt = "";
            string _tranacc = "";
            

            //cTransaction tran = new cTransaction("0", curDate.ToShortDateString(), "0", txtAccNo.Text, cmbFAccount.Text, _tranType, "-" + _trAmnt.ToString(), _tranDesc);
            //GlobalConfig.Connection.InsertTran(tran);

            //GlobalConfig.Connection.InsertTran(tran2);
            if (validateForm())
            {
                _tranDesc = $"Transfer Funds To {cmbTAccount.Text}";
                _amnt = "-" + _trAmnt.ToString();
                _tranacc = cmbFAccount.Text;
                cTransaction tran = new cTransaction("0", curDate.ToShortDateString(), "0", txtAccNo.Text, _tranacc, _tranType, _amnt, _tranDesc);
                GlobalConfig.Connection.InsertTran(tran);

                tran.TrAccNo = cmbTAccount.Text;
                tran.TranType = "TF";
                tran.TranDesc = $"Transfer Funds From {cmbFAccount.Text}";
                tran.TranAmount = _trAmnt;
                GlobalConfig.Connection.InsertTran(tran);
                MessageBox.Show("Records Saved .....!");
            }
            else
            {
                MessageBox.Show("Invalid Entry, OR insuffient fund to transfer.....!");
                cmbFAccount.Focus();
            }

        }
    }
}
