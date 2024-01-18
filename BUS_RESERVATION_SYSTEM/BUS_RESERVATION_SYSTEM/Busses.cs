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
    public partial class Busses : Form
    {
        public Busses()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void MenuTripsLbl_Click(object sender, EventArgs e)
        {
            Trips trips = new Trips();
            trips.Show();
        }
 
        private void MenuPassengersLbl_Click_1(object sender, EventArgs e)
        {
            Passengers passengers = new Passengers();
            passengers.Show();
        }

        private void MenuDriversLbl_Click_1(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Show();
        }
    }
}
