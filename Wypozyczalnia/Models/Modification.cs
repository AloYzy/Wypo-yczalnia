using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    /// <summary>
    /// Class that represent single car modification.
    /// </summary>
    public class Modification
    {
        public Car Car { get; set; }
        public string Reason { get; set; }
        public string SearchLicensePlaneNumText { get; set; }
        public string SearchVINText { get; set; }

        /// <summary>
        /// Validates if given criteria are correct.
        /// </summary>
        /// <returns>Dictionary with key = ture if criteria are correct, key = false if criteria are incorrect.</returns>
        public Dictionary<bool, string> ValidateSearchCriteria()
        {
            Dictionary<bool, string> validationResult = new Dictionary<bool, string>();
            bool valid = true;
            string errorMsg = string.Empty;
            Car car = new Car();

            if (!string.IsNullOrWhiteSpace(SearchLicensePlaneNumText))
            {
                car.LicensePlateNum = SearchLicensePlaneNumText;
                if (car.ValidateLicensePlatenumber().Keys.Contains(false))
                {
                    valid = false;
                    errorMsg += car.ValidateLicensePlatenumber()[false];
                }
                else if (!car.IsLicensePlateNumberPresent())
                {
                    valid = false;
                    errorMsg += "Podany numer rejestracyjny nie istnieje w bazie!";
                }
            }
            else if (!string.IsNullOrWhiteSpace(SearchVINText))
            {
                car.VIN = SearchVINText;
                if (car.ValidateVINNumber().Keys.Contains(false))
                {
                    valid = false;
                    errorMsg += car.ValidateVINNumber()[false];
                }
                else if (!car.IsVINPresent())
                {
                    valid = false;
                    errorMsg += "Podany numer VIN nie istnieje w bazie!";
                }
            }
            else
            {
                valid = false;
                errorMsg += "Podaj numer VIN lub numer rejestracyjny samochodu!";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        /// <summary>
        /// Reads database for data of single car.
        /// </summary>
        /// <returns>Car object.</returns>
        public Car LoadCarData()
        {
            return (!string.IsNullOrWhiteSpace(SearchLicensePlaneNumText) ? Car.GetCarByLicensePlateNum(SearchLicensePlaneNumText) : ((!string.IsNullOrWhiteSpace(SearchVINText) ? Car.GetCarByVIN(SearchVINText) : new Car())));
        }

        /// <summary>
        /// Saves car modification.
        /// </summary>
        /// <returns>Dictionary with key = ture if save succeeded, key = false if save failed.</returns>
        public Dictionary<bool, string> SaveModification()
        {
            bool valid = true;
            string errorMsg = string.Empty;
            Dictionary<bool, string> validationResult = new Dictionary<bool, string>();
            bool updated = false;

            if (this.Car.SimpleValidateCar().Keys.Contains(false))
            {
                valid = false;
                errorMsg += this.Car.SimpleValidateCar()[false];
            }
            if (string.IsNullOrWhiteSpace(Reason))
            {
                valid = false;
                errorMsg += "Podaj powód modyfikacji!\n";
            }

            if (valid)
            {
                updated = this.Car.UpdateCar(this.Car.GetId(string.IsNullOrWhiteSpace(SearchLicensePlaneNumText) ? "VIN" : "Numer rejestracyjny",
                    string.IsNullOrWhiteSpace(SearchLicensePlaneNumText) ? SearchVINText : SearchLicensePlaneNumText));
            }

            if (!updated)
            {
                valid = false;
                errorMsg += "Nie udało się zapisać zmian!";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }
    }
}
