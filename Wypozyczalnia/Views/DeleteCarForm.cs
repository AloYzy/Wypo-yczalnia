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

namespace Wypozyczalnia.Views
{
    public partial class DeleteCarForm : Form, IDeleteCar
    {
        public DeleteCarForm()
        {
            InitializeComponent();
        }

        public string LicensePlateNumber => this.licensePlateNumberTextBox.Text;

        public string VIN => this.VINTextBox.Text;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LicensePlateNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.LicensePlateNumber.Length > 0)
            {
                this.VINTextBox.Enabled = false;
            }
            else
            {
                this.VINTextBox.Enabled = true;
            }
        }

        private void VINTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.VIN.Length > 0)
            {
                this.licensePlateNumberTextBox.Enabled = false;
            }
            else
            {
                this.licensePlateNumberTextBox.Enabled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteCarPresenter deleteFormPresenter = new DeleteCarPresenter(this);
            if (deleteFormPresenter.FindCar() && deleteFormPresenter.CanDeleteCar())
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usnąć samochód?", "UWAGA!!!", MessageBoxButtons.YesNo);

                if(dialogResult == DialogResult.Yes)
                {
                    deleteFormPresenter.DeleteCar();
                    this.ShowSuccessInfo("Samochód został usunięty!");
                }
            }
            else
            {
                this.ShowWarning("Nie znaleziono samochodu lub samochód jest obecnie wypożyczony!");
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
    }
}
