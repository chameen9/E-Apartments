using E_Apartments.Data;
using E_Apartments.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Forms.Admin
{
    public partial class FrmMarkReservations : Form
    {
        public FrmMarkReservations()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        /// <summary>Handles the Click event of the btnCancel control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Guid thisLeasingId;
        /// <summary>Handles the Click event of the btnLaese control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnLaese_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Before leasing this apartment, Please Make sure all the dues are Payed by the Customer."+Environment.NewLine+"Click Ok to cinfirm the payments and confirm the Lease.","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    _appDbContext = new AppDbContext();
                    var thisLeasing = new Leasing();
                    thisLeasing.LeasingId = thisLeasingId = Guid.NewGuid();
                    thisLeasing.ApartmentID = FrmManageReservations.ApartmentID;
                    thisLeasing.StartedDate = Convert.ToDateTime(FrmManageReservations.ReservedFrom);
                    thisLeasing.EndDate = Convert.ToDateTime(FrmManageReservations.ReservedTo);
                    thisLeasing.AdditionalParkingFee = Convert.ToDouble(FrmManageReservations.AddParkingFee);
                    thisLeasing.RefundableAmount = Convert.ToDouble(FrmManageReservations.RefubdableAmount);
                    thisLeasing.MonthlyRate = Convert.ToDouble(FrmManageReservations.MonthlyInstallment);
                    thisLeasing.TotalAmount = Convert.ToDouble(FrmManageReservations.TotalAmount);
                    thisLeasing.PaidAmount = Convert.ToDouble(FrmManageReservations.PaidAmount);
                    thisLeasing.Balance = Convert.ToDouble(FrmManageReservations.Balance);
                    thisLeasing.ClassID = FrmManageReservations.ClassID;

                    _appDbContext.Leasings.Add(thisLeasing);
                    _appDbContext.SaveChanges();
                    //MessageBox.Show("Leasing Added !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


                _appDbContext = new AppDbContext();
                var foundCustomer = _appDbContext.CustomerSaves.FirstOrDefault(x => x.CustomerName == FrmManageReservations.CustomerName && x.LeasingId == null);
                if(foundCustomer != null)
                {
                    try
                    {
                        foundCustomer.LeasingId = thisLeasingId;
                        _appDbContext.Entry(foundCustomer).State = System.Data.Entity.EntityState.Modified;
                        _appDbContext.SaveChanges();
                        //MessageBox.Show("Customer Found");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Customer Not Found");
                }
                string ApartmentIdForRservation = FrmManageReservations.ApartmentID.ToString();
                _appDbContext = new AppDbContext();
                var thisReservation = _appDbContext.Reservation.FirstOrDefault(x => x.CustomerId == foundCustomer.CustomerId && x.ApartmentId == ApartmentIdForRservation);
                if(thisReservation != null)
                {
                    try
                    {
                        thisReservation.Status = "Completed";
                        _appDbContext.Entry(thisReservation).State = System.Data.Entity.EntityState.Modified;
                        _appDbContext.SaveChanges();
                        //MessageBox.Show("Reservation Found");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Reservation ID Not Found");
                }
                
                MessageBox.Show("New Leasing created.","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //nothing
            }
        }

        /// <summary>Handles the Load event of the FrmMarkReservations control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmMarkReservations_Load(object sender, EventArgs e)
        {
            try
            {
                txtCusName.Text = FrmManageReservations.CustomerName;
                txtApartmentId.Text = FrmManageReservations.ApartmentID;
                dtpStart.Value = Convert.ToDateTime(FrmManageReservations.ReservedFrom);
                dtpEnd.Value = Convert.ToDateTime(FrmManageReservations.ReservedTo);
                txtClassId.Text = FrmManageReservations.ClassID;

                _appDbContext = new AppDbContext();
                var thisClass = _appDbContext.Classes.FirstOrDefault(x => x.ClassId == txtClassId.Text);

                txtReservationFee.Text = thisClass.NonRefundableReservationAmount.ToString();
                lblCurrentDue.Text = FrmManageReservations.Balance;
                lblPaid.Text = FrmManageReservations.PaidAmount;
                lblTotal.Text = FrmManageReservations.TotalAmount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
