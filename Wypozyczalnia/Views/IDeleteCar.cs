using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Views
{
    public interface IDeleteCar
    {
        string LicensePlateNumber { get; }
        string VIN { get; }
    }
}
