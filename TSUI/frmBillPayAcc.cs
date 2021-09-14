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
    public partial class frmBillPayAcc : Form
    {
        public frmBillPayAcc()
        {
            InitializeComponent();
        }

        private void frmBillPayAcc_Load(object sender, EventArgs e)
        {
            txtAccNo.Text = frmMain._accountNo;
        }

        private Boolean validateForm()
        {
            bool output = true;

            if (txtAccNo.Text.Length == 0)
            {
                output = false;
            }

            if (txtPAccount.Text.Length == 0)
            {
                output = false;
            }

            if (txtPName.Text.Length == 0)
            {
                output = false;
            }

            if (txtPType.Text.Length ==0)
            {
                output = false;
            }
            return output;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                cBillPayee BP = new cBillPayee(txtAccNo.Text, txtPName.Text, txtPType.Text, txtPAccount.Text);
                GlobalConfig.Connection.InertPayee(BP);

                MessageBox.Show("Payee Added successfully to the Account......!");
                txtPAccount.Text = "";
                txtPName.Text= "";
                txtPType.Text = "";

                txtPAccount.Focus();

            }
            else
            {
                MessageBox.Show("Invalid OR Blank Enteries");

                txtPAccount.Focus();

            }

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBillPayee frmBP = new frmBillPayee();
            frmBP.Show();
            this.Hide();
        }
    }
}
