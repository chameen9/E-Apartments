using E_Apartments.Data;
using E_Apartments.Forms.CusForms;
using E_Apartments.Forms.Customer_Forms;
using E_Apartments.Models;
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

namespace E_Apartments.Forms.Customer
{
    public partial class FrmCusDashboard : Form
    {
        public FrmCusDashboard()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;

        // for panel to act as the ribbon
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        // for panel to act as the ribbon

        /// <summary>Changes the button properties.</summary>
        /// <param name="clickedButton">The clicked button.</param>
        private void ChangeButtonProperties(IconButton clickedButton)
        {
            List<IconButton> allButtons = new List<IconButton> {
                btnNavFindApartments,
                btnNavExtendLease,
                btnCusReservations,
                btnNavOccupents,
                btnNavApplications
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
        }
        /// <summary>Resets the button properties.</summary>
        private void ResetButtonProperties()
        {
            List<IconButton> allButtons = new List<IconButton> {
                btnNavFindApartments,
                btnNavExtendLease,
                btnCusReservations,
                btnNavOccupents,
                btnNavApplications
            };

            foreach (IconButton button in allButtons)
            {
                button.BackColor = Color.FromArgb(31, 32, 71);
                button.ForeColor = Color.White;
                button.IconColor = Color.White;
            }
        }
        public static Guid cusIdforReservation;
        public static Guid cusIdApplication;
        public static Guid LeaseId;
        public static DateTime LeaseEndDate;
        public static Guid CustomerId;
        public static bool enableLeaseExtendBtn;
        /// <summary>Handles the Load event of the FrmCusDashboard control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmCusDashboard_Load(object sender, EventArgs e)
        {
            _appDbContext = new AppDbContext();
            if (FrmLogin.userEmail != null && _appDbContext != null)
            {
                string customerEmail = FrmLogin.userEmail.ToString();
                
                var customerSaves = _appDbContext.CustomerSaves;
                if (customerSaves != null)
                {
                    var customer = customerSaves.Where(x => x.CustomerEmail == customerEmail).FirstOrDefault();
                    lblName.Text = customer.CustomerName;
                    CustomerId = customer.CustomerId;

                    _appDbContext = new AppDbContext();
                    var exisitngResv = _appDbContext.Reservation.FirstOrDefault(r => r.CustomerId == customer.CustomerId && r.Status == "Pending");
                    if (exisitngResv != null)
                    {
                        btnCusReservations.Visible = true;
                        cusIdforReservation = exisitngResv.CustomerId;
                    }
                    else
                    {
                        btnCusReservations.Visible = false;
                    }

                    _appDbContext = new AppDbContext();
                    var existingApplication = _appDbContext.AptApplication.FirstOrDefault(r => r.CustomerId == customer.CustomerId && r.Status == "Pending");
                    if (existingApplication != null)
                    {
                        btnNavApplications.Visible = true;
                        btnNavFindApartments.Visible = false;
                        cusIdApplication = existingApplication.CustomerId;
                    }
                    else
                    {
                        btnNavApplications.Visible = false;
                        btnNavFindApartments.Visible = true;
                    }

                }
                else
                {
                    //MessageBox.Show("CustomerSaves object is null");
                }
            }
            else
            {
                //
            }

            string cusEmail = FrmLogin.userEmail.ToString(); 
            _appDbContext = new AppDbContext();
            var foundCustomer = _appDbContext.CustomerSaves.FirstOrDefault(x=>x.CustomerEmail == cusEmail);
            if(foundCustomer != null)
            {
                var cusID = foundCustomer.CustomerId;
                _appDbContext = new AppDbContext();
                var ExistingReservation = _appDbContext.Reservation.FirstOrDefault(x=>x.CustomerId == cusID);
                if(ExistingReservation != null)
                {
                    btnNavFindApartments.Visible = false;
                }
                else
                {
                    btnNavFindApartments.Visible = true;
                }
            }

            if (String.IsNullOrEmpty(FrmLogin.leasingId))//leasingID
            {
                btnNavExtendLease.Visible = false;
            }
            else
            {
                
                LeaseId = Guid.Parse(FrmLogin.leasingId);
                _appDbContext= new AppDbContext();
                var thisLeasing = _appDbContext.Leasings.FirstOrDefault(x => x.LeasingId == LeaseId);
                LeaseEndDate = thisLeasing.EndDate;

                if (LeaseEndDate <= DateTime.Now.AddMonths(2))      // find the leasing
                {
                    btnNavExtendLease.Visible = true;
                    enableLeaseExtendBtn = true;
                }
                else
                {
                    btnNavExtendLease.Visible = true;
                    enableLeaseExtendBtn = false;
                }
            }

            pnlMain.Controls.Clear();

            FrmWaitDashboard frmWaitDashboard = new FrmWaitDashboard();
            frmWaitDashboard.TopLevel = false;
            pnlMain.Controls.Add(frmWaitDashboard);
            frmWaitDashboard.Dock = DockStyle.Fill;
            frmWaitDashboard.Show();
        }

        /// <summary>Handles the MouseDown event of the pnlRibbon control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
        private void pnlRibbon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>Handles the Click event of the picLogo control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void picLogo_Click(object sender, EventArgs e)
        {
            ResetButtonProperties();

            lblFormTopic.Text = "Customer Dashborad";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Bars;
            pnlMain.Controls.Clear();

            FrmWaitDashboard frmWaitDashboard = new FrmWaitDashboard();
            frmWaitDashboard.TopLevel = false;
            pnlMain.Controls.Add(frmWaitDashboard);
            frmWaitDashboard.Dock = DockStyle.Fill;
            frmWaitDashboard.Show();
        }

        /// <summary>Handles the Click event of the btnNavFindApartments control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavFindApartments_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavFindApartments);

            lblFormTopic.Text = "Find an Apartment";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Building;
            pnlMain.Controls.Clear();

            FrmFindApartments frmFindApartments = new FrmFindApartments();
            frmFindApartments.TopLevel = false;
            pnlMain.Controls.Add(frmFindApartments);
            frmFindApartments.Dock = DockStyle.Fill;
            frmFindApartments.Show();
        }

