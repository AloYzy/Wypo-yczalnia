using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia
{

    public enum EnumCategory
    {
        Hatchback,
        Kombi,
        Sedan,
        Suv
    }

    public enum EnumDriveType
    {
        AllDrive,
        Przedni,
        Tylny        
    }

    public enum EnumGearboxType
    {
        Automatyczna,
        Manualna
    }

    public enum EnumEngineType
    {
        Beznynowy,
        Diesel,
        Hybrydowy
    }

    public enum EnumStatus
    {
        Dostępny,
        Wypożyczony
    }

}
