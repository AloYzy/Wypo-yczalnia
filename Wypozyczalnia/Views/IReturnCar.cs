using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wypozyczalnia.Models;

namespace Wypozyczalnia.Views
{
    public interface IReturnCar
    {
        string LicenseNumber { get; }
        bool SearchPossible { set; }
        Rent Rent { get; set; }
    }
}
