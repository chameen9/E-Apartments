using E_Apartments.Data;
using E_Apartments.Models;
using E_Apartments.Validators;
using FluentValidation.Results;
using Microsoft.VisualStudio.Services.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace E_Apartments.Forms.Admin
{
    public partial class FrmClassManage : Form
    {
        public FrmClassManage()
        {
            InitializeComponent();
            LoadClassIds();

            

            cmbClassID.SelectedIndexChanged += new System.EventHandler(cmbClassID_SelectedIndexChanged);
            cmbSearchClassId.SelectedIndexChanged += new System.EventHandler(cmbSearchClassId_SelectedIndexChanged);

        }
       
        AppDbContext _appDbContext;
        /// <summary>Handles the Click event of the btnSearch control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnStatus(true, false);
            LoadClassIds();
            cmbClassID.SelectedIndex = 0;
        }

        /// <summary>Handles the Click event of the btnClose control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnStatus(false, true);
            Clear();
        }

        /// <summary>BTNs the status.</summary>
        /// <param name="major">if set to <c>true</c> [major].</param>
        /// <param name="secd">if set to <c>true</c> [secd].</param>
        private void btnStatus(bool major, bool secd)
        {
            btnClose.Visible = major;
            btnUpdate.Visible = major;
            btnDelete.Visible = major;
            cmbClassID.Visible = major;
            btnSearch.Visible = major;

            btnSearch.Visible = secd;
            txtClassID.Visible = secd;
            btnClear.Visible = secd;
            btnAdd.Visible = secd;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        /// <summary>Clears this instance.</summary>
        private void Clear()
        {
            txtClassID.Text = string.Empty;
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

        /// <summary>Handles the Click event of the btnAdd control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();
                //Validate Fields
                var ValClass = new Class();
                ValClass.ClassId = txtClassID.Text.ToString();
                ValClass.ClassName = txtClassName.Text.ToString();
                ValClass.RefundableAmount = double.Parse(txtRefundableAmount.Text);
                ValClass.NonRefundableReservationAmount = double.Parse(txtNonRefundableReservationFee.Text);
                ValClass.MonthlyRate = double.Parse(txtMonthlyInstallment.Text);
                ValClass.RoomsWithAttachedBathroomsCount = (int)nmbRoomsWithAttachedBathroomsCount.Value;
                ValClass.CommonBathroomsCount = (int)nmbCommonBathroomsCount.Value;
                ValClass.CommonRoomsCount = (int)nmbCommonRoomsCount.Value;
                ValClass.ServentBathroomsCount = (int)nmbServentBathroomCount.Value;
                ValClass.ServentRoomsCount = (int)nmbServentRoomsCount.Value;
                ValClass.AdditionalParkingFee = double.Parse(txtAdditionalParkingFee.Text);
                ValClass.MaxOccuepentsCount = (int)nmbMaxOccuoentsCount.Value;

                ClassValidator classValidator = new ClassValidator();
                ValidationResult results = classValidator.Validate(ValClass);
                if (!results.IsValid)
                {
                    foreach (var failure in results.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    var existingClassId = _appDbContext.Classes.Where(x => x.ClassId == txtClassID.Text).FirstOrDefault();

                    if (existingClassId != null)
                    {
                        MessageBox.Show("Class ID Aleready Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _appDbContext.Classes.Add(ValClass);
                        _appDbContext.SaveChanges();
                        //MessageBox.Show("Saved");
                        Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>Handles the Load event of the FrmClassManage control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmClassManage_Load(object sender, EventArgs e)
        {
            txtRefundableAmount.Text = "0.00";
            txtNonRefundableReservationFee.Text = "0.00";
            txtMonthlyInstallment.Text = "0.00";
            txtAdditionalParkingFee.Text = "0.00";

        }

        /// <summary>Handles the Click event of the btnUpdate control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateClassDetails();
            cmbClassID.SelectedIndex = 0;
            LoadClassIds();
        }
        /// <summary>Updates the class details.</summary>
        void updateClassDetails()
        {
            try
            {
                _appDbContext = new AppDbContext();
                //Get existing class from database
                var classToUpdate = _appDbContext.Classes.FirstOrDefault(c => c.ClassId == cmbClassID.Text.ToString());

                if (classToUpdate != null)
                {
                    //Update properties
                    classToUpdate.ClassName = txtClassName.Text.ToString();
                    classToUpdate.RefundableAmount = double.Parse(txtRefundableAmount.Text);
                    classToUpdate.NonRefundableReservationAmount = double.Parse(txtNonRefundableReservationFee.Text);
                    classToUpdate.MonthlyRate = double.Parse(txtMonthlyInstallment.Text);
                    classToUpdate.RoomsWithAttachedBathroomsCount = (int)nmbRoomsWithAttachedBathroomsCount.Value;
                    classToUpdate.CommonBathroomsCount = (int)nmbCommonBathroomsCount.Value;
                    classToUpdate.CommonRoomsCount = (int)nmbCommonRoomsCount.Value;
                    classToUpdate.ServentBathroomsCount = (int)nmbServentBathroomCount.Value;
                    classToUpdate.ServentRoomsCount = (int)nmbServentRoomsCount.Value;
                    classToUpdate.AdditionalParkingFee = double.Parse(txtAdditionalParkingFee.Text);
                    classToUpdate.MaxOccuepentsCount = (int)nmbMaxOccuoentsCount.Value;

                    //Mark the class as modified
                    _appDbContext.Entry(classToUpdate).State = System.Data.Entity.EntityState.Modified;
                    //Save changes to the database
                    _appDbContext.SaveChanges();
                    MessageBox.Show("Class : "+cmbClassID.Text.ToString()+" Updated.","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Class Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>Handles the SelectedIndexChanged event of the cmbClassID control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void cmbClassID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassDetailsToFields(cmbClassID.Text.ToString(),cmbClassID.SelectedIndex);

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
                    txtClassID.Text = selectedClass.ClassId;
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

                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else if (selectedIndex == 0)
                {
                    Clear();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Loads the class ids.</summary>
        private void LoadClassIds()
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
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>Handles the Click event of the btnDelete control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();
                var selectedClassId = cmbClassID.SelectedValue.ToString();
                var selectedClass = _appDbContext.Classes.FirstOrDefault(c => c.ClassId == selectedClassId);
                if (selectedClass != null)
                {
                    _appDbContext.Classes.Remove(selectedClass);
                    _appDbContext.SaveChanges();
                    MessageBox.Show("Class deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClassIds();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the SelectedIndexChanged event of the cmbSearchClassId control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void cmbSearchClassId_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassDetailsToFields(cmbSearchClassId.Text.ToString(),cmbSearchClassId.SelectedIndex);
        }

        /// <summary>Handles the TextChanged event of the cmbSearchClassId control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void cmbSearchClassId_TextChanged(object sender, EventArgs e)
        {
            cmbSearchClassId.Items.Clear();
            string searchedKey = cmbSearchClassId.Text;
            var classIds = _appDbContext.Classes
                .Where(c => c.ClassId.StartsWith(searchedKey))
                .Select(c => c.ClassId)
                .ToList();

            if (classIds.Count == 0)
            {
                cmbSearchClassId.Items.Add("Not found");
            }
            else
            {
                cmbSearchClassId.Items.Add(searchedKey);
                foreach (string item in classIds)
                    cmbSearchClassId.Items.Add(item);
            }
            cmbSearchClassId.DroppedDown = true;
            cmbSearchClassId.SelectionStart = searchedKey.Length;
            cmbSearchClassId.SelectionLength = 0;
            cmbSearchClassId.AutoCompleteMode = AutoCompleteMode.None;
        }
    }
}
