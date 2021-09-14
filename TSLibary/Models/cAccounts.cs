using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLibary.Models
{
    public class cAccounts
    {
        public int AccNo { get; set; }
        public int PIN { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string CheqAccoNo { get; set; }
        public double CheqBal { get; set; }
        public string SavAccoNo { get; set; }
        public double SavBalance { get; set; }
        public double MaxWithDrawal { get; set; }
        public double MaxTransferAmt { get; set; }

        public cAccounts()
        {

        }

        public cAccounts(string accno)
        {
            int _accno = 0;
            int.TryParse(accno, out _accno);
            AccNo = _accno;
        }

        public cAccounts(string accno, string pin)
        {
            int _accno = 0;
            int.TryParse(accno, out _accno);
            AccNo = _accno;

            int _npin = 0;
            int.TryParse(pin, out _npin);
            PIN = _npin;
        }

        public cAccounts(string accno, string pin, string fname, string lname, string caccno, 
            string cbal, string savcno, string sbal, string maxwd, string maxtr)
        {
            FName = fname;
            LName = lname;
            CheqAccoNo = caccno;
            SavAccoNo = savcno;

            int _pin = 0;
            int.TryParse(pin, out _pin);
            PIN = _pin;

            int _accno = 0;
            int.TryParse(accno, out _accno);
            AccNo = _accno;

            double _cbal = 0.00;
            double.TryParse(cbal, out _cbal);
            CheqBal = _cbal;

            double _sbal = 0.00;
            double.TryParse(sbal, out _sbal);
            SavBalance = _sbal;

            double _maxwd = 0.00;
            double.TryParse(maxwd, out _maxwd);
            MaxWithDrawal = _maxwd;

            double _maxtr = 0.00;
            double.TryParse(maxtr, out _maxtr);
            MaxTransferAmt = _maxtr;
        }


        public void withdraw(double amt)
        {
            Console.WriteLine(0);
        }

        public void deposit(double amt)
        {
            Console.WriteLine(0);
        }

        public void transferIn(double amt)
        {
            Console.WriteLine(0);
        }

        public void transferOut(double amt)
        {
            Console.WriteLine(0);
        }

        public string FullName
        {
            get
            {
                return $"{FName} {LName}";
            }
        }
    }
}
