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
    public partial class MainWindowForm : Form, IShowCars
    {
        public CheckedListBox.CheckedItemCollection CategoryText => categoryCheckedListBox.CheckedItems;

        public string CostTextFrom => costFromTextBox.Text;

        public string CostTextTo => costToTextBox.Text;

        public CheckedListBox.CheckedItemCollection DriveTypeText => driveTypeCheckedListBox.CheckedItems;

        public CheckedListBox.CheckedItemCollection EngineText => engineCheckedListBox.CheckedItems;

        public string GearboxText => gearboxRadioButton1.Checked ? gearboxRadioButton1.Text : (gearboxRadioButton2.Checked ? gearboxRadioButton2.Text : ($"('{gearboxRadioButton1.Text}', '{gearboxRadioButton2.Text}')"));

        public CheckedListBox.CheckedItemCollection ManufacturerText => manufacturerCheckedListBox.CheckedItems;

        public CheckedListBox.CheckedItemCollection ModelText => modelCheckedListBox.CheckedItems;

        public DateTime ProductionDateFrom => productionDateFrom.Value;

        public DateTime ProductionDateTo => productionDateTo.Value;

        public DataTable AllAvailableCars { set => availableCarsDataGridView.DataSource = value; }

        public DataTable SearchedAvailableCars { set => searchedAvailableCarsDataGridView.DataSource = value; }

        public DataTable AllCars { set => allCarsDataGridView.DataSource = value; }

        public CheckedListBox CategoryCheckedListBox
        {
            get
            {
                return this.categoryCheckedListBox;
            }
            set { }
        }

        public CheckedListBox DriveTypeCheckedListBox
        {
            get
            {
                return this.driveTypeCheckedListBox;
            }
            set { }
        }

        public CheckedListBox EngineCheckedListBox
        {
            get
            {
                return this.engineCheckedListBox;
            }
            set { }
        }

        public CheckedListBox ManufacturerCheckedListBox
        {
            get
            {
                return this.manufacturerCheckedListBox;
            }
            set { }
        }

        public CheckedListBox ModelCheckedListBox
        {
            get
            {
                return this.modelCheckedListBox;
            }
            set { }
        }

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void PokazSamochodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showCarsPanel.Visible = true;
            this.searchCarsPanel.Visible = false;

            SearchCarPresenter presenter = new SearchCarPresenter(this);
            presenter.SearchAllCars();
        }

        private void WypozyczSamochodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.searchCarsPanel.Visible = true;
            this.showCarsPanel.Visible = false;

            SearchCarPresenter presenter = new SearchCarPresenter(this);
            presenter.SearchAllAvailableCars();
            presenter.FillCheckedListBoxes();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypozyczalniaDataSet.Samochody' table. You can move, or remove it, as needed.
            //this.samochodyTableAdapter.Fill(this.wypozyczalniaDataSet.Samochody);

        }

        private void availableCarsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowRentCarForm(sender, e);
        }

        private void DodajSamochodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addNewCarForm = new AddNewCarForm();
            addNewCarForm.ShowDialog();
        }

        private void EdytujSamochodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form modifyCarForm = new ModifyCarForm();
            modifyCarForm.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchCarPresenter searchCarPresenter = new SearchCarPresenter(this);
            searchCarPresenter.SearchAvailableCarsByCriteria(CategoryText, ManufacturerText, ModelText, DriveTypeText, EngineText, ProductionDateFrom, ProductionDateTo, CostTextFrom, CostTextTo, GearboxText);
        }

        private void searchedAvailableCarsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowRentCarForm(sender, e);
        }

        private void ShowRentCarForm(object sender, DataGridViewCellEventArgs e)
        {
            Form rentCarForm = new RentForm(sender, e);
            rentCarForm. ShowDialog();

        }
    }
}
