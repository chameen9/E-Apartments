using E_Apartments.Data;
using E_Apartments.Forms.Customer;
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

namespace E_Apartments.Forms.CusForms
{
    public partial class FrmExtendLeasing : Form
    {
        public FrmExtendLeasing()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;

        public static Guid guidLeasingId;
        public DateTime LeasingExpireDate;
        private void FrmExtendLeasing_Load(object sender, EventArgs e)
        {
            try
            {
                guidLeasingId = FrmCusDashboard.LeaseId;
                txtLeasingId.Text = FrmCusDashboard.LeaseId.ToString();
                _appDbContext = new AppDbContext();
                var thisLeasing = _appDbContext.Leasings.FirstOrDefault(x => x.LeasingId == guidLeasingId);
                if (thisLeasing != null)
                {

                    txtClassId.Text = thisLeasing.ClassID.ToString();
                    txtApartmentId.Text = thisLeasing.ApartmentID.ToString();
                    txtRefundableamount.Text = thisLeasing.RefundableAmount.ToString();
                    txtMonthlyInstallment.Text = thisLeasing.MonthlyRate.ToString();
                    txtStartedDate.Text = thisLeasing.StartedDate.ToString();
                    txtEndDate.Text = thisLeasing.EndDate.ToString();
                    LeasingExpireDate = thisLeasing.EndDate;

                    _appDbContext = new AppDbContext();
                    var thisClass = _appDbContext.Classes.Where(x => x.ClassId == thisLeasing.ClassID.ToString()).FirstOrDefault();
                    txtReservationFee.Text = thisClass.NonRefundableReservationAmount.ToString();
                    lblClassName.Text = thisClass.ClassName.ToString();

                    if (FrmCusDashboard.enableLeaseExtendBtn)
                    {
                        btnMakeExtendRequest.Enabled = true;
                    }
                    else
                    {
                        btnMakeExtendRequest.Enabled = false;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnMakeExtendRequest_Click(object sender, EventArgs e)
        {
            if (dtpExtendedTo.Value.Date < LeasingExpireDate.AddMonths(2))
            {
                MessageBox.Show("The gap between extended date and lease expire date should be at least 2 months.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpExtendedTo.Value < LeasingExpireDate)
            {
                MessageBox.Show("Extended Date should not be less than Lease Expire Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                _appDbContext = new AppDbContext();
                var existingRequest = _appDbContext.LeaseExtendRequest.FirstOrDefault(x => x.LeasingId == guidLeasingId && x.Status == "Requested");
                if (existingRequest != null)
                {
                    MessageBox.Show("You Already made a request on this leasing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _appDbContext = new AppDbContext();
                        var leaseExRequest = new LeaseExtendRequest();
                        leaseExRequest.RequestId = Guid.NewGuid();
                        leaseExRequest.LeasingId = guidLeasingId;
                        leaseExRequest.Status = "Requested";
                        leaseExRequest.RequestedAt = DateTime.Now;
                        leaseExRequest.RequestedEndDate = dtpExtendedTo.Value;
                        _appDbContext.LeaseExtendRequest.Add(leaseExRequest);
                        _appDbContext.SaveChanges();
                        MessageBox.Show("Extend Request on this Lease Agreement Sent Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
