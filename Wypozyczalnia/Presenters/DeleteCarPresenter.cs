using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wypozyczalnia.Models;
using Wypozyczalnia.Views;

namespace Wypozyczalnia.Presenters
{
    public class DeleteCarPresenter
    {
        IDeleteCar deleteCarView;

        public DeleteCarPresenter(IDeleteCar view)
        {
            deleteCarView = view;
        }

        public void DeleteCar()
        {
            string columnName = string.Empty;
            string columnValue = string.Empty;

            if (deleteCarView.LicensePlateNumber.Length > 0)
            {
                columnName = "Numer rejestracyjny";
                columnValue = deleteCarView.LicensePlateNumber;
            }
            else if (deleteCarView.VIN.Length > 0)
            {
                columnName = "VIN";
                columnValue = deleteCarView.VIN;
            }

            Car.SetStatusAsDeleted(columnName, columnValue);
        }

        public bool FindCar()
        {
            bool found = false;
            Car car = null;

            if (deleteCarView.LicensePlateNumber.Length > 0)
            {
                car = Car.GetCarByLicensePlateNum(deleteCarView.LicensePlateNumber);
            }
            else if (deleteCarView.VIN.Length > 0)
            {
                car = Car.GetCarByVIN(deleteCarView.VIN);
            }

            if (car != null)
            {
                found = true;
            }

            return found;
        }

        public bool CanDeleteCar()
        {
            bool canDelete = false;
            string columnName = string.Empty;
            string columnValue = string.Empty;

            if (deleteCarView.LicensePlateNumber.Length > 0)
            {
                columnName = "Numer rejestracyjny";
                columnValue = deleteCarView.LicensePlateNumber;
            }
            else if (deleteCarView.VIN.Length > 0)
            {
                columnName = "VIN";
                columnValue = deleteCarView.VIN;
            }

            if (EnumStatus.Dostępny.ToString().Equals(Car.GetStatus(columnName, columnValue).Trim()))
            {
                canDelete = true;
            }

            return canDelete;
        }
    }
}
