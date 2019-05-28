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
                        $"VALUES('{this.categoryComboBox.Text}', '{this.manufacturerTextBox.Text.ToUpper()}', '{this.modelTextBox.Text.ToUpper()}', '{this.productionYearDateTimePicker.Value.ToString("yyyy-MM-dd")}', '{this.driveTypeComboBox.Text}', '{this.gearBoxComboBox.Text}', '{this.engineTypeComboBox.Text}', '{EnumStatus.Dostępny}', '{this.costTextBox.Text}', '{this.VINTextBox.Text.ToUpper()}', '{this.LicensePlateNumberTextBox.Text.ToUpper()}')";
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

            if (String.Empty.Equals(this.categoryComboBox.Text))
            {
                valid = false;
                errorMsg += "Klasa samochodu nie może zostać pusta!\n";
            }
            if (String.Empty.Equals(this.manufacturerTextBox.Text))
            {
                valid = false;
                errorMsg += "Marka samochodu nie może zostać pusta!\n";
            }
            if (String.Empty.Equals(this.modelTextBox.Text))
            {
                valid = false;
                errorMsg += "Model samochodu nie może zostać pusty!\n";
            }
            if (String.Empty.Equals(this.driveTypeComboBox.Text))
            {
                valid = false;
                errorMsg += "Rodzaj napędu nie może zostać pusty!\n";
            }
            if (String.Empty.Equals(this.gearBoxComboBox.Text))
            {
                valid = false;
                errorMsg += "Skrzynia biegów nie może zostać pusta!\n";
            }
            if (String.Empty.Equals(this.productionYearDateTimePicker.Text))
            {
                valid = false;
                errorMsg += "Data produkcji nie może zostać pusta!\n";
            }
            if (String.Empty.Equals(this.engineTypeComboBox.Text))
            {
                valid = false;
                errorMsg += "Silnik nie może zostać pusty!\n";
            }
            if (String.Empty.Equals(this.costTextBox.Text))
            {
                valid = false;
                errorMsg += "Koszt wynajęcia samochodu nie może zostać pusty!\n";
            }
            if (String.Empty.Equals(this.VINTextBox.Text))
            {
                valid = false;
                errorMsg += "Numer VIN samochodu nie może zostać pusty!\n";
            }
            else if (this.VINTextBox.Text.Trim().Length != 17)
            {
                valid = false;
                errorMsg += $"Wprowadzony numer VIN samochodu jest nieprawiłowy! ({this.VINTextBox.Text.Trim().Length} znaków zamiast 17)\n";
            }
            else if (this.VINTextBox.Text.Contains("I") || this.VINTextBox.Text.Contains("O") || this.VINTextBox.Text.Contains("Q"))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer VIN samochodu jest nieprawiłowy! (Numer VIN nie może zawierać liter I, O i Q!\n";
            }
            else if (this.IsVINPresent(this.VINTextBox.Text))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer VIN już istnieje w bazie!";
            }
            if (String.Empty.Equals(this.LicensePlateNumberTextBox.Text))
            {
                valid = false;
                errorMsg += "Numer rejestracyjny samochodu nie może zostać pusty!";
            }
            else if (this.LicensePlateNumberTextBox.Text.Trim().Length != 7)
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu jest nieprawiłowy! ({this.LicensePlateNumberTextBox.Text.Trim().Length} znaków zamiast 7)";
            }
            else if (!Char.IsLetter(this.LicensePlateNumberTextBox.Text.ToCharArray()[0]) || !Char.IsLetter(this.LicensePlateNumberTextBox.Text.ToCharArray()[1]))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu jest nieprawiłowy! (Co najmniej 2 pierwsze znaki muszą być literami)";
            }
            else if (this.IsLicensePlateNumberPresent(this.LicensePlateNumberTextBox.Text))
            {
                valid = false;
                errorMsg += $"Wprowadzony numer rejestracyjny samochodu już istnieje w bazie!";
            }

            validationResult.Add(valid, errorMsg);

            return validationResult;
        }

        private Boolean IsVINPresent(string VIN)
        {
            Boolean exists = false;

            SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-ESRM8PV;
                                                                database=Wypozyczalnia;
                                                                User id=admin;
                                                                Password=admin;");
            sqlConnection.Open();
            SqlCommand query = sqlConnection.CreateCommand();
            query.CommandText = $"select * from samochody where VIN = '{VIN}'";
            SqlDataReader dataReader = query.ExecuteReader();
            if (dataReader.HasRows)
            {
                exists = true;
            }

            return exists;
        }

        private Boolean IsLicensePlateNumberPresent(string licPlateNum)
        {
            Boolean exists = false;

            SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-ESRM8PV;
                                                                database=Wypozyczalnia;
                                                                User id=admin;
                                                                Password=admin;");
            sqlConnection.Open();
            SqlCommand query = sqlConnection.CreateCommand();
            query.CommandText = $"select * from samochody where [Numer rejestracyjny] = '{licPlateNum}'";
            SqlDataReader dataReader = query.ExecuteReader();
            if (dataReader.HasRows)
            {
                exists = true;
            }

            return exists;
        }
    }
}
