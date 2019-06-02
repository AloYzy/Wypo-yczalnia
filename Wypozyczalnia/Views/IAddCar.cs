using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Views
{
    public interface IAddCar
    {
        string CategoryText { get; set; }
        string CostText { get; set; }
        string DriveTypeText { get; set; }
        string EngineText { get; set; }
        string GearboxText { get; set; }
        string LicensePlateNumText { get; set; }
        string ManufacturerText { get; set; }
        string ModelText { get; set; }
        DateTime ProductionDate { get; set; }
        string VINText { get; set; }

        Dictionary<bool, string> Valid { get; set; }
        bool Added { get; set; }
    }
}
