using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia
{
    class Helpers
    {
        public const string connectionString = "Data source=DESKTOP-ESRM8PV;database=Wypozyczalnia;User id = admin;Password=admin;";

        public static Dictionary<Boolean, string> ValidateVINNumber(string VIN)
        {
            Dictionary<Boolean, string> validationResult = new Dictionary<bool, string>();
            Boolean valid = true;
            string errorMsg = "";

            if (VIN.Trim().Length != 17)
            {
                valid = false;
                errorMsg += $"Wprowadzony numer VIN samochodu jest nieprawiłowy! ({VIN.Trim().Length} znaków zamiast 17)\n";
            }
            else if (VIN.Contains("I") || VIN.Contains("O") || VIN.Contains("Q"))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer VIN samochodu jest nieprawiłowy! (Numer VIN nie może zawierać liter I, O i Q!\n";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        public static Dictionary<Boolean, string> ValidateLicensePlatenumber(string licPlateNum)
        {
            Dictionary<Boolean, string> validationResult = new Dictionary<bool, string>();
            Boolean valid = true;
            string errorMsg = "";

            if (licPlateNum.Trim().Length != 7)
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu jest nieprawiłowy! ({licPlateNum.Trim().Length} znaków zamiast 7)";
            }
            else if (!Char.IsLetter(licPlateNum.ToCharArray()[0]) || !Char.IsLetter(licPlateNum.ToCharArray()[1]))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu jest nieprawiłowy! (Co najmniej 2 pierwsze znaki muszą być literami)";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        public static Boolean IsVINPresent(string VIN)
        {
            Boolean exists = false;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

                SqlCommand query = sqlConnection.CreateCommand();
                query.CommandText = $"select * from samochody where VIN = '{VIN}'";
                SqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    exists = true;
                }
            }

            return exists;
        }

        public static Boolean IsLicensePlateNumberPresent(string licPlateNum)
        {
            Boolean exists = false;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

                SqlCommand query = sqlConnection.CreateCommand();
                query.CommandText = $"select * from samochody where [Numer rejestracyjny] = '{licPlateNum}'";
                SqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    exists = true;
                }
            }

            return exists;
        }
    }
}
