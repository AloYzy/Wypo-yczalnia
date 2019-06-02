using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wypozyczalnia.Models;
using Wypozyczalnia.Views;

namespace Wypozyczalnia.Presenters
{
    public class LoginPresenter
    {
        ILogin loginView;

        public LoginPresenter(ILogin view)
        {
            loginView = view;
        }

        public void LogIn()
        {
            LoginCredentials credentials = new LoginCredentials
            {
                Login = loginView.LoginText,
                Password = loginView.PasswordText
            };

            loginView.LogedIn = credentials.LogInWorker();
        }

    }
}
