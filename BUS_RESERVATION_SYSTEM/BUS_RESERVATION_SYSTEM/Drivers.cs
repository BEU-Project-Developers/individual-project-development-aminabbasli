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
    public partial class Drivers : Form
    {
        Functions myFunctionDriver;
        private DataSet yourDataSet = new DataSet();

        public Drivers()
        {
            InitializeComponent();
            myFunctionDriver = new Functions();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            ShowDrivers();
            DrvListGridView.CellClick += DrvListGridView_CellContentClick;
        }


        private void ShowDrivers()
        {
            try
            {
                string Query = "select * from driverTbl";
                DataTable DriverData = myFunctionDriver.GetData(Query); // Assuming GetData returns a DataTable
                DrvListGridView.DataSource = DriverData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        int Key = 0;
        private void DrvListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DrvNameTxtbx.Text = DrvListGridView.SelectedRows[0].Cells["DrvName"].Value.ToString();
            DrvSurnameTxtbx.Text = DrvListGridView.SelectedRows[0].Cells["DrvSurname"].Value.ToString();
            DrvPhoneTxtbx.Text = DrvListGridView.SelectedRows[0].Cells["DrvPhone"].Value.ToString();
            DrvSalaryTxtbx.Text = DrvListGridView.SelectedRows[0].Cells["DrvSalary"].Value.ToString();


            if (DrvListGridView.SelectedRows[0].Cells["DrvID"].Value == null || DrvListGridView.SelectedRows[0].Cells["DrvID"].Value == DBNull.Value)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DrvListGridView.SelectedRows[0].Cells["DrvID"].Value.ToString());
            }

        }

        private void AddDriverBtn_Click(object sender, EventArgs e)
        {
            if (DrvNameTxtbx.Text == "" || DrvSurnameTxtbx.Text == "" || DrvPhoneTxtbx.Text == "")
            {
                MessageBox.Show("Missing info!");
            }
            else
            {
                try
                {
                    string DrvName = DrvNameTxtbx.Text;
                    string DrvSurname = DrvSurnameTxtbx.Text;
                    string DrvPhone = DrvPhoneTxtbx.Text;
                    int DrvSalary = int.Parse(DrvSalaryTxtbx.Text);

                    //Using parameterized queries is a best practice for security and helps prevent SQL injection attacks.
                    string Query = "INSERT INTO driverTbl (DrvName, DrvSurname, DrvPhone, DrvSalary) VALUES (@p0, @p1, @p2, @p3)";

                    List<object> parameters = new List<object> { DrvName, DrvSurname, DrvPhone, DrvSalary };
                    myFunctionDriver.SetData(Query, parameters);

                    DrvNameTxtbx.Text = "";
                    DrvSurnameTxtbx.Text = "";
                    DrvPhoneTxtbx.Text = "";
                    DrvSalaryTxtbx.Text = "";

                    // Optionally, we can add a success message or perform other actions after the insert
                    MessageBox.Show("Record inserted successfully!");

                    // Refresh the grid view to show updated data
                    ShowDrivers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditDriverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if any required field is empty
                if (DrvNameTxtbx.Text == "" || DrvSurnameTxtbx.Text == "" || DrvSalaryTxtbx.Text == "")
                {
                    MessageBox.Show("Missing Info!");
                    return;
                }

                string DrvName = DrvNameTxtbx.Text;
                string DrvSurname = DrvSurnameTxtbx.Text;
                string DrvPhone = DrvPhoneTxtbx.Text;
                int DrvSalary = int.Parse(DrvSalaryTxtbx.Text);

                // Retrieves BusID from the selected row in the DataGridView
                int DrvID = Convert.ToInt32(DrvListGridView.SelectedRows[0].Cells["DrvID"].Value);

                string Query = "UPDATE driverTbl SET DrvName = @p0, DrvSurname = @p1, DrvPhone = @p2 , DrvSalary = @p3 WHERE DrvID = @p4";

                List<object> parameters = new List<object> { DrvName, DrvSurname, DrvPhone, DrvSalary, DrvID };
                myFunctionDriver.SetData(Query, parameters);

                DrvNameTxtbx.Text = "";
                DrvSurnameTxtbx.Text = "";
                DrvPhoneTxtbx.Text = "";
                DrvSalaryTxtbx.Text = "";

                // Optionally, we can add a success message or perform other actions after the update
                MessageBox.Show("Record updated successfully!");

                // Refresh the grid view to show updated data
                ShowDrivers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteDriverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if a row is selected in the grid view
                if (DrvListGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to delete.");
                }
                else
                {
                    // Retrieves BusID from the selected row in the DataGridView
                    int DrvID = Convert.ToInt32(DrvListGridView.SelectedRows[0].Cells["DrvID"].Value);

                    // Constructing the DELETE query
                    string Query = "DELETE FROM driverTbl WHERE DrvID = @p0";

                    // Uses the Functions class to execute the delete query
                    List<object> parameters = new List<object> { DrvID };
                    myFunctionDriver.SetData(Query, parameters);

                    DrvNameTxtbx.Text = "";
                    DrvSurnameTxtbx.Text = "";
                    DrvPhoneTxtbx.Text = "";
                    DrvSalaryTxtbx.Text = "";

                    // Optionally, we can add a success message or perform other actions after the delete
                    MessageBox.Show("Record deleted successfully!");

                    // Refreshs the grid view to show updated data
                    ShowDrivers();
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

        private void MenuBussesLbl_Click(object sender, EventArgs e)
        {
            try
            {
                Busses busses = new Busses();
                busses.Show();
                this.Close();
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Passengers form: {ex.Message}");
            }
        }

       

        private void ProfileIcon_Click(object sender, EventArgs e)
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