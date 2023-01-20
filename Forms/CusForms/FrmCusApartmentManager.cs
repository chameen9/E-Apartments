using E_Apartments.Data;
using E_Apartments.Forms.Customer_Forms;
using E_Apartments.Models;
using Microsoft.VisualStudio.Services.ActivityStatistic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Forms.CusForms
{
    public partial class FrmCusApartmentManager : Form
    {
        public FrmCusApartmentManager()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        public static string CustomerEmail;
        public static Guid foundCustomerId;
        private void FrmCusApartmentManager_Load(object sender, EventArgs e)
        {
            txtSelectedApartment.Text = FrmFindApartments.cellApartmentId.ToString();
            txtLocation.Text = FrmFindApartments.cellBuildingLocation.ToString();
            txtFloorNumber.Text = FrmFindApartments.cellFloorNumber.ToString();
            txtBuildingId.Text = FrmFindApartments.cellBuildingId.ToString();
            txtClassId.Text = FrmFindApartments.cellClassId.ToString();
            CustomerEmail = FrmLogin.userEmail.ToString();

            _appDbContext = new AppDbContext();
            var parkingId = _appDbContext.Apartments.Where(x => x.ApartmentId == txtSelectedApartment.Text).Select(x=>x.ParkingId).FirstOrDefault();

            txtParkingId.Text = parkingId.ToString();

            _appDbContext = new AppDbContext();
            var selectedClass = _appDbContext.Classes.Where(x=>x.ClassId == txtClassId.Text).FirstOrDefault();

            lblRF.Text = lblRF.Text+selectedClass.RefundableAmount.ToString();
            RefundableAmount = selectedClass.RefundableAmount.ToString();
            lblRSV.Text = lblRSV.Text + selectedClass.NonRefundableReservationAmount.ToString();
            ReservationFee = selectedClass.NonRefundableReservationAmount.ToString();
            lblInstallment.Text = lblInstallment.Text + selectedClass.MonthlyRate.ToString();
            MonthlyInstallment = selectedClass.MonthlyRate.ToString();
            lblRWAB.Text = lblRWAB.Text + selectedClass.RoomsWithAttachedBathroomsCount.ToString();
            lblBC.Text = lblBC.Text + selectedClass.CommonBathroomsCount.ToString();
            lblRC.Text = lblRC.Text + selectedClass.CommonRoomsCount.ToString();
            lblBSV.Text = lblBSV.Text + selectedClass.ServentBathroomsCount.ToString();
            lblSVRBathrooms.Text = lblSVRBathrooms.Text + selectedClass.ServentRoomsCount.ToString();
            lblMaxOc.Text = lblMaxOc.Text + selectedClass.MaxOccuepentsCount.ToString();
            lblAddParkingFee.Text = lblAddParkingFee.Text + selectedClass.AdditionalParkingFee.ToString();
            AdditionalParkingFee = selectedClass.AdditionalParkingFee.ToString();

            _appDbContext = new AppDbContext();
            var additionalparkingIds = _appDbContext.AdditionalParkings.Where(x => x.AddStatus == "Available" && x.BuildingId == txtBuildingId.Text).Select(X=>X.AddParkingId).ToList();
            if (additionalparkingIds != null)
            {
                additionalparkingIds.Insert(0, 0);
                
                cmbAddParkings.DataSource = additionalparkingIds;
            }
            else
            {
                
            }
            _appDbContext = new AppDbContext();
            var foundCusID = _appDbContext.CustomerSaves.Where(x=>x.CustomerEmail == CustomerEmail).Select(x=>x.CustomerId).FirstOrDefault();
            foundCustomerId = foundCusID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string CustomerID;
        public static string ApartmentID;
        public static string RefundableAmount;
        public static string MonthlyInstallment;
        public static string AdditionalParkingFee;
        public static bool AdditionalParkingState;
        public static string ReservationFee;
        public static int AdditionalParkingId;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _appDbContext = new AppDbContext();
            var existApartment = _appDbContext.Apartments.Where(x => x.ApartmentId == txtSelectedApartment.Text && x.CustomerId == null).FirstOrDefault();


            if (cmbAddParkings.SelectedIndex != 0)
            {
                // additional parkings selected

                if (existApartment == null)
                {
                    //no mathing apartments found == if there is no customer in this apartment == 
                    DialogResult result = MessageBox.Show("This Apartment is Already Taken or Unavailable." + Environment.NewLine + "If You want to Make an Application for this Apartment," + Environment.NewLine + "Please Click Yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //make application
                        CustomerID = foundCustomerId.ToString();
                        ApartmentID = txtSelectedApartment.Text;
                        AdditionalParkingState = true;
                        AdditionalParkingId = Convert.ToInt32(cmbAddParkings.Text);

                        FrmMakeApplication frmMakeApplication = new FrmMakeApplication();
                        frmMakeApplication.FormClosed += (s, args) => this.Enabled = true;
                        frmMakeApplication.ShowDialog();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do You want to make a Reservation on this?" +  Environment.NewLine + "Please Click Yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //make application
                        CustomerID = foundCustomerId.ToString();
                        ApartmentID = txtSelectedApartment.Text;
                        AdditionalParkingState = true;
                        AdditionalParkingId = Convert.ToInt32(cmbAddParkings.Text);

                        FrmMakeReservation frmMakeReservation = new FrmMakeReservation();
                        frmMakeReservation.FormClosed += (s, args) => this.Enabled = true;
                        frmMakeReservation.ShowDialog();
                    }

                }

            }
            else
            {
                if (existApartment == null)
                {
                    //no mathing apartments found == if there is no customer in this apartment == 
                    DialogResult result = MessageBox.Show("This Apartment is Already Taken." + Environment.NewLine + "If You want to Make an Application for this Apartment,"+Environment.NewLine+"Please Click Yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //make application
                        CustomerID = foundCustomerId.ToString();
                        ApartmentID = txtSelectedApartment.Text;
                        AdditionalParkingState = false;

                        FrmMakeApplication frmMakeApplication = new FrmMakeApplication();
                        frmMakeApplication.FormClosed += (s, args) => this.Enabled = true;
                        frmMakeApplication.ShowDialog();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do You want to make a Reservation on this?" + Environment.NewLine + "Please Click Yes to continue.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //make application
                        CustomerID = foundCustomerId.ToString();
                        ApartmentID = txtSelectedApartment.Text;
                        AdditionalParkingState = false;

                        FrmMakeReservation frmMakeReservation = new FrmMakeReservation();
                        frmMakeReservation.FormClosed += (s, args) => this.Enabled = true;
                        frmMakeReservation.ShowDialog();
                    }

                }
            }
        }
    }
}
