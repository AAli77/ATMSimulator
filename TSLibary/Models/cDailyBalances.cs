using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLibary.Models
{
    public class cDailyBalances : cAccounts
    {
        public double Balance { get; set; }
        public string TrAcc { get; set; }

        public cDailyBalances(string accno, string traccno, string bal)
        {
            int _accno = 0;
            int.TryParse(accno, out _accno);
            AccNo = _accno;

            double _bal = 0;
            double.TryParse(bal, out _bal);
            Balance = _bal;

            TrAcc = traccno;
        }
    }
}
