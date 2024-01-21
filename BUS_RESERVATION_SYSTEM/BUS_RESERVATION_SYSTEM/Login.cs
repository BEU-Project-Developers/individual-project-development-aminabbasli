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

        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameTxtbx.Text;
            string password = LoginPasswordTxtbx.Text;
            if (IsValidAdmin(username, password))
            {
                Trips trips = new Trips();
                trips.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        private bool IsValidAdmin(string username, string password)
        {
            return (username == "admin" && password == "admin123");
        }
        private void ResetLbl_Click(object sender, EventArgs e)
        {
            LoginUsernameTxtbx.Text = "";
            LoginPasswordTxtbx.Text = "";
        }
    }
}
