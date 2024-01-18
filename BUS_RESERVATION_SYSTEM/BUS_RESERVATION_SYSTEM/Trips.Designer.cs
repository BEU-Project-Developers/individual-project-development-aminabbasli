namespace BUS_RESERVATION_SYSTEM
{
    partial class Trips
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trips));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopTripsPicBox = new System.Windows.Forms.PictureBox();
            this.TopTripsLbl = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.BusIcon = new System.Windows.Forms.PictureBox();
            this.DriversPicBox = new System.Windows.Forms.PictureBox();
            this.PassengersPicBox = new System.Windows.Forms.PictureBox();
            this.BussesPicBox = new System.Windows.Forms.PictureBox();
            this.TripsPicBox = new System.Windows.Forms.PictureBox();
            this.HomeLbl = new System.Windows.Forms.Label();
            this.MenuDriversLbl = new System.Windows.Forms.Label();
            this.MenuTripsLbl = new System.Windows.Forms.Label();
            this.MenuPassengersLbl = new System.Windows.Forms.Label();
            this.MenuBussesLbl = new System.Windows.Forms.Label();
            this.LeftMostPanel = new System.Windows.Forms.Panel();
            this.ProfileIcon = new System.Windows.Forms.PictureBox();
            this.TripsListGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TripsDate = new System.Windows.Forms.DateTimePicker();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopTripsPicBox)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriversPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BussesPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripsPicBox)).BeginInit();
            this.LeftMostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripsListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LightGray;
            this.TopPanel.Controls.Add(this.TopTripsPicBox);
            this.TopPanel.Controls.Add(this.TopTripsLbl);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(448, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(6);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1628, 75);
            this.TopPanel.TabIndex = 66;
            // 
            // TopTripsPicBox
            // 
            this.TopTripsPicBox.Image = ((System.Drawing.Image)(resources.GetObject("TopTripsPicBox.Image")));
            this.TopTripsPicBox.Location = new System.Drawing.Point(18, 12);
            this.TopTripsPicBox.Margin = new System.Windows.Forms.Padding(6);
            this.TopTripsPicBox.Name = "TopTripsPicBox";
            this.TopTripsPicBox.Size = new System.Drawing.Size(48, 50);
            this.TopTripsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TopTripsPicBox.TabIndex = 35;
            this.TopTripsPicBox.TabStop = false;
            // 
            // TopTripsLbl
            // 
            this.TopTripsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TopTripsLbl.AutoSize = true;
            this.TopTripsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopTripsLbl.Location = new System.Drawing.Point(72, 17);
            this.TopTripsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TopTripsLbl.Name = "TopTripsLbl";
            this.TopTripsLbl.Size = new System.Drawing.Size(89, 37);
            this.TopTripsLbl.TabIndex = 1;
            this.TopTripsLbl.Text = "Trips";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.MenuPanel.Controls.Add(this.BusIcon);
            this.MenuPanel.Controls.Add(this.DriversPicBox);
            this.MenuPanel.Controls.Add(this.PassengersPicBox);
            this.MenuPanel.Controls.Add(this.BussesPicBox);
            this.MenuPanel.Controls.Add(this.TripsPicBox);
            this.MenuPanel.Controls.Add(this.HomeLbl);
            this.MenuPanel.Controls.Add(this.MenuDriversLbl);
            this.MenuPanel.Controls.Add(this.MenuTripsLbl);
            this.MenuPanel.Controls.Add(this.MenuPassengersLbl);
            this.MenuPanel.Controls.Add(this.MenuBussesLbl);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(100, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(6);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(348, 1039);
            this.MenuPanel.TabIndex = 65;
            // 
            // BusIcon
            // 
            this.BusIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusIcon.Image = ((System.Drawing.Image)(resources.GetObject("BusIcon.Image")));
            this.BusIcon.Location = new System.Drawing.Point(38, 23);
            this.BusIcon.Margin = new System.Windows.Forms.Padding(6);
            this.BusIcon.Name = "BusIcon";
            this.BusIcon.Size = new System.Drawing.Size(282, 275);
            this.BusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BusIcon.TabIndex = 38;
            this.BusIcon.TabStop = false;
            // 
            // DriversPicBox
            // 
            this.DriversPicBox.Image = ((System.Drawing.Image)(resources.GetObject("DriversPicBox.Image")));
            this.DriversPicBox.Location = new System.Drawing.Point(58, 763);
            this.DriversPicBox.Margin = new System.Windows.Forms.Padding(6);
            this.DriversPicBox.Name = "DriversPicBox";
            this.DriversPicBox.Size = new System.Drawing.Size(48, 50);
            this.DriversPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DriversPicBox.TabIndex = 37;
            this.DriversPicBox.TabStop = false;
            // 
            // PassengersPicBox
            // 
            this.PassengersPicBox.Image = ((System.Drawing.Image)(resources.GetObject("PassengersPicBox.Image")));
            this.PassengersPicBox.Location = new System.Drawing.Point(58, 677);
            this.PassengersPicBox.Margin = new System.Windows.Forms.Padding(6);
            this.PassengersPicBox.Name = "PassengersPicBox";
            this.PassengersPicBox.Size = new System.Drawing.Size(48, 50);
            this.PassengersPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassengersPicBox.TabIndex = 36;
            this.PassengersPicBox.TabStop = false;
            // 
            // BussesPicBox
            // 
            this.BussesPicBox.Image = ((System.Drawing.Image)(resources.GetObject("BussesPicBox.Image")));
            this.BussesPicBox.Location = new System.Drawing.Point(58, 592);
            this.BussesPicBox.Margin = new System.Windows.Forms.Padding(6);
            this.BussesPicBox.Name = "BussesPicBox";
            this.BussesPicBox.Size = new System.Drawing.Size(48, 50);
            this.BussesPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BussesPicBox.TabIndex = 35;
            this.BussesPicBox.TabStop = false;
            // 
            // TripsPicBox
            // 
            this.TripsPicBox.Image = ((System.Drawing.Image)(resources.GetObject("TripsPicBox.Image")));
            this.TripsPicBox.Location = new System.Drawing.Point(58, 506);
            this.TripsPicBox.Margin = new System.Windows.Forms.Padding(6);
            this.TripsPicBox.Name = "TripsPicBox";
            this.TripsPicBox.Size = new System.Drawing.Size(48, 50);
            this.TripsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TripsPicBox.TabIndex = 34;
            this.TripsPicBox.TabStop = false;
            // 
            // HomeLbl
            // 
            this.HomeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HomeLbl.AutoSize = true;
            this.HomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeLbl.ForeColor = System.Drawing.Color.White;
            this.HomeLbl.Location = new System.Drawing.Point(74, 369);
            this.HomeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HomeLbl.Name = "HomeLbl";
            this.HomeLbl.Size = new System.Drawing.Size(171, 55);
            this.HomeLbl.TabIndex = 33;
            this.HomeLbl.Text = "Home ";
            // 
            // MenuDriversLbl
            // 
            this.MenuDriversLbl.AutoSize = true;
            this.MenuDriversLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuDriversLbl.ForeColor = System.Drawing.Color.White;
            this.MenuDriversLbl.Location = new System.Drawing.Point(118, 771);
            this.MenuDriversLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MenuDriversLbl.Name = "MenuDriversLbl";
            this.MenuDriversLbl.Size = new System.Drawing.Size(133, 39);
            this.MenuDriversLbl.TabIndex = 32;
            this.MenuDriversLbl.Text = "Drivers";
            // 
            // MenuTripsLbl
            // 
            this.MenuTripsLbl.AutoSize = true;
            this.MenuTripsLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuTripsLbl.ForeColor = System.Drawing.Color.White;
            this.MenuTripsLbl.Location = new System.Drawing.Point(118, 513);
            this.MenuTripsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MenuTripsLbl.Name = "MenuTripsLbl";
            this.MenuTripsLbl.Size = new System.Drawing.Size(97, 39);
            this.MenuTripsLbl.TabIndex = 30;
            this.MenuTripsLbl.Text = "Trips";
            // 
            // MenuPassengersLbl
            // 
            this.MenuPassengersLbl.AutoSize = true;
            this.MenuPassengersLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuPassengersLbl.ForeColor = System.Drawing.Color.White;
            this.MenuPassengersLbl.Location = new System.Drawing.Point(118, 685);
            this.MenuPassengersLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MenuPassengersLbl.Name = "MenuPassengersLbl";
            this.MenuPassengersLbl.Size = new System.Drawing.Size(197, 39);
            this.MenuPassengersLbl.TabIndex = 29;
            this.MenuPassengersLbl.Text = "Passengers";
            // 
            // MenuBussesLbl
            // 
            this.MenuBussesLbl.AutoSize = true;
            this.MenuBussesLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuBussesLbl.ForeColor = System.Drawing.Color.White;
            this.MenuBussesLbl.Location = new System.Drawing.Point(118, 600);
            this.MenuBussesLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MenuBussesLbl.Name = "MenuBussesLbl";
            this.MenuBussesLbl.Size = new System.Drawing.Size(126, 39);
            this.MenuBussesLbl.TabIndex = 28;
            this.MenuBussesLbl.Text = "Busses";
            this.MenuBussesLbl.Click += new System.EventHandler(this.MenuBussesLbl_Click);
            // 
            // LeftMostPanel
            // 
            this.LeftMostPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LeftMostPanel.Controls.Add(this.ProfileIcon);
            this.LeftMostPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMostPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMostPanel.Margin = new System.Windows.Forms.Padding(6);
            this.LeftMostPanel.Name = "LeftMostPanel";
            this.LeftMostPanel.Size = new System.Drawing.Size(100, 1039);
            this.LeftMostPanel.TabIndex = 64;
            // 
            // ProfileIcon
            // 
            this.ProfileIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileIcon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("ProfileIcon.Image")));
            this.ProfileIcon.Location = new System.Drawing.Point(0, 0);
            this.ProfileIcon.Margin = new System.Windows.Forms.Padding(6);
            this.ProfileIcon.Name = "ProfileIcon";
            this.ProfileIcon.Size = new System.Drawing.Size(100, 117);
            this.ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileIcon.TabIndex = 0;
            this.ProfileIcon.TabStop = false;
            // 
            // TripsListGridView
            // 
            this.TripsListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TripsListGridView.BackgroundColor = System.Drawing.Color.White;
            this.TripsListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TripsListGridView.Location = new System.Drawing.Point(520, 121);
            this.TripsListGridView.Margin = new System.Windows.Forms.Padding(6);
            this.TripsListGridView.Name = "TripsListGridView";
            this.TripsListGridView.RowHeadersWidth = 82;
            this.TripsListGridView.Size = new System.Drawing.Size(1500, 570);
            this.TripsListGridView.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(563, 736);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 68;
            this.label1.Text = "Trip ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(569, 780);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 37);
            this.textBox1.TabIndex = 69;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(569, 894);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 37);
            this.textBox2.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(563, 853);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 36);
            this.label2.TabIndex = 70;
            this.label2.Text = "Route";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(981, 740);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 36);
            this.label3.TabIndex = 72;
            this.label3.Text = "Date";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(987, 894);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(338, 37);
            this.textBox4.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(981, 853);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 74;
            this.label4.Text = "Bus";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1505, 763);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 75);
            this.button1.TabIndex = 76;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1719, 763);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 75);
            this.button2.TabIndex = 77;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1505, 856);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 75);
            this.button3.TabIndex = 78;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // TripsDate
            // 
            this.TripsDate.Location = new System.Drawing.Point(987, 782);
            this.TripsDate.Name = "TripsDate";
            this.TripsDate.Size = new System.Drawing.Size(391, 31);
            this.TripsDate.TabIndex = 79;
            // 
            // Trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2076, 1039);
            this.Controls.Add(this.TripsDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TripsListGridView);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.LeftMostPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Trips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trips";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopTripsPicBox)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriversPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BussesPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripsPicBox)).EndInit();
            this.LeftMostPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripsListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TopTripsLbl;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel LeftMostPanel;
        private System.Windows.Forms.PictureBox ProfileIcon;
        private System.Windows.Forms.DataGridView TripsListGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox DriversPicBox;
        private System.Windows.Forms.PictureBox PassengersPicBox;
        private System.Windows.Forms.PictureBox BussesPicBox;
        private System.Windows.Forms.PictureBox TripsPicBox;
        private System.Windows.Forms.Label HomeLbl;
        private System.Windows.Forms.Label MenuDriversLbl;
        private System.Windows.Forms.Label MenuTripsLbl;
        private System.Windows.Forms.Label MenuPassengersLbl;
        private System.Windows.Forms.Label MenuBussesLbl;
        private System.Windows.Forms.PictureBox TopTripsPicBox;
        private System.Windows.Forms.PictureBox BusIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker TripsDate;
    }
}