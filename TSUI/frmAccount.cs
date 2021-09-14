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
using TSLibary.DataAccess;
using TSLibary.Models;


namespace TSUI
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                txtCAccNo.Text = lblAN1001.Text + txtAccNo.Text + "-0";
                txtBCheq.Text = "10000.00";
                txtSAccNo.Text = lblAN1001.Text + txtAccNo.Text + "-1";
                txtBSav.Text = "0.00";

                string _accno = lblAN1001.Text + txtAccNo.Text;

                cAccounts model = new cAccounts(
                    _accno,
                    txtPIN.Text,
                    txtFName.Text,
                    txtLName.Text,
                    txtCAccNo.Text,
                    txtBCheq.Text,
                    txtSAccNo.Text,
                    txtBSav.Text,
                    txtMWD.Text,
                    txtMTr.Text);

                GlobalConfig.Connection.CreateAcc(model);

                MessageBox.Show("Record Saved.....!");

                txtAccNo.Text = "";
                txtPIN.Text = "";
                txtFName.Text = "";
                txtLName.Text = "";
                txtCAccNo.Text = "";
                txtBCheq.Text = "";
                txtSAccNo.Text = "";
                txtBSav.Text = "";
                txtMWD.Text = "";
                txtMTr.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Entry");

                txtAccNo.Text = "";
                txtPIN.Text = "";
                txtFName.Text = "";
                txtLName.Text = "";
                txtCAccNo.Text = "";
                txtBCheq.Text = "";
                txtSAccNo.Text = "";
                txtBSav.Text = "";
                txtMWD.Text = "";
                txtMTr.Text = "";
            }
        }

        private bool validateForm()
        {
            bool output = true;

            string _accno = lblAN1001.Text + txtAccNo.Text;
            int accno = 0;
            bool accno_valid = int.TryParse(_accno, out accno);
            if (!accno_valid)
            {
                output = false;
            }
            if (_accno.ToString().Length != 8)
            {
                output = false;
            }

            int pin = 0;
            bool pin_valid = int.TryParse(txtPIN.Text, out pin);
            if (!pin_valid)
            {
                output = false;
            }

            if(txtPIN.Text.Length == 0)
            {
                output = false;
            }

            if(txtFName.Text.Length == 0)
            {
                output = false;
            }

            if (txtLName.Text.Length == 0)
            {
                output = false;
            }

            double maxwd = 0;
            bool maxwd_valid = double.TryParse(txtMWD.Text, out maxwd);
            if (!maxwd_valid)
            {
                output = false;
            }
            if (txtMWD.Text.Length == 0)
            {
                output = false;
            }

            double maxtr = 0;
            bool maxtr_valid = double.TryParse(txtMTr.Text, out maxtr);
            if (!maxtr_valid)
            {
                output = false;
            }
            if (txtMTr.Text.Length == 0)
            {
                output = false;
            }


            return output;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSupervisor fSuper = new frmSupervisor();
            fSuper.Show();
            this.Hide();
        }
    }
}
