using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Presenters;
using Wypozyczalnia.Views;

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

        public string ClientName => this.nameTextBox.Text;

        public string ClientSurname => this.surnameTextBox.Text;

        public string LicenseNumber => this.licenseTextBox.Text;

        public DateTime DateStart { get => this.startDateTimePicker.Value; set => this.startDateTimePicker.Value = value; }

        public DateTime DateEnd { get => this.endDateTimePicker.Value; set => this.endDateTimePicker.Value = value; }

        public decimal TotalCost { set => totalCostLabel.Text = value.ToString(); }

        public string Manufacturer { get => throw new NotImplementedException(); set => this.manufacturerTextBox.Text = value; }
        public string Model { get => throw new NotImplementedException(); set => this.modelTextBox.Text = value; }
        public string Engine { get => throw new NotImplementedException(); set => this.engineTextBox.Text = value; }
        public string LicensePlateNumber { get => throw new NotImplementedException(); set => this.licensePlateNumberTextBox.Text = value; }
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

            if (rentCarPresenter.ValidateDates().Keys.Contains(false))
            {
                this.ShowWarning(rentCarPresenter.ValidateDates()[false]);
            }
            else if (rentCarPresenter.ValidateDates().Keys.Contains(true))
            {
                rentCarPresenter.CalculateTotalCost();
            }
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

        private void AcceptRentButton_Click(object sender, EventArgs e)
        {
            RentCarPresenter rentCarPresenter = new RentCarPresenter(this);

            if (rentCarPresenter.ValidateClientData().Keys.Contains(false))
            {
                this.ShowWarning(rentCarPresenter.ValidateClientData()[false]);
            }
            else if (rentCarPresenter.ValidateClientData().Keys.Contains(true))
            {
                rentCarPresenter.AddNewRent();
            }
        }
    }
}
