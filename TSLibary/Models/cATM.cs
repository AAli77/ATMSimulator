using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLibary.Models
{
    public class cATM
    {
        public int ATMid { get; set; }
        public string DepoDate { get; set; }
        public double DepoAmount { get; set; }
        public double DepoBalance { get; set; }
        public string fndRec { get; set; }

        public cATM()
        {

        }

        public cATM(string atmid, string ddate, string damount, string dbalance, string frec)
        {
            int _atmid = 0;
            int.TryParse(atmid, out _atmid);
            ATMid = _atmid;

            double _damount = 0;
            double.TryParse(damount, out _damount);
            DepoAmount = _damount;

            double _dbal = 0;
            double.TryParse(damount, out _dbal);
            DepoBalance = _dbal;

            DepoDate = ddate;
            fndRec = frec;

        }
    }
}
