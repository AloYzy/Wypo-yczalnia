using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wypozyczalnia.Models;
using Wypozyczalnia.Views;

namespace Wypozyczalnia.Presenters
{
    public class ReturnCarPresenter
    {
        IReturnCar returnCarView;

        public ReturnCarPresenter(IReturnCar view)
        {
            returnCarView = view;
        }

        public void checkIfSearchPossible()
        {
            if(returnCarView.LicenseNumber.Length == 7)
            {
                returnCarView.SearchPossible = true;
            }
        }

        public bool FindRent()
        {
            bool found = false;

            Car car = Car.GetCarByLicensePlateNum(returnCarView.LicenseNumber);
            if (!string.IsNullOrEmpty(car.LicensePlateNum) && car.Status.Trim().Equals(EnumStatus.Wypożyczony.ToString()))
            {
                int id = car.GetId("numer rejestracyjny", car.LicensePlateNum);
                Rent rent = Rent.GetRentByCarId(id);
                if(rent != null)
                {
                    rent.Car = car;
                    found = true;
                    returnCarView.Rent = rent;
                }
            }
            return found;
        }
    }
}
