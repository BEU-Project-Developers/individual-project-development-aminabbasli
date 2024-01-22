namespace BUS_RESERVATION_SYSTEM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.ProfileIcon = new System.Windows.Forms.PictureBox();
            this.LOGIN_Lbl = new System.Windows.Forms.Label();
            this.LoginUsernameTxtbx = new System.Windows.Forms.TextBox();
            this.LoginPasswordTxtbx = new System.Windows.Forms.TextBox();
            this.LoginUsernameLbl = new System.Windows.Forms.Label();
            this.LoginPasswordLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ResetLbl = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginPanel.Controls.Add(this.ProfileIcon);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(6);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(180, 740);
            this.LoginPanel.TabIndex = 0;
            // 
            // ProfileIcon
            // 
            this.ProfileIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileIcon.BackColor = System.Drawing.Color.Transparent;
            this.ProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("ProfileIcon.Image")));
            this.ProfileIcon.Location = new System.Drawing.Point(15, 15);
            this.ProfileIcon.Margin = new System.Windows.Forms.Padding(6);
            this.ProfileIcon.Name = "ProfileIcon";
            this.ProfileIcon.Size = new System.Drawing.Size(152, 153);
            this.ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileIcon.TabIndex = 1;
            this.ProfileIcon.TabStop = false;
            // 
            // LOGIN_Lbl
            // 
            this.LOGIN_Lbl.AutoSize = true;
            this.LOGIN_Lbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LOGIN_Lbl.ForeColor = System.Drawing.Color.Black;
            this.LOGIN_Lbl.Location = new System.Drawing.Point(461, 59);
            this.LOGIN_Lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LOGIN_Lbl.Name = "LOGIN_Lbl";
            this.LOGIN_Lbl.Size = new System.Drawing.Size(178, 51);
            this.LOGIN_Lbl.TabIndex = 1;
            this.LOGIN_Lbl.Text = "LOGIN";
            // 
            // LoginUsernameTxtbx
            // 
            this.LoginUsernameTxtbx.BackColor = System.Drawing.Color.White;
            this.LoginUsernameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginUsernameTxtbx.Location = new System.Drawing.Point(288, 251);
            this.LoginUsernameTxtbx.Margin = new System.Windows.Forms.Padding(6);
            this.LoginUsernameTxtbx.Name = "LoginUsernameTxtbx";
            this.LoginUsernameTxtbx.Size = new System.Drawing.Size(504, 37);
            this.LoginUsernameTxtbx.TabIndex = 2;
            // 
            // LoginPasswordTxtbx
            // 
            this.LoginPasswordTxtbx.BackColor = System.Drawing.Color.White;
            this.LoginPasswordTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginPasswordTxtbx.Location = new System.Drawing.Point(288, 394);
            this.LoginPasswordTxtbx.Margin = new System.Windows.Forms.Padding(6);
            this.LoginPasswordTxtbx.Name = "LoginPasswordTxtbx";
            this.LoginPasswordTxtbx.Size = new System.Drawing.Size(504, 37);
            this.LoginPasswordTxtbx.TabIndex = 3;
            // 
            // LoginUsernameLbl
            // 
            this.LoginUsernameLbl.AutoSize = true;
            this.LoginUsernameLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginUsernameLbl.Location = new System.Drawing.Point(282, 211);
            this.LoginUsernameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LoginUsernameLbl.Name = "LoginUsernameLbl";
            this.LoginUsernameLbl.Size = new System.Drawing.Size(182, 36);
            this.LoginUsernameLbl.TabIndex = 4;
            this.LoginUsernameLbl.Text = "Username:";
            // 
            // LoginPasswordLbl
            // 
            this.LoginPasswordLbl.AutoSize = true;
            this.LoginPasswordLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginPasswordLbl.Location = new System.Drawing.Point(282, 354);
            this.LoginPasswordLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LoginPasswordLbl.Name = "LoginPasswordLbl";
            this.LoginPasswordLbl.Size = new System.Drawing.Size(182, 36);
            this.LoginPasswordLbl.TabIndex = 5;
            this.LoginPasswordLbl.Text = "Password :";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(421, 509);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(6);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(244, 77);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Log in";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ResetLbl
            // 
            this.ResetLbl.AutoSize = true;
            this.ResetLbl.BackColor = System.Drawing.Color.Transparent;
            this.ResetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetLbl.ForeColor = System.Drawing.Color.Black;
            this.ResetLbl.Location = new System.Drawing.Point(487, 626);
            this.ResetLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ResetLbl.Name = "ResetLbl";
            this.ResetLbl.Size = new System.Drawing.Size(103, 37);
            this.ResetLbl.TabIndex = 8;
            this.ResetLbl.Text = "Reset";
            this.ResetLbl.Click += new System.EventHandler(this.ResetLbl_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(930, 740);
            this.Controls.Add(this.LOGIN_Lbl);
            this.Controls.Add(this.ResetLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginPasswordLbl);
            this.Controls.Add(this.LoginUsernameLbl);
            this.Controls.Add(this.LoginPasswordTxtbx);
            this.Controls.Add(this.LoginUsernameTxtbx);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label LOGIN_Lbl;
        private System.Windows.Forms.TextBox LoginUsernameTxtbx;
        private System.Windows.Forms.TextBox LoginPasswordTxtbx;
        private System.Windows.Forms.Label LoginUsernameLbl;
        private System.Windows.Forms.Label LoginPasswordLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label ResetLbl;
        private System.Windows.Forms.PictureBox ProfileIcon;
    }
}