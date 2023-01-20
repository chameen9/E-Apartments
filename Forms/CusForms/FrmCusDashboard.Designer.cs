namespace E_Apartments.Forms.Customer
{
    partial class FrmCusDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCusDashboard));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.iconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.pnlRibbon = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNavApplications = new FontAwesome.Sharp.IconButton();
            this.btnNavOccupents = new FontAwesome.Sharp.IconButton();
            this.btnCusReservations = new FontAwesome.Sharp.IconButton();
            this.btnNavExtendLease = new FontAwesome.Sharp.IconButton();
            this.btnNavFindApartments = new FontAwesome.Sharp.IconButton();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogout = new FontAwesome.Sharp.IconPictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).BeginInit();
            this.pnlRibbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlNavBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(250, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1030, 655);
            this.pnlMain.TabIndex = 211;
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFormTopic.Location = new System.Drawing.Point(46, 0);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(250, 40);
            this.lblFormTopic.TabIndex = 1;
            this.lblFormTopic.Text = "Customer Dashboard";
            this.lblFormTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.Controls.Add(this.iconTitle);
            this.pnlFormHeader.Controls.Add(this.lblFormTopic);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(250, 25);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1030, 40);
            this.pnlFormHeader.TabIndex = 210;
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconTitle.IconColor = System.Drawing.Color.White;
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 20;
            this.iconTitle.Location = new System.Drawing.Point(20, 11);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(20, 20);
            this.iconTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTitle.TabIndex = 2;
            this.iconTitle.TabStop = false;
            // 
            // pnlRibbon
            // 
            this.pnlRibbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlRibbon.Controls.Add(this.btnMinimize);
            this.pnlRibbon.Controls.Add(this.btnExit);
            this.pnlRibbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRibbon.Location = new System.Drawing.Point(250, 0);
            this.pnlRibbon.Name = "pnlRibbon";
            this.pnlRibbon.Size = new System.Drawing.Size(1030, 25);
            this.pnlRibbon.TabIndex = 209;
            this.pnlRibbon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlRibbon_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(980, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1005, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(44, 120);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 25);
            this.lblName.TabIndex = 204;
            this.lblName.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 14);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNavApplications);
            this.panel2.Controls.Add(this.btnNavOccupents);
            this.panel2.Controls.Add(this.btnCusReservations);
            this.panel2.Controls.Add(this.btnNavExtendLease);
            this.panel2.Controls.Add(this.btnNavFindApartments);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 512);
            this.panel2.TabIndex = 207;
            // 
            // btnNavApplications
            // 
            this.btnNavApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavApplications.FlatAppearance.BorderSize = 0;
            this.btnNavApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavApplications.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavApplications.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnNavApplications.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavApplications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavApplications.IconSize = 30;
            this.btnNavApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavApplications.Location = new System.Drawing.Point(0, 194);
            this.btnNavApplications.Name = "btnNavApplications";
            this.btnNavApplications.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavApplications.Size = new System.Drawing.Size(250, 45);
            this.btnNavApplications.TabIndex = 3;
            this.btnNavApplications.TabStop = false;
            this.btnNavApplications.Text = "Applications";
            this.btnNavApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavApplications.UseVisualStyleBackColor = false;
            this.btnNavApplications.Click += new System.EventHandler(this.btnNavApplications_Click);
            // 
            // btnNavOccupents
            // 
            this.btnNavOccupents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavOccupents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavOccupents.FlatAppearance.BorderSize = 0;
            this.btnNavOccupents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOccupents.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavOccupents.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnNavOccupents.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavOccupents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavOccupents.IconSize = 30;
            this.btnNavOccupents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOccupents.Location = new System.Drawing.Point(0, 149);
            this.btnNavOccupents.Name = "btnNavOccupents";
            this.btnNavOccupents.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavOccupents.Size = new System.Drawing.Size(250, 45);
            this.btnNavOccupents.TabIndex = 2;
            this.btnNavOccupents.TabStop = false;
            this.btnNavOccupents.Text = "Occupents";
            this.btnNavOccupents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOccupents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavOccupents.UseVisualStyleBackColor = false;
            this.btnNavOccupents.Click += new System.EventHandler(this.btnNavOccupents_Click);
            // 
            // btnCusReservations
            // 
            this.btnCusReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnCusReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCusReservations.FlatAppearance.BorderSize = 0;
            this.btnCusReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusReservations.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCusReservations.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnCusReservations.IconColor = System.Drawing.SystemColors.Window;
            this.btnCusReservations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCusReservations.IconSize = 30;
            this.btnCusReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusReservations.Location = new System.Drawing.Point(0, 104);
            this.btnCusReservations.Name = "btnCusReservations";
            this.btnCusReservations.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCusReservations.Size = new System.Drawing.Size(250, 45);
            this.btnCusReservations.TabIndex = 1;
            this.btnCusReservations.TabStop = false;
            this.btnCusReservations.Text = "Reservations";
            this.btnCusReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCusReservations.UseVisualStyleBackColor = false;
            this.btnCusReservations.Click += new System.EventHandler(this.btnCusReservations_Click);
            // 
            // btnNavExtendLease
            // 
            this.btnNavExtendLease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavExtendLease.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavExtendLease.FlatAppearance.BorderSize = 0;
            this.btnNavExtendLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavExtendLease.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavExtendLease.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnNavExtendLease.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavExtendLease.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavExtendLease.IconSize = 30;
            this.btnNavExtendLease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavExtendLease.Location = new System.Drawing.Point(0, 59);
            this.btnNavExtendLease.Name = "btnNavExtendLease";
            this.btnNavExtendLease.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavExtendLease.Size = new System.Drawing.Size(250, 45);
            this.btnNavExtendLease.TabIndex = 0;
            this.btnNavExtendLease.TabStop = false;
            this.btnNavExtendLease.Text = "Extend Lease";
            this.btnNavExtendLease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavExtendLease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavExtendLease.UseVisualStyleBackColor = false;
            this.btnNavExtendLease.Visible = false;
            this.btnNavExtendLease.Click += new System.EventHandler(this.btnNavExtendLease_Click);
            // 
            // btnNavFindApartments
            // 
            this.btnNavFindApartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavFindApartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavFindApartments.FlatAppearance.BorderSize = 0;
            this.btnNavFindApartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavFindApartments.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavFindApartments.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnNavFindApartments.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavFindApartments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavFindApartments.IconSize = 30;
            this.btnNavFindApartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavFindApartments.Location = new System.Drawing.Point(0, 14);
            this.btnNavFindApartments.Name = "btnNavFindApartments";
            this.btnNavFindApartments.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavFindApartments.Size = new System.Drawing.Size(250, 45);
            this.btnNavFindApartments.TabIndex = 0;
            this.btnNavFindApartments.TabStop = false;
            this.btnNavFindApartments.Text = "Find an Apartment";
            this.btnNavFindApartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavFindApartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavFindApartments.UseVisualStyleBackColor = false;
            this.btnNavFindApartments.Click += new System.EventHandler(this.btnNavFindApartments_Click);
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.pnlNavBar.Controls.Add(this.panel2);
            this.pnlNavBar.Controls.Add(this.panel1);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(250, 720);
            this.pnlNavBar.TabIndex = 208;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 208);
            this.panel1.TabIndex = 206;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.picUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.picUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.picUser.IconColor = System.Drawing.Color.SteelBlue;
            this.picUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picUser.IconSize = 20;
            this.picUser.Location = new System.Drawing.Point(17, 121);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(20, 20);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUser.TabIndex = 207;
            this.picUser.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLogout.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 20;
            this.btnLogout.Location = new System.Drawing.Point(17, 150);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(20, 20);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLogout.TabIndex = 206;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(56, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(137, 74);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 205;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // FrmCusDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.pnlRibbon);
            this.Controls.Add(this.pnlNavBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCusDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.FrmCusDashboard_Load);
            this.pnlFormHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).EndInit();
            this.pnlRibbon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlNavBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picUser;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnNavExtendLease;
        private FontAwesome.Sharp.IconButton btnNavFindApartments;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox iconTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Panel pnlRibbon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnLogout;
        private FontAwesome.Sharp.IconButton btnCusReservations;
        private FontAwesome.Sharp.IconButton btnNavOccupents;
        private FontAwesome.Sharp.IconButton btnNavApplications;
    }
}