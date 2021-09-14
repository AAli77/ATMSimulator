using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLibary.Models
{
    public class cBillPayee : cAccounts
    {
        public string BPAccNo { get; set; }
        public string BPName { get; set; }
        public string BPType { get; set; }

        public cBillPayee()
        {

        }

        public cBillPayee(string accno, string bpname, string bptype, string bpacc)
        {
            BPName = bpname;
            BPType = bptype;
            BPAccNo = bpacc;

            int _accno = 0;
            int.TryParse(accno, out _accno);
            AccNo = _accno;
        }

        public cBillPayee(string accno)
        {
            int _accno = 0;
            int.TryParse(accno, out _accno);
            AccNo = _accno;
        }

        public string BPayeeFullName
        {
            get
            {
                return $"{BPAccNo} - {BPName}";
            }
        }


    }
}
