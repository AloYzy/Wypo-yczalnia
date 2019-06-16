using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    /// <summary>
    /// Class that represents single car rent.
    /// </summary>
    public class Rent
    {
        public Client Client { get; set; }
        public Car Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Decimal TotalCost { get; set; }

        public Rent(Client client, Car car, DateTime start, DateTime end, decimal cost)
        {
            Client = client;
            Car = car;
            StartDate = start;
            EndDate = end;
            TotalCost = cost;
        }

        public Rent()
        {
        }

        /// <summary>
        /// Saves new car rent to database.
        /// </summary>
        /// <returns>True if save succeeded, false if save failed.</returns>
        public bool CreateNewRent()
        {
            bool success = false;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO wypozyczenia ([id samochodu], [id klienta], poczatek, koniec, koszt) " +
                        $"VALUES(@carId, @clientId, @start, @end, @cost)", sqlConnection);

                command.Parameters.Add(new SqlParameter("carId", Car.GetId("Numer rejestracyjny", this.Car.LicensePlateNum)));
                command.Parameters.Add(new SqlParameter("clientId", this.Client.GetClientIdByLicenseNumber(this.Client.LicenseNumber)));
                command.Parameters.Add(new SqlParameter("start", this.StartDate));
                command.Parameters.Add(new SqlParameter("end", this.EndDate));
                command.Parameters.Add(new SqlParameter("cost", this.TotalCost));

                try
                {
                    command.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return success;
        }

        /// <summary>
        /// Reads database and serached for rent based on given car id.
        /// </summary>
        /// <param name="id">Integer that represent car id.</param>
        /// <returns>Rent objetc.</returns>
        public static Rent GetRentByCarId(int id)
        {
            Rent rent = new Rent();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                DataTable dataTable = new DataTable();
                var sqlDataAdaper = new SqlDataAdapter($"SELECT * FROM wypozyczenia WHERE [id samochodu] = '{id}'", sqlConnection);
                sqlDataAdaper.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    //rent.Car = Car.get "" + (int)Enum.Parse(typeof(EnumCategory), dataTable.Rows[0].Field<string>("Klasa"));
                    rent.Client = Client.GetClientById(dataTable.Rows[0].Field<int>("Id klienta"));
                    rent.EndDate = DateTime.Parse(dataTable.Rows[0].Field<DateTime>("Koniec").ToString());
                    rent.StartDate = DateTime.Parse(dataTable.Rows[0].Field<DateTime>("Poczatek").ToString());
                    rent.TotalCost = dataTable.Rows[0].Field<decimal>("Koszt");
                }
            }

            return rent;
        }
    }
}
