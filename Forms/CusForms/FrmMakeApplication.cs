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

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
