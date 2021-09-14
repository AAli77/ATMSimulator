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
    public partial class Form1 : Form
    {
        //private List<cAccounts> activeAccount = new List<cAccounts>();
        private List<cAccounts> activeAccount = GlobalConfig.Connection.GetAccounts();

        public Form1()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUplist();
        }

        //private void LoadListData()
        //{
        //    GlobalConfig.Connection.GetAccounts();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateSampleData()
        {
            activeAccount.Add(new cAccounts { FName = "Amir", LName = "Ali" });
            activeAccount.Add(new cAccounts { FName = "Sara", LName = "Ali" });
            activeAccount.Add(new cAccounts { FName = "Aafi", LName = "Ali" });
            activeAccount.Add(new cAccounts { FName = "Anwar", LName = "Ali" });
        }

        private void WireUplist()
        {
            comboBox1.DataSource = activeAccount;
            comboBox1.DisplayMember = "FullName";

        }
    }
}
