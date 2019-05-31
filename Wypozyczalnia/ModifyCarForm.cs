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
            this.ClearControls();

            /*
             * Sprawdz poprawnosc wpisanego numeru VIN i jesli jest poprawny oraz istnieje w bazie to wczytaj dane samochodu do kontrolek
             */
            if (this.searchVINTextBox.Text.Trim().Length == 0 && this.searchLicensePlateNumberTextBox.Text.Trim().Length == 0)
            {
                ShowWarning("Podaj numer VIN lub numer rejestracyjny samochodu!");
            }
            else if (this.searchVINTextBox.Text.Trim().Length > 0)
            {
                Dictionary<Boolean, string> VINValidationResult = Helpers.ValidateVINNumber(this.searchVINTextBox.Text.Trim());

                if (VINValidationResult.Keys.Contains(false))
                {
                    this.ShowWarning(VINValidationResult[false]);
                }
                else if (!Helpers.IsVINPresent(this.searchVINTextBox.Text.Trim()))
                {
                    this.ShowWarning("Podany numer VIN nie istnieje w bazie!");
                }
                else if (VINValidationResult.Keys.Contains(true) && Helpers.IsVINPresent(this.searchVINTextBox.Text.Trim()))
                {
                    LoadData("VIN", this.searchVINTextBox.Text.Trim());
                }
            }

            /*
             * Sprawdz poprawnosc wpisanego numeru rejestracyjnego i jesli jest poprawny oraz istnieje w bazie to wczytaj dane samochodu do kontrolek
             */
            else if (this.searchLicensePlateNumberTextBox.Text.Trim().Length > 0)
            {
                Dictionary<Boolean, string> licensePlateNumValidationResult = Helpers.ValidateLicensePlatenumber(this.searchLicensePlateNumberTextBox.Text.Trim());

                if (licensePlateNumValidationResult.Keys.Contains(false))
                {
                    this.ShowWarning(licensePlateNumValidationResult[false]);
                }
                else if (!Helpers.IsLicensePlateNumberPresent(this.searchLicensePlateNumberTextBox.Text.Trim()))
                {
                    this.ShowWarning("Podany numer rejestracyjny nie istnieje w bazie!");
                }
                else if (licensePlateNumValidationResult.Keys.Contains(true) && Helpers.IsLicensePlateNumberPresent(this.searchLicensePlateNumberTextBox.Text.Trim()))
                {
                    LoadData("[Numer rejestracyjny]", this.searchLicensePlateNumberTextBox.Text.Trim());
                }
            }
        }

        /*
         * Wypelnia kontrolki danymi wyszukanego samochodu
         */
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
                    this.productionDateDateTimePicker.Value = DateTime.Parse(table.Rows[0].Field<DateTime>("Rok produkcji").ToString());

                    this.categoryComboBox.SelectedIndex = (int)Enum.Parse(typeof(EnumCategory), table.Rows[0].Field<string>("Klasa"));
                    this.driveTypeComboBox.SelectedIndex = (int)Enum.Parse(typeof(EnumDriveType), table.Rows[0].Field<string>("Rodzaj napędu"));
                    this.engineComboBox.SelectedIndex = (int)Enum.Parse(typeof(EnumEngineType), table.Rows[0].Field<string>("Silnik"));
                    this.gearboxComboBox.SelectedIndex = (int)Enum.Parse(typeof(EnumGearboxType), table.Rows[0].Field<string>("Skrzynia biegów"));

                    this.costTextBox.Text = table.Rows[0].Field<decimal>("Koszt wynajęcia").ToString();
                    this.licensePlateNumberTextBox.Text = table.Rows[0].Field<string>("Numer rejestracyjny");
                    this.manufacturerTextBox.Text = table.Rows[0].Field<string>("Marka");
                    this.modelTextBox.Text = table.Rows[0].Field<string>("Model");
                    this.VINTextBox.Text = table.Rows[0].Field<string>("VIN");

                    this.saveButton.Enabled = true;
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

        private void ShowSuccessInfo(string errorMsg)
        {
            string caption = "Operacja udana";
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

        private void ClearControls()
        {
            this.productionDateDateTimePicker.Value = DateTime.Now;

            this.categoryComboBox.SelectedIndex = -1;
            this.driveTypeComboBox.SelectedIndex = -1;
            this.engineComboBox.SelectedIndex = -1;
            this.gearboxComboBox.SelectedIndex = -1;

            this.costTextBox.Text = String.Empty;
            this.licensePlateNumberTextBox.Text = String.Empty;
            this.manufacturerTextBox.Text = String.Empty;
            this.modelTextBox.Text = String.Empty;
            this.VINTextBox.Text = String.Empty;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Dictionary<Boolean, string> validationResult = this.ValidateForm();

            if (validationResult.Keys.Contains(false))
            {
                this.ShowWarning(validationResult[false]);
            }
            else if (validationResult.Keys.Contains(true))
            {
                this.UpdateCar();
            }
        }

        private Dictionary<Boolean, string> ValidateForm()
        {
            Dictionary<Boolean, string> validationResult = new Dictionary<Boolean, string>();
            Boolean valid = true;
            String errorMsg = "";

            /*
             * walidacja powodu modyfikacji
             */
            if (String.IsNullOrWhiteSpace(this.modificationReasonTextBox.Text))
            {
                valid = false;
                errorMsg += "Podaj powód modyfikacji!";
            }

            /*
             * walidacja daty produkcji
             */
            if (this.productionDateDateTimePicker.Value > DateTime.Now)
            {
                valid = false;
                errorMsg += "Podana data jest nieprawidłowa!";
            }

            /*
             * walidacja numeru rejestracyjnego
             */
            if (Helpers.ValidateLicensePlatenumber(this.licensePlateNumberTextBox.Text.Trim()).Keys.Contains(false))
            {
                valid = false;
                errorMsg += Helpers.ValidateLicensePlatenumber(this.licensePlateNumberTextBox.Text.Trim())[false];
            }

            /*
             * walidacja VIN
             */
            if (Helpers.ValidateVINNumber(this.VINTextBox.Text.Trim()).Keys.Contains(false))
            {
                valid = false;
                errorMsg += Helpers.ValidateVINNumber(this.VINTextBox.Text.Trim())[false];
            }

            // Dopisac metody do validacji pozostalych kontrolek
            validationResult.Add(valid, errorMsg);
            return validationResult;
        }

        private void UpdateCar()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Helpers.connectionString;
                sqlConnection.Open();

                string param = String.Empty;
                string paramValue = String.Empty;
                string id = String.Empty;

                if (!String.IsNullOrWhiteSpace(this.searchVINTextBox.Text))
                {
                    param = "VIN";
                    paramValue = "'" + this.searchVINTextBox.Text.Trim() + "'";
                }
                else if (!String.IsNullOrWhiteSpace(this.searchLicensePlateNumberTextBox.Text))
                {
                    param = "[Numer rejestracyjny]";
                    paramValue = "'" + this.searchLicensePlateNumberTextBox.Text.Trim() + "'";
                }

                SqlCommand subQuery = new SqlCommand($"SELECT Id FROM samochody where {param} = {paramValue}", sqlConnection);
                try
                {
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(subQuery);
                    DataTable dataTable = new DataTable();
                    sqlAdapter.Fill(dataTable);
                    id = dataTable.Rows[0]["Id"].ToString();
                }
                catch (Exception)
                {

                    throw;
                }

                SqlCommand command = new SqlCommand($"UPDATE samochody SET Klasa = @category, " +
                                                                        $"Marka = @manufacturer, " +
                                                                        $"Model = @model, " +
                                                                        $"[Rok produkcji] = @date, " +
                                                                        $"[Rodzaj napędu] = @driveType, " +
                                                                        $"[Skrzynia biegów] = @gearbox, " +
                                                                        $"Silnik = @engine, " +
                                                                        $"[Koszt wynajęcia] = @cost, " +
                                                                        $"VIN = @vin, " +
                                                                        $"[Numer rejestracyjny] = @licensePlateNum " +
                                                                        $"WHERE Id = @id", sqlConnection);

                command.Parameters.Add(new SqlParameter("category", this.categoryComboBox.Text.Trim()));
                command.Parameters.Add(new SqlParameter("manufacturer", this.manufacturerTextBox.Text.Trim()));
                command.Parameters.Add(new SqlParameter("model", this.modelTextBox.Text.Trim()));
                command.Parameters.Add(new SqlParameter("date", this.productionDateDateTimePicker.Value.ToString("yyyy-MM-dd")));
                command.Parameters.Add(new SqlParameter("driveType", this.driveTypeComboBox.Text.Trim()));
                command.Parameters.Add(new SqlParameter("gearbox", this.gearboxComboBox.Text.Trim()));
                command.Parameters.Add(new SqlParameter("engine", this.engineComboBox.Text.Trim()));
                command.Parameters.Add(new SqlParameter("cost", SqlDbType.Decimal)
                {
                    Precision = 18,
                    Scale = 2
                }).Value = this.costTextBox.Text.Trim();
                command.Parameters.Add(new SqlParameter("vin", this.VINTextBox.Text.Trim()));
                command.Parameters.Add(new SqlParameter("licensePlateNum", this.licensePlateNumberTextBox.Text.Trim()));
                command.Parameters.Add(new SqlParameter("id", id));

                try
                {
                    command.ExecuteNonQuery();
                    this.ShowSuccessInfo("Dane samochodu zostały zmodyfikowane!");
                    this.saveButton.Enabled = false;
                }
                catch (Exception exp)
                {

                    throw;
                }
            }
        }
    }
}
