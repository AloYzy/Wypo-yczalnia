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

        public void SearchAvailableCarsByCriteria(CheckedListBox.CheckedItemCollection categoryText, CheckedListBox.CheckedItemCollection manufacturerText, CheckedListBox.CheckedItemCollection modelText, CheckedListBox.CheckedItemCollection driveTypeText, CheckedListBox.CheckedItemCollection engineText, DateTime productionDateFrom, DateTime productionDateTo, string costTextFrom, string costTextTo, string gearboxText)
        {
            string categoryCriteria = string.Empty;
            if (categoryText.Count == 0)
            {
                for (int i = 0; i < Car.getAllCategories().Rows.Count; i++)
                {
                    if (i == Car.getAllCategories().Rows.Count - 1)
                    {
                        categoryCriteria += "'" + Car.getAllCategories().Rows[i]["klasa"].ToString().Trim() + "'";
                    }
                    else
                    {
                        categoryCriteria += "'" + Car.getAllCategories().Rows[i]["klasa"].ToString().Trim() + "'" + ",";
                    }
                }
            }
            else
            {
                for (int i = 0; i < categoryText.Count; i++)
                {
                    if (i == categoryText.Count - 1)
                    {
                        categoryCriteria += "'" + categoryText[i].ToString().Trim() + "'";
                    }
                    else
                    {
                        categoryCriteria += "'" + categoryText[i].ToString().Trim() + "'" + ",";
                    }
                }
            }

            string manufacturerCriteria = string.Empty;
            if (manufacturerText.Count == 0)
            {
                for (int i = 0; i < Car.getAllManufacturers().Rows.Count; i++)
                {
                    if (i == Car.getAllManufacturers().Rows.Count - 1)
                    {
                        manufacturerCriteria += "'" + Car.getAllManufacturers().Rows[i]["marka"].ToString().Trim() + "'";
                    }
                    else
                    {
                        manufacturerCriteria += "'" + Car.getAllManufacturers().Rows[i]["marka"].ToString().Trim() + "'" + ",";
                    }
                }
            }
            else
            {
                for (int i = 0; i < manufacturerText.Count; i++)
                {
                    manufacturerCriteria += "'" + manufacturerText[i].ToString().Trim() + "'" + ",";
                }
            }

            string modelCriteria = string.Empty;
            if (modelText.Count == 0)
            {
                for (int i = 0; i < Car.getAllModels().Rows.Count; i++)
                {
                    if (i == Car.getAllModels().Rows.Count - 1)
                    {
                        modelCriteria += "'" + Car.getAllModels().Rows[i]["model"].ToString().Trim() + "'";
                    }
                    else
                    {
                        modelCriteria += "'" + Car.getAllModels().Rows[i]["model"].ToString().Trim() + "'" + ",";
                    }
                }
            }
            else
            {
                for (int i = 0; i < modelText.Count; i++)
                {
                    modelCriteria += "'" + modelText[i].ToString().Trim() + "'" + ",";
                }
            }

            string driveTypeCriteria = string.Empty;
            if (driveTypeText.Count == 0)
            {
                for (int i = 0; i < Car.getAllDriveTypes().Rows.Count; i++)
                {
                    if (i == Car.getAllDriveTypes().Rows.Count - 1)
                    {
                        driveTypeCriteria += "'" + Car.getAllDriveTypes().Rows[i]["rodzaj napędu"].ToString().Trim() + "'";
                    }
                    else
                    {
                        driveTypeCriteria += "'" + Car.getAllDriveTypes().Rows[i]["rodzaj napędu"].ToString().Trim() + "'" + ",";
                    }
                }
            }
            else
            {
                for (int i = 0; i < driveTypeText.Count; i++)
                {
                    driveTypeCriteria += "'" + driveTypeText[i].ToString().Trim() + "'" + ",";
                }
            }

            string engineCriteria = string.Empty;
            if (engineText.Count == 0)
            {
                for (int i = 0; i < Car.getAllEngines().Rows.Count; i++)
                {
                    if (i == Car.getAllEngines().Rows.Count - 1)
                    {
                        engineCriteria += "'" + Car.getAllEngines().Rows[i]["silnik"].ToString().Trim() + "'";
                    }
                    else
                    {
                        engineCriteria += "'" + Car.getAllEngines().Rows[i]["silnik"].ToString().Trim() + "'" + ",";
                    }
                }
            }
            else
            {
                for (int i = 0; i < engineText.Count; i++)
                {
                    engineCriteria += "'" + engineText[i].ToString().Trim() + "'" + ",";
                }
            }

            decimal costFromCriteria = 0;
            if (decimal.TryParse(costTextFrom, out decimal costFrom))
            {
                costFromCriteria = costFrom;
            }

            decimal costToCriteria = Car.getMaxCost();
            if (decimal.TryParse(costTextTo, out decimal costTo))
            {
                costToCriteria = costTo;
            }

            showCarsView.SearchedAvailableCars = Car.SearchAvailableCarsByCriteria(categoryCriteria, manufacturerCriteria, modelCriteria, driveTypeCriteria, engineCriteria, productionDateFrom, productionDateTo, costFromCriteria, costToCriteria, gearboxText);
        }
    }
}
