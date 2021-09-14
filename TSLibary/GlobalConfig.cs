using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLibary.DataAccess;
using TSLibary.Models;

namespace TSLibary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //todo : Create DB Connections
                SQLConnector sql = new SQLConnector();
                Connection=sql;
            }

            //else if (db == DatabaseType.textFile)
            //{
            //    //TODO : Create a Text Connections
            //    TextConnector text = new TextConnector();
            //    Connection = text;
            //}
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
