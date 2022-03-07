using NewMotivationHR.DB;
using NewMotivationHR.PL;
using NewMotivationHR.PL.SalaryForms;
using NewMotivationHR.PL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMotivationHR
{
    static class Program
    {
        public static User UserNow = new User();
        public static bool LogInUser = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmLogin());
            if (LogInUser)
            {
                Application.Run(new Form1());
            }
        }
    }
    
}
