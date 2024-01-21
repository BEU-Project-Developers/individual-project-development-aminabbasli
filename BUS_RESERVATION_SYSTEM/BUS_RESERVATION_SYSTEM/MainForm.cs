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

            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += timer1_Tick;

            this.Load += MainForm_Load;
        } 
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            Login loginPage = new Login();
            loginPage.Show();

            this.Hide();
        }
    }
}
