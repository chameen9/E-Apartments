namespace E_Apartments.Forms
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNavAddUsers = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNavCustomers = new FontAwesome.Sharp.IconButton();
            this.btnNavManageApplications = new FontAwesome.Sharp.IconButton();
            this.btnNavManageClasses = new FontAwesome.Sharp.IconButton();
            this.btnNavAddParkings = new FontAwesome.Sharp.IconButton();
            this.btnNavManageReservations = new FontAwesome.Sharp.IconButton();
            this.btnNavManageBuildings = new FontAwesome.Sharp.IconButton();
            this.btnNavManageParkings = new FontAwesome.Sharp.IconButton();
            this.btnNavExtendRequests = new FontAwesome.Sharp.IconButton();
            this.btnNavManageApartments = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNavCheckAvailability = new FontAwesome.Sharp.IconButton();
            this.btnNavClassInfo = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogout = new FontAwesome.Sharp.IconPictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lbluserName = new System.Windows.Forms.Label();
            this.pnlRibbon = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.iconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlNavBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlRibbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.pnlFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).BeginInit();
            this.SuspendLayout();
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
            this.pnlNavBar.TabIndex = 204;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 564);
            this.panel2.TabIndex = 207;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnNavAddUsers);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 495);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 69);
            this.panel6.TabIndex = 6;
            // 
            // btnNavAddUsers
            // 
            this.btnNavAddUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavAddUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAddUsers.FlatAppearance.BorderSize = 0;
            this.btnNavAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAddUsers.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavAddUsers.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNavAddUsers.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavAddUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavAddUsers.IconSize = 30;
            this.btnNavAddUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAddUsers.Location = new System.Drawing.Point(0, 0);
            this.btnNavAddUsers.Name = "btnNavAddUsers";
            this.btnNavAddUsers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavAddUsers.Size = new System.Drawing.Size(250, 45);
            this.btnNavAddUsers.TabIndex = 4;
            this.btnNavAddUsers.TabStop = false;
            this.btnNavAddUsers.Text = "Add Users";
            this.btnNavAddUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAddUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavAddUsers.UseVisualStyleBackColor = false;
            this.btnNavAddUsers.Visible = false;
            this.btnNavAddUsers.Click += new System.EventHandler(this.btnNavAddUsers_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNavCustomers);
            this.panel5.Controls.Add(this.btnNavManageApplications);
            this.panel5.Controls.Add(this.btnNavManageClasses);
            this.panel5.Controls.Add(this.btnNavAddParkings);
            this.panel5.Controls.Add(this.btnNavManageReservations);
            this.panel5.Controls.Add(this.btnNavManageBuildings);
            this.panel5.Controls.Add(this.btnNavManageParkings);
            this.panel5.Controls.Add(this.btnNavExtendRequests);
            this.panel5.Controls.Add(this.btnNavManageApartments);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 405);
            this.panel5.TabIndex = 5;
            // 
            // btnNavCustomers
            // 
            this.btnNavCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavCustomers.FlatAppearance.BorderSize = 0;
            this.btnNavCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCustomers.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavCustomers.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            this.btnNavCustomers.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavCustomers.IconSize = 30;
            this.btnNavCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCustomers.Location = new System.Drawing.Point(0, 360);
            this.btnNavCustomers.Name = "btnNavCustomers";
            this.btnNavCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavCustomers.Size = new System.Drawing.Size(250, 45);
            this.btnNavCustomers.TabIndex = 5;
            this.btnNavCustomers.TabStop = false;
            this.btnNavCustomers.Text = "Customers";
            this.btnNavCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavCustomers.UseVisualStyleBackColor = false;
            this.btnNavCustomers.Click += new System.EventHandler(this.btnNavCustomers_Click);
            // 
            // btnNavManageApplications
            // 
            this.btnNavManageApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavManageApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavManageApplications.FlatAppearance.BorderSize = 0;
            this.btnNavManageApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageApplications.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavManageApplications.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnNavManageApplications.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavManageApplications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavManageApplications.IconSize = 30;
            this.btnNavManageApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageApplications.Location = new System.Drawing.Point(0, 315);
            this.btnNavManageApplications.Name = "btnNavManageApplications";
            this.btnNavManageApplications.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavManageApplications.Size = new System.Drawing.Size(250, 45);
            this.btnNavManageApplications.TabIndex = 4;
            this.btnNavManageApplications.TabStop = false;
            this.btnNavManageApplications.Text = "Manage App:";
            this.btnNavManageApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavManageApplications.UseVisualStyleBackColor = false;
            this.btnNavManageApplications.Click += new System.EventHandler(this.btnNavManageApplications_Click);
            // 
            // btnNavManageClasses
            // 
            this.btnNavManageClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavManageClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavManageClasses.FlatAppearance.BorderSize = 0;
            this.btnNavManageClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageClasses.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavManageClasses.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.btnNavManageClasses.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavManageClasses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavManageClasses.IconSize = 30;
            this.btnNavManageClasses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageClasses.Location = new System.Drawing.Point(0, 270);
            this.btnNavManageClasses.Name = "btnNavManageClasses";
            this.btnNavManageClasses.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavManageClasses.Size = new System.Drawing.Size(250, 45);
            this.btnNavManageClasses.TabIndex = 0;
            this.btnNavManageClasses.TabStop = false;
            this.btnNavManageClasses.Text = "Manage Classes";
            this.btnNavManageClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageClasses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavManageClasses.UseVisualStyleBackColor = false;
            this.btnNavManageClasses.Visible = false;
            this.btnNavManageClasses.Click += new System.EventHandler(this.btnNavManageClasses_Click);
            // 
            // btnNavAddParkings
            // 
            this.btnNavAddParkings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavAddParkings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAddParkings.FlatAppearance.BorderSize = 0;
            this.btnNavAddParkings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAddParkings.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavAddParkings.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.btnNavAddParkings.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavAddParkings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavAddParkings.IconSize = 30;
            this.btnNavAddParkings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAddParkings.Location = new System.Drawing.Point(0, 225);
            this.btnNavAddParkings.Name = "btnNavAddParkings";
            this.btnNavAddParkings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavAddParkings.Size = new System.Drawing.Size(250, 45);
            this.btnNavAddParkings.TabIndex = 3;
            this.btnNavAddParkings.TabStop = false;
            this.btnNavAddParkings.Text = "Additional Parkings";
            this.btnNavAddParkings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAddParkings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavAddParkings.UseVisualStyleBackColor = false;
            this.btnNavAddParkings.Visible = false;
            this.btnNavAddParkings.Click += new System.EventHandler(this.btnNavAddParkings_Click);
            // 
            // btnNavManageReservations
            // 
            this.btnNavManageReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavManageReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavManageReservations.FlatAppearance.BorderSize = 0;
            this.btnNavManageReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageReservations.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavManageReservations.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnNavManageReservations.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavManageReservations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavManageReservations.IconSize = 30;
            this.btnNavManageReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageReservations.Location = new System.Drawing.Point(0, 180);
            this.btnNavManageReservations.Name = "btnNavManageReservations";
            this.btnNavManageReservations.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavManageReservations.Size = new System.Drawing.Size(250, 45);
            this.btnNavManageReservations.TabIndex = 0;
            this.btnNavManageReservations.TabStop = false;
            this.btnNavManageReservations.Text = "Manage Rsv:";
            this.btnNavManageReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavManageReservations.UseVisualStyleBackColor = false;
            this.btnNavManageReservations.Click += new System.EventHandler(this.btnNavAddLease_Click);
            // 
            // btnNavManageBuildings
            // 
            this.btnNavManageBuildings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavManageBuildings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavManageBuildings.FlatAppearance.BorderSize = 0;
            this.btnNavManageBuildings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageBuildings.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavManageBuildings.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnNavManageBuildings.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavManageBuildings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavManageBuildings.IconSize = 30;
            this.btnNavManageBuildings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageBuildings.Location = new System.Drawing.Point(0, 135);
            this.btnNavManageBuildings.Name = "btnNavManageBuildings";
            this.btnNavManageBuildings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavManageBuildings.Size = new System.Drawing.Size(250, 45);
            this.btnNavManageBuildings.TabIndex = 0;
            this.btnNavManageBuildings.TabStop = false;
            this.btnNavManageBuildings.Text = "Manage Buildings";
            this.btnNavManageBuildings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageBuildings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavManageBuildings.UseVisualStyleBackColor = false;
            this.btnNavManageBuildings.Visible = false;
            this.btnNavManageBuildings.Click += new System.EventHandler(this.btnNavManageBuildings_Click);
            // 
            // btnNavManageParkings
            // 
            this.btnNavManageParkings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavManageParkings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavManageParkings.FlatAppearance.BorderSize = 0;
            this.btnNavManageParkings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageParkings.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavManageParkings.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.btnNavManageParkings.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavManageParkings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavManageParkings.IconSize = 30;
            this.btnNavManageParkings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageParkings.Location = new System.Drawing.Point(0, 90);
            this.btnNavManageParkings.Name = "btnNavManageParkings";
            this.btnNavManageParkings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavManageParkings.Size = new System.Drawing.Size(250, 45);
            this.btnNavManageParkings.TabIndex = 1;
            this.btnNavManageParkings.TabStop = false;
            this.btnNavManageParkings.Text = "Manage Parkings";
            this.btnNavManageParkings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageParkings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavManageParkings.UseVisualStyleBackColor = false;
            this.btnNavManageParkings.Visible = false;
            this.btnNavManageParkings.Click += new System.EventHandler(this.btnNavManageParkings_Click);
            // 
            // btnNavExtendRequests
            // 
            this.btnNavExtendRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavExtendRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavExtendRequests.FlatAppearance.BorderSize = 0;
            this.btnNavExtendRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavExtendRequests.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavExtendRequests.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnNavExtendRequests.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavExtendRequests.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavExtendRequests.IconSize = 30;
            this.btnNavExtendRequests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavExtendRequests.Location = new System.Drawing.Point(0, 45);
            this.btnNavExtendRequests.Name = "btnNavExtendRequests";
            this.btnNavExtendRequests.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavExtendRequests.Size = new System.Drawing.Size(250, 45);
            this.btnNavExtendRequests.TabIndex = 2;
            this.btnNavExtendRequests.TabStop = false;
            this.btnNavExtendRequests.Text = "Extend Requests";
            this.btnNavExtendRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavExtendRequests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavExtendRequests.UseVisualStyleBackColor = false;
            this.btnNavExtendRequests.Visible = false;
            this.btnNavExtendRequests.Click += new System.EventHandler(this.btnNavExtendRequests_Click);
            // 
            // btnNavManageApartments
            // 
            this.btnNavManageApartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavManageApartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavManageApartments.FlatAppearance.BorderSize = 0;
            this.btnNavManageApartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManageApartments.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavManageApartments.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnNavManageApartments.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavManageApartments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavManageApartments.IconSize = 30;
            this.btnNavManageApartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageApartments.Location = new System.Drawing.Point(0, 0);
            this.btnNavManageApartments.Name = "btnNavManageApartments";
            this.btnNavManageApartments.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavManageApartments.Size = new System.Drawing.Size(250, 45);
            this.btnNavManageApartments.TabIndex = 0;
            this.btnNavManageApartments.TabStop = false;
            this.btnNavManageApartments.Text = "Manage Apt:";
            this.btnNavManageApartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManageApartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavManageApartments.UseVisualStyleBackColor = false;
            this.btnNavManageApartments.Visible = false;
            this.btnNavManageApartments.Click += new System.EventHandler(this.btnNavManageApartments_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNavCheckAvailability);
            this.panel4.Controls.Add(this.btnNavClassInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 90);
            this.panel4.TabIndex = 0;
            // 
            // btnNavCheckAvailability
            // 
            this.btnNavCheckAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavCheckAvailability.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavCheckAvailability.FlatAppearance.BorderSize = 0;
            this.btnNavCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCheckAvailability.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCheckAvailability.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavCheckAvailability.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.btnNavCheckAvailability.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavCheckAvailability.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavCheckAvailability.IconSize = 30;
            this.btnNavCheckAvailability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCheckAvailability.Location = new System.Drawing.Point(0, 45);
            this.btnNavCheckAvailability.Name = "btnNavCheckAvailability";
            this.btnNavCheckAvailability.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavCheckAvailability.Size = new System.Drawing.Size(250, 45);
            this.btnNavCheckAvailability.TabIndex = 0;
            this.btnNavCheckAvailability.TabStop = false;
            this.btnNavCheckAvailability.Text = "Check Availability";
            this.btnNavCheckAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCheckAvailability.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavCheckAvailability.UseVisualStyleBackColor = false;
            this.btnNavCheckAvailability.Click += new System.EventHandler(this.btnNavCheckAvailability_Click);
            // 
            // btnNavClassInfo
            // 
            this.btnNavClassInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnNavClassInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavClassInfo.FlatAppearance.BorderSize = 0;
            this.btnNavClassInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavClassInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavClassInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNavClassInfo.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnNavClassInfo.IconColor = System.Drawing.SystemColors.Window;
            this.btnNavClassInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNavClassInfo.IconSize = 30;
            this.btnNavClassInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavClassInfo.Location = new System.Drawing.Point(0, 0);
            this.btnNavClassInfo.Name = "btnNavClassInfo";
            this.btnNavClassInfo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNavClassInfo.Size = new System.Drawing.Size(250, 45);
            this.btnNavClassInfo.TabIndex = 0;
            this.btnNavClassInfo.TabStop = false;
            this.btnNavClassInfo.Text = "View Class Info";
            this.btnNavClassInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavClassInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavClassInfo.UseVisualStyleBackColor = false;
            this.btnNavClassInfo.Click += new System.EventHandler(this.btnNavClassInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lbluserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 156);
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
            this.picUser.Location = new System.Drawing.Point(17, 118);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(20, 20);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUser.TabIndex = 207;
            this.picUser.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 20;
            this.btnLogout.Location = new System.Drawing.Point(213, 118);
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
            // lbluserName
            // 
            this.lbluserName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbluserName.Location = new System.Drawing.Point(44, 116);
            this.lbluserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(162, 25);
            this.lbluserName.TabIndex = 204;
            this.lbluserName.Text = "userName";
            this.lbluserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbluserName.Click += new System.EventHandler(this.lbluserName_Click);
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
            this.pnlRibbon.TabIndex = 205;
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.Controls.Add(this.iconTitle);
            this.pnlFormHeader.Controls.Add(this.lblFormTopic);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(250, 25);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(1030, 40);
            this.pnlFormHeader.TabIndex = 206;
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
            // lblFormTopic
            // 
            this.lblFormTopic.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFormTopic.Location = new System.Drawing.Point(46, 0);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(250, 40);
            this.lblFormTopic.TabIndex = 1;
            this.lblFormTopic.Text = "Dashboard";
            this.lblFormTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(250, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1030, 655);
            this.pnlMain.TabIndex = 207;
            // 
            // FrmDashboard
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.pnlNavBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlRibbon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.pnlFormHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlRibbon;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnNavManageReservations;
        private FontAwesome.Sharp.IconPictureBox iconTitle;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconButton btnNavClassInfo;
        private FontAwesome.Sharp.IconButton btnNavCheckAvailability;
        private FontAwesome.Sharp.IconPictureBox btnLogout;
        private FontAwesome.Sharp.IconButton btnNavManageClasses;
        private FontAwesome.Sharp.IconButton btnNavManageBuildings;
        private FontAwesome.Sharp.IconPictureBox picUser;
        private FontAwesome.Sharp.IconButton btnNavManageApartments;
        private FontAwesome.Sharp.IconButton btnNavManageParkings;
        private FontAwesome.Sharp.IconButton btnNavExtendRequests;
        private FontAwesome.Sharp.IconButton btnNavAddParkings;
        private FontAwesome.Sharp.IconButton btnNavAddUsers;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnNavManageApplications;
        private FontAwesome.Sharp.IconButton btnNavCustomers;
    }
}