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
    public partial class MainForm : Form
    {
        private Timer timer;
        public MainForm() //Constructor
        {
            InitializeComponent();

            // Initialize and configure a timer
            timer = new Timer();
            timer.Interval = 3000;  // Set the interval to 3000 milliseconds (3 seconds)
            timer.Tick += timer1_Tick;  // Subscribe to the Tick event


            // Subscribe to the Load event of the MainForm
            this.Load += MainForm_Load;
        } 
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Start the timer when the MainForm is loaded
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer to prevent further ticks
            timer.Stop();

            Login loginPage = new Login();
            loginPage.Show();

            this.Hide();
        }
    }
}
