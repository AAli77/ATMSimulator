using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLibary.Models
{
    public class cLogin
    {
        public int LoginID { get; set; }
        public int PIN { get; set; }
        public string LoginType { get; set; }
        public string LoginStat { get; set; }
        public string fndLogin { get; set; }

        public cLogin()
        {

        }

        public cLogin(string loginid, string pin, string ltype, string lstat, string flogin)
        {
            int _pin = 0;
            int.TryParse(pin, out _pin);
            PIN = _pin;

            int _loginid = 0;
            int.TryParse(loginid, out _loginid);
            LoginID = _loginid;

            LoginType = ltype;
            LoginStat = lstat;
            fndLogin = flogin;

        }

    }



}
