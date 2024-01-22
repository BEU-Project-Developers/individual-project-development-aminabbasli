using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using static System.Windows.Forms.AxHost;

namespace BUS_RESERVATION_SYSTEM
{
    public partial class Trips : Form
    {
        Functions myFunctionTrip;  // defining the object of Functions class:
        private DataSet yourDataSet = new DataSet(); 

        public Trips()  // constructor 
        {
            InitializeComponent();

            //If 'tripsTbl' table doesn't exist, attempting to bind data to it would result in an error:
            if (yourDataSet != null && yourDataSet.Tables["tripsTbl"] != null)
            {
                DateTime defaultDate = DateTime.Now; //inintializes defaultDate object with current date

                //Binds the "Value" property of the TripsDate control to the "Date" column in the "tripsTbl" table of yourDataSet
                //DataSourceUpdateMode.OnValidation indicates that the data source is updated when the control loses focus or when validation is explicitly called.
                TripsDate.DataBindings.Add("Value", yourDataSet.Tables["tripsTbl"], "Date", true, DataSourceUpdateMode.OnValidation, defaultDate);  //The defaultDate parameter specifies the default value for the TripsDate control.
            }

            // Initializing Functions class:
            myFunctionTrip = new Functions();
        }


        private void Trips_Load(object sender, EventArgs e)
        {
            ShowTrips();
            TripsListGridView.CellClick += TripsListGridView_CellContentClick; //Subscribes the TripsListGridView_CellContentClick method -
                                                                               // - to the CellClick event of the TripsListGridView DataGridView.

        }


        private void ShowTrips()
        {
            try
            {
                string Query = "select * from tripsTbl";

                // Assuming GetData returns a DataTable, calls that method to retrieve data based on the provided SQL query:
                DataTable tripsData = myFunctionTrip.GetData(Query);

                //This associates the data from the DataTable with the DataGridView, effectively displaying the query results in the grid:
                TripsListGridView.DataSource = tripsData;
            }
            catch (Exception ex)
            {
                //This is a way to provide feedback to the user about any issues encountered while attempting to fetch and display the trip data:
                MessageBox.Show(ex.Message);
            }

        }


        
        // The logic below is used to  update the content of the textboxes based on any cell that user selects from DataGridView
        // this is applied to make it easier and quicker to update data stored in data base:
        
        int Key = 0; //The variable Key is used to store the "TripID" of the selected row from the TripsListGridView DataGridView.
        private void TripsListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TripRouteTxbx.Text = TripsListGridView.SelectedRows[0].Cells["Route"].Value.ToString();
            TripPriceTxbx.Text = TripsListGridView.SelectedRows[0].Cells["Price"].Value.ToString();
            TripsDate.Value = (DateTime)TripsListGridView.SelectedRows[0].Cells["Date"].Value;
            TripTourNameTxbx.Text = TripsListGridView.SelectedRows[0].Cells["TourName"].Value.ToString();


