using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Models;
using Wypozyczalnia.Presenters;

namespace Wypozyczalnia.Views
{
    public partial class RentForm : Form, IRentCar
    {
        public RentForm(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();
            this.FillData(sender, e);
            this.CalculateTotalCost();
        }

        public RentForm(Rent rent)
        {
            InitializeComponent();
            RentCarPresenter rentCarPresenter = new RentCarPresenter(this);
            rentCarPresenter.FillRentData(rent);
            this.PrepareControlsForReturnForm();
        }

        private void PrepareControlsForReturnForm()
        {
            this.nameTextBox.Enabled = false;
            this.surnameTextBox.Enabled = false;
            this.licenseTextBox.Enabled = false;
            this.endDateTimePicker.Enabled = false;
            this.startDateTimePicker.Enabled = false;
            this.acceptButton.Enabled = false;
            this.paidCheckBox.Visible = true;
            this.Text = "Obierz samochód";
        }

        public string ClientName { get => this.nameTextBox.Text; set => this.nameTextBox.Text = value; }

        public string ClientSurname { get => this.surnameTextBox.Text; set => this.surnameTextBox.Text = value; }

        public string LicenseNumber { get => this.licenseTextBox.Text; set => this.licenseTextBox.Text = value; }

        public DateTime DateStart { get => this.startDateTimePicker.Value; set => this.startDateTimePicker.Value = value; }

        public DateTime DateEnd { get => this.endDateTimePicker.Value; set => this.endDateTimePicker.Value = value; }

        public decimal TotalCost { get => decimal.Parse(this.totalCostLabel.Text); set => totalCostLabel.Text = value.ToString(); }

        public string Manufacturer { get => this.manufacturerTextBox.Text; set => this.manufacturerTextBox.Text = value; }
        public string Model { get => this.modelTextBox.Text; set => this.modelTextBox.Text = value; }
        public string Engine { get => this.engineTextBox.Text; set => this.engineTextBox.Text = value; }
        public string LicensePlateNumber { get => this.licensePlateNumberTextBox.Text; set => this.licensePlateNumberTextBox.Text = value; }
        public string Cost { get => this.costTextBox.Text; set => this.costTextBox.Text = value; }

        private void FillData(object sender, DataGridViewCellEventArgs e)
        {
            RentCarPresenter presenter = new RentCarPresenter(this);
            presenter.FillForm(sender, e);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region StartEndDate
        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateTotalCost();
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            RentCarPresenter rentCarPresenter = new RentCarPresenter(this);
            rentCarPresenter.CalculateTotalCost();
        }
        #endregion

        #region Dialogs
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
        #endregion

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            RentCarPresenter rentCarPresenter = new RentCarPresenter(this);

            if (this.paidCheckBox.Visible && this.paidCheckBox.Checked)
            {
                rentCarPresenter.ReturnCar();
                this.ShowSuccessInfo("Samochód został zwrócony!");
                this.acceptButton.Enabled = false;
            }
            else
            {
                if (rentCarPresenter.ValidateDates().Keys.Contains(false))
                {
                    this.ShowWarning(rentCarPresenter.ValidateDates()[false]);
                }
                else if (rentCarPresenter.ValidateDates().Keys.Contains(true))
                {
                    if (rentCarPresenter.ValidateClientData().Keys.Contains(false))
                    {
                        this.ShowWarning(rentCarPresenter.ValidateClientData()[false]);
                    }
                    else if (rentCarPresenter.ValidateClientData().Keys.Contains(true))
                    {
                        if (rentCarPresenter.AddNewRent())
                        {
                            this.ShowSuccessInfo("Samochód został wypożyczony!");
                            this.acceptButton.Enabled = false;
                        }
                        else
                        {
                            this.ShowWarning("Coś poszło nie tak! Spróbuj ponownie.");
                        }
                    }
                }
            }
        }

        private void paidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.paidCheckBox.Checked)
            {
                this.acceptButton.Enabled = true;
            }
            else if (!this.paidCheckBox.Checked)
            {
                this.acceptButton.Enabled = false;
            }
        }
    }
}
