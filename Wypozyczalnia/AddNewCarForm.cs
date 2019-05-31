using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Wypozyczalnia
{
    public partial class AddNewCarForm : Form
    {
        public AddNewCarForm()
        {
            InitializeComponent();
            FillCategoryComboBox();
            FillDriveTypeComboBox();
            FillGearboxComboBox();
            FillEngineTypeComboBox();
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
                this.gearBoxComboBox.Items.Add(e);
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
                this.engineTypeComboBox.Items.Add(e);
            }
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {

            Dictionary<Boolean, string> validationResult = this.ValidateForm();

            if (validationResult.Keys.Contains(true))
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-ESRM8PV;
                                                                database=Wypozyczalnia;
                                                                User id=admin;
                                                                Password=admin;");
                    sqlConnection.Open();
                    SqlCommand query = sqlConnection.CreateCommand();
                    query.CommandText = $"INSERT INTO samochody (klasa, marka, model, [rok produkcji], [rodzaj napędu], [skrzynia biegów], silnik, status, [koszt wynajęcia], vin, [numer rejestracyjny]) " +
                        $"VALUES('{this.categoryComboBox.Text}', '{this.manufacturerTextBox.Text.ToUpper()}', '{this.modelTextBox.Text.ToUpper()}', '{this.productionYearDateTimePicker.Value.ToString("yyyy-MM-dd")}', '{this.driveTypeComboBox.Text}', '{this.gearBoxComboBox.Text}', '{this.engineTypeComboBox.Text}', '{EnumStatus.Dostępny}', '{this.costTextBox.Text}', '{this.VINTextBox.Text.ToUpper()}', '{this.licensePlateNumberTextBox.Text.ToUpper()}')";
                    query.ExecuteNonQuery();
                    sqlConnection.Close();

                    string infoMsg = "Samochód został pomyślnie dodany do bazy.";
                    string caption = "Dodano";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult dialogResult = MessageBox.Show(infoMsg, caption, buttons);

                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
                catch (Exception exp)
                {

                    Console.WriteLine(exp.Message);
                }
            }
            else
            {
                string errorMsg = validationResult[false];
                string caption = "Nieprawidłowe dane";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(errorMsg, caption, buttons);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Dictionary<Boolean, string> ValidateForm()
        {
            Dictionary<Boolean, string> validationResult = new Dictionary<Boolean, string>();
            Boolean valid = true;
            String errorMsg = "";

            /*
             * walidacja klasy samochodu
             */
            if (String.IsNullOrWhiteSpace(this.categoryComboBox.Text))
            {
                valid = false;
                errorMsg += "Klasa samochodu nie może zostać pusta!\n";
            }

            /*
             * walidacja marki
             */
            if (String.IsNullOrWhiteSpace(this.manufacturerTextBox.Text))
            {
                valid = false;
                errorMsg += "Marka samochodu nie może zostać pusta!\n";
            }

            /*
             * walidacja modelu
             */
            if (String.IsNullOrWhiteSpace(this.modelTextBox.Text))
            {
                valid = false;
                errorMsg += "Model samochodu nie może zostać pusty!\n";
            }

            /*
             * walidacja rodzaju napędu
             */
            if (String.IsNullOrWhiteSpace(this.driveTypeComboBox.Text))
            {
                valid = false;
                errorMsg += "Rodzaj napędu nie może zostać pusty!\n";
            }

            /*
             * walidacja skrzyni biegów
             */
            if (String.IsNullOrWhiteSpace(this.gearBoxComboBox.Text))
            {
                valid = false;
                errorMsg += "Skrzynia biegów nie może zostać pusta!\n";
            }

            /*
             * walidacja daty produkcji
             */
            if (String.IsNullOrWhiteSpace(this.productionYearDateTimePicker.Text))
            {
                valid = false;
                errorMsg += "Data produkcji nie może zostać pusta!\n";
            }

            /*
             * walidacja rodzaju silnika
             */
            if (String.IsNullOrWhiteSpace(this.engineTypeComboBox.Text))
            {
                valid = false;
                errorMsg += "Silnik nie może zostać pusty!\n";
            }

            /*
             * walidacja kosztu wynajęcia
             */
            if (String.IsNullOrWhiteSpace(this.costTextBox.Text))
            {
                valid = false;
                errorMsg += "Koszt wynajęcia samochodu nie może zostać pusty!\n";
            }

            /*
             * walidacja VIN
             */
            if (String.IsNullOrWhiteSpace(this.VINTextBox.Text))
            {
                valid = false;
                errorMsg += "Numer VIN samochodu nie może zostać pusty!\n";
            }
            else if (Helpers.ValidateVINNumber(this.VINTextBox.Text.Trim()).Keys.Contains(false))
            {
                valid = false;
                errorMsg += Helpers.ValidateVINNumber(this.VINTextBox.Text.Trim())[false];
            }
            else if (Helpers.IsVINPresent(this.VINTextBox.Text.Trim()))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer VIN już istnieje w bazie!";
            }

            /*
             * walidacja numeru rejestracyjnego
             */
            if (String.IsNullOrWhiteSpace(this.licensePlateNumberTextBox.Text))
            {
                valid = false;
                errorMsg += "Numer rejestracyjny samochodu nie może zostać pusty!";
            }
            else if (Helpers.ValidateLicensePlatenumber(this.licensePlateNumberTextBox.Text.Trim()).Keys.Contains(false))
            {
                valid = false;
                errorMsg += Helpers.ValidateLicensePlatenumber(this.licensePlateNumberTextBox.Text.Trim())[false];
            }
            else if (Helpers.IsLicensePlateNumberPresent(this.licensePlateNumberTextBox.Text.Trim()))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu już istnieje w bazie!";
            }

            validationResult.Add(valid, errorMsg);
            return validationResult;
        }
    }
}
