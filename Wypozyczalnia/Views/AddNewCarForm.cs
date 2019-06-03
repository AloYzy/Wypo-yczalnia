using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Wypozyczalnia.Presenters;
using Wypozyczalnia.Views;

namespace Wypozyczalnia
{
    public partial class AddNewCarForm : Form, IAddCar
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
                return engineTypeComboBox.Text;

            }
            set
            {
                engineTypeComboBox.SelectedIndex = int.Parse(value);
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
                return productionYearDateTimePicker.Value;
            }
            set
            {
                productionYearDateTimePicker.Value = value;
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

        public Dictionary<bool, string> Valid { get; set; }
        public bool Added { get; set; }

        public AddNewCarForm()
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
            this.engineTypeComboBox.Items.AddRange(comboBoxesValues["engine"]);
            this.gearboxComboBox.Items.AddRange(comboBoxesValues["gearbox"]);
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarPresenter presenter = new AddCarPresenter(this);
            presenter.ValidateCar();

            if (Valid.Keys.Contains(false))
            {
                string errorMsg = Valid[false];
                string caption = "Nieprawidłowe dane";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(errorMsg, caption, buttons);
            }
            else if (Valid.Keys.Contains(true) && string.IsNullOrWhiteSpace(Valid[true]))
            {
                presenter.AddNewCar();

                if (Added)
                {
                    string infoMsg = "Samochód został pomyślnie dodany do bazy.";
                    string caption = "Dodano";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult dialogResult = MessageBox.Show(infoMsg, caption, buttons);

                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
