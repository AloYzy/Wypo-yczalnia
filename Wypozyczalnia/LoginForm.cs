using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Presenters;
using Wypozyczalnia.Views;

namespace Wypozyczalnia
{
    public partial class LoginForm : Form, ILogin
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string LoginText
        {
            get
            {
                return loginTextBox.Text;
            }
            set
            {
                loginTextBox.Text = value;
            }
        }

        public string PasswordText
        {
            get
            {
                return passwordTextBox.Text;
            }
            set
            {
                passwordTextBox.Text = value;
            }
        }

        public bool LogedIn { get; set; }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);
            presenter.LogIn();

            if (LogedIn)
            {
                this.Close();
            }
        }
    }
}
