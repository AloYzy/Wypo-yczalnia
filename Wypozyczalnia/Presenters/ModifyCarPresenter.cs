using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wypozyczalnia.Models;
using Wypozyczalnia.Views;

namespace Wypozyczalnia.Presenters
{
    public class ModifyCarPresenter
    {
        IModifyCar modifyCarView;

        public ModifyCarPresenter(IModifyCar view)
        {
            modifyCarView = view;
        }

        public void ValidateSearchCriteria()
        {
            Modification modification = new Modification
            {
                SearchLicensePlaneNumText = modifyCarView.SearchLicensePlaneNumText,
                SearchVINText = modifyCarView.SearchVINText
            };

            modifyCarView.ValidationResult = modification.ValidateSearchCriteria();
        }

        public void LoadCarData()
        {
            Modification modification = new Modification
            {
                SearchLicensePlaneNumText = modifyCarView.SearchLicensePlaneNumText,
                SearchVINText = modifyCarView.SearchVINText
            };

            Car car = modification.LoadCarData();
            modifyCarView.CategoryText = car.Category;
            modifyCarView.CostText = car.Cost;
            modifyCarView.DriveTypeText = car.DriveType;
            modifyCarView.EngineText = car.Engine;
            modifyCarView.GearboxText = car.Gearbox;
            modifyCarView.LicensePlateNumText = car.LicensePlateNum;
            modifyCarView.ManufacturerText = car.Manufacturer;
            modifyCarView.ModelText = car.Model;
            modifyCarView.ProductionDate = car.ProductionDate;
            modifyCarView.VINText = car.VIN;
        }

        public Dictionary<bool, string> SaveModification()
        {
            Modification modification = new Modification
            {
                Car = new Car
                {
                    Category = modifyCarView.CategoryText,
                    Cost = modifyCarView.CostText,
                    DriveType = modifyCarView.DriveTypeText,
                    Engine = modifyCarView.EngineText,
                    Gearbox = modifyCarView.GearboxText,
                    LicensePlateNum = modifyCarView.LicensePlateNumText,
                    Manufacturer = modifyCarView.ManufacturerText,
                    Model = modifyCarView.ModelText,
                    ProductionDate = modifyCarView.ProductionDate,
                    VIN = modifyCarView.VINText
                },
                Reason = modifyCarView.ReasonText,
                SearchLicensePlaneNumText = modifyCarView.SearchLicensePlaneNumText,
                SearchVINText = modifyCarView.SearchVINText
            };

            return modification.SaveModification();
        }
    }
}

