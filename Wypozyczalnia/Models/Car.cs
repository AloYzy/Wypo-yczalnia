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
    /// Enum that contains all possible categories of cars.
    /// </summary>
    public enum EnumCategory
    {
        Hatchback,
        Kombi,
        Sedan,
        Suv
    }

    /// <summary>
    /// Enum that contains all possible drive types. 
    /// </summary>
    public enum EnumDriveType
    {
        AllDrive,
        Przedni,
        Tylny
    }

    /// <summary>
    /// Enum that contains all possible engine types.
    /// </summary>
    public enum EnumEngineType
    {
        Benzynowy,
        Diesel,
        Hybrydowy
    }

    /// <summary>
    /// Enum that contains all possible gearbox types.
    /// </summary>
    public enum EnumGearboxType
    {
        Automatyczna,
        Manualna
    }

    /// <summary>
    /// Enum that contains all possible statuses of car.
    /// </summary>
    public enum EnumStatus
    {
        Dostępny,
        Usunięty,
        Wypożyczony
    }

    /// <summary>
    /// Class that represents single car.
    /// </summary>
    public class Car
    {
        public string Category { get; set; }
        public string Cost { get; set; }
        public string DriveType { get; set; }
        public string Engine { get; set; }
        public string Gearbox { get; set; }
        public string Id { get; set; }
        public string LicensePlateNum { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Status { get; set; }
        public string VIN { get; set; }

        /// <summary>
        /// Prepare data for comboBox controls used in some forms (like MainWindowForm and AddNewCarForm).
        /// </summary>
        /// <returns>Dictionary with all possible values for each comboBox control.</returns>
        public static Dictionary<string, string[]> FillComboBoxes()
        {
            Dictionary<string, string[]> comboBoxes = new Dictionary<string, string[]>();
            List<string> categoryComboBoxValues = new List<string>();
            List<string> driveTypeComboBoxValues = new List<string>();
            List<string> engineTypeComboBoxValues = new List<string>();
            List<string> gearboxComboBoxValues = new List<string>();

            foreach (EnumCategory e in Enum.GetValues(typeof(EnumCategory)).Cast<EnumCategory>())
            {
                categoryComboBoxValues.Add(e.ToString());
            }
            foreach (EnumDriveType e in Enum.GetValues(typeof(EnumDriveType)).Cast<EnumDriveType>())
            {
                driveTypeComboBoxValues.Add(e.ToString());
            }
            foreach (EnumEngineType e in Enum.GetValues(typeof(EnumEngineType)).Cast<EnumEngineType>())
            {
                engineTypeComboBoxValues.Add(e.ToString());
            }
            foreach (EnumGearboxType e in Enum.GetValues(typeof(EnumGearboxType)).Cast<EnumGearboxType>())
            {
                gearboxComboBoxValues.Add(e.ToString());
            }

            comboBoxes.Add("category", categoryComboBoxValues.ToArray());
            comboBoxes.Add("driveType", driveTypeComboBoxValues.ToArray());
            comboBoxes.Add("engine", engineTypeComboBoxValues.ToArray());
            comboBoxes.Add("gearbox", gearboxComboBoxValues.ToArray());

            return comboBoxes;
        }

        public Car()
        {
            Category = "-1";
            Cost = string.Empty;
            DriveType = "-1";
            Engine = "-1";
            Gearbox = "-1";
            LicensePlateNum = string.Empty;
            Manufacturer = string.Empty;
            Model = string.Empty;
            ProductionDate = DateTime.Now;
            VIN = string.Empty;
        }

        /// <summary>
        /// Reads database and return id of car based on provided params.
        /// </summary>
        /// <param name="columnName">String that represents column name in database.</param>
        /// <param name="columnValue">String that represents column value in database.</param>
        /// <returns>Id of car.</returns>
        public int GetId(string columnName, string columnValue)
        {
            int id = -1;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand subQuery = new SqlCommand($"SELECT Id FROM samochody where [{columnName}] = '{columnValue}'", sqlConnection);
                try
                {
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(subQuery);
                    DataTable dataTable = new DataTable();
                    sqlAdapter.Fill(dataTable);
                    id = (int)dataTable.Rows[0]["Id"];
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return id;
        }

        /// <summary>
        /// Reads database and return status of car based on provided params.
        /// </summary>
        /// <param name="columnName">String that represents column name in database.</param>
        /// <param name="columnValue">String that represents column value in database.</param>
        /// <returns>Status of car.</returns>
        public static string GetStatus(string columnName, string columnValue)
        {
            string status = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand subQuery = new SqlCommand($"SELECT Status FROM samochody where [{columnName}] = '{columnValue}'", sqlConnection);
                try
                {
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(subQuery);
                    DataTable dataTable = new DataTable();
                    sqlAdapter.Fill(dataTable);
                    status = dataTable.Rows[0]["Status"].ToString();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return status;
        }

        /// <summary>
        /// Updates car data in database.
        /// </summary>
        /// <param name="id">Integer that represents id of car.</param>
        /// <returns>True if update succeeded, false if update failed.</returns>
        public bool UpdateCar(int id)
        {
            bool success = false;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand($"UPDATE samochody SET Klasa = @category, " +
                                                                        $"Marka = @manufacturer, " +
                                                                        $"Model = @model, " +
                                                                        $"[Rok produkcji] = @date, " +
                                                                        $"[Rodzaj napędu] = @driveType, " +
                                                                        $"[Skrzynia biegów] = @gearbox, " +
                                                                        $"Silnik = @engine, " +
                                                                        $"[Koszt wynajęcia] = @cost, " +
                                                                        $"VIN = @vin, " +
                                                                        $"[Numer rejestracyjny] = @licensePlateNum " +
                                                                        $"WHERE Id = @id", sqlConnection);

                command.Parameters.Add(new SqlParameter("category", Category));
                command.Parameters.Add(new SqlParameter("manufacturer", Manufacturer));
                command.Parameters.Add(new SqlParameter("model", Model));
                command.Parameters.Add(new SqlParameter("date", ProductionDate.ToString("yyyy-MM-dd")));
                command.Parameters.Add(new SqlParameter("driveType", DriveType));
                command.Parameters.Add(new SqlParameter("gearbox", Gearbox));
                command.Parameters.Add(new SqlParameter("engine", Engine));
                command.Parameters.Add(new SqlParameter("cost", SqlDbType.Decimal)
                {
                    Precision = 18,
                    Scale = 2
                }).Value = Cost;
                command.Parameters.Add(new SqlParameter("vin", VIN));
                command.Parameters.Add(new SqlParameter("licensePlateNum", LicensePlateNum));
                command.Parameters.Add(new SqlParameter("id", id));

                try
                {
                    command.ExecuteNonQuery();
                    success = true;
                }
                catch (Exception exp)
                {

                    throw;
                }
            }

            return success;
        }

        /// <summary>
        /// Change car status in database as "rent".
        /// </summary>
        /// <param name="car">Car object.</param>
        public void SetStatusAsRent(Car car)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand($"UPDATE samochody SET status = @status WHERE [numer rejestracyjny] = @licenseNumberPlate", sqlConnection);

                command.Parameters.Add(new SqlParameter("status", EnumStatus.Wypożyczony.ToString()));
                command.Parameters.Add(new SqlParameter("licenseNumberPlate", car.LicensePlateNum));
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Change car status in database as "available".
        /// </summary>
        /// <param name="licensePlateNumber">String that represent license plate number of car.</param>
        public static void SetStatusAsAvailable(string licensePlateNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand($"UPDATE samochody SET status = @status WHERE [numer rejestracyjny] = @licenseNumberPlate", sqlConnection);

                command.Parameters.Add(new SqlParameter("status", EnumStatus.Dostępny.ToString()));
                command.Parameters.Add(new SqlParameter("licenseNumberPlate", licensePlateNumber));
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Change car status in database as "deleted".
        /// </summary>
        /// <param name="columnName">String that represents column name in database.</param>
        /// <param name="columnValue">String that represents column value in database.</param>
        public static void SetStatusAsDeleted(string columnName, string columnValue)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand($"UPDATE samochody SET status = @status WHERE [{columnName}] = @columnValue", sqlConnection);

                command.Parameters.Add(new SqlParameter("status", EnumStatus.Usunięty.ToString()));
                command.Parameters.Add(new SqlParameter("columnValue", columnValue));
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Reads database and searches for available cars based on given criteria.
        /// </summary>
        /// <param name="categoryCriteria">String that represents criteria that car must fulfil.</param>
        /// <param name="manufacturerCriteria">String that represents criteria that car must fulfil.</param>
        /// <param name="modelCriteria">String that represents criteria that car must fulfil.</param>
        /// <param name="driveTypeCriteria">String that represents criteria that car must fulfil.</param>
        /// <param name="engineCriteria">String that represents criteria that car must fulfil.</param>
        /// <param name="productionDateFrom">DateTime that represents the oldest possible production date of the car.</param>
        /// <param name="productionDateTo">DateTime that represents the youngest possible production date of the car.</param>
        /// <param name="costFromCriteria">Decimal that represents the cheapest possible car.</param>
        /// <param name="costToCriteria">Decimal that represents the most expensive possible car.</param>
        /// <param name="gearboxText">String that represents criteria that car must fulfil.</param>
        /// <returns>DataTable with all cars that filfilled given criteria.</returns>
        public static DataTable SearchAvailableCarsByCriteria(string categoryCriteria, string manufacturerCriteria, string modelCriteria, string driveTypeCriteria, string engineCriteria, DateTime productionDateFrom, DateTime productionDateTo, decimal costFromCriteria, decimal costToCriteria, string gearboxText)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                var sqlDataAdaper = new SqlDataAdapter($"SELECT * FROM samochody WHERE " +
                    $"klasa in ({categoryCriteria}) AND marka in ({manufacturerCriteria}) AND model in ({modelCriteria}) AND [rodzaj napędu] in ({driveTypeCriteria}) " +
                    $"AND silnik in ({engineCriteria}) AND ([rok produkcji] >= '{productionDateFrom}' AND [rok produkcji] <= '{productionDateTo}' AND ([koszt wynajęcia] BETWEEN {costFromCriteria.ToString().Replace(',', '.')} AND {costToCriteria.ToString().Replace(',', '.')}) AND [skrzynia biegów] in {gearboxText}) AND status = '{EnumStatus.Dostępny.ToString()}' ORDER BY id ASC", sqlConnection);
                sqlDataAdaper.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Reads database and searches the most expensive car.
        /// </summary>
        /// <returns>Decimal that represents the most expensive car.</returns>
        public static decimal getMaxCost()
        {

            decimal maxCost = decimal.MaxValue;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                DataTable dataTable = new DataTable();
                var sqlDataAdaper = new SqlDataAdapter($"SELECT TOP 1 [koszt wynajęcia] FROM samochody ORDER BY [koszt wynajęcia] DESC", sqlConnection);
                sqlDataAdaper.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    maxCost = dataTable.Rows[0].Field<decimal>("Koszt wynajęcia");
                }
            }

            return maxCost;
        }

        /// <summary>
        /// Save new car to database.
        /// </summary>
        /// <returns>True if save succeeded, false if save failed.</returns>
        public bool AddNewCar()
        {
            bool success = false;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO samochody (klasa, marka, model, [rok produkcji], [rodzaj napędu], [skrzynia biegów], silnik, status, [koszt wynajęcia], vin, [numer rejestracyjny]) " +
                        $"VALUES(@category, @manufacturer, @model, @productionDate, @driveType, @gearbox, @engine, @status, @cost, @VIN, @licensePlateNum)", sqlConnection);

                command.Parameters.Add(new SqlParameter("category", Category));
                command.Parameters.Add(new SqlParameter("manufacturer", Manufacturer.ToUpper()));
                command.Parameters.Add(new SqlParameter("model", Model.ToUpper()));
                command.Parameters.Add(new SqlParameter("productionDate", ProductionDate.ToString("yyyy-MM-dd")));
                command.Parameters.Add(new SqlParameter("driveType", DriveType));
                command.Parameters.Add(new SqlParameter("gearbox", Gearbox));
                command.Parameters.Add(new SqlParameter("engine", Engine));
                command.Parameters.Add(new SqlParameter("status", EnumStatus.Dostępny.ToString()));
                command.Parameters.Add(new SqlParameter("cost", Cost));
                command.Parameters.Add(new SqlParameter("VIN", VIN.ToUpper()));
                command.Parameters.Add(new SqlParameter("licensePlateNum", LicensePlateNum.ToUpper()));

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
        /// Reads database and searches car based on given license plate number.
        /// </summary>
        /// <param name="licensePlateNum">String that represents license plate number.</param>
        /// <returns>Car object.</returns>
        public static Car GetCarByLicensePlateNum(string licensePlateNum)
        {
            Car car = new Car();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                DataTable dataTable = new DataTable();
                var sqlDataAdaper = new SqlDataAdapter($"SELECT * FROM samochody WHERE [Numer rejestracyjny] = '{licensePlateNum}'", sqlConnection);
                sqlDataAdaper.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    car.Category = "" + (int)Enum.Parse(typeof(EnumCategory), dataTable.Rows[0].Field<string>("Klasa"));
                    car.Cost = dataTable.Rows[0].Field<decimal>("Koszt wynajęcia").ToString();
                    car.DriveType = "" + (int)Enum.Parse(typeof(EnumDriveType), dataTable.Rows[0].Field<string>("Rodzaj napędu"));
                    car.Engine = "" + (int)Enum.Parse(typeof(EnumEngineType), dataTable.Rows[0].Field<string>("Silnik"));
                    car.Gearbox = "" + (int)Enum.Parse(typeof(EnumGearboxType), dataTable.Rows[0].Field<string>("Skrzynia biegów"));
                    car.LicensePlateNum = dataTable.Rows[0].Field<string>("Numer rejestracyjny");
                    car.Manufacturer = dataTable.Rows[0].Field<string>("Marka");
                    car.Model = dataTable.Rows[0].Field<string>("Model");
                    car.ProductionDate = DateTime.Parse(dataTable.Rows[0].Field<DateTime>("Rok produkcji").ToString());
                    car.VIN = dataTable.Rows[0].Field<string>("VIN");
                    car.Status = dataTable.Rows[0].Field<string>("Status");
                }
            }

            return car;
        }

        /// <summary>
        /// Reads database and searches car based on given VIN number.
        /// </summary>
        /// <param name="VIN">String that represents VIN number.</param>
        /// <returns>Car object.</returns>
        public static Car GetCarByVIN(string VIN)
        {
            Car car = new Car();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                DataTable dataTable = new DataTable();
                var sqlDataAdaper = new SqlDataAdapter($"SELECT * FROM samochody WHERE [VIN] = '{VIN}'", sqlConnection);
                sqlDataAdaper.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    car.Category = "" + (int)Enum.Parse(typeof(EnumCategory), dataTable.Rows[0].Field<string>("Klasa"));
                    car.Cost = dataTable.Rows[0].Field<decimal>("Koszt wynajęcia").ToString();
                    car.DriveType = "" + (int)Enum.Parse(typeof(EnumDriveType), dataTable.Rows[0].Field<string>("Rodzaj napędu"));
                    car.Engine = "" + (int)Enum.Parse(typeof(EnumEngineType), dataTable.Rows[0].Field<string>("Silnik"));
                    car.Gearbox = "" + (int)Enum.Parse(typeof(EnumGearboxType), dataTable.Rows[0].Field<string>("Skrzynia biegów"));
                    car.LicensePlateNum = dataTable.Rows[0].Field<string>("Numer rejestracyjny");
                    car.Manufacturer = dataTable.Rows[0].Field<string>("Marka");
                    car.Model = dataTable.Rows[0].Field<string>("Model");
                    car.ProductionDate = DateTime.Parse(dataTable.Rows[0].Field<DateTime>("Rok produkcji").ToString());
                    car.VIN = dataTable.Rows[0].Field<string>("VIN");
                    car.Status = dataTable.Rows[0].Field<string>("Status");
                }
            }

            return car;
        }

        /// <summary>
        /// Validates if car data are correct.
        /// </summary>
        /// <returns>Dictionary with key = ture if data are correct, key = false if data are incorrect.</returns>
        public Dictionary<bool, string> ValidateCar()
        {
            bool valid = true;
            string errorMsg = string.Empty;
            Dictionary<bool, string> validationResult = new Dictionary<bool, string>();

            if (String.IsNullOrWhiteSpace(Category))
            {
                valid = false;
                errorMsg += "Klasa samochodu nie może zostać pusta!\n";
            }

            if (String.IsNullOrWhiteSpace(Manufacturer))
            {
                valid = false;
                errorMsg += "Marka samochodu nie może zostać pusta!\n";
            }

            if (String.IsNullOrWhiteSpace(Model))
            {
                valid = false;
                errorMsg += "Model samochodu nie może zostać pusty!\n";
            }

            if (String.IsNullOrWhiteSpace(DriveType))
            {
                valid = false;
                errorMsg += "Rodzaj napędu nie może zostać pusty!\n";
            }

            if (String.IsNullOrWhiteSpace(Gearbox))
            {
                valid = false;
                errorMsg += "Skrzynia biegów nie może zostać pusta!\n";
            }

            if (ProductionDate == null)
            {
                valid = false;
                errorMsg += "Data produkcji nie może zostać pusta!\n";
            }
            else if (ProductionDate >= DateTime.Now)
            {
                valid = false;
                errorMsg += "Data produkcji nie może być większa niż obecna!\n";
            }

            if (String.IsNullOrWhiteSpace(Engine))
            {
                valid = false;
                errorMsg += "Silnik nie może zostać pusty!\n";
            }

            decimal cost;
            if (String.IsNullOrEmpty(Cost))
            {
                valid = false;
                errorMsg += "Koszt wynajęcia samochodu nie może zostać pusty!\n";
            }
            else if (!decimal.TryParse(Cost, out cost))
            {
                valid = false;
                errorMsg += "Podany koszt wynajęcia samochodu jest nieprawidłowy!\n";
            }
            else if (cost <= 0)
            {
                valid = false;
                errorMsg += "Koszt wynajęcia samochodu nie może być mniejszy lub równy 0!\n";
            }

            if (ValidateVINNumber().Keys.Contains(false))
            {
                valid = false;
                errorMsg += ValidateVINNumber()[false];
            }
            else if (IsVINPresent())
            {
                valid = false;
                errorMsg += $"Wprowadzony numer VIN już istnieje w bazie!";
            }

            if (ValidateLicensePlatenumber().Keys.Contains(false))
            {
                valid = false;
                errorMsg += ValidateLicensePlatenumber()[false];
            }
            else if (IsLicensePlateNumberPresent())
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu już istnieje w bazie!";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        /// <summary>
        /// Validates if car data are correct.
        /// </summary>
        /// <returns>Dictionary with key = ture if data are correct, key = false if data are incorrect.</returns>
        public Dictionary<bool, string> SimpleValidateCar()
        {
            bool valid = true;
            string errorMsg = string.Empty;
            Dictionary<bool, string> validationResult = new Dictionary<bool, string>();

            if (String.IsNullOrWhiteSpace(Category))
            {
                valid = false;
                errorMsg += "Klasa samochodu nie może zostać pusta!\n";
            }

            if (String.IsNullOrWhiteSpace(Manufacturer))
            {
                valid = false;
                errorMsg += "Marka samochodu nie może zostać pusta!\n";
            }

            if (String.IsNullOrWhiteSpace(Model))
            {
                valid = false;
                errorMsg += "Model samochodu nie może zostać pusty!\n";
            }

            if (String.IsNullOrWhiteSpace(DriveType))
            {
                valid = false;
                errorMsg += "Rodzaj napędu nie może zostać pusty!\n";
            }

            if (String.IsNullOrWhiteSpace(Gearbox))
            {
                valid = false;
                errorMsg += "Skrzynia biegów nie może zostać pusta!\n";
            }

            if (ProductionDate == null)
            {
                valid = false;
                errorMsg += "Data produkcji nie może zostać pusta!\n";
            }
            else if (ProductionDate >= DateTime.Now)
            {
                valid = false;
                errorMsg += "Data produkcji nie może być większa niż obecna!\n";
            }

            if (String.IsNullOrWhiteSpace(Engine))
            {
                valid = false;
                errorMsg += "Silnik nie może zostać pusty!\n";
            }

            decimal cost;
            if (String.IsNullOrEmpty(Cost))
            {
                valid = false;
                errorMsg += "Koszt wynajęcia samochodu nie może zostać pusty!\n";
            }
            else if (!decimal.TryParse(Cost, out cost))
            {
                valid = false;
                errorMsg += "Podany koszt wynajęcia samochodu jest nieprawidłowy!\n";
            }
            else if (cost <= 0)
            {
                valid = false;
                errorMsg += "Koszt wynajęcia samochodu nie może być mniejszy lub równy 0!\n";
            }

            if (ValidateVINNumber().Keys.Contains(false))
            {
                valid = false;
                errorMsg += ValidateVINNumber()[false];
            }

            if (ValidateLicensePlatenumber().Keys.Contains(false))
            {
                valid = false;
                errorMsg += ValidateLicensePlatenumber()[false];
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        /// <summary>
        /// Validates if VIN number is correct.
        /// </summary>
        /// <returns>Dictionary with key = ture if VIN number is correct, key = false if VIN number is incorrect.</returns>
        public Dictionary<Boolean, string> ValidateVINNumber()
        {
            Dictionary<Boolean, string> validationResult = new Dictionary<bool, string>();
            Boolean valid = true;
            string errorMsg = "";

            if (String.IsNullOrWhiteSpace(VIN))
            {
                valid = false;
                errorMsg += "Numer VIN samochodu nie może zostać pusty!\n";
            }
            else if (VIN.Trim().Length != 17)
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

        /// <summary>
        /// Checks if VIN number is already present in database.
        /// </summary>
        /// <returns>True if VIN number is already present in database, false if VIN number is not present in database.</returns>
        public Boolean IsVINPresent()
        {
            Boolean exists = false;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand query = sqlConnection.CreateCommand();
                query.CommandText = $"SELECT * FROM samochody WHERE VIN = '{VIN}'";
                SqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    exists = true;
                }
            }

            return exists;
        }

        /// <summary>
        /// Validates if license plate number is correct.
        /// </summary>
        /// <returns>Dictionary with key = ture if license plate number is correct, key = false if license plate number is incorrect.</returns>
        public Dictionary<Boolean, string> ValidateLicensePlatenumber()
        {
            Dictionary<Boolean, string> validationResult = new Dictionary<bool, string>();
            Boolean valid = true;
            string errorMsg = "";

            if (String.IsNullOrWhiteSpace(LicensePlateNum))
            {
                valid = false;
                errorMsg += "Numer rejestracyjny samochodu nie może zostać pusty!";
            }
            else if (LicensePlateNum.Trim().Length != 7)
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu jest nieprawiłowy! ({LicensePlateNum.Trim().Length} znaków zamiast 7)";
            }
            else if (!Char.IsLetter(LicensePlateNum.ToCharArray()[0]) || !Char.IsLetter(LicensePlateNum.ToCharArray()[1]))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu jest nieprawiłowy! (Co najmniej 2 pierwsze znaki muszą być literami)";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        /// <summary>
        /// Checks if license plate number is already present in database.
        /// </summary>
        /// <returns>True if license plate number is already present in database, false if license plate number is not present in database.</returns>
        public Boolean IsLicensePlateNumberPresent()
        {
            Boolean exists = false;

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                SqlCommand query = sqlConnection.CreateCommand();
                query.CommandText = $"SELECT * FROM samochody WHERE [Numer rejestracyjny] = '{LicensePlateNum}'";
                SqlDataReader dataReader = query.ExecuteReader();
                if (dataReader.HasRows)
                {
                    exists = true;
                }
            }

            return exists;
        }

        /// <summary>
        /// Reads database and searches for all categories already present in database.
        /// </summary>
        /// <returns>DataTable that contains all categories present in database.</returns>
        public static DataTable getAllCategories()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                var sqlDataAdaper = new SqlDataAdapter($"SELECT DISTINCT klasa FROM samochody ORDER BY klasa ASC", sqlConnection);
                sqlDataAdaper.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Reads database and searches for all drive types already present in database.
        /// </summary>
        /// <returns>DataTable that contains all drive types present in database.</returns>
        public static DataTable getAllDriveTypes()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                var sqlDataAdaper = new SqlDataAdapter($"SELECT DISTINCT [Rodzaj napędu] FROM samochody ORDER BY [Rodzaj napędu] ASC", sqlConnection);
                sqlDataAdaper.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Reads database and searches for all engine types already present in database.
        /// </summary>
        /// <returns>DataTable that contains all engine types present in database.</returns>
        public static DataTable getAllEngines()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                var sqlDataAdaper = new SqlDataAdapter($"SELECT DISTINCT Silnik FROM samochody ORDER BY Silnik ASC", sqlConnection);
                sqlDataAdaper.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Reads database and searches for all manufacturers already present in database.
        /// </summary>
        /// <returns>DataTable that contains all manufacturers present in database.</returns>
        public static DataTable getAllManufacturers()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                var sqlDataAdaper = new SqlDataAdapter($"SELECT DISTINCT Marka FROM samochody ORDER BY Marka ASC", sqlConnection);
                sqlDataAdaper.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Reads database and searches for all models already present in database.
        /// </summary>
        /// <returns>DataTable that contains all models present in database.</returns>
        public static DataTable getAllModels()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                var sqlDataAdaper = new SqlDataAdapter($"SELECT DISTINCT Model FROM samochody ORDER BY Model ASC", sqlConnection);
                sqlDataAdaper.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Reads database and searches for all available cars.
        /// </summary>
        /// <returns>DataTable that contains all available cars.</returns>
        public static DataTable SearchAllAvailableCars()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                var sqlDataAdaper = new SqlDataAdapter($"SELECT * FROM samochody WHERE status = '{EnumStatus.Dostępny}'", sqlConnection);
                sqlDataAdaper.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Reads database and searches for all cars.
        /// </summary>
        /// <returns>DataTable that contains all cars.</returns>
        public static DataTable SearchAllCars()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                var sqlDataAdaper = new SqlDataAdapter($"SELECT * FROM samochody", sqlConnection);
                sqlDataAdaper.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
