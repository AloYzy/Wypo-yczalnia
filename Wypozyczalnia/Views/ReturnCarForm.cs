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
using Wypozyczalnia.Views;

namespace Wypozyczalnia.Views
{
    public partial class ReturnCarForm : Form, IReturnCar
    {
        public ReturnCarForm()
        {
            InitializeComponent();
        }

        public string LicenseNumber => this.licensePlateNumberTextBox.Text;

        public bool SearchPossible { set => this.searchButton.Enabled = value; }
        public Rent Rent { get; set; }

        private void LicensePlateNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ReturnCarPresenter returnCarPresenter = new ReturnCarPresenter(this);
            returnCarPresenter.checkIfSearchPossible();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ReturnCarPresenter returnCarPresenter = new ReturnCarPresenter(this);
            if (returnCarPresenter.FindRent())
            {
                RentForm rentForm = new RentForm(Rent);
                rentForm.ShowDialog();
                //this.
            }
        }
    }
}
