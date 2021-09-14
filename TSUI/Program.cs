using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSLibary.Models;

namespace TSUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize Database connection
            TSLibary.GlobalConfig.InitializeConnection(DatabaseType.Sql);

            //Statup Form
            Application.Run(new frmSplash());


        }
    }
}
