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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        int _start = 0;
        int _counter = 0;
        int _strlen = 0;
        string _strtxt = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            _strtxt = lblLoading.Text;
            _strlen = lblLoading.Text.Length;
            lblLoading.Text = "";
            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            _start += 1;
            _counter++;
            pbLoading.Value = _start;
            lblPBPer.Text = _start.ToString()+" %";
            lblLoading.Text = _strtxt.Substring(0, _counter);

            if (_strlen == lblLoading.Text.Length)
            {
                lblLoading.Text = "";
                _counter = 0;
            }

            if (pbLoading.Value == 100)
            {
                pbLoading.Value = 0;
                timer1.Stop();
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
