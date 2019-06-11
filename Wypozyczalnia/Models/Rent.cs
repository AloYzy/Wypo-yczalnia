using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    public class Rent
    {
        public Client Client { get; }
        public Car Car { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public Decimal TotalCost { get; set; }
    }
}
