using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Views
{
    public interface IRentCar
    {
        string ClientName { get; set; }
        string ClientSurname { get; set; }
        string LicenseNumber { get; set; }

        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }

        string Manufacturer { get; set; }
        string Model { get; set; }
        string Engine { get; set; }
        string LicensePlateNumber { get; set; }
        string Cost { get; set; }

        decimal TotalCost { get; set; }
    }
}
