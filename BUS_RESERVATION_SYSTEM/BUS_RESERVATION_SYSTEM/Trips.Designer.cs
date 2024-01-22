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
            this.components = new System.ComponentModel.Container();
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
            this.TripPriceTxbx = new System.Windows.Forms.TextBox();
            this.TripRouteTxbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TripTourNameTxbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TripAddBtn = new System.Windows.Forms.Button();
            this.TripEditBtn = new System.Windows.Forms.Button();
            this.TripDeleteBtn = new System.Windows.Forms.Button();
            this.TripsDate = new System.Windows.Forms.DateTimePicker();
            this.TripsLbl = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.TopPanel.Size = new System.Drawing.Size(1683, 75);
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
            this.MenuPanel.Size = new System.Drawing.Size(348, 975);
            this.MenuPanel.TabIndex = 65;
            // 
            // BusIcon
            // 
            this.BusIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.BusIcon.Image = ((System.Drawing.Image)(resources.GetObject("BusIcon.Image")));
            this.BusIcon.Location = new System.Drawing.Point(0, 0);
            this.BusIcon.Margin = new System.Windows.Forms.Padding(6);
            this.BusIcon.Name = "BusIcon";
            this.BusIcon.Size = new System.Drawing.Size(348, 237);
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
            this.MenuDriversLbl.Click += new System.EventHandler(this.MenuDriversLbl_Click);
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
            this.MenuPassengersLbl.Click += new System.EventHandler(this.MenuPassengersLbl_Click);
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
            this.LeftMostPanel.Size = new System.Drawing.Size(100, 975);
            this.LeftMostPanel.TabIndex = 64;
            // 
            // ProfileIcon
            // 
            this.ProfileIcon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProfileIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("ProfileIcon.Image")));
            this.ProfileIcon.Location = new System.Drawing.Point(0, 0);
            this.ProfileIcon.Margin = new System.Windows.Forms.Padding(6);
            this.ProfileIcon.Name = "ProfileIcon";
            this.ProfileIcon.Size = new System.Drawing.Size(100, 104);
            this.ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileIcon.TabIndex = 0;
            this.ProfileIcon.TabStop = false;
            this.ProfileIcon.Click += new System.EventHandler(this.ProfileIcon_Click_1);
            // 
            // TripsListGridView
            // 
            this.TripsListGridView.BackgroundColor = System.Drawing.Color.White;
            this.TripsListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TripsListGridView.Location = new System.Drawing.Point(934, 215);
            this.TripsListGridView.Margin = new System.Windows.Forms.Padding(6);
            this.TripsListGridView.Name = "TripsListGridView";
            this.TripsListGridView.RowHeadersWidth = 82;
            this.TripsListGridView.Size = new System.Drawing.Size(1161, 648);
            this.TripsListGridView.TabIndex = 67;
            this.TripsListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TripsListGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(523, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 36);
            this.label1.TabIndex = 68;
            this.label1.Text = "Price";
            // 
            // TripPriceTxbx
            // 
            this.TripPriceTxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripPriceTxbx.Location = new System.Drawing.Point(527, 387);
            this.TripPriceTxbx.Margin = new System.Windows.Forms.Padding(6);
            this.TripPriceTxbx.Name = "TripPriceTxbx";
            this.TripPriceTxbx.Size = new System.Drawing.Size(338, 37);
            this.TripPriceTxbx.TabIndex = 69;
            // 
            // TripRouteTxbx
            // 
            this.TripRouteTxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripRouteTxbx.Location = new System.Drawing.Point(529, 268);
            this.TripRouteTxbx.Margin = new System.Windows.Forms.Padding(6);
            this.TripRouteTxbx.Name = "TripRouteTxbx";
            this.TripRouteTxbx.Size = new System.Drawing.Size(338, 37);
            this.TripRouteTxbx.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(525, 226);
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
            this.label3.Location = new System.Drawing.Point(519, 461);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 36);
            this.label3.TabIndex = 72;
            this.label3.Text = "Date";
            // 
            // TripTourNameTxbx
            // 
            this.TripTourNameTxbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripTourNameTxbx.Location = new System.Drawing.Point(527, 615);
            this.TripTourNameTxbx.Margin = new System.Windows.Forms.Padding(6);
            this.TripTourNameTxbx.Name = "TripTourNameTxbx";
            this.TripTourNameTxbx.Size = new System.Drawing.Size(338, 37);
            this.TripTourNameTxbx.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(519, 575);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 36);
            this.label4.TabIndex = 74;
            this.label4.Text = "Tour Name";
            // 
            // TripAddBtn
            // 
            this.TripAddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.TripAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TripAddBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripAddBtn.ForeColor = System.Drawing.Color.White;
            this.TripAddBtn.Location = new System.Drawing.Point(517, 707);
            this.TripAddBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TripAddBtn.Name = "TripAddBtn";
            this.TripAddBtn.Size = new System.Drawing.Size(169, 75);
            this.TripAddBtn.TabIndex = 76;
            this.TripAddBtn.Text = "Add";
            this.TripAddBtn.UseVisualStyleBackColor = false;
            this.TripAddBtn.Click += new System.EventHandler(this.TripAddBtn_Click);
            // 
            // TripEditBtn
            // 
            this.TripEditBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.TripEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TripEditBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripEditBtn.ForeColor = System.Drawing.Color.White;
            this.TripEditBtn.Location = new System.Drawing.Point(733, 707);
            this.TripEditBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TripEditBtn.Name = "TripEditBtn";
            this.TripEditBtn.Size = new System.Drawing.Size(169, 75);
            this.TripEditBtn.TabIndex = 77;
            this.TripEditBtn.Text = "Edit";
            this.TripEditBtn.UseVisualStyleBackColor = false;
            this.TripEditBtn.Click += new System.EventHandler(this.TripEditBtn_Click);
            // 
            // TripDeleteBtn
            // 
            this.TripDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.TripDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TripDeleteBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.TripDeleteBtn.Location = new System.Drawing.Point(631, 804);
            this.TripDeleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TripDeleteBtn.Name = "TripDeleteBtn";
            this.TripDeleteBtn.Size = new System.Drawing.Size(169, 75);
            this.TripDeleteBtn.TabIndex = 78;
            this.TripDeleteBtn.Text = "Delete";
            this.TripDeleteBtn.UseVisualStyleBackColor = false;
            this.TripDeleteBtn.Click += new System.EventHandler(this.TripDeleteBtn_Click);
            // 
            // TripsDate
            // 
            this.TripsDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TripsDate.Location = new System.Drawing.Point(527, 504);
            this.TripsDate.Margin = new System.Windows.Forms.Padding(4);
            this.TripsDate.Name = "TripsDate";
            this.TripsDate.Size = new System.Drawing.Size(192, 31);
            this.TripsDate.TabIndex = 79;
            // 
            // TripsLbl
            // 
            this.TripsLbl.AutoSize = true;
            this.TripsLbl.Font = new System.Drawing.Font("Trebuchet MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripsLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TripsLbl.Location = new System.Drawing.Point(1056, 118);
            this.TripsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TripsLbl.Name = "TripsLbl";
            this.TripsLbl.Size = new System.Drawing.Size(120, 54);
            this.TripsLbl.TabIndex = 80;
            this.TripsLbl.Text = "Trips";
            // 
            // Trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2131, 975);
            this.Controls.Add(this.TripsLbl);
            this.Controls.Add(this.TripsDate);
            this.Controls.Add(this.TripDeleteBtn);
            this.Controls.Add(this.TripEditBtn);
            this.Controls.Add(this.TripAddBtn);
            this.Controls.Add(this.TripTourNameTxbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TripRouteTxbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TripPriceTxbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TripsListGridView);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.LeftMostPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Trips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trips";
            this.Load += new System.EventHandler(this.Trips_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox TripPriceTxbx;
        private System.Windows.Forms.TextBox TripRouteTxbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TripTourNameTxbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TripAddBtn;
        private System.Windows.Forms.Button TripDeleteBtn;
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
        private System.Windows.Forms.DateTimePicker TripsDate;
        private System.Windows.Forms.Label TripsLbl;
        private System.Windows.Forms.Button TripEditBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}