        /// <summary>Handles the Click event of the btnNavExtendLease control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavExtendLease_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavExtendLease);

            lblFormTopic.Text = "Extend Lease";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.HandshakeSimple;
            pnlMain.Controls.Clear();

            
            FrmExtendLeasing frmExtendLeasing = new FrmExtendLeasing();
            frmExtendLeasing.TopLevel = false;
            pnlMain.Controls.Add(frmExtendLeasing);
            frmExtendLeasing.Dock = DockStyle.Fill;
            frmExtendLeasing.Show();
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

        /// <summary>Handles the Click event of the btnMinimize control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>Handles the Click event of the btnExit control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>Handles the Click event of the btnCusReservations control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCusReservations_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnCusReservations);

            lblFormTopic.Text = "Your Reservations";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            pnlMain.Controls.Clear();

            FrmCusMadeReservations frmCusMadeReservations = new FrmCusMadeReservations();
            frmCusMadeReservations.TopLevel = false;
            pnlMain.Controls.Add(frmCusMadeReservations);
            frmCusMadeReservations.Dock = DockStyle.Fill;
            frmCusMadeReservations.Show();


        }

        /// <summary>Handles the Click event of the btnNavOccupents control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavOccupents_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavOccupents);

            lblFormTopic.Text = "Occupents";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            pnlMain.Controls.Clear();

            FrmCusOccupents frmCusOccupents = new FrmCusOccupents();
            frmCusOccupents.TopLevel = false;
            pnlMain.Controls.Add(frmCusOccupents);
            frmCusOccupents.Dock = DockStyle.Fill;
            frmCusOccupents.Show();
        }

        /// <summary>Handles the Click event of the btnNavApplications control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNavApplications_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(btnNavApplications);

            lblFormTopic.Text = "Applications";
            iconTitle.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            pnlMain.Controls.Clear();

            FrmCusApplications frmCusApplications = new FrmCusApplications();
            frmCusApplications.TopLevel = false;
            pnlMain.Controls.Add(frmCusApplications);
            frmCusApplications.Dock = DockStyle.Fill;
            frmCusApplications.Show();
        }
    }
}
