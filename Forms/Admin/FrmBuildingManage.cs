﻿using E_Apartments.Data;
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
    public partial class FrmBuildingManage : Form
    {
        public FrmBuildingManage()
        {
            InitializeComponent();

            cmbBuildingId.SelectedIndexChanged += new System.EventHandler(cmbBuildingId_SelectedIndexChanged);

            ToolTip searchToolTip = new ToolTip();
            searchToolTip.SetToolTip(txtSearchBox, "Search By Name or Location");

        }

        private void FrmBuildingManage_Load(object sender, EventArgs e)
        {
            clear(true);
            loadBuildingIds();
            ViewGrid();

            if (txtSearchBox.Text == "")
            {
                txtSearchBox.Text = "Enter Building Name or Location";
                txtSearchBox.ForeColor = Color.Silver;
            }
        }

        private void ViewGrid()
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridBuildings.DataSource = _appDbContext.Buildings
                    .Select(x => new {ID = x.BuildingId, Name = x.BuildingName, Location = x.Location, Floors = x.FLoorCount,Apartments = x.ApartmentsCount, Norm_Parkings = x.ParkingsCount, Add_Parkings = x.AdditionalParkingsCount })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        AppDbContext _appDbContext;
       
        private void changeFeildStatus(bool Primary, bool Secondary)
        {
            btnClose.Visible = Primary;
            btnUpdate.Visible = Primary;
            btnDelete.Visible = Primary;
            cmbBuildingId.Visible = Primary;
            btnSearch.Visible = Primary;

            btnSearch.Visible = Secondary;
            txtBuildingId.Visible = Secondary;
            btnClear.Visible = Secondary;
            btnAdd.Visible = Secondary;
        }
        private void loadBuildingIds()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var classIds = _appDbContext.Buildings.Select(c => c.BuildingId).ToList();
                classIds.Insert(0, "-Select-"); // add "-Select-" as the first item
                cmbBuildingId.DataSource = classIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear(bool txtFocus)
        {
            txtBuildingId.Text = string.Empty;
            txtBuildingLocation.Text = string.Empty;
            txtBuildingName.Text = string.Empty;

            nmbAdditionalPrikingsCount.Value = 0;
            nmbApartmentsCount.Value = 0;
            nmbNormalParkingsCount.Value = 0;
            nmbFloorCount.Value = 0;
            if (txtFocus)
            {
                txtBuildingId.Focus();
            }
            else
            {
                cmbBuildingId.Focus();
            }
        }
        private void fetchDataToFields(string key, int selectedIndex)
        {
            try
            {
                _appDbContext = new AppDbContext();
                var selectedBuildingId = key;
                var selectedBuilding = _appDbContext.Buildings.FirstOrDefault(c => c.BuildingId == selectedBuildingId);
                if (selectedBuilding != null)
                {
                    txtBuildingId.Text = selectedBuilding.BuildingId;
                    txtBuildingName.Text = selectedBuilding.BuildingName;
                    txtBuildingLocation.Text = selectedBuilding.Location;
                    nmbApartmentsCount.Value = selectedBuilding.ApartmentsCount;
                    nmbNormalParkingsCount.Value = selectedBuilding.ParkingsCount;
                    nmbAdditionalPrikingsCount.Value = selectedBuilding.AdditionalParkingsCount;
                    nmbFloorCount.Value = selectedBuilding.FLoorCount;

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
        private void btnSearchEvent()
        {
            changeFeildStatus(true, false);
            loadBuildingIds();
            cmbBuildingId.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearchEvent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            changeFeildStatus(false, true);
            clear(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();
                //Validate Fields
                var building = new Building();

                building.BuildingId = txtBuildingId.Text;
                building.BuildingName = txtBuildingName.Text;
                building.Location = txtBuildingLocation.Text;
                building.ApartmentsCount = (int)nmbApartmentsCount.Value;
                building.ParkingsCount = (int)nmbNormalParkingsCount.Value;
                building.AdditionalParkingsCount = (int)nmbAdditionalPrikingsCount.Value;
                building.FLoorCount = (int)nmbFloorCount.Value;

                BuildingValidator buildingValidator = new BuildingValidator();
                ValidationResult results = buildingValidator.Validate(building);
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
                    var existingBuildongId = _appDbContext.Buildings.Where(x => x.BuildingId == txtBuildingId.Text).FirstOrDefault();

                    if (existingBuildongId != null)
                    {
                        MessageBox.Show("Building ID Aleready Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _appDbContext.Buildings.Add(building);
                        _appDbContext.SaveChanges();
                        //MessageBox.Show("Saved");
                        clear(true);
                        loadBuildingIds();
                        ViewGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();
                //Get existing class from database
                var buildingToUpdate = _appDbContext.Buildings.FirstOrDefault(c => c.BuildingId == cmbBuildingId.Text.ToString());

                if (buildingToUpdate != null)
                {
                    //Update properties
                    buildingToUpdate.BuildingName = txtBuildingName.Text.ToString();
                    buildingToUpdate.Location = txtBuildingLocation.Text.ToString();
                    buildingToUpdate.ApartmentsCount = (int)nmbApartmentsCount.Value;
                    buildingToUpdate.ParkingsCount = (int)nmbNormalParkingsCount.Value;
                    buildingToUpdate.AdditionalParkingsCount = (int)nmbAdditionalPrikingsCount.Value;
                    buildingToUpdate.FLoorCount = (int)nmbFloorCount.Value;

                    //Mark the class as modified
                    _appDbContext.Entry(buildingToUpdate).State = System.Data.Entity.EntityState.Modified;
                    //Save changes to the database
                    _appDbContext.SaveChanges();

                    MessageBox.Show("Building : " + cmbBuildingId.Text.ToString() + " Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear(false);
                    cmbBuildingId.SelectedIndex = 0;
                    loadBuildingIds();
                    ViewGrid();
                }
                else
                {
                    MessageBox.Show("Building Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var selectedBuildingId = cmbBuildingId.SelectedValue.ToString();
                    var selectedBuilding = _appDbContext.Buildings.FirstOrDefault(c => c.BuildingId == selectedBuildingId);
                    if (selectedBuilding != null)
                    {
                        _appDbContext.Buildings.Remove(selectedBuilding);
                        _appDbContext.SaveChanges();
                        MessageBox.Show("Building : " + selectedBuildingId + " removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmbBuildingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchDataToFields(cmbBuildingId.Text.ToString(),cmbBuildingId.SelectedIndex);
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBox.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                ViewGrid();
            }
            else if (searchText == "Enter Building Name or Location")
            {
                ViewGrid();
            }
            else
            {
                DGridBuildings.DataSource = _appDbContext.Buildings
                                              .Where(x => x.BuildingName.Contains(searchText) || x.Location.Contains(searchText))
                                              .Select(x => new { ID = x.BuildingId, Name = x.BuildingName, Location = x.Location, Floors = x.FLoorCount ,Apartments = x.ApartmentsCount, Norm_Parkings = x.ParkingsCount, Add_Parkings = x.AdditionalParkingsCount })
                                              .ToList();
            }
            DGridBuildings.Refresh();
        }

        private void txtSearchBox_Enter(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "Enter Building Name or Location")
            {
                txtSearchBox.Text = "";
                txtSearchBox.ForeColor = Color.White;
            }
        }

        private void txtSearchBox_Leave(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "")
            {
                txtSearchBox.Text = "Enter Building Name or Location";
                txtSearchBox.ForeColor = Color.Silver;
            }

        }

        private void DGridBuildings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSearchEvent();
            string key = DGridBuildings.CurrentRow.Cells[0].Value.ToString();
            cmbBuildingId.Text = key;
            fetchDataToFields(key,cmbBuildingId.SelectedIndex);
        }
    }
}
