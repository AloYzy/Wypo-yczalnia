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

namespace Wypozyczalnia
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = this.loginTextBox.Text;
            string password = this.passwordTextBox.Text;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-ESRM8PV;
                                                                database=Wypozyczalnia;
                                                                User id=admin;
                                                                Password=admin;");
                sqlConnection.Open();
                SqlCommand query = sqlConnection.CreateCommand();
                query.CommandText = $"select * from pracownicy where login = '{login}' and haslo = '{password}'";
                SqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    this.Hide();
                    Form mainWindow = new MainWindowForm();
                    mainWindow.ShowDialog();
                }
                else
                {
                    Console.WriteLine("Błędny login lub hasło.");
                }
                
                dataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd!");
                Console.WriteLine(exp.Message);
            }
        }
    }
}
