using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wypozyczalnia.Models;
using Wypozyczalnia.Views;

namespace Wypozyczalnia.Presenters
{
    public class AddCarPresenter
    {
        IAddCar addCarView;

        public AddCarPresenter(IAddCar view)
        {
            addCarView = view;
        }

        public void AddNewCar()
        {
            Car car = new Car
            {
                Category = addCarView.CategoryText,
                Cost = addCarView.CostText,
                DriveType = addCarView.DriveTypeText,
                Engine = addCarView.EngineText,
                Gearbox = addCarView.GearboxText,
                LicensePlateNum = addCarView.LicensePlateNumText,
                Manufacturer = addCarView.ManufacturerText,
                Model = addCarView.ModelText,
                ProductionDate = addCarView.ProductionDate,
                VIN = addCarView.VINText
            };

            addCarView.Added = car.AddNewCar();
        }

        public void ValidateCar()
        {
            Car car = new Car
            {
                Category = addCarView.CategoryText,
                Cost = addCarView.CostText,
                DriveType = addCarView.DriveTypeText,
                Engine = addCarView.EngineText,
                Gearbox = addCarView.GearboxText,
                LicensePlateNum = addCarView.LicensePlateNumText,
                Manufacturer = addCarView.ManufacturerText,
                Model = addCarView.ModelText,
                ProductionDate = addCarView.ProductionDate,
                VIN = addCarView.VINText
            };

            addCarView.Valid = car.ValidateCar();
        }

        public Dictionary<string, string[]> FillComboboxes()
        {
            return Car.FillComboBoxes();
        }

        public void ClearCarData()
        {
            Car car = new Car();

            addCarView.CategoryText = car.Category;
            addCarView.CostText = car.Cost;
            addCarView.DriveTypeText = car.DriveType;
            addCarView.EngineText = car.Engine;
            addCarView.GearboxText = car.Gearbox;
            addCarView.LicensePlateNumText = car.LicensePlateNum;
            addCarView.ManufacturerText = car.Manufacturer;
            addCarView.ModelText = car.Model;
            addCarView.ProductionDate = car.ProductionDate;
            addCarView.VINText = car.VIN;
        }

        
    }
}
