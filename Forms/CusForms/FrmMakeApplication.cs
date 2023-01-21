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

namespace E_Apartments.Forms.CusForms
{
    public partial class FrmMakeApplication : Form
    {
        public FrmMakeApplication()
        {
            InitializeComponent();
            // Create the tooltip
            ToolTip tooltip = new ToolTip();
            // Set the tooltip text
            tooltip.SetToolTip(icoInfo, "This Additional Parking Fee " + Environment.NewLine + "will be added to the total Payble.");
        }
        AppDbContext _appDbContext;

        /// <summary>Handles the Load event of the FrmMakeApplication control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmMakeApplication_Load(object sender, EventArgs e)
        {
            lblCusId.Text = FrmCusApartmentManager.CustomerID;
            lblApartmentID.Text = FrmCusApartmentManager.ApartmentID;
            lblRF.Text = lblRF.Text + FrmCusApartmentManager.RefundableAmount;
            lblInstallment.Text = lblInstallment.Text + FrmCusApartmentManager.MonthlyInstallment;
            if (FrmCusApartmentManager.AdditionalParkingState == true)
                lblAddParkings.Text = lblAddParkings.Text + FrmCusApartmentManager.AdditionalParkingFee;
            else
            {
                lblAddParkings.Text = lblAddParkings.Text + "0";
            }

            txtEmail.Text = FrmCusApartmentManager.CustomerEmail;
        }

        /// <summary>Handles the Click event of the btnConfirm control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(dtpRequireFrom.Value >= DateTime.Today)
            {
                if(dtpRequireFrom.Value.Date == dtpRequireTo.Value.Date)
                {
                    MessageBox.Show("Required From Date and Required To Dates are Equal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtpRequireTo.Value < DateTime.Today)
                {
                    MessageBox.Show("Required To Date should not in Past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _appDbContext = new AppDbContext();
                    Guid CusId = Guid.Parse(FrmCusApartmentManager.CustomerID);
                    string ApartmentId = Convert.ToString(FrmCusApartmentManager.ApartmentID);
                    var existingApplication = _appDbContext.AptApplication.Where(x=>x.CustomerId == CusId && x.ApartmentId == ApartmentId && x.Status == "Pending").FirstOrDefault();
                    
                    if(existingApplication != null)
                    {
                        MessageBox.Show("You Already made a Application on this Apartment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (FrmCusApartmentManager.AdditionalParkingState)
                        {
                            int addPkId = (int)FrmCusApartmentManager.AdditionalParkingId;
                            try
                            {
                                _appDbContext = new AppDbContext();
                                var aptApplication = new AptApplication();
                                aptApplication.AppID = Guid.NewGuid();
                                aptApplication.Status = "Pending";
                                aptApplication.CustomerId = CusId;
                                aptApplication.ApartmentId = ApartmentId;
                                aptApplication.CreatedAt = DateTime.Now;
                                aptApplication.ResrvedFrom = dtpRequireFrom.Value;
                                aptApplication.ResrvedTo = dtpRequireTo.Value;
                                aptApplication.AddParkingId = addPkId;

                                _appDbContext.AptApplication.Add(aptApplication);
                                _appDbContext.SaveChanges();
                                MessageBox.Show("Application on this Apartment sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            try
                            {
                                _appDbContext = new AppDbContext();
                                var aptApplication = new AptApplication();
                                aptApplication.AppID = Guid.NewGuid();
                                aptApplication.Status = "Pendig";
                                aptApplication.CustomerId = CusId;
                                aptApplication.ApartmentId = ApartmentId;
                                aptApplication.CreatedAt = DateTime.Now;
                                aptApplication.ResrvedFrom = dtpRequireFrom.Value;
                                aptApplication.ResrvedTo = dtpRequireTo.Value;

                                _appDbContext.AptApplication.Add(aptApplication);
                                _appDbContext.SaveChanges();
                                MessageBox.Show("Application on this Apartment sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Required From Date should not in Past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Click event of the btnCancel control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
