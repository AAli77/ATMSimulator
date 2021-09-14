using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLibary.Models;

namespace TSLibary.DataAccess
{
    public interface IDataConnection
    {
        //Accounts
        cAccounts CreateAcc(cAccounts model);
        cAccounts ChangePin(cAccounts model);
        cAccounts getAccInfo(cAccounts model);
        List<cAccounts> GetAccounts();

        //Login
        cLogin GetLogin(cLogin model);

        //ATM
        cATM AddBalance(cATM model);
        cATM GetBalance(cATM model);

        //Transaction
        cTransaction InsertTran(cTransaction model);
        cDailyBalances GetAccBal(cDailyBalances model);
        cBillPayee InertPayee(cBillPayee model);
        List<cBillPayee> GetBillP_Acc(int accno);
        List<cTransaction> dispTransaction(int accno, string tracc, int pdays);
    }
}
