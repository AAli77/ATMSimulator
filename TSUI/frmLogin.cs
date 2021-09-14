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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                cLogin model = new cLogin(
                    txtAccount.Text, 
                    txtPIN.Text,
                    "","","");

                GlobalConfig.Connection.GetLogin(model);

                if (model.fndLogin == "1") //Member Found
                {
                    if (model.LoginStat == "A") //Login Status Active
                    {
                        if (model.LoginType == "M") //Member Login
                        {
                            int accno = 0;
                            int.TryParse(txtAccount.Text, out accno);
                            frmMain._acc = accno;

                            frmMain._accountNo = txtAccount.Text;
                            frmMain fmenu = new frmMain();
                            fmenu.Show();
                            this.Hide();
                        }
                        else if(model.LoginType == "S") //supervisor Login
                        {
                            frmSupervisor fsuper = new frmSupervisor();
                            fsuper.Show();
                            this.Hide();

                        }
                    }
                    else if(model.LoginStat == "N") //Login Status Not Active
                    {
                        MessageBox.Show("Member Not Active"); 
                    }
                }
                else if(model.fndLogin=="0") //No MemberFound
                {
                    MessageBox.Show("Member Not Found");
                }
                txtAccount.Text = "";
                txtPIN.Text = "";
                

            }
            else
            {
                MessageBox.Show("Invalid Entry");

                txtAccount.Text = "";
                txtPIN.Text = "";
                
            }
        }

        private bool validateForm()
        {
            bool output = true;
            int accno = 0;
            bool accno_valid = int.TryParse(txtAccount.Text, out accno);
            if (!accno_valid)
            {
                output = false;
            }
            if(accno < 1)
            {
                output = false;
            }

            if(txtAccount.Text.Length == 0)
            {
                output = false;
            }

            if(txtPIN.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
