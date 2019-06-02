using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Presenters;
using Wypozyczalnia.Views;

namespace Wypozyczalnia
{
    public partial class ModifyCarForm : Form, IModifyCar
    {
        public string CategoryText
        {
            get
            {
                return categoryComboBox.Text;
            }
            set
            {
                categoryComboBox.SelectedIndex = int.Parse(value);
            }
        }
        public string CostText
        {
            get
            {
                return costTextBox.Text;
            }
            set
            {
                costTextBox.Text = value;
            }
        }
        public string DriveTypeText
        {
            get
            {
                return driveTypeComboBox.Text;
            }
            set
            {
                driveTypeComboBox.SelectedIndex = int.Parse(value);
            }
        }
        public string EngineText
        {
            get
            {
                return engineComboBox.Text;
            }
            set
            {
                engineComboBox.SelectedIndex = int.Parse(value);
            }
        }
        public string GearboxText
        {
            get
            {
                return gearboxComboBox.Text;
            }
            set
            {
                gearboxComboBox.SelectedIndex = int.Parse(value);
            }
        }
        public string LicensePlateNumText
        {
            get
            {
                return licensePlateNumberTextBox.Text;
            }
            set
            {
                licensePlateNumberTextBox.Text = value;
            }
        }
        public string ManufacturerText
        {
            get
            {
                return manufacturerTextBox.Text;
            }
            set
            {
                manufacturerTextBox.Text = value;
            }
        }
        public string ModelText
        {
            get
            {
                return modelTextBox.Text;
            }
            set
            {
                modelTextBox.Text = value;
            }
        }
        public DateTime ProductionDate
        {
            get
            {
                return productionDateDateTimePicker.Value;
            }
            set
            {
                productionDateDateTimePicker.Value = value;
            }
        }
        public string VINText
        {
            get
            {
                return VINTextBox.Text;
            }
            set
            {
                VINTextBox.Text = value;
            }
        }

        public string ReasonText => modificationReasonTextBox.Text;
        public string SearchLicensePlaneNumText => searchLicensePlateNumberTextBox.Text;
        public string SearchVINText => searchVINTextBox.Text;

        public Dictionary<bool, string> Valid { get; set; }
        public bool Added { get; set; }
        public Dictionary<bool, string> ValidationResult { get; set; }

        public ModifyCarForm()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            AddCarPresenter presenter = new AddCarPresenter(this);
            Dictionary<string, string[]> comboBoxesValues = presenter.FillComboboxes();
            this.categoryComboBox.Items.AddRange(comboBoxesValues["category"]);
            this.driveTypeComboBox.Items.AddRange(comboBoxesValues["driveType"]);
            this.engineComboBox.Items.AddRange(comboBoxesValues["engine"]);
            this.gearboxComboBox.Items.AddRange(comboBoxesValues["gearbox"]);
        }

        #region SearchTextFields
        /*
         * Wyszukiwanie powinno byc realizowane na podstawie 1 danej: albo numeru VIN albo numeru rejestracyjnego
         */
        private void VINTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.searchVINTextBox.Text.Trim().Length > 0)
            {
                this.searchLicensePlateNumberTextBox.Enabled = false;
            }
            else
            {
                this.searchLicensePlateNumberTextBox.Enabled = true;
            }
        }

        private void LicensePlateNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.searchLicensePlateNumberTextBox.Text.Trim().Length > 0)
            {
                this.searchVINTextBox.Enabled = false;
            }
            else
            {
                this.searchVINTextBox.Enabled = true;
            }
        }
        #endregion

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AddCarPresenter addCarPresenter = new AddCarPresenter(this);
            addCarPresenter.ClearCarData();

            ModifyCarPresenter modifyCarPresenter = new ModifyCarPresenter(this);
            modifyCarPresenter.ValidateSearchCriteria();

            if (ValidationResult.Keys.Contains(false))
            {
                this.ShowWarning(ValidationResult[false]);
                this.saveButton.Enabled = false;
            }
            else if (ValidationResult.Keys.Contains(true))
            {
                modifyCarPresenter.LoadCarData();
                this.saveButton.Enabled = true;
            }
        }

        private void ShowWarning(string errorMsg)
        {
            string caption = "Nieprawidłowe dane";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errorMsg, caption, buttons);
        }

        private void ShowSuccessInfo(string errorMsg)
        {
            string caption = "Operacja udana";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errorMsg, caption, buttons);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ModifyCarPresenter modifyCarPresenter = new ModifyCarPresenter(this);

            if (modifyCarPresenter.SaveModification().Keys.Contains(false))
            {
                this.ShowWarning(modifyCarPresenter.SaveModification()[false]);
            }
            else
            {
                this.ShowSuccessInfo("Dane samochodu zostały zmodyfikowane!");
                this.saveButton.Enabled = false;
            }
        }

    }
}
