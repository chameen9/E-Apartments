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
    public partial class FrmApartmentManage : Form
    {
        public FrmApartmentManage()
        {
            InitializeComponent();

            cmbApartmentID.SelectedIndexChanged += new System.EventHandler(cmbApartmentID_SelectedIndexChanged);
            cmbBuildingId.SelectedIndexChanged += new System.EventHandler(cmbBuildingId_SelectedIndexChanged);
        }
        AppDbContext _appDbContext;

        private void loadBuildingIds()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var Ids = _appDbContext.Buildings.Select(c => c.BuildingId).ToList();
                Ids.Insert(0, "-Select-"); // add "-Select-" as the first item
                cmbBuildingId.DataSource = Ids;
                //cmbFilterBuilding.DataSource = classIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadParkingIDs(bool FilterWithBuilding, string BuildingId)
        {
            try
            {
                _appDbContext = new AppDbContext();
                var ids = _appDbContext.Parkings.Where(c => c.Status == "Available").Select(c => c.ParkingId).ToList();
                if(FilterWithBuilding)
                {
                    ids = _appDbContext.Parkings.Where(c => c.Status == "Available" && c.BuildingId == BuildingId).Select(c => c.ParkingId).ToList();
                }
                
                else
                {
                    ids = _appDbContext.Parkings.Where(c => c.Status == "Available").Select(c => c.ParkingId).ToList();
                }
                ids.Insert(0, "-Select-"); // add "-Select-" as the first item
                cmbParkingId.DataSource = ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadClassIds()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var ids = _appDbContext.Classes.Select(c => c.ClassId).ToList();
                ids.Insert(0, "-Select-");
                cmbClassId.DataSource= ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void calculateFloorNumber(string buildingId)
        {
            try
            {
                if (buildingId != "-Select-")
                {
                    var buildingFloorNumbers = _appDbContext.Buildings.Where(x => x.BuildingId == buildingId)
                                                                  .Select(x => x.FLoorCount)
                                                                  .FirstOrDefault();
                    cmbFloorNumber.DataSource = Enumerable.Range(1, buildingFloorNumbers).Take(buildingFloorNumbers).ToList();
                }
                else
                {
                    cmbFloorNumber.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void viewGrid()
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridApartments.DataSource = _appDbContext.Apartments
                    .Select(x => new { ID = x.ApartmentId, Floor = x.FloorNumber, Building = x.BuildingId, Parking = x.ParkingId ,Class = x.ClassId })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear()
        {
            txtApartmentId.Text = string.Empty;
            cmbBuildingId.SelectedIndex = 0;
            //cmbFloorNumber.SelectedIndex = 0;
            //cmbParkingId.SelectedIndex = 0;
            cmbClassId.SelectedIndex = 0;
        }
        private void loadApartmentIds()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var ids = _appDbContext.Apartments.Select(c => c.ApartmentId).ToList();
                ids.Insert(0, "-Select-");
                cmbApartmentID.DataSource = ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void changeFeildStatus(bool Primary, bool Secondary)
        {
            btnClose.Visible = Primary;
            btnUpdate.Visible = Primary;
            btnDelete.Visible = Primary;
            cmbApartmentID.Visible = Primary;
            btnSearch.Visible = Primary;

            btnSearch.Visible = Secondary;
            txtApartmentId.Visible = Secondary;
            btnClear.Visible = Secondary;
            btnAdd.Visible = Secondary;
        }

        private void btnSearchEvent()
        {
            changeFeildStatus(true, false);
            loadApartmentIds();
            cmbApartmentID.SelectedIndex = 0;
        }
        private void fetchDataToFields(string key, int selectedIndex)
        {
            try
            {
                _appDbContext = new AppDbContext();
                var selectedApartmentId = key;
                var selectedApartment = _appDbContext.Apartments.FirstOrDefault(c => c.ApartmentId == selectedApartmentId);
                if (selectedApartment != null)
                {
                    txtApartmentId.Text = selectedApartment.ApartmentId;
                    cmbBuildingId.Text = selectedApartment.BuildingId;
                    cmbClassId.Text = selectedApartment.ClassId;
                    cmbParkingId.Text = selectedApartment.ParkingId;
                    cmbFloorNumber.Text = selectedApartment.FloorNumber.ToString();

                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else if (selectedIndex == 0)
                {
                    clear();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmApartmentManage_Load(object sender, EventArgs e)
        {
            loadBuildingIds();
            loadParkingIDs(true,null);
            loadClassIds();
            viewGrid();

            lblBuildingName.Text= string.Empty;
            lblClassName.Text= string.Empty;

            if (txtSearchBox.Text == "")
            {
                txtSearchBox.Text = "Enter Building ID or Class ID";
                txtSearchBox.ForeColor = Color.Silver;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var existingApartmentId = _appDbContext.Apartments.Where(x=>x.ApartmentId == txtApartmentId.Text).FirstOrDefault();

            if(txtApartmentId.Text == string.Empty || cmbBuildingId.SelectedIndex == 0 || cmbParkingId.SelectedIndex == 0 || cmbFloorNumber.DataSource == null || cmbClassId.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select/Fill all the Details","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (existingApartmentId != null)
            {
                MessageBox.Show("Apartment Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var maxApartmentsCount = _appDbContext.Buildings.Where(x => x.BuildingId == cmbBuildingId.SelectedValue.ToString()).Select(x => x.ApartmentsCount).FirstOrDefault();
                var savedApartmentsCount = _appDbContext.Apartments.Where(x => x.BuildingId == cmbBuildingId.SelectedValue.ToString()).Count();
                if(maxApartmentsCount != savedApartmentsCount)
                {
                    _appDbContext = new AppDbContext();
                    var apartment = new Apartment();
                    apartment.ApartmentId = txtApartmentId.Text;
                    apartment.BuildingId = cmbBuildingId.SelectedValue.ToString();
                    apartment.FloorNumber = Convert.ToInt32(cmbFloorNumber.SelectedValue.ToString());
                    apartment.ParkingId = cmbParkingId.SelectedValue.ToString();
                    apartment.ClassId = cmbClassId.SelectedValue.ToString();
                    _appDbContext.Apartments.Add(apartment);
                    _appDbContext.SaveChanges();

                    try
                    {
                        _appDbContext = new AppDbContext();
                        //Get existing class from database
                        var parkingToUpdate = _appDbContext.Parkings.FirstOrDefault(c => c.ParkingId == cmbParkingId.Text.ToString());

                        if (parkingToUpdate != null)
                        {
                            //Update properties
                            parkingToUpdate.Status = "Reserved";

                            //Mark the class as modified
                            _appDbContext.Entry(parkingToUpdate).State = System.Data.Entity.EntityState.Modified;
                            //Save changes to the database
                            _appDbContext.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Parking ID Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    viewGrid();
                    clear();
                    //MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("You can't add anymore Apartment in to this Building :" + cmbBuildingId.SelectedValue + Environment.NewLine + "Because it reached to the Maximum amount of Apartments in that Building.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();
                //Get existing class from database
                var apartmentToUpdate = _appDbContext.Apartments.FirstOrDefault(c => c.ApartmentId == cmbApartmentID.Text.ToString());

                if (apartmentToUpdate != null)
                {
                    //Update properties
                    apartmentToUpdate.FloorNumber = Convert.ToInt32(cmbFloorNumber.Text.ToString());
                    apartmentToUpdate.BuildingId = cmbBuildingId.Text.ToString();
                    apartmentToUpdate.ParkingId = cmbParkingId.Text.ToString();
                    apartmentToUpdate.ClassId = cmbClassId.Text.ToString();

                    //Mark the class as modified
                    _appDbContext.Entry(apartmentToUpdate).State = System.Data.Entity.EntityState.Modified;
                    //Save changes to the database
                    _appDbContext.SaveChanges();

                    MessageBox.Show("Apartment : " + cmbApartmentID.Text.ToString() + " Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    cmbApartmentID.SelectedIndex = 0;
                    loadApartmentIds();
                    viewGrid();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _appDbContext = new AppDbContext();
                    var selectedApartmentId = cmbApartmentID.SelectedValue.ToString();
                    var selectedApartment = _appDbContext.Apartments.FirstOrDefault(c => c.ApartmentId == selectedApartmentId);
                    if (selectedApartment != null)
                    {
                        _appDbContext.Apartments.Remove(selectedApartment);
                        _appDbContext.SaveChanges();
                        MessageBox.Show("Apartment : " + selectedApartmentId + " removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadApartmentIds();
                        viewGrid();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearchEvent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            changeFeildStatus(false, true);
            clear();
        }

        private void cmbBuildingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadParkingIDs(true,cmbBuildingId.SelectedValue.ToString());
            calculateFloorNumber(cmbBuildingId.SelectedValue.ToString());

            if(cmbBuildingId.SelectedIndex != 0)
            {
                lblBuildingName.Text = "(Name : " + _appDbContext.Buildings.Where(x => x.BuildingId == cmbBuildingId.SelectedValue.ToString()).Select(x => x.BuildingName).FirstOrDefault()+")";
            }
            else
            {
                lblBuildingName.Text = string.Empty;
            }
        }

        private void cmbApartmentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchDataToFields(cmbApartmentID.Text.ToString(), cmbApartmentID.SelectedIndex);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbParkingId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbClassId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClassId.SelectedIndex != 0)
            {
                lblClassName.Text = "(Name : " + _appDbContext.Classes.Where(x => x.ClassId == cmbClassId.SelectedValue.ToString()).Select(x => x.ClassName).FirstOrDefault() + ")";
            }
            else
            {
                lblClassName.Text = string.Empty;
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBox.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                viewGrid();
            }
            else if (searchText == "Enter Building ID or Class ID")
            {
                viewGrid();
            }
            else
            {
                
                DGridApartments.DataSource = _appDbContext.Apartments
                                              .Where(x => x.BuildingId.Contains(searchText) || x.ClassId.Contains(searchText))
                                              .Select(x => new { ID = x.ApartmentId, Floor = x.FloorNumber, Building = x.BuildingId, Parking = x.ParkingId, Class = x.ClassId })
                                              .ToList();
            }
            DGridApartments.Refresh();
        }

        private void txtSearchBox_Enter(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "Enter Building ID or Class ID")
            {
                txtSearchBox.Text = "";
                txtSearchBox.ForeColor = Color.White;
            }
        }

        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "")
            {
                txtSearchBox.Text = "Enter Building ID or Class ID";
                txtSearchBox.ForeColor = Color.Silver;
            }
        }
    }
}
