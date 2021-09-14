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
    public partial class frmAccBalances : Form
    {
        //private List<cTransaction> dBalance = new List<cTransaction>();
        public frmAccBalances()
        {
            InitializeComponent();
            //CreateSampleData();
            //showReport(1,"A",0);



        }

        private void frmAccBalances_Load(object sender, EventArgs e)
        {
            txtAccNo.Text = frmMain._accountNo;
            cmbAcType.Items.Clear();
            cmbAcType.Items.Add(txtAccNo.Text + "-0");
            cmbAcType.Items.Add(txtAccNo.Text + "-1");
        }

        private Boolean validateForm()
        {
            try
            {
                bool output = true;

                if (txtAccNo.Text.Length == 0)
                {
                    return false;
                }

                if (cmbAcType.Text.Length == 0)
                {
                    return false;
                }

                if (rdDays30.Checked==false && rdDays60.Checked==false && rdDays90.Checked==false && rdDays120.Checked == false && rdToday.Checked == false)
                {
                    return false;
                }

                return output;

            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {

            }
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
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int _accno;
            int.TryParse(txtAccNo.Text, out _accno);


            if (validateForm())
            {
                if (rdDays30.Checked == true)
                {
                    showReport(_accno, cmbAcType.Text, 30);
                }
                else if (rdDays60.Checked == true)
                {
                    showReport(_accno, cmbAcType.Text, 60);
                }
                else if (rdDays90.Checked == true)
                {
                    showReport(_accno, cmbAcType.Text, 90);
                }
                else if (rdDays120.Checked == true)
                {
                    showReport(_accno, cmbAcType.Text, 120);
                }
                else if (rdToday.Checked == true)
                {
                    showReport(_accno, cmbAcType.Text, 0);
                }
            }
            else
            {
                MessageBox.Show("Invalid data entered.....!");
            }
        }

        private void showReport(int accno, string traccno, int pdays)
        {
            List<cTransaction> dBalance = GlobalConfig.Connection.dispTransaction(accno, traccno, pdays);

            lstDispBal.DataSource = dBalance;
            lstDispBal.DisplayMember = "DisplayTransaction";

        }

        private void CreateSampleData()
        {
            //dBalance.Add(new cTransaction {AccNo=1, TranAcc="1", TranType="AB",TranAmount=0,TranDesc=""});
            //dBalance.Add(new cTransaction { BPAccNo = "12345674", BPName = "Epcor Utility" });
            //dBalance.Add(new cTransaction { BPAccNo = "8989898989889", BPName = "XYZ Express" });
            //dBalance.Add(new cTransaction { BPAccNo = "1001-1234", BPName = "Goverment" });
        }

        private void grpRptMonth_Enter(object sender, EventArgs e)
        {

        }
    }
}
