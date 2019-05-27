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
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void pokazSamochodyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.showCarsPanel.Visible = true;
            this.searchCarsPanel.Visible = false;

        }

        private void wypozyczSamochodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.searchCarsPanel.Visible = true;
            this.showCarsPanel.Visible = false;

            this.fillAllCheckedListBoxes();
            this.availableCarsDataGridView.DataSource = this.findAvailableCars();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypozyczalniaDataSet.Samochody' table. You can move, or remove it, as needed.
            //this.samochodyTableAdapter.Fill(this.wypozyczalniaDataSet.Samochody);

        }

        private void fillAllCheckedListBoxes()
        {
            this.fillCheckedListBox("marka");
            this.fillCheckedListBox("model");
        }

        private void fillCheckedListBox(string param)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-ESRM8PV;
                                                                database=Wypozyczalnia;
                                                                User id=admin;
                                                                Password=admin;");
                SqlCommand cmd = new SqlCommand($"select distinct {param} from samochody order by {param} asc", sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (param.Equals("marka"))
                    {
                        this.manufacturerCheckedListBox.Items.Add(dt.Rows[i][$"{param}"].ToString());
                    } else if (param.Equals("model"))
                    {
                        this.modelCheckedListBox.Items.Add(dt.Rows[i][$"{param}"].ToString());
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd!");
                Console.WriteLine(exp.Message);
            }
        }

        private DataTable findAvailableCars()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data source=DESKTOP-ESRM8PV;
                                                                database=Wypozyczalnia;
                                                                User id=admin;
                                                                Password=admin;");
            SqlCommand cmd = new SqlCommand($"select * from samochody where status = 'D' order by 'Id' asc", sqlConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void advancedSearchTabPage_Click(object sender, EventArgs e)
        {

        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void availableCarsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodajSamochodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addNewCarForm = new AddNewCarForm();
            addNewCarForm.ShowDialog();
        }
    }
}
