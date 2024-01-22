using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;


namespace BUS_RESERVATION_SYSTEM
{
    public partial class Busses : Form
    {
        Functions myFunctionBus;
        private DataSet yourDataSet = new DataSet();
        public Busses()
        {
            InitializeComponent();
            myFunctionBus = new Functions();
        }

        private void Busses_Load_1(object sender, EventArgs e)
        {
            ShowBusses();
            BusListGridView.CellClick += BusListGridView_CellContentClick_1;
        }

        private void ShowBusses()
        {
            try
            {
                string Query = "select * from busTbl";
                // Assuming GetData returns a DataTable
                DataTable bussesData = myFunctionBus.GetData(Query);

                BusListGridView.DataSource = bussesData;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // The logic below is used to  update the content of the textboxes based on any cell that user selects from DataGridView
        // this is applied to make it easier and quicker to update data stored in data base:
        
        int Key = 0; //The variable Key is used to store the "BusID" of the selected row from the TripsListGridView DataGridView.
        private void BusListGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BusTourNameTxtbx.Text = BusListGridView.SelectedRows[0].Cells["TourName"].Value.ToString();
            BusManufacturerTxtbx.Text = BusListGridView.SelectedRows[0].Cells["Manufacturer"].Value.ToString();
            BusCapacityTxtbx.Text = BusListGridView.SelectedRows[0].Cells["Capacity"].Value.ToString();

            if (BusListGridView.SelectedRows[0].Cells["BusID"].Value == null || BusListGridView.SelectedRows[0].Cells["BusID"].Value == DBNull.Value)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BusListGridView.SelectedRows[0].Cells["BusID"].Value.ToString());
            }
        }

        

        private void AddBusBtn_Click_1(object sender, EventArgs e)
        {
            if (BusTourNameTxtbx.Text == "" || BusManufacturerTxtbx.Text == "" || BusCapacityTxtbx.Text == "")
            {
                MessageBox.Show("Missing info!");
            }
            else
            {
                try
                {
                    string TourName = BusTourNameTxtbx.Text;
                    string Manufacturer = BusManufacturerTxtbx.Text;
                    int Capacity = int.Parse(BusCapacityTxtbx.Text);

                    //Using parameterized queries is a best practice for security and helps prevent SQL injection attacks.
                    string Query = "INSERT INTO busTbl (TourName, Manufacturer, Capacity) VALUES (@p0, @p1, @p2)";

                    List<object> parameters = new List<object> { TourName, Manufacturer, Capacity };
                    myFunctionBus.SetData(Query, parameters);

                    BusTourNameTxtbx.Text = "";
                    BusManufacturerTxtbx.Text = "";
                    BusCapacityTxtbx.Text = "";

                    // Optionally, we can add a success message or perform other actions after the insert
                    MessageBox.Show("Record inserted successfully!");

                    // Refresh the grid view to show updated data
                    ShowBusses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void EditBusBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Checks if any required field is empty
                if (BusTourNameTxtbx.Text == "" || BusManufacturerTxtbx.Text == "" || BusCapacityTxtbx.Text == "")
                {
                    MessageBox.Show("Missing Info!");
                    return;
                }

                string TourName = BusTourNameTxtbx.Text;
                string Manufacturer = BusManufacturerTxtbx.Text;
                int Capacity = int.Parse(BusCapacityTxtbx.Text);

                // Retrieves BusID from the selected row in the DataGridView
                int BusID = Convert.ToInt32(BusListGridView.SelectedRows[0].Cells["BusID"].Value);

                string Query = "UPDATE busTbl SET TourName = @p0, Manufacturer = @p1, Capacity = @p2 WHERE BusID = @p3";

                List<object> parameters = new List<object> { TourName, Manufacturer, Capacity, BusID };
                myFunctionBus.SetData(Query, parameters);

                BusTourNameTxtbx.Text = "";
                BusManufacturerTxtbx.Text = "";
                BusCapacityTxtbx.Text = "";

                // Optionally, we can add a success message or perform other actions after the update
                MessageBox.Show("Record updated successfully!");

                // Refresh the grid view to show updated data
                ShowBusses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBusBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Checks if a row is selected in the grid view
                if (BusListGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.");
                }
                else
                {
                    // Retrieves BusID from the selected row in the DataGridView
                    int BusID = Convert.ToInt32(BusListGridView.SelectedRows[0].Cells["BusID"].Value);

                    // Constructing the DELETE query
                    string Query = "DELETE FROM busTbl WHERE BusID = @p0";

                    // Uses the Functions class to execute the delete query
                    List<object> parameters = new List<object> { BusID };
                    myFunctionBus.SetData(Query, parameters);

                    BusTourNameTxtbx.Text = "";
                    BusManufacturerTxtbx.Text = "";
                    BusCapacityTxtbx.Text = "";

                    // Optionally, we can add a success message or perform other actions after the delete
                    MessageBox.Show("Record deleted successfully!");

                    // Refreshs the grid view to show updated data
                    ShowBusses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MenuTripsLbl_Click(object sender, EventArgs e)
        {
            try
            {
                Trips trips = new Trips();
                trips.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Passengers form: {ex.Message}");
            }
        }

        private void MenuPassengersLbl_Click_1(object sender, EventArgs e)
        {
            try
            {
                Passengers passengers = new Passengers();
                passengers.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Passengers form: {ex.Message}");
            }
        }

        private void MenuDriversLbl_Click_1(object sender, EventArgs e)
        {
            try
            {
                Drivers drivers = new Drivers();
                drivers.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Drivers form: {ex.Message}");
            }
        }

        private void ProfileIcon_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Login login = new Login();
                this.Close();
                login.Show();
            }
        }
    }
}