            //When updating or deleting a specific trip record, having the "TripID" allows the application to identify the exact record in the database.
            // Thats why we use 'Key' value as a reference to the unique identifier of the selected trip 
            if (TripsListGridView.SelectedRows[0].Cells["TripID"].Value == null || TripsListGridView.SelectedRows[0].Cells["TripID"].Value == DBNull.Value)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TripsListGridView.SelectedRows[0].Cells["TripID"].Value.ToString());
            }
        }


        private void TripAddBtn_Click(object sender, EventArgs e)
        {
            if (TripPriceTxbx.Text == "" || TripRouteTxbx.Text == "") //because the Price and Route columns cannot be null
            {
                MessageBox.Show("Missing Info!");
            }
            else
            {
                try // it is safe to write the logic using try/catch blocks
                {
                    // here the values of textboxes and datetimepicker are initialized to parameters which will be used in query:
                    decimal Price = decimal.Parse(TripPriceTxbx.Text); 
                    string Route = TripRouteTxbx.Text;
                    DateTime Date = TripsDate.Value;
                    string TourName = TripTourNameTxbx.Text;

                    string Query = "INSERT INTO tripsTbl (Route, Price, Date, TourName) VALUES (@p0, @p1, @p2, @p3)";

                    // A list of parameters is created to pass values to the query in a parameterized manner,
                    // ,it is good for code readability and maintainability:
                    List<object> parameters = new List<object> { Route, Price, Date, TourName };

                    
                    myFunctionTrip.SetData(Query, parameters);

                    // it will be 
                    TripPriceTxbx.Text = "";
                    TripRouteTxbx.Text = "";
                    TripTourNameTxbx.Text = "";

                    MessageBox.Show("Record inserted successfully!");

                    // Refreshs the grid view to show updated data
                    ShowTrips();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TripEditBtn_Click(object sender, EventArgs e)
        {
            if (TripPriceTxbx.Text == "" || TripRouteTxbx.Text == "") //because the Price and Route columns cannot be null
            {
                MessageBox.Show("Missing Info!");
            }
            else
            {
                try
                {
                    // here the values of textboxes and datetimepicker are initialized to parameters which will be used in query:
                    decimal Price = decimal.Parse(TripPriceTxbx.Text);
                    string Route = TripRouteTxbx.Text;
                    DateTime Date = TripsDate.Value;
                    string TourName = TripTourNameTxbx.Text;

                    // Retrieves TripID from the selected row in the DataGridView in order to edit the data based on its identifier:
                    int TripID = Convert.ToInt32(TripsListGridView.SelectedRows[0].Cells["TripID"].Value);

                    string Query = "UPDATE tripsTbl SET Route = @p1, Price = @p2, Date = @p3, TourName = @p4 WHERE TripID = @p0";

                    // A list of parameters is created to pass values to the query in a parameterized manner,
                    // ,it is good for code readability and maintainability:
                    List<object> parameters = new List<object> { TripID, Route, Price, Date, TourName };
                    myFunctionTrip.SetData(Query, parameters);

                    TripPriceTxbx.Text = "";
                    TripRouteTxbx.Text = "";
                    TripTourNameTxbx.Text = "";

                    // Optionally, we can add a success message or perform other actions after the update
                    MessageBox.Show("Record updated successfully!");
                    // Refresh the grid view to show updated data
                    ShowTrips();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void TripDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if a row is selected in the grid view
                if (TripsListGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.");
                }
                else
                {
                    // Retrieves TripID from the selected row in the DataGridView
                    int TripID = Convert.ToInt32(TripsListGridView.SelectedRows[0].Cells["TripID"].Value);

                    // Constructing the DELETE query
                    string Query = "DELETE FROM tripsTbl WHERE TripID = @p0";

                    List<object> parameters = new List<object> { TripID };
                    myFunctionTrip.SetData(Query, parameters);

                    TripPriceTxbx.Text = "";
                    TripRouteTxbx.Text = "";
                    TripTourNameTxbx.Text = "";

                    // Optionally, we can add a success message or perform other actions after the delete
                    MessageBox.Show("Record deleted successfully!");

                    // Refreshs the grid view to show updated data
                    ShowTrips();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // Below code blocks provide to navigate among the forms:

        // Using try/catch is  good practice when performing operations that might throw exceptions.
        //It helps to handle unexpected errors and provides a more user-friendly experience by displaying a meaningful error message.
        private void MenuBussesLbl_Click(object sender, EventArgs e)
        {
            try 
            {
                Busses busses = new Busses();
                busses.Show();
                this.Close();  //This method closes the current form, frees up its resources and reduces memory consumption.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Busses form: {ex.Message}");
            }
        }

        private void MenuPassengersLbl_Click(object sender, EventArgs e)
        {
            try
            {
                Passengers passengers = new Passengers();
                passengers.Show();
                this.Close(); //This method closes the current form, frees up its resources and reduces memory consumption.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Passengers form: {ex.Message}");
            }
        }

        private void MenuDriversLbl_Click(object sender, EventArgs e)
        {
            try
            {
                Drivers drivers = new Drivers();
                drivers.Show();
                this.Close(); //This method closes the current form, frees up its resources and reduces memory consumption.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Drivers form: {ex.Message}");
            }
        }

        
        // Here I provided a logic for logging out the current form and turning back to login form when clicking on the top-left 'Profile' icon:
        private void ProfileIcon_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Login login = new Login();
                this.Close();  //This method closes the current form, frees up its resources and reduces memory consumption.
                login.Show();
            }
        }
    }
}