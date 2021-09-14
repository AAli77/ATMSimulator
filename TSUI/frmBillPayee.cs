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
    public partial class frmBillPayee: Form
    {
        //private List<cBillPayee> availBillP = new List<cBillPayee>();
        private List<cBillPayee> availBillP = GlobalConfig.Connection.GetBillP_Acc(frmMain._acc);
        public frmBillPayee()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUplist();

            
        }

        private void frmBillPayee_Load(object sender, EventArgs e)
        {
            txtATMId.Text = frmMain._atm.ToString();
            txtAccNo.Text = frmMain._accountNo;
            cmbAcType.Items.Clear();
            cmbAcType.Items.Add(txtAccNo.Text + "-0");
            cmbAcType.Items.Add(txtAccNo.Text + "-1");
        }

        private void CreateSampleData()
        {
            availBillP.Add(new cBillPayee { BPAccNo = "511111111111", BPName = "ABC Credit Card" });
            availBillP.Add(new cBillPayee { BPAccNo = "12345674", BPName = "Epcor Utility" });
            availBillP.Add(new cBillPayee { BPAccNo = "8989898989889", BPName = "XYZ Express" });
            availBillP.Add(new cBillPayee { BPAccNo = "1001-1234", BPName = "Goverment" });
        }


        private void WireUplist()
        {
            cmbBillPayAcc.DataSource = availBillP;
            cmbBillPayAcc.DisplayMember = "BPayeeFullName";

        }

        private void llblNewBP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBillPayAcc frmBPAcc = new frmBillPayAcc();
            frmBPAcc.Show();
            this.Hide();

        }

        private void cmbAcType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cDailyBalances bal = new cDailyBalances(txtAccNo.Text, cmbAcType.Text, "0");
            GlobalConfig.Connection.GetAccBal(bal);
            lblAcBal.Text = bal.Balance.ToString();
        }

        private Boolean validateForm()
        {
            bool output = true;

            double bAmount = 0;
            double.TryParse(txtAmount.Text, out bAmount);
            bAmount += 1.25;

            double bal = 0;
            double.TryParse(lblAcBal.Text, out bal);

            if (bAmount > bal)
            {
                output = false;
            }

            if (bAmount < 2)
            {
                output = false;
            }

            if (txtAccNo.Text.Length == 0)
            {
                output = false;
            }

            if (txtAmount.Text.Length == 0)
            {
                output = false;
            }

            if(txtATMId.Text.Length == 0)
            {
                output = false;
            }

            if (cmbAcType.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void saveTransaction(double wdAmount)
        {
            DateTime curDate = DateTime.Now;
            double _serviceChg = 1.25;
            string _tranDesc = "";

            _tranDesc = "Bill pay for Account " + cmbBillPayAcc.Text;

            cTransaction tran = new cTransaction("0", curDate.ToShortDateString(), txtATMId.Text, txtAccNo.Text, cmbAcType.Text, "BP", "-" + wdAmount.ToString(), _tranDesc);
            GlobalConfig.Connection.InsertTran(tran);

            cTransaction tran2 = new cTransaction("0", curDate.ToShortDateString(), txtATMId.Text, txtAccNo.Text, cmbAcType.Text, "SC", "-" + _serviceChg.ToString(), "Bill Payee Service Charge");
            GlobalConfig.Connection.InsertTran(tran2);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            double _bpAmnt = 0;
            double.TryParse(txtAmount.Text, out _bpAmnt);

            DateTime curDate = DateTime.Now;
            double _serviceChg = 1.25;
            string _tranDesc = "";

            _tranDesc = "Bill pay for Account " + cmbBillPayAcc.Text;

            cTransaction tran = new cTransaction("0", curDate.ToShortDateString(), txtATMId.Text, txtAccNo.Text, cmbAcType.Text, "BP", "-" + _bpAmnt.ToString(), _tranDesc);
            GlobalConfig.Connection.InsertTran(tran);

            cTransaction tran2 = new cTransaction("0", curDate.ToShortDateString(), txtATMId.Text, txtAccNo.Text, cmbAcType.Text, "SC", "-" + _serviceChg.ToString(), "Bill Payee Service Charge");
            GlobalConfig.Connection.InsertTran(tran2);


            if (validateForm())
            {
                saveTransaction(_bpAmnt);
                MessageBox.Show("Bill Successfully Paid.....!");
                txtAccNo.Text = "";
                cmbAcType.Focus();

            }
            else
            {
                MessageBox.Show("Invalid Entry OR not enough Balance");
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
