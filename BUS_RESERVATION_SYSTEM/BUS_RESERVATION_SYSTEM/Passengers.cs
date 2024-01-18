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
    public partial class Passengers : Form
    {
        public Passengers()
        {
            InitializeComponent();
        }

        private void MenuTripsLbl_Click(object sender, EventArgs e)
        {
            Trips trips = new Trips();
            trips.Show();
        }

        private void MenuBussesLbl_Click(object sender, EventArgs e)
        {
            Busses busses = new Busses();
            busses.Show();
        }

        private void MenuDriversLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
