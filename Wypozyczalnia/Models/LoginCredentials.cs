using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    /// <summary>
    /// Class that represent user login and password.
    /// </summary>
    public class LoginCredentials
    {
        public string Login { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Reads database and verify if exists user with given login and password.
        /// </summary>
        /// <returns>True if exists user with given login and password, false if user with given login and password does not exist in database.</returns>
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
