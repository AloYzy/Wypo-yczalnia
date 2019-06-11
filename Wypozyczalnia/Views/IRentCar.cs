using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Views
{
    public interface IRentCar
    {
        string ClientName { get; }
        string ClientSurname { get; }
        string LicenseNumber { get; }

        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }

        string Manufacturer { get; set; }
        string Model { get; set; }
        string Engine { get; set; }
        string LicensePlateNumber { get; set; }
        string Cost { get; set; }

        decimal TotalCost { set; }
    }
}
