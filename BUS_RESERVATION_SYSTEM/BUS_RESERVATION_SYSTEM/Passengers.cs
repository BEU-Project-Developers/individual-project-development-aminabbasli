using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace BUS_RESERVATION_SYSTEM
{
    public partial class Passengers : Form
    {
        Functions myFunctionPassenger;  // defining the object of Functions class:
        private DataSet yourDataSet = new DataSet();

        public Passengers()
        {
            InitializeComponent();

            // Initializing Functions class:
            myFunctionPassenger = new Functions();
        }

        private void Passengers_Load(object sender, EventArgs e)
        {
            ShowPassengers();
            PassengersListGridView.CellClick += PassengersListGridView_CellContentClick;//Subscribes the PassengersListGridView_CellContentClick method -
                                                                                        // - to the CellClick event of the PassengersListGridView DataGridView.
        }


        private void ShowPassengers()
        {
            try
            {
                string Query = "select * from passengerTbl";
                DataTable PassengerData = myFunctionPassenger.GetData(Query); // Assuming GetData returns a DataTable
                PassengersListGridView.DataSource = PassengerData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // The logic below is used to  update the content of the textboxes based on any cell that user selects from DataGridView
        // this is applied to make it easier and quicker to update data stored in data base:
       
        int Key = 0; //The variable Key is used to store the "PassID" of the selected row from the TripsListGridView DataGridView.
        private void PassengersListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {    
             PassNameTxtbx.Text = PassengersListGridView.SelectedRows[0].Cells["PassName"].Value.ToString();
             PassSurnameTxbx.Text = PassengersListGridView.SelectedRows[0].Cells["PassSurname"].Value.ToString();
             PassPhoneTxtbx.Text = PassengersListGridView.SelectedRows[0].Cells["PassPhone"].Value.ToString();
             PassTripIDTxbx.Text = PassengersListGridView.SelectedRows[0].Cells["PassTripID"].Value.ToString();

            //When updating or deleting a specific trip record, having the "PassID" allows the application to identify the exact record in the database.
            // Thats why we use 'Key' value as a reference to the unique identifier of the selected trip 
            if (PassengersListGridView.SelectedRows[0].Cells["PassID"].Value == null || PassengersListGridView.SelectedRows[0].Cells["PassID"].Value == DBNull.Value)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PassengersListGridView.SelectedRows[0].Cells["PassID"].Value.ToString());
            }
        }


        private void AddPassengerBtn_Click(object sender, EventArgs e)
        {
            // Checks if any required field is empty, because Name , Surname and Phone cannot contain null value 
            if (PassNameTxtbx.Text == "" || PassSurnameTxbx.Text == "" || PassPhoneTxtbx.Text == "")
            {
                MessageBox.Show("Missing info!");
            }
            else
            {
                try
                {
                    // here the values of textboxes and datetimepicker are initialized to parameters which will be used in query:
                    string PassName = PassNameTxtbx.Text;
                    string PassSurname = PassSurnameTxbx.Text;
                    string PassPhone = PassPhoneTxtbx.Text;
                    int PassTripID = int.Parse(PassTripIDTxbx.Text);

                    //Using parameterized queries is a best practice for security and helps prevent SQL injection attacks.
                    string Query = "INSERT INTO passengerTbl (PassName, PassSurname, PassPhone, PassTripID) VALUES (@p0, @p1, @p2, @p3)";


                    // A list of parameters is created to pass values to the query in a parameterized manner,
                    // ,it is good for code readability and maintainability:
                    List<object> parameters = new List<object> { PassName, PassSurname, PassPhone, PassTripID };
                    myFunctionPassenger.SetData(Query, parameters);

                    PassNameTxtbx.Text = "";
                    PassSurnameTxbx.Text = "";
                    PassPhoneTxtbx.Text = "";
                    PassTripIDTxbx.Text = "";

                    // Optionally, we can add a success message or perform other actions after the insert
                    MessageBox.Show("Record inserted successfully!");

                    // Refresh the grid view to show updated data
                    ShowPassengers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditPassengerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if any required field is empty, because Name , Surname and Phone cannot contain null value 
                if (PassNameTxtbx.Text == "" || PassSurnameTxbx.Text == "" || PassPhoneTxtbx.Text == "")
                {
                    MessageBox.Show("Missing Info!");
                    return;
                }

                // here the values of textboxes and datetimepicker are initialized to parameters which will be used in query:
                string PassName = PassNameTxtbx.Text;
                string PassSurname = PassSurnameTxbx.Text;
                string PassPhone = PassPhoneTxtbx.Text;
                int PassTripID = int.Parse(PassTripIDTxbx.Text);

                // Retrieves TripID from the selected row in the DataGridView in order to edit the data based on its identifier:
                int PassID = Convert.ToInt32(PassengersListGridView.SelectedRows[0].Cells["PassID"].Value);

                string Query = "UPDATE passengerTbl SET PassName = @p0, PassSurname = @p1, PassPhone = @p2 , PassTripID = @p3 WHERE PassID = @p4";


                // A list of parameters is created to pass values to the query in a parameterized manner,
                // ,it is good for code readability and maintainability:
                List<object> parameters = new List<object> { PassName, PassSurname, PassPhone, PassTripID, PassID };
                myFunctionPassenger.SetData(Query, parameters);



                PassNameTxtbx.Text = "";
                PassSurnameTxbx.Text = "";
                PassPhoneTxtbx.Text = "";
                PassTripIDTxbx.Text = "";

                // Optionally, we can add a success message or perform other actions after the update
                MessageBox.Show("Record updated successfully!");

                // Refresh the grid view to show updated data
                ShowPassengers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletePassengerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if a row is selected in the grid view
                if (PassengersListGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.");
                }
                else
                {
                    // Retrieves BusID from the selected row in the DataGridView
                    int PassID = Convert.ToInt32(PassengersListGridView.SelectedRows[0].Cells["PassID"].Value);

                    // Constructing the DELETE query
                    string Query = "DELETE FROM passengerTbl WHERE PassID = @p0";

                    // Uses the Functions class to execute the delete query
                    List<object> parameters = new List<object> { PassID };
                    myFunctionPassenger.SetData(Query, parameters);

                    PassNameTxtbx.Text = "";
                    PassSurnameTxbx.Text = "";
                    PassPhoneTxtbx.Text = "";
                    PassTripIDTxbx.Text = "";

                    // Optionally, we can add a success message or perform other actions after the delete
                    MessageBox.Show("Record deleted successfully!");

                    // Refreshs the grid view to show updated data
                    ShowPassengers();
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
                this.Close();  //This method closes the current form, frees up its resources and reduces memory consumption.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Passengers form: {ex.Message}");
            }
        }

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

        private void MenuDriversLbl_Click(object sender, EventArgs e)
        {
            try
            {
                Drivers drivers = new Drivers();
                drivers.Show();
                this.Close();  //This method closes the current form, frees up its resources and reduces memory consumption.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Drivers form: {ex.Message}");
            }
        }


        // Here I provided a logic for logging out the current form and turning back to login form when clicking on the top-left 'Profile' icon:
        private void ProfileIcon_Click(object sender, EventArgs e)
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
