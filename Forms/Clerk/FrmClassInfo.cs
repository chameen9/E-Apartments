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

namespace E_Apartments.Forms.Clerk
{
    public partial class FrmClassInfo : Form
    {
        public FrmClassInfo()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;

        /// <summary>Loads the class ids.</summary>
        private void loadClassIds()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var classIds = _appDbContext.Classes.Select(c => c.ClassId).ToList();
                classIds.Insert(0, "-Select-"); // add "-Select-" as the first item
                cmbClassID.DataSource = classIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>Handles the Load event of the FrmClassInfo control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmClassInfo_Load(object sender, EventArgs e)
        {
            loadClassIds();
        }

        /// <summary>Handles the SelectedIndexChanged event of the cmbClassID control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void cmbClassID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassDetailsToFields(cmbClassID.Text,cmbClassID.SelectedIndex);
        }
        /// <summary>Loads the class details to fields.</summary>
        /// <param name="key">The key.</param>
        /// <param name="selectedIndex">Index of the selected.</param>
        private void LoadClassDetailsToFields(string key, int selectedIndex)
        {
            try
            {
                _appDbContext = new AppDbContext();
                var selectedClassId = key;
                var selectedClass = _appDbContext.Classes.FirstOrDefault(c => c.ClassId == selectedClassId);
                if (selectedClass != null)
                {
                    
                    txtClassName.Text = selectedClass.ClassName;
                    txtRefundableAmount.Text = selectedClass.RefundableAmount.ToString();
                    txtNonRefundableReservationFee.Text = selectedClass.NonRefundableReservationAmount.ToString();
                    txtMonthlyInstallment.Text = selectedClass.MonthlyRate.ToString();
                    nmbRoomsWithAttachedBathroomsCount.Value = selectedClass.RoomsWithAttachedBathroomsCount;
                    nmbCommonBathroomsCount.Value = selectedClass.CommonBathroomsCount;
                    nmbCommonRoomsCount.Value = selectedClass.CommonRoomsCount;
                    nmbServentBathroomCount.Value = selectedClass.ServentBathroomsCount;
                    nmbServentRoomsCount.Value = selectedClass.ServentRoomsCount;
                    txtAdditionalParkingFee.Text = selectedClass.AdditionalParkingFee.ToString();
                    nmbMaxOccuoentsCount.Value = selectedClass.MaxOccuepentsCount;

                   
                }
                else if (selectedIndex == 0)
                {
                    Clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>Clears this instance.</summary>
        private void Clear()
        {
            
            txtClassName.Text = string.Empty;
            txtRefundableAmount.Text = "0.00";
            txtNonRefundableReservationFee.Text = "0.00";
            txtMonthlyInstallment.Text = "0.00";
            txtAdditionalParkingFee.Text = "0.00";
            nmbCommonBathroomsCount.Value = 0;
            nmbCommonRoomsCount.Value = 0;
            nmbMaxOccuoentsCount.Value = 0;
            nmbRoomsWithAttachedBathroomsCount.Value = 0;
            nmbServentBathroomCount.Value = 0;
            nmbServentRoomsCount.Value = 0;
        }

        /// <summary>Handles the Click event of the btnSearch control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadClassIds();
        }
    }
}
