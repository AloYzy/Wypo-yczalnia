using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wypozyczalnia
{
    static class Program
    {

        private static LoginForm loginForm = null;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new LoginForm();
            Application.Run(loginForm);
            if (loginForm.LogedIn)
            {
                Application.Run(new MainWindowForm());
            }
            
        }
    }
}
