using E_Apartments.Forms.Admin;
using E_Apartments.Forms.Clerk;
using E_Apartments.Forms.EmpGeneral;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnLogout, "Click to Logout");
        }

        // for panel to act as the ribbon
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        // for panel to act as the ribbon

        /// <summary>Handles the Load event of the FrmDashboard control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            
            lbluserName.Text = FrmLogin.userName;

            pnlMain.Controls.Clear();

            FrmWaitDashboard frmWaitDashboard = new FrmWaitDashboard();
            frmWaitDashboard.TopLevel = false;
            pnlMain.Controls.Add(frmWaitDashboard);
            frmWaitDashboard.Dock = DockStyle.Fill;
            frmWaitDashboard.Show();

            if(FrmLogin.userType == "Clerk")
            {
                btnNavCheckAvailability.Visible = true;
                btnNavClassInfo.Visible = true;

                btnNavManageClasses.Visible = false;
                btnNavManageBuildings.Visible = false;
                btnNavManageApartments.Visible = false;
                btnNavManageParkings.Visible = false;
                btnNavManageReservations.Visible = false;
                btnNavExtendRequests.Visible = false;
                btnNavAddParkings.Visible = false;
                btnNavAddUsers.Visible = false;
                btnNavManageApplications.Visible = false;
                btnNavCustomers.Visible = false;
            }
            
            else if(FrmLogin.userType == "Admin")
            {
                //admin
                btnNavCheckAvailability.Visible = true;
                btnNavClassInfo.Visible = true;

                btnNavManageClasses.Visible = true;
                btnNavManageBuildings.Visible = true;
                btnNavManageApartments.Visible = true;
                btnNavManageParkings.Visible = true;
                btnNavManageReservations.Visible = true;
                btnNavExtendRequests.Visible = true;
                btnNavAddParkings.Visible = true;
                btnNavManageApplications.Visible = true;
                btnNavCustomers.Visible = true;

                btnNavAddUsers.Visible = false;
            }
            else if(FrmLogin.userType == "SuperAdmin")
            {
                //Super admin
                btnNavCheckAvailability.Visible = true;
                btnNavClassInfo.Visible = true;

                btnNavManageClasses.Visible = true;
                btnNavManageBuildings.Visible = true;
                btnNavManageApartments.Visible = true;
                btnNavManageParkings.Visible = true;
                btnNavManageReservations.Visible = true;
                btnNavExtendRequests.Visible = true;
                btnNavAddParkings.Visible = true;
                btnNavManageApplications.Visible = true;
                btnNavCustomers.Visible = true;

                btnNavAddUsers.Visible = true;
            }
            else
            {
                btnNavCheckAvailability.Visible = false;
                btnNavClassInfo.Visible = false;

                btnNavManageClasses.Visible = false;
                btnNavManageBuildings.Visible = false;
                btnNavManageApartments.Visible = false;
                btnNavManageParkings.Visible = false;
                btnNavManageReservations.Visible = false;
                btnNavExtendRequests.Visible = false;
                btnNavAddParkings.Visible = false;
                btnNavAddUsers.Visible = false;
                btnNavManageApplications.Visible = false;
                btnNavCustomers.Visible = false;
            }
        }
        /// <summary>Changes the button properties.</summary>
        /// <param name="clickedButton">The clicked button.</param>
        private void ChangeButtonProperties(IconButton clickedButton)
        {
            List<IconButton> allButtons = new List<IconButton> { 
                //btnNavAddCustomer, 
                btnNavManageReservations, 
                btnNavCheckAvailability, 
                btnNavClassInfo,
                btnNavManageClasses, 
                btnNavManageBuildings,
                btnNavManageApartments,
                btnNavManageParkings,
                btnNavExtendRequests,
                btnNavAddParkings,
                btnNavAddUsers,
                btnNavManageApplications,
                btnNavCustomers
            };

            foreach (IconButton button in allButtons)
            {
                if (button == clickedButton)
                {
                    button.BackColor = Color.FromArgb(35, 35, 78);
                    button.ForeColor = Color.FromArgb(0, 143, 251);
                    button.IconColor = Color.FromArgb(0, 143, 251);
                }
                else
                {
                    button.BackColor = Color.FromArgb(31, 32, 71);
                    button.ForeColor = Color.White;
                    button.IconColor = Color.White;
                }
            }
            lbluserName.ForeColor = Color.White;
            picUser.IconColor = Color.SteelBlue;
        }
        /// <summary>Resets the button properties.</summary>
        private void ResetButtonProperties()
        {
            List<IconButton> allButtons = new List<IconButton> {
                //btnNavAddCustomer,
                btnNavManageReservations,
                btnNavCheckAvailability,
                btnNavClassInfo,
                btnNavManageClasses,
                btnNavManageBuildings,
                btnNavManageApartments,
                btnNavManageParkings,
                btnNavExtendRequests,
                btnNavAddParkings,
                btnNavAddUsers,
                btnNavManageApplications,
                btnNavCustomers
            };

            foreach (IconButton button in allButtons)
            {
                button.BackColor = Color.FromArgb(31, 32, 71);
                button.ForeColor = Color.White;
                button.IconColor = Color.White;
            }
            
        }

        /// <summary>Handles the MouseDown event of the pnlRibbon control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
        private void pnlRibbon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>Handles the Click event of the btnNavAddLease control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavAddLease_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavManageReservations);

            lblFormTopic.Text = "Manage Reservations";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            pnlMain.Controls.Clear();

            FrmManageReservations frmManageReservations = new FrmManageReservations();
            frmManageReservations.TopLevel = false;
            pnlMain.Controls.Add(frmManageReservations);
            frmManageReservations.Dock = DockStyle.Fill;
            frmManageReservations.Show();
        }


        /// <summary>Handles the 1 event of the btnExit_Click control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>Handles the Click event of the btnMinimize control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>Handles the Click event of the picLogo control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void picLogo_Click(object sender, EventArgs e)
        {
            lblFormTopic.Text = "Dashboard";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Bars;

            pnlMain.Controls.Clear();

            FrmWaitDashboard frmWaitDashboard = new FrmWaitDashboard();
            frmWaitDashboard.TopLevel = false;
            pnlMain.Controls.Add(frmWaitDashboard);
            frmWaitDashboard.Dock = DockStyle.Fill;
            frmWaitDashboard.Show();

            ResetButtonProperties();
            lbluserName.ForeColor = Color.White;
            picUser.IconColor = Color.SteelBlue;
        }

        /// <summary>Handles the Click event of the btnNavCheckAvailability control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavCheckAvailability_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavCheckAvailability);

            lblFormTopic.Text = "Check Availability";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            pnlMain.Controls.Clear();

            FrmCheckAvailability frmCheckAvailability = new FrmCheckAvailability();
            frmCheckAvailability.TopLevel = false;
            pnlMain.Controls.Add(frmCheckAvailability);
            frmCheckAvailability.Dock = DockStyle.Fill;
            frmCheckAvailability.Show();
        }

        /// <summary>Handles the Click event of the btnNavClassInfo control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavClassInfo_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavClassInfo);

            lblFormTopic.Text = "Class Information";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            pnlMain.Controls.Clear();

            FrmClassInfo frmClassInfo = new FrmClassInfo();
            frmClassInfo.TopLevel = false;
            pnlMain.Controls.Add(frmClassInfo);
            frmClassInfo.Dock = DockStyle.Fill;
            frmClassInfo.Show();
        }

        /// <summary>Handles the Click event of the btnLogout control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        /// <summary>Handles the Click event of the btnNavManageClasses control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavManageClasses_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavManageClasses);

            lblFormTopic.Text = "Manage Classes";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            pnlMain.Controls.Clear();

            FrmClassManage frmClassManage = new FrmClassManage();
            frmClassManage.TopLevel = false;
            pnlMain.Controls.Add(frmClassManage);
            frmClassManage.Dock = DockStyle.Fill;
            frmClassManage.Show();
        }

        /// <summary>Handles the Click event of the btnNavManageBuildings control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavManageBuildings_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavManageBuildings);

            lblFormTopic.Text = "Manage Buildings";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Building;
            pnlMain.Controls.Clear();

            FrmBuildingManage frmBuildingManage = new FrmBuildingManage();
            frmBuildingManage.TopLevel = false;
            pnlMain.Controls.Add(frmBuildingManage);
            frmBuildingManage.Dock = DockStyle.Fill;
            frmBuildingManage.Show();
        }

        /// <summary>Handles the Click event of the btnNavManageApartments control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavManageApartments_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavManageApartments);

            lblFormTopic.Text = "Manage Apartments";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            pnlMain.Controls.Clear();

            FrmApartmentManage frmApartmentManage = new FrmApartmentManage();
            frmApartmentManage.TopLevel = false;
            pnlMain.Controls.Add(frmApartmentManage);
            frmApartmentManage.Dock = DockStyle.Fill;
            frmApartmentManage.Show();
        }

        /// <summary>Handles the Click event of the btnNavManageParkings control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavManageParkings_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavManageParkings);

            lblFormTopic.Text = "Manage Parkings";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.SquareParking;
            pnlMain.Controls.Clear();

            FrmParkingManage frmParkingManage = new FrmParkingManage();
            frmParkingManage.TopLevel = false;
            pnlMain.Controls.Add(frmParkingManage);
            frmParkingManage.Dock = DockStyle.Fill;
            frmParkingManage.Show();
        }

        /// <summary>Handles the Click event of the btnNavExtendRequests control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavExtendRequests_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavExtendRequests);

            lblFormTopic.Text = "Extend Requests";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            pnlMain.Controls.Clear();

            FrmExtendRequestManage frmExtendRequestManage = new FrmExtendRequestManage();
            frmExtendRequestManage.TopLevel = false;
            pnlMain.Controls.Add(frmExtendRequestManage);
            frmExtendRequestManage.Dock = DockStyle.Fill;
            frmExtendRequestManage.Show(); 
        }

        /// <summary>Handles the Click event of the btnNavAddParkings control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavAddParkings_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavAddParkings);

            lblFormTopic.Text = "Manage Additional Parkings";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.SquareParking;
            pnlMain.Controls.Clear();

            FrmManageAdditionalParkings frmManageAdditionalParkings = new FrmManageAdditionalParkings();
            frmManageAdditionalParkings.TopLevel = false;
            pnlMain.Controls.Add(frmManageAdditionalParkings);
            frmManageAdditionalParkings.Dock = DockStyle.Fill;
            frmManageAdditionalParkings.Show();
        }

        /// <summary>Handles the Click event of the btnNavAddUsers control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavAddUsers_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavAddUsers);

            lblFormTopic.Text = "Add Users";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            pnlMain.Controls.Clear();

            FrmAddUsers frmAddUsers = new FrmAddUsers();
            frmAddUsers.TopLevel = false;
            pnlMain.Controls.Add(frmAddUsers);
            frmAddUsers.Dock = DockStyle.Fill;
            frmAddUsers.Show();
        }

        /// <summary>Handles the Click event of the lbluserName control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void lbluserName_Click(object sender, EventArgs e)
        {
            lbluserName.ForeColor = Color.FromArgb(0, 143, 251);
            picUser.IconColor = Color.FromArgb(0, 143, 251);

            ResetButtonProperties();

            pnlMain.Controls.Clear();

            lblFormTopic.Text = "Profile";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.User;
            pnlMain.Controls.Clear();

            FrmUserProfile frmUserProfile = new FrmUserProfile();
            frmUserProfile.TopLevel = false;
            pnlMain.Controls.Add(frmUserProfile);
            frmUserProfile.Dock = DockStyle.Fill;
            frmUserProfile.Show();
        }

        /// <summary>Handles the Click event of the btnNavManageApplications control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavManageApplications_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavManageApplications);

            lblFormTopic.Text = "Manage Applications";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            pnlMain.Controls.Clear();

            FrmManageApplications frmManageApplications = new FrmManageApplications();
            frmManageApplications.TopLevel = false;
            pnlMain.Controls.Add(frmManageApplications);
            frmManageApplications.Dock = DockStyle.Fill;
            frmManageApplications.Show();
        }

        /// <summary>Handles the Click event of the btnNavCustomers control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavCustomers_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavCustomers);

            lblFormTopic.Text = "Customers";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            pnlMain.Controls.Clear();

            FrmManageCustomers frmManageCustomers = new FrmManageCustomers();
            frmManageCustomers.TopLevel = false;
            pnlMain.Controls.Add(frmManageCustomers);
            frmManageCustomers.Dock = DockStyle.Fill;
            frmManageCustomers.Show();
        }
    }
}
