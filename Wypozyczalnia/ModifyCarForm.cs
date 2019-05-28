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

namespace Wypozyczalnia
{
    public partial class ModifyCarForm : Form
    {
        public ModifyCarForm()
        {
            InitializeComponent();
            this.FillCategoryComboBox();
            this.FillDriveTypeComboBox();
            this.FillEngineTypeComboBox();
            this.FillGearboxComboBox();

        }

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (this.searchVINTextBox.Text.Trim().Length == 0 && this.searchLicensePlateNumberTextBox.Text.Trim().Length == 0)
            {
                ShowWarning("Podaj numer VIN lub numer rejestracyjny samochodu!");
            }
            else if (this.searchVINTextBox.Text.Trim().Length > 0)
            {
                Dictionary<Boolean, string> VINValidationResult = Helpers.ValidateVINNumber(this.searchVINTextBox.Text.Trim());
                if (VINValidationResult.Keys.Contains(true))
                {
                    this.ClearComboBoxesValues();
                    LoadData("VIN", this.searchVINTextBox.Text.Trim());
                }
                else if (VINValidationResult.Keys.Contains(false))
                {
                    ShowWarning(VINValidationResult[false]);
                }
            }
            else if (this.searchLicensePlateNumberTextBox.Text.Trim().Length > 0)
            {
                Dictionary<Boolean, string> licensePlateNumValidationResult = Helpers.ValidateLicensePlatenumber(this.searchLicensePlateNumberTextBox.Text.Trim());
                if (licensePlateNumValidationResult.Keys.Contains(true))
                {
                    this.ClearComboBoxesValues();
                    LoadData("[Numer rejestracyjny]", this.searchLicensePlateNumberTextBox.Text.Trim());
                }
                else if (licensePlateNumValidationResult.Keys.Contains(false))
                {
                    ShowWarning(licensePlateNumValidationResult[false]);
                }
            }
        }

        private void LoadData(string columnName, string columnValue)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-ESRM8PV;
                                                                database=Wypozyczalnia;
                                                                User id=admin;
                                                                Password=admin;");

                DataTable table = new DataTable();
                var da = new SqlDataAdapter($"select * from samochody where {columnName} = '{columnValue}'", sqlConnection);
                da.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.categoryComboBox.SelectedIndex = (int)Enum.Parse(typeof(EnumCategory), table.Rows[0].Field<string>("Klasa"));
                    this.manufacturerTextBox.Text = table.Rows[0].Field<string>("Marka");
                    this.modelTextBox.Text = table.Rows[0].Field<string>("Model");
                    this.driveTypeComboBox.SelectedIndex = (int)Enum.Parse(typeof(EnumDriveType), table.Rows[0].Field<string>("Rodzaj napędu"));
                    this.gearboxComboBox.SelectedIndex = (int)Enum.Parse(typeof(EnumGearboxType), table.Rows[0].Field<string>("Skrzynia biegów"));
                    this.productionDateDateTimePicker.Value = DateTime.Parse(table.Rows[0].Field<DateTime>("Rok produkcji").ToString());
                    this.engineComboBox.SelectedIndex = (int)Enum.Parse(typeof(EnumEngineType), table.Rows[0].Field<string>("Silnik"));
                    this.costTextBox.Text = table.Rows[0].Field<decimal>("Koszt wynajęcia").ToString();
                    this.VINTextBox.Text = table.Rows[0].Field<string>("VIN");
                    this.licensePlateNumberTextBox.Text = table.Rows[0].Field<string>("Numer rejestracyjny");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd!");
                Console.WriteLine(exp.Message);
            }
        }

        private void ShowWarning(string errorMsg)
        {
            string caption = "Nieprawidłowe dane";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(errorMsg, caption, buttons);
        }

        private void FillCategoryComboBox()
        {
            foreach (EnumCategory e in Enum.GetValues(typeof(EnumCategory)).Cast<EnumCategory>())
            {
                this.categoryComboBox.Items.Add(e);
            }
        }

        private void FillGearboxComboBox()
        {
            foreach (EnumGearboxType e in Enum.GetValues(typeof(EnumGearboxType)).Cast<EnumGearboxType>())
            {
                this.gearboxComboBox.Items.Add(e);
            }
        }

        private void FillDriveTypeComboBox()
        {
            foreach (EnumDriveType e in Enum.GetValues(typeof(EnumDriveType)).Cast<EnumDriveType>())
            {
                this.driveTypeComboBox.Items.Add(e);
            }
        }

        private void FillEngineTypeComboBox()
        {
            foreach (EnumEngineType e in Enum.GetValues(typeof(EnumEngineType)).Cast<EnumEngineType>())
            {
                this.engineComboBox.Items.Add(e);
            }
        }

        private void ClearComboBoxesValues()
        {
            this.categoryComboBox.SelectedIndex = -1;
            this.gearboxComboBox.SelectedIndex = -1;
            this.driveTypeComboBox.SelectedIndex = -1;
            this.engineComboBox.SelectedIndex = -1;
        }
    }
}
