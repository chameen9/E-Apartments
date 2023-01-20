using E_Apartments.Data;
using E_Apartments.Forms.Customer;
using E_Apartments.Forms.Customer_Forms;
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
using System.Windows.Media.Animation;

namespace E_Apartments.Forms.CusForms
{
    public partial class FrmMakeReservation : Form
    {
        public FrmMakeReservation()
        {
            InitializeComponent();

            // Create the tooltip
            ToolTip tooltip = new ToolTip();
            // Set the tooltip text
            tooltip.SetToolTip(icoInfo, "This Additional Parking Fee " + Environment.NewLine + "will be added to the total Payble.");
            tooltip.SetToolTip(icorsvinfo, "The Reservation Fee " + Environment.NewLine + "is Non-Refundable.");
            tooltip.SetToolTip(icoinfoTotPay, "The Total Payble Fee is" + Environment.NewLine + "Calculated for all the payments,"+Environment.NewLine+"Including Monthly Installments.");
        }
        AppDbContext _appDbContext;

        private void FrmMakeReservation_Load(object sender, EventArgs e)
        {
            lblCusId.Text = FrmCusApartmentManager.CustomerID;
            txtAparmtmentId.Text = FrmCusApartmentManager.ApartmentID;
            lblRF.Text = lblRF.Text + FrmCusApartmentManager.RefundableAmount;
            lblInstallment.Text = lblInstallment.Text + FrmCusApartmentManager.MonthlyInstallment;
            lblRsvFee.Text = lblRsvFee.Text + FrmCusApartmentManager.ReservationFee;
            if (FrmCusApartmentManager.AdditionalParkingState == true)
                lblAddParkings.Text = lblAddParkings.Text + FrmCusApartmentManager.AdditionalParkingFee;
            else
            {
                lblAddParkings.Text = lblAddParkings.Text + "0";
            }

            txtEmail.Text = FrmCusApartmentManager.CustomerEmail;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public double addParki;

        private void calonly()
        {
            int months = ((dtpReservedTo.Value.Year - dtpReservedFrom.Value.Year) * 12) + dtpReservedTo.Value.Month - dtpReservedFrom.Value.Month;

            double refundAm = Convert.ToDouble(FrmCusApartmentManager.RefundableAmount);
            double monthIns = Convert.ToDouble(FrmCusApartmentManager.MonthlyInstallment);

            if (FrmCusApartmentManager.AdditionalParkingState == true)
            {
                addParki = Convert.ToDouble(FrmCusApartmentManager.AdditionalParkingFee);
            }
            else
            {
                addParki = 0.00;
            }

            double resveFee = Convert.ToDouble(FrmCusApartmentManager.ReservationFee);

            double TotalPayble = refundAm + (monthIns * months) + addParki + resveFee;
            lblCalculatedTotOnly.Text = TotalPayble.ToString();
            lblTot.Text = "Payble Amount      : Rs." + TotalPayble.ToString();
        }

        private void calculation()
        {
            if (dtpReservedFrom.Value >= DateTime.Today)
            {
                if (dtpReservedFrom.Value.Date == dtpReservedTo.Value.Date)
                {
                    MessageBox.Show("Reserved From Date and Reserved To Dates are Equal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtpReservedTo.Value < DateTime.Today)
                {
                    MessageBox.Show("Reserved To Date should not in Past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int months = ((dtpReservedTo.Value.Year - dtpReservedFrom.Value.Year) * 12) + dtpReservedTo.Value.Month - dtpReservedFrom.Value.Month;

                    double refundAm = Convert.ToDouble(FrmCusApartmentManager.RefundableAmount);
                    double monthIns = Convert.ToDouble(FrmCusApartmentManager.MonthlyInstallment);

                    if (FrmCusApartmentManager.AdditionalParkingState == true)
                    {
                        addParki = Convert.ToDouble(FrmCusApartmentManager.AdditionalParkingFee);
                    }
                    else
                    {
                        addParki = 0.00;
                    }

                    double resveFee = Convert.ToDouble(FrmCusApartmentManager.ReservationFee);

                    double TotalPayble = refundAm + (monthIns * months) + addParki + resveFee;

                    lblTot.Text = "Payble Amount      : Rs." + TotalPayble.ToString();

                }
            }
            else
            {
                MessageBox.Show("Reserved From Date should not in Past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public double totAmount;
        public double totPaid;
        public double ResvFee;
        public double RfFee;
        public double AddPaFee;
        public double MontIns;
        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (dtpReservedFrom.Value >= DateTime.Today)
            {
                if (dtpReservedFrom.Value.Date == dtpReservedTo.Value.Date)
                {
                    MessageBox.Show("Reserved From Date and Reserved To Dates are Equal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtpReservedTo.Value < DateTime.Today)
                {
                    MessageBox.Show("Reserved To Date should not in Past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    calonly();
                    _appDbContext = new AppDbContext();
                    Guid cusId = Guid.Parse(FrmCusApartmentManager.CustomerID);
                    var existingreservation = _appDbContext.Reservation.Where(x => x.CustomerId == cusId && x.ApartmentId == txtAparmtmentId.Text && x.Status == "Pending").FirstOrDefault();
                    if(existingreservation != null)
                    {
                        MessageBox.Show("You Already made a Reservation on this Apartment.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ResvFee = double.Parse(FrmCusApartmentManager.ReservationFee);
                        RfFee = double.Parse(FrmCusApartmentManager.RefundableAmount);
                        MontIns = double.Parse(FrmCusApartmentManager.MonthlyInstallment);
                        
                        _appDbContext = new AppDbContext();
                        var reservation = new Reservation();

                        reservation.ResvId = Guid.NewGuid();
                        reservation.Status = "Pending";
                        reservation.CustomerId = Guid.Parse(FrmCusApartmentManager.CustomerID);
                        reservation.ApartmentId = txtAparmtmentId.Text;
                        reservation.CreatedAt = DateTime.Now;
                        reservation.ResrvedFrom = dtpReservedFrom.Value;
                        reservation.ResrvedTo = dtpReservedTo.Value;

                        if (FrmCusApartmentManager.AdditionalParkingState == true)
                        {
                            reservation.AdditionalParkingFee = double.Parse(FrmCusApartmentManager.AdditionalParkingFee);
                            AddPaFee = double.Parse(FrmCusApartmentManager.AdditionalParkingFee);

                            totPaid = ResvFee + RfFee + AddPaFee + MontIns;
                            reservation.PaidAmount = totPaid;
                        }
                        else
                        {
                            totPaid = ResvFee + RfFee + MontIns;
                            reservation.PaidAmount = totPaid;
                        }
                        reservation.RefundableAmount = double.Parse(FrmCusApartmentManager.RefundableAmount);
                        reservation.MonthlyRate = double.Parse(FrmCusApartmentManager.MonthlyInstallment);
                        reservation.TotalAmount = double.Parse(lblCalculatedTotOnly.Text);
                        totAmount = double.Parse(lblCalculatedTotOnly.Text);
                        double balance = totAmount - totPaid;
                        reservation.Balance = balance;
                        reservation.ClassID = FrmFindApartments.cellClassId.ToString();


                        _appDbContext.Reservation.Add(reservation);
                        _appDbContext.SaveChanges();
                        //MessageBox.Show("Saved in Reservation");
                        _appDbContext = new AppDbContext();
                        var apartment = new Apartment();
                        var apartmentToUpdate = _appDbContext.Apartments.FirstOrDefault(c => c.ApartmentId == txtAparmtmentId.Text.ToString());

                        if (apartmentToUpdate != null)
                        {
                            if(FrmCusApartmentManager.AdditionalParkingState == true)
                            {
                                int convertedAddParkingId = (int)FrmCusApartmentManager.AdditionalParkingId;
                                //Update properties
                                apartmentToUpdate.CustomerId = Guid.Parse(lblCusId.Text);
                                apartmentToUpdate.AddParkingId = convertedAddParkingId;
                                int addprkingidKey = (int)FrmCusApartmentManager.AdditionalParkingId;
                                //Mark the class as modified
                                _appDbContext.Entry(apartmentToUpdate).State = System.Data.Entity.EntityState.Modified;
                                //Save changes to the database
                                _appDbContext.SaveChanges();
                                //MessageBox.Show("Saved in apartments");

                                _appDbContext = new AppDbContext();
                                var addParkingToUpdate = _appDbContext.AdditionalParkings.FirstOrDefault(a => a.AddParkingId == addprkingidKey);
                                if(addParkingToUpdate != null)
                                {
                                    addParkingToUpdate.AddStatus = "Reserved";
                                    _appDbContext.Entry(addParkingToUpdate).State = System.Data.Entity.EntityState.Modified;
                                    _appDbContext.SaveChanges();
                                    //MessageBox.Show("Saved in add parkings");
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Additional Parking Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                //Update properties
                                apartmentToUpdate.CustomerId = Guid.Parse(lblCusId.Text);

                                //Mark the class as modified
                                _appDbContext.Entry(apartmentToUpdate).State = System.Data.Entity.EntityState.Modified;
                                //Save changes to the database
                                _appDbContext.SaveChanges();
                            }
                            
                            MailSender.SendMailWithoutMessage(FrmCusApartmentManager.CustomerEmail.ToString(), "Reservation Success !",
                                "Dear valued Customer,<br>" +
                                "Your Reservation on :"+ apartmentToUpdate.ApartmentId + " Apartment, successfully recived."
                                );
                            DialogResult result =  MessageBox.Show("Your Rservation created successfully."+Environment.NewLine+"Please Login again to continue.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                //FrmLogin frmLogin= new FrmLogin();
                                //frmLogin.Show();
                                //this.Close();

                                //FrmCusApartmentManager frmcuApManager = new FrmCusApartmentManager();
                                //frmcuApManager.Close();

                                //FrmCusDashboard frmCusDashboard = new FrmCusDashboard();
                                //frmCusDashboard.Close();
                                //FrmLogin frmLogin = new FrmLogin();
                                //frmLogin.Show();

                                //FrmCusApartmentManager frmCusApartmentManager = new FrmCusApartmentManager();
                                //frmCusApartmentManager.Dispose();

                                //FrmMakeReservation frmMakeReservation = new FrmMakeReservation();
                                //frmMakeReservation.Dispose();

                                //FrmCusDashboard frmCusDashboard = new FrmCusDashboard();
                                //frmCusDashboard.Close();

                                //this.Close();
                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Apartment Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Reserved From Date should not in Past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void dtpReservedTo_ValueChanged(object sender, EventArgs e)
        {
            calculation();
        }

        private void dtpReservedFrom_ValueChanged(object sender, EventArgs e)
        {
            calculation();
        }
    }
}
