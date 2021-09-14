using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSUI
{
    public partial class frmSupervisor : Form
    {
        public frmSupervisor()
        {
            InitializeComponent();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            frmAccount frmACC = new frmAccount();
            frmACC.Show();
            this.Hide();
        }

        private void btnfillATM_Click(object sender, EventArgs e)
        {
            frmATM fATM = new frmATM();
            fATM.Show();
            this.Hide();
        }

        private void frmSupervisor_Load(object sender, EventArgs e)
        {

        }

        private void btnBLogin_Click(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();
            flogin.Show();
            this.Hide();
        }
    }
}
