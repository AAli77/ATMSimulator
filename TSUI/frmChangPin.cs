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
    public partial class frmChangPin : Form
    {
        public frmChangPin()
        {
            InitializeComponent();
        }

        private void frmChangPin_Load(object sender, EventArgs e)
        {
            txtAccNo.Text = frmMain._accountNo;
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private Boolean validateForm()
        {
            bool output = true;

            int _npin = 0;
            bool valid_npin = int.TryParse(txtNPIN.Text, out _npin);
            if (!valid_npin)
            {
                output = false;
            }

            int _cpin = 0;
            bool valid_cpin = int.TryParse(txtCPIN.Text, out _cpin);
            if (!valid_cpin)
            {
                output = false;
            }



            if (txtAccNo.Text.Length == 0)
            {
                output = false;
            }

            if (txtCPIN.Text.Length == 0)
            {
                output = false;
            }

            if (txtNPIN.Text.Length == 0)
            {
                output = false;
            }

            if (txtNPIN.Text != txtCPIN.Text)
            {
                output = false;
            }

            return output;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {

                cAccounts model = new cAccounts(txtAccNo.Text, txtNPIN.Text);
                GlobalConfig.Connection.ChangePin(model);

                MessageBox.Show("PIN successfully changed......!");

                this.Close();
                frmMain fmain = new frmMain();
                fmain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Entry OR Pin does not match");
                txtNPIN.Text = "";
                txtCPIN.Text = "";

                txtNPIN.Focus();
            }
        }
    }
}
