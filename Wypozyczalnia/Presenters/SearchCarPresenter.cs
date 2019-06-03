using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Models;
using Wypozyczalnia.Views;

namespace Wypozyczalnia.Presenters
{
    public class SearchCarPresenter
    {
        IShowCars showCarsView;

        public SearchCarPresenter(IShowCars view)
        {
            showCarsView = view;
        }

        public void SearchAllAvailableCars()
        {
            showCarsView.AllAvailableCars = Car.SearchAllAvailableCars();
        }

        public void SearchAllCars()
        {
            showCarsView.AllCars = Car.SearchAllCars();
        }

        public void FillCheckedListBoxes()
        {
            DataTable categoryDataTable = Car.getAllCategories();
            for (int i = 0; i < categoryDataTable.Rows.Count; i++)
            {
                showCarsView.CategoryCheckedListBox.Items.Add(categoryDataTable.Rows[i]["Klasa"].ToString());
            }

            DataTable driveTypeDataTable = Car.getAllDriveTypes();
            for (int i = 0; i < driveTypeDataTable.Rows.Count; i++)
            {
                showCarsView.DriveTypeCheckedListBox.Items.Add(driveTypeDataTable.Rows[i]["Rodzaj napędu"].ToString());
            }

            DataTable engineDataTable = Car.getAllEngines();
            for (int i = 0; i < engineDataTable.Rows.Count; i++)
            {
                showCarsView.EngineCheckedListBox.Items.Add(engineDataTable.Rows[i]["Silnik"].ToString());
            }

            DataTable manufacturerDataTable = Car.getAllManufacturers();
            for (int i = 0; i < manufacturerDataTable.Rows.Count; i++)
            {
                showCarsView.ManufacturerCheckedListBox.Items.Add(manufacturerDataTable.Rows[i]["Marka"].ToString());
            }

            DataTable modelDataTable = Car.getAllModels();
            for (int i = 0; i < modelDataTable.Rows.Count; i++)
            {
                showCarsView.ModelCheckedListBox.Items.Add(modelDataTable.Rows[i]["Model"].ToString());
            }
        }
    }
}
