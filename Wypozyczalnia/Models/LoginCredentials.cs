using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    public class LoginCredentials
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public bool LogInWorker()
        {
            bool logedIn = false;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand query = sqlConnection.CreateCommand();
                query.CommandText = $"SELECT * FROM pracownicy WHERE login = '{Login}' and haslo = '{Password}'";
                SqlDataReader dataReader = query.ExecuteReader();

                if (dataReader.HasRows)
                {
                    logedIn = true;
                }
            }

            return logedIn;
        }
    }
}
