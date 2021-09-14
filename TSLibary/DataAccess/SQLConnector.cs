using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLibary.Models;

//@AccNo numeric(8,0),
//@PIN numeric(4,0),
//@FName nvarchar(50),
//@LName nvarchar(50),
//@CheqAccNo nvarchar(50),
//@CheqAccBal money,
//@SavAccNo  nvarchar(50),
//@SavAccBal money,
//@MaxWD money,
//@MaxTransfer money,
//@id int = 0 output

namespace TSLibary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        public cDailyBalances GetAccBal(cDailyBalances model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                try
                {
                    var bal = new DynamicParameters();
                    bal.Add("@AccNo", model.AccNo);
                    bal.Add("@TrAccNo", model.TrAcc);
                    bal.Add("@Balance", 0, dbType: DbType.Double, direction: ParameterDirection.Output);
                    connection.Execute("spGetAccBal", bal, commandType: CommandType.StoredProcedure);

                    model.Balance = bal.Get<double>("@Balance");

                    return model;

                }
                catch (Exception e)
                {
                    model.Balance = 0;
                    return model;
                }
                finally
                {

                }
            }
        }

        public cATM AddBalance(cATM model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var atm = new DynamicParameters();
                atm.Add("@ATMid", model.ATMid);
                atm.Add("@ddate", model.DepoDate);
                atm.Add("@ddepo", model.DepoAmount);
                atm.Add("@dbal", model.DepoBalance);
                connection.Execute("spATM_Insert", atm, commandType: CommandType.StoredProcedure);
                return model;
            }
        }

        public cATM GetBalance(cATM model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var a = new DynamicParameters();
                a.Add("@ATMid", model.ATMid);
                a.Add("@ddate", model.DepoDate);
                a.Add("@ddepo", 0, dbType: DbType.Double, direction: ParameterDirection.Output);
                a.Add("@dbal", 0, dbType: DbType.Double, direction: ParameterDirection.Output);
                a.Add("@fnd", 0, dbType: DbType.String, direction: ParameterDirection.Output);

                connection.Execute("sp_getATMBal", a, commandType: CommandType.StoredProcedure);
                //model.LoginType = l.Get<string>("@LType");
                model.DepoAmount = a.Get<double>("@ddepo");
                model.DepoBalance = a.Get<double>("@dbal");
                model.fndRec = a.Get<string>("@fnd");

                return model;
            }
        }

        public cAccounts ChangePin(cAccounts model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var a = new DynamicParameters();
                a.Add("@AcNo", model.AccNo);
                a.Add("@Pin", model.PIN);

                connection.Execute("dbo.spUpdatePin", a, commandType: CommandType.StoredProcedure);
            }
            return model;
        }

        public cAccounts CreateAcc(cAccounts model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                // Adding Account Information
                var p = new DynamicParameters();
                p.Add("@AccNo", model.AccNo);
                p.Add("@PIN", model.PIN);
                p.Add("@FName", model.FName);
                p.Add("@LName", model.LName);
                p.Add("@CheqAccNo", model.CheqAccoNo);
                p.Add("@CheqAccBal", model.CheqBal);
                p.Add("@SavAccNo", model.SavAccoNo);
                p.Add("@SavAccBal", model.SavBalance);
                p.Add("@MaxWD", model.MaxWithDrawal);
                p.Add("@MaxTransfer", model.MaxTransferAmt);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spAccount_Insert", p, commandType: CommandType.StoredProcedure);

                // Adding Account Login Information
                var l = new DynamicParameters();
                l.Add("@LoginID", model.AccNo);
                l.Add("@LoginPIN", model.PIN);
                connection.Execute("spLogin_Insert", l, commandType: CommandType.StoredProcedure);

                // Adding Transaction of a Deposit, when open a Account
                DateTime _curDate = DateTime.Now;
                string _trDesc = "Account Opening - Deposit";

                var dep = new DynamicParameters();
                dep.Add("@TranDate", _curDate.ToShortDateString());
                dep.Add("@AccNo", model.AccNo);
                dep.Add("@TrAccount", model.CheqAccoNo);
                dep.Add("@TranAmount", model.CheqBal);
                dep.Add("@TranDesc", _trDesc);
                dep.Add("@TranID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("sp_TranDeposit_Insert", dep, commandType: CommandType.StoredProcedure);
                //_tranid = p.Get<int>("@_tranid");
                return model;
            }

        }

        public cTransaction InsertTran(cTransaction model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var tran = new DynamicParameters();
                tran.Add("@TranDate", model.TranDate);
                tran.Add("@ATMID", model.ATMID);
                tran.Add("@AccNo", model.AccNo);
                tran.Add("@TrAccount", model.TrAccNo);
                tran.Add("@TrType", model.TranType);
                tran.Add("@TranAmount", model.TranAmount);
                tran.Add("@TranDesc", model.TranDesc);
                tran.Add("@TranID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("sp_TranInsert", tran, commandType: CommandType.StoredProcedure);
                return model;
            }

        }


        public cLogin GetLogin(cLogin model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var l = new DynamicParameters();
                l.Add("@LID", model.LoginID);
                l.Add("@LPIN", model.PIN);
                l.Add("@LType", 0, dbType: DbType.String, direction: ParameterDirection.Output);
                l.Add("@LStat", 0, dbType: DbType.String, direction: ParameterDirection.Output);
                l.Add("@LFnd", 0, dbType: DbType.String, direction: ParameterDirection.Output);

                connection.Execute("sp_getLogin", l, commandType: CommandType.StoredProcedure);

                model.LoginType = l.Get<string>("@LType");
                model.LoginStat = l.Get<string>("@LStat");
                model.fndLogin = l.Get<string>("@LFnd");

                return model;

            }
        }

        public cAccounts getAccInfo(cAccounts model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var acc = new DynamicParameters();
                //string _fName, _lName;
                acc.Add("@AccNo", model.AccNo);
                acc.Add("@FName", dbType: DbType.String, direction: ParameterDirection.Output, size:5215585);
                acc.Add("@LName", dbType: DbType.String, direction: ParameterDirection.Output, size:5215585);
                connection.Execute("sp_AccInfo", acc, commandType: CommandType.StoredProcedure);
                model.FName = acc.Get<string>("@FName");
                model.LName = acc.Get<string>("@LName");

                return model;
            }

        }


        public cBillPayee InertPayee(cBillPayee model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var p = new DynamicParameters();
                p.Add("@AccNo", model.AccNo);
                p.Add("@BPName", model.BPName);
                p.Add("@BPType", model.BPType);
                p.Add("@BPAcc", model.BPAccNo);
                connection.Execute("spBillPayee_Insert", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }

        public List<cBillPayee> GetBillP_Acc(int accno)
        {
            List<cBillPayee> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var p = new DynamicParameters();
                p.Add("@AccNo", accno);

                output = connection.Query<cBillPayee>("dbo.spGetBPAcc", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<cAccounts> GetAccounts()
        {
            List<cAccounts> output;
            int _accno = 10011234;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var p = new DynamicParameters();
                p.Add("@AccNo", _accno);
                output = connection.Query<cAccounts>("dbo.spGetAllAcc", p, commandType: CommandType.StoredProcedure).ToList();

            }
            return output;
        }

        public List<cTransaction> dispTransaction(int accno, string tracc, int pdays)
        {
            List<cTransaction> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ATM")))
            {
                var d = new DynamicParameters();
                d.Add("@AcNo", accno);
                d.Add("@TrAc", tracc);
                d.Add("@pDays", pdays);

                output = connection.Query<cTransaction>("dbo.sp_AcBalance", d, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

    }
}
