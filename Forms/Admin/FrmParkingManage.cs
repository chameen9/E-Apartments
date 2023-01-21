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
    public partial class FrmParkingManage : Form
    {
        public FrmParkingManage()
        {
            InitializeComponent();

            cmbParkingId.SelectedIndexChanged += new System.EventHandler(cmbParkingId_SelectedIndexChanged);

            
        }
        AppDbContext _appDbContext;

        /// <summary>Changes the feild status.</summary>
        /// <param name="Primary">if set to <c>true</c> [primary].</param>
        /// <param name="Secondary">if set to <c>true</c> [secondary].</param>
        private void changeFeildStatus(bool Primary, bool Secondary)
        {
            btnClose.Visible = Primary;
            btnUpdate.Visible = Primary;
            btnDelete.Visible = Primary;
            cmbParkingId.Visible = Primary;
            btnSearch.Visible = Primary;

            btnSearch.Visible = Secondary;
            txtParkingId.Visible = Secondary;
            btnClear.Visible = Secondary;
            btnAdd.Visible = Secondary;
        }
        /// <summary>Loads the building ids.</summary>
        private void loadBuildingIds()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var classIds = _appDbContext.Buildings.Select(c => c.BuildingId).ToList();
                classIds.Insert(0, "-Select-"); // add "-Select-" as the first item
                cmbBuildingId.DataSource = classIds;
                cmbFilterBuilding.DataSource = classIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>Loads the parking i ds.</summary>
        private void loadParkingIDs()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var ids = _appDbContext.Parkings.Select(c => c.ParkingId).ToList();
                ids.Insert(0, "-Select-"); // add "-Select-" as the first item
                cmbParkingId.DataSource = ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>Loads the parking statuses.</summary>
        private void loadParkingStatuses()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var statuses = _appDbContext.Parkings.Select(p => p.Status).Distinct().ToList();
                statuses.Insert(0, "-Select-");
                cmbFilterStatus.DataSource = statuses;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>BTNs the search event.</summary>
        private void btnSearchEvent()
        {
            changeFeildStatus(true, false);
            loadParkingIDs();
            cmbParkingId.SelectedIndex = 0;
        }
        /// <summary>Views the grid.</summary>
        private void ViewGrid()
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridParkings.DataSource = _appDbContext.Parkings
                    .Select(x => new { ID = x.ParkingId, Building_ID = x.BuildingId, Status = x.Status})
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>Clears the specified text focus.</summary>
        /// <param name="txtFocus">if set to <c>true</c> [text focus].</param>
        private void clear(bool txtFocus)
        {
            txtParkingId.Text = string.Empty;
            cmbBuildingId.SelectedIndex = 0;
            //cmbParkingId.SelectedIndex = 0;
            if (txtFocus)
            {
                txtParkingId.Focus();
            }
            else
            {
                cmbBuildingId.Focus();
            }
        }
        /// <summary>Fetches the data to fields.</summary>
        /// <param name="key">The key.</param>
        /// <param name="selectedIndex">Index of the selected.</param>
        private void fetchDataToFields(string key, int selectedIndex)
        {
            try
            {
                _appDbContext = new AppDbContext();
                var selcetedParkingId = key;
                var selectedParking = _appDbContext.Parkings.FirstOrDefault(c => c.ParkingId == selcetedParkingId);
                if (selectedParking != null)
                {
                    txtParkingId.Text = selectedParking.ParkingId;
                    cmbBuildingId.Text = selectedParking.BuildingId;

                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else if (selectedIndex == 0)
                {
                    clear(false);
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>Filters the d grid.</summary>
        private void filterDGrid()
        {
            try
            {
                if (cmbFilterBuilding.SelectedItem != null && cmbFilterStatus.SelectedItem != null)
                {
                    _appDbContext = new AppDbContext();
                    string FilterbuildingId = cmbFilterBuilding.SelectedItem.ToString();
                    string status = cmbFilterStatus.SelectedItem.ToString();
                    if (FilterbuildingId != "-Select-" && status != "-Select-")
                    {
                        DGridParkings.DataSource = _appDbContext.Parkings
                            .Where(p => p.BuildingId == FilterbuildingId && p.Status == status)
                            .Select(x => new { ID = x.ParkingId, Building_ID = x.BuildingId, Status = x.Status })
                            .ToList();
                    }
                    else if (FilterbuildingId != "-Select-" && status == "-Select-")
                    {
                        DGridParkings.DataSource = _appDbContext.Parkings
                            .Where(p => p.BuildingId == FilterbuildingId)
                            .Select(x => new { ID = x.ParkingId, Building_ID = x.BuildingId, Status = x.Status })
                            .ToList();
                    }
                    else if (FilterbuildingId == "-Select-" && status != "-Select-")
                    {
                        DGridParkings.DataSource = _appDbContext.Parkings
                            .Where(p => p.Status == status)
                            .Select(x => new { ID = x.ParkingId, Building_ID = x.BuildingId, Status = x.Status })
                            .ToList();
                    }
                    else
                    {
                        ViewGrid();
                    }
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Load event of the FrmParkingManage control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmParkingManage_Load(object sender, EventArgs e)
        {
            loadParkingStatuses();
            loadBuildingIds();
            clear(true);
            ViewGrid();
        }

        /// <summary>Handles the Click event of the btnClear control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear(true);
        }

        /// <summary>Handles the Click event of the btnAdd control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var buildingNoramlParkingsCount = _appDbContext.Buildings.Where(x => x.BuildingId == cmbBuildingId.Text).Select(x => x.ParkingsCount).FirstOrDefault();

                var addedParkingsCount = _appDbContext.Parkings.Where(x => x.BuildingId == cmbBuildingId.Text).Count();

                var existingParkingId = _appDbContext.Parkings.Where(x => x.ParkingId == txtParkingId.Text).FirstOrDefault();

                if (existingParkingId != null)
                {
                    MessageBox.Show("Building ID Aleready Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtParkingId.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter a Parking Id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbBuildingId.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select a Building", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (buildingNoramlParkingsCount == addedParkingsCount)
                {
                    MessageBox.Show("You already entered the Maximum Limit of the Parkings in that Building.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _appDbContext = new AppDbContext();
                    var parking = new Parking();
                    parking.ParkingId= txtParkingId.Text;
                    parking.BuildingId = cmbBuildingId.Text.ToString();
                    parking.Status = "Available";

                    _appDbContext.Parkings.Add(parking);
                    _appDbContext.SaveChanges();
                    //MessageBox.Show("Saved");
                    clear(true);
                    loadBuildingIds();
                    ViewGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Click event of the btnUpdate control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();
                //Get existing class from database
                var parkingToUpdate = _appDbContext.Parkings.FirstOrDefault(c => c.ParkingId == cmbParkingId.Text.ToString());

                if (parkingToUpdate != null)
                {
                    //Update properties
                    parkingToUpdate.BuildingId = cmbBuildingId.Text.ToString();
                    parkingToUpdate.Status = "Available";

                    //Mark the class as modified
                    _appDbContext.Entry(parkingToUpdate).State = System.Data.Entity.EntityState.Modified;
                    //Save changes to the database
                    _appDbContext.SaveChanges();

                    MessageBox.Show("Parking : " + cmbParkingId.Text.ToString() + " Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear(false);
                    cmbParkingId.SelectedIndex = 0;
                    loadBuildingIds();
                    ViewGrid();
                }
                else
                {
                    MessageBox.Show("Parking Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Click event of the btnDelete control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _appDbContext = new AppDbContext();
                    var selectedParkingId = cmbParkingId.SelectedValue.ToString();
                    var selectedParking = _appDbContext.Parkings.FirstOrDefault(c => c.ParkingId == selectedParkingId);
                    if (selectedParking != null)
                    {
                        _appDbContext.Parkings.Remove(selectedParking);
                        _appDbContext.SaveChanges();
                        MessageBox.Show("Parking : " + selectedParkingId + " removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadBuildingIds();
                        ViewGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                // Cancel
            }
        }

        /// <summary>Handles the Click event of the btnSearch control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearchEvent();
        }

        /// <summary>Handles the Click event of the btnClose control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            changeFeildStatus(false, true);
            clear(true);
        }

        /// <summary>Handles the SelectedIndexChanged event of the cmbParkingId control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void cmbParkingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchDataToFields(cmbParkingId.Text.ToString(), cmbParkingId.SelectedIndex);
        }

        private void DGridParkings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnSearchEvent();
            //string key = DGridParkings.CurrentRow.Cells[0].Value.ToString();
            //cmbParkingId.Text = key;
            //fetchDataToFields(key, cmbParkingId.SelectedIndex);
        }

        /// <summary>Handles the SelectedIndexChanged event of the cmbFilterBuilding control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void cmbFilterBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDGrid();
        }

        /// <summary>Handles the SelectedIndexChanged event of the cmbFilterStatus control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDGrid();
        }
    }
}
