using E_Apartments.Data;
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
    public partial class FrmMarkApplications : Form
    {
        public FrmMarkApplications()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        /// <summary>Handles the Load event of the FrmMarkApplications control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmMarkApplications_Load(object sender, EventArgs e)
        {
            try
            {
                txtApartmentId.Text = FrmManageApplications.thisApartmentId;
                lblCusId.Text = FrmManageApplications.thisCustomerId;
                txtCusName.Text = FrmManageApplications.thisCustomerName;
                dtpStart.Value = Convert.ToDateTime(FrmManageApplications.thisAppliedFrom);
                dtpEnd.Value = Convert.ToDateTime(FrmManageApplications.thisAppliedTo);
                txtAppliedAtDate.Text = FrmManageApplications.thisAppliedDate;
                txtAddPkId.Text = FrmManageApplications.thisApID;
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Click event of the btnCancel control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>Handles the Click event of the btnAccept control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Guid ExistingcusId = Guid.Parse(FrmManageApplications.thisCustomerId);
            string ExistingApartmentId = FrmManageApplications.thisApartmentId;
            _appDbContext = new AppDbContext();
            var ExistingApplication = _appDbContext.AptApplication.FirstOrDefault(x => x.CustomerId == ExistingcusId && x.ApartmentId == ExistingApartmentId && x.Status == "Accepted");
            if (ExistingApplication != null)
            {
                MessageBox.Show("You alraedy accepted this Application.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Guid cusId = Guid.Parse(FrmManageApplications.thisCustomerId);
                string ApartmentId = FrmManageApplications.thisApartmentId;
                _appDbContext = new AppDbContext();
                var thisApplication = _appDbContext.AptApplication.FirstOrDefault(x => x.CustomerId == cusId && x.ApartmentId == ApartmentId && x.Status == "Pending");
                if (thisApplication != null)
                {
                    thisApplication.Status = "Accepted";
                    _appDbContext.Entry(thisApplication).State = System.Data.Entity.EntityState.Modified;
                    _appDbContext.SaveChanges();

                    string thiEmail = thisApplication.CustomerSave.CustomerEmail.ToString();
                    string thisApId = thisApplication.ApartmentId.ToString();
                    MailSender.SendMailWithoutMessage(
                        thiEmail,
                        "Application Accepted.",
                        "Congratulations ! <br>" +
                        "Your Application for Apartment :" + thisApId + " has been accepted." + "<br>" +
                        "Please make a reservation to continue."
                        );
                    MessageBox.Show("This Application Marked as Accepted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Application Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
