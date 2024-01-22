using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_RESERVATION_SYSTEM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // This method is empty, no specific actions are performed when the Login form is loaded.
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Get the entered username and password from the textboxes
            string username = LoginUsernameTxtbx.Text;
            string password = LoginPasswordTxtbx.Text;

            // Check if the entered username and password are valid (admin credentials)
            if (IsValidAdmin(username, password))
            {
                // If valid, create an instance of the Trips form and show it
                Trips trips = new Trips();
                trips.Show();

                // Close the current Login form
                this.Close();
            }
            else
            {
                // If invalid, show a message indicating invalid credentials
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool IsValidAdmin(string username, string password)
        {
            // Simple check for admin credentials (username: "admin", password: "admin123")
            return (username == "admin" && password == "admin123");
        }

        private void ResetLbl_Click(object sender, EventArgs e)
        {
            // Reset the text in the username and password textboxes
            LoginUsernameTxtbx.Text = "";
            LoginPasswordTxtbx.Text = "";
        }
    }
}
