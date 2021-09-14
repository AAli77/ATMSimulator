using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLibary.Models
{
    public class cTransaction : cAccounts
    {
        public int TranID { get; set; }
        public string TranDate { get; set; }
        public int ATMID { get; set; }
        public string TranType { get; set; }
        public float TranAmount { get; set; }
        public string TranDesc { get; set; }
        public string TrAccNo { get; set; }

        public cTransaction()
        {

        }

        public cTransaction(string trid, string trdate, string atmid, string accno, string tracno, string trtype, string tramount, string trdesc)
        {
            TranDate = trdate;
            TranType = trtype;
            TrAccNo = tracno;
            TranDesc = trdesc;

            int _accno = 0;
            int.TryParse(accno, out _accno);
            AccNo = _accno;

            int _trid = 0;
            int.TryParse(trid, out _trid);
            TranID = _trid;

            int _atmid = 0;
            int.TryParse(atmid, out _atmid);
            ATMID = _atmid;

            float _tramt = 0;
            float.TryParse(tramount, out _tramt);
            TranAmount = _tramt;

        }

        //Method to display transaction
        public string DisplayTransaction
        {
            get
            {
                string _tramount = TranAmount.ToString("#,##0.00");

                string _trtypeD = "";
                _trtypeD = "Hello";
                switch (TranType)
                {
                    case "WD":
                        _trtypeD = "WithDrawal";
                        break;
                    case "BP":
                        _trtypeD = "Bill Payee";
                        break;
                    case "SC":
                        _trtypeD = "Service Charge";
                        break;
                    case "DP":
                        _trtypeD = "Deposit       ";
                        break;
                    case "TO":
                        _trtypeD = "Transfer To";
                        break;
                    case "TF":
                        _trtypeD = "Transfer From";
                        break;
                    default:
                        _trtypeD = "Other        ";
                        break;
                }

                return $"{TranDate},\t{TrAccNo},\t{_trtypeD},\t{_tramount},\t\t{TranDesc}";
            }
        }

    }
}
