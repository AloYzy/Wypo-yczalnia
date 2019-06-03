using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia.Views
{
    public interface IShowCars
    {
        CheckedListBox.CheckedItemCollection CategoryText { get; }
        CheckedListBox CategoryCheckedListBox { get; set; }
        string CostTextFrom { get; }
        string CostTextTo { get; }
        CheckedListBox.CheckedItemCollection DriveTypeText { get; }
        CheckedListBox DriveTypeCheckedListBox { get; set; }
        CheckedListBox.CheckedItemCollection EngineText { get; }
        CheckedListBox EngineCheckedListBox { get; set; }
        string GearboxText { get; }
        CheckedListBox.CheckedItemCollection ManufacturerText { get; }
        CheckedListBox ManufacturerCheckedListBox { get; set; }
        CheckedListBox.CheckedItemCollection ModelText { get; }
        CheckedListBox ModelCheckedListBox { get; set; }
        DateTime ProductionDateFrom { get; }
        DateTime ProductionDateTo { get; }
        DataTable AllAvailableCars { set; }
        DataTable SearchedAvailableCars { set; }
        DataTable AllCars { set; }
    }
}
