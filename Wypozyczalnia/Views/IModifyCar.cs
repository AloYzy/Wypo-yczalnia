using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wypozyczalnia.Models;

namespace Wypozyczalnia.Views
{
    public interface IModifyCar: IAddCar
    {
        //string CategoryText { get; set; }
        //string CostText { get; set; }
        //string DriveTypeText { get; set; }
        //string EngineText { get; set; }
        //string GearboxText { get; set; }
        //string LicensePlateNumText { get; set; }
        //string ManufacturerText { get; set; }
        //string ModelText { get; set; }
        //DateTime ProductionDate { get; set; }
        //string VINText { get; set; }
        string ReasonText { get; }
        string SearchLicensePlaneNumText { get; }
        string SearchVINText { get; }
        Dictionary<bool, string> ValidationResult { get; set; }
    }
}
