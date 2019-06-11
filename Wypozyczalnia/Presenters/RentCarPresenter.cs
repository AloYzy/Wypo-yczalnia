using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Models;
using Wypozyczalnia.Views;

namespace Wypozyczalnia.Presenters
{
    public class RentCarPresenter
    {
        IRentCar rentCarView;
        Car car;

        public RentCarPresenter(IRentCar view)
        {
            rentCarView = view;
        }

        public void FillForm(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView)
            {
                var cells = (sender as DataGridView).CurrentRow.Cells;
                car = Car.GetCarByLicensePlateNum(cells[11].FormattedValue.ToString());
                rentCarView.Manufacturer = car.Manufacturer;
                rentCarView.Model = car.Model;
                EnumEngineType engine = (EnumEngineType)int.Parse(car.Engine);
                rentCarView.Engine = engine.ToString();
                rentCarView.LicensePlateNumber = car.LicensePlateNum;
                rentCarView.Cost = car.Cost;
            }
        }

        public void CalculateTotalCost()
        {
            int startDay = rentCarView.DateStart.DayOfYear;
            int endDay = rentCarView.DateEnd.DayOfYear;
            decimal cost;
            if (decimal.TryParse(rentCarView.Cost, out cost))
            {
                rentCarView.TotalCost = (endDay - startDay) * cost;
            }
        }

        public Dictionary<bool, string> ValidateDates()
        {
            Dictionary<bool, string> validationResult = new Dictionary<bool, string>();
            bool valid = true;
            string errorMsg = string.Empty;

            if (rentCarView.DateStart.Date < DateTime.Now.Date)
            {
                valid = false;
                errorMsg += "Data wypożyczenia nie może być wcześniejsza niż dzień obecny!\n";
            }
            else if (rentCarView.DateEnd.Date < DateTime.Now.Date)
            {
                valid = false;
                errorMsg += "Data zwrotu nie może być wcześniejsza niż dzień obecny!\n";
            }
            else if (rentCarView.DateStart.Date > rentCarView.DateEnd.Date)
            {
                valid = false;
                errorMsg += "Data zwrotu nie może być wcześniejsza niż data wypożyczenia!\n";
            }
            else if (rentCarView.DateStart.Date == rentCarView.DateEnd.Date)
            {
                valid = false;
                errorMsg += "Data wypożyczenia i zwrotu nie mogą być identyczne!\n";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        public Dictionary<bool, string> ValidateClientData()
        {
            Dictionary<bool, string> validationResult = new Dictionary<bool, string>();
            bool valid = true;
            string errorMsg = string.Empty;

            if (string.IsNullOrWhiteSpace(rentCarView.ClientName))
            {
                valid = false;
                errorMsg += "Imię klienta nie może zostać puste!\n";
            }
            if (string.IsNullOrWhiteSpace(rentCarView.ClientSurname))
            {
                valid = false;
                errorMsg += "Nazwisko klienta nie może zostać puste!\n";
            }
            if (string.IsNullOrWhiteSpace(rentCarView.LicenseNumber))
            {
                valid = false;
                errorMsg += "Numer prawa jazdy nie może zostać pusty!\n";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        internal void AddNewRent()
        {
            throw new NotImplementedException();
        }
    }
}
