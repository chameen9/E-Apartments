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
            }
        }
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
                btnNavManageApplications
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
                btnNavManageApplications
            };

            foreach (IconButton button in allButtons)
            {
                button.BackColor = Color.FromArgb(31, 32, 71);
                button.ForeColor = Color.White;
                button.IconColor = Color.White;
            }
            
        }

        private void pnlRibbon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnNavAddCusomer_Click(object sender, EventArgs e)
        {
            //navigateAddCustomer();
        }
        private void navigateAddCustomer()
        {
            //ChangeButtonProperties(btnNavAddCustomer);

            lblFormTopic.Text = "Register Customer";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            pnlMain.Controls.Clear();

            FrmAddCustomer frmAddCustomer = new FrmAddCustomer();
            frmAddCustomer.TopLevel = false;
            pnlMain.Controls.Add(frmAddCustomer);
            frmAddCustomer.Dock = DockStyle.Fill;
            frmAddCustomer.Show();
        }

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
        

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

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
    }
